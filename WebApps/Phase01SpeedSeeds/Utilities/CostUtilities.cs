namespace Phase01SpeedSeeds.Utilities;

public static class CostUtilities
{
    public static Dictionary<string, int> GetCoinOnlyDictionary(int value)
    {
        Dictionary<string, int> output = [];
        output[CurrencyKeys.Coin] = value;
        return output;
    }
}