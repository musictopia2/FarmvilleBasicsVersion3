namespace Phase10Rentals.Services.Rentals;
public class RentalManager(TreeManager treeManager)
{
    private BasicList<RentalInstanceModel> _rentals = [];
    private IRentalProfile _profile = null!;
    public async Task SetRentalStyleContextAsync(RentalsServicesContext context)
    {
        _rentals = await context.RentalProfile.LoadAsync();
        _profile = context.RentalProfile;
        await RentalProgressAsync();
        await SaveAsync();
        // reset cache when loading
    }
    public bool CanRent(StoreItemRowModel row) => _rentals.Exists(x => x.TargetName == row.TargetName) == false;
    public async Task RentAsync(StoreItemRowModel row)
    {
        if (CanRent(row) == false)
        {
            throw new CustomBasicException("Unable to rent because already renting.  Should had checked CanRent");
        }
        if (row.Category != EnumCatalogCategory.Tree)
        {
            throw new CustomBasicException("Only trees are supported for now");
        }
        if (row.Duration is null)
        {
            throw new CustomBasicException("Rentals require a duration");
        }
        treeManager.UnlockTreeRental(row);
        var now = DateTime.Now;
        _rentals.Add(new()
        {
            Category = row.Category,
            TargetName = row.TargetName,
            StartedAt = DateTime.Now,
            EndsAt = now.Add(row.Duration.Value)
        });
        _needsSaving = true;
    }
    public string GetDurationString(string targetName)
    {
        var item = _rentals.SingleOrDefault(x => x.TargetName == targetName);
        if (item is null)
        {
            return "";
        }
        var remaining = item.EndsAt - DateTime.Now;
        if (remaining <= TimeSpan.Zero)
        {
            return "";
        }
        return remaining.GetTimeCompact;
    }

    private async Task SaveAsync()
    {
        if (_needsSaving == false)
        {
            return;
        }
        await _profile.SaveAsync(_rentals);
        _needsSaving = false;
    }
    private bool _needsSaving = false;
    private async Task RentalProgressAsync()
    {
        var now = DateTime.Now;

        var list = _rentals.Where(x => x.EndsAt <= now).ToBasicList();
        foreach (var item in list)
        {
            //these are all the ones that has to be processed actively because they expired.
            if (item.Category == EnumCatalogCategory.Tree)
            {
                //use the tree manager
                //if it was able to do, then take off.
                await treeManager.ShowRentalExpireAsync(item);
                _rentals.RemoveSpecificItem(item);
                _needsSaving = true;
            }
            else
            {
                throw new CustomBasicException("Only trees are supported for now");
            }
        }

    }


    public async Task UpdateTickAsync()
    {
        if (_rentals.Count == 0)
        {
            return;
        }
        await RentalProgressAsync();
        await SaveAsync();
    }


}