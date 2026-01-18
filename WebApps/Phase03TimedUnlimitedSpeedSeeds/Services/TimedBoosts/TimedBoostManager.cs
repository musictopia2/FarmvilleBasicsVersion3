namespace Phase03TimedUnlimitedSpeedSeeds.Services.TimedBoosts;
public class TimedBoostManager
{
    private TimedBoostProfileModel _profile = null!;
    private ITimedBoostProfile _profileStore = null!;
    public event Action? Tick;             // “countdown changed” (UI refresh)
    private void NotifyTick() => Tick?.Invoke();
    public async Task SetTimedBoostStyleContextAsync(TimedBoostServicesContext context)
    {
        _profile = await context.TimedBoostProfile.LoadAsync();
        _profileStore = context.TimedBoostProfile;
        CleanupExpired();
       
        await SaveAsync();
        // reset cache when loading
    }



    public BasicList<TimedBoostCredit> GetBoosts()
    {
        return _profile.Credits.Where(x => x.Quantity > 0).ToBasicList();
    }
    // Activate later from credits
    // Rule: if already active, EXTEND the current end time.
    public async Task ActiveBoostAsync(TimedBoostCredit credit)
    {
        credit.Quantity--;
        if (credit.Quantity == 0)
        {
            _profile.Credits.RemoveSpecificItem(credit);
        }

        CleanupExpired();

        var now = DateTime.Now;
        var active = _profile.Active.SingleOrDefault(a => a.BoostKey == credit.BoostKey);

        if (active is null)
        {
            _profile.Active.Add(new ActiveTimedBoost
            {
                BoostKey = credit.BoostKey,
                StartedAt = now,
                EndsAt = now.Add(credit.Duration)
            });
        }
        else
        {
            // extend
            var baseTime = active.EndsAt > now ? active.EndsAt : now;
            active.EndsAt = baseTime.Add(credit.Duration);
        }
        await SaveAsync(); //no problem to save here.
    }
    //use this information (so if its null, then normal screen).
    public TimeSpan? GetUnlimitedSpeedSeedTimeLeft()
    {
        var active = _profile.Active
            .SingleOrDefault(x => x.BoostKey == BoostKeys.UnlimitedSpeedSeed);

        if (active is null)
        {
            return null;
        }
        var remaining = active.EndsAt - DateTime.Now;
        if (remaining <= TimeSpan.Zero)
        {
            return null; // already expired
        }
        return remaining;
    }

    private bool CleanupExpired()
    {
        var now = DateTime.Now;

        int before = _profile.Active.Count;
        _profile.Active.RemoveAllAndObtain(a => a.EndsAt <= now);

        return _profile.Active.Count != before;
    }

    private async Task SaveAsync()
    {
        // Whatever your profile wrapper uses. If your interface differs,
        // change this to context.TimedBoostProfile.SaveAsync(_profile).
        await _profileStore.SaveAsync(_profile);
    }
    
    public async Task UpdateTickAsync()
    {
        if (_profile.Active.Count == 0)
        {
            return; //you have none active.
        }

        


        bool changed = CleanupExpired();
        if (changed)
        {
            await SaveAsync();
            //NotifyChanged();
            // if everything expired, ping tick once so any countdown UI clears
            if (_profile.Active.Count == 0)
            {
                NotifyTick();
                return;
            }
        }
        if (_profile.Active.Count > 0)
        {
            // still active => refresh countdown
            NotifyTick();
        }

        
    }
}