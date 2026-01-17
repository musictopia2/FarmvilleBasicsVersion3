namespace Phase03TimedUnlimitedSpeedSeeds.Services.TimedBoosts;
public class TimedBoostCredit
{
    public string BoostKey { get; set; } = "";
    public TimeSpan Duration { get; set; }
    public int Quantity { get; set; }
}