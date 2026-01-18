namespace Phase04PowerPinsTimeReduction.Services.TimedBoosts;
public class ActiveTimedBoost
{
    public string BoostKey { get; set; } = "";
    public DateTime StartedAt { get; set; }
    public DateTime EndsAt { get; set; }
    public TimeSpan? ReduceBy { get; set; }
}