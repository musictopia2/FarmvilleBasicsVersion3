namespace Phase14TimedUnlimitedSpeedSeeds.Models;
public class ActiveTimedBoost
{
    public string BoostKey { get; set; } = "";
    public DateTime StartedAt { get; set; }
    public DateTime EndsAt { get; set; }
}