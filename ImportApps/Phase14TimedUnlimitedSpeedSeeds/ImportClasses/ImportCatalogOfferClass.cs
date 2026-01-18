namespace Phase14TimedUnlimitedSpeedSeeds.ImportClasses;

public static class ImportCatalogOfferClass
{
    public static async Task ImportCatalogAsync()
    {
        CatalogOfferDatabase db = new();
        var firsts = FarmHelperClass.GetAllFarms();
        BasicList<CatalogOfferDocument> list = [];
        foreach (var item in firsts)
        {
            list.Add(GenerateCatalogFarm(item));
        }
        await db.ImportAsync(list);
    }

    private static CatalogOfferDocument GenerateCatalogFarm(FarmKey farm)
    {
        BasicList<CatalogOfferModel> list = [];
        list.AddRange(ImportTreeCatalogClass.GetTreeOffers(farm));
        list.AddRange(ImportAnimalCatalogClass.GetAnimalOffers(farm));
        list.AddRange(ImportWorksiteCatalogClass.GetWorksiteOffers(farm));
        list.AddRange(ImportWorkerCatalogClass.GetWorkerOffers(farm));
        list.AddRange(ImportWorkshopCatalogClass.GetWorkshopOffers(farm));
        list.AddRange(ImportUnlimitedSpeedSeeds());
        if (farm.Theme == FarmThemeList.Country)
        {
            list.AddRange(ImportCountryUnlimitedItems());

        }
        else if (farm.Theme == FarmThemeList.Tropical)
        {
            list.AddRange(ImportTropicalUnlimitedItems());

        }
        else
        {
            throw new CustomBasicException("Not supported");
        }
        return new()
        {
            Farm = farm,
            Offers = list

        };

    }

    private static BasicList<CatalogOfferModel> ImportUnlimitedSpeedSeeds()
    {
        BasicList<CatalogOfferModel> output = [];
        EnumCatalogCategory category = EnumCatalogCategory.TimedBoost;


        output.Add(new()
        {
            Category = category,
            LevelRequired = 10,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(10),
            Duration = TimeSpan.FromSeconds(10),
            TargetName = BoostKeys.UnlimitedSpeedSeed
        });

        output.Add(new()
        {
            Category = category,
            LevelRequired = 10,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(20),
            Duration = TimeSpan.FromMinutes(4),
            TargetName = BoostKeys.UnlimitedSpeedSeed
        });
        return output;
    }

    private static BasicList<CatalogOfferModel> ImportCountryUnlimitedItems()
    {
        //this is where i set the prices
        BasicList<CatalogOfferModel> output = [];
        EnumCatalogCategory category = EnumCatalogCategory.InstantUnlimited;

        //has to start with only trees to get this working.  then apply to the other domains.

        output.Add(new()
        {
            Category = category,
            LevelRequired = 5,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(10),
            TargetName = CountryItemList.Wheat
        });

        output.Add(new()
        {
            Category = category,
            LevelRequired = 5,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(10),
            TargetName = CountryItemList.Apple
        });
        output.Add(new()
        {
            Category = category,
            LevelRequired = 12,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(20),
            TargetName = CountryItemList.Milk
        });
        return output;
    }
    private static BasicList<CatalogOfferModel> ImportTropicalUnlimitedItems()
    {
        //this is where i set the prices
        BasicList<CatalogOfferModel> output = [];
        EnumCatalogCategory category = EnumCatalogCategory.InstantUnlimited;
        output.Add(new()
        {
            Category = category,
            LevelRequired = 5,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(10),
            TargetName = TropicalItemList.Pineapple
        });
        output.Add(new()
        {
            Category = category,
            LevelRequired = 5,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(10),
            TargetName = TropicalItemList.Coconut
        });
        output.Add(new()
        {
            Category = category,
            LevelRequired = 12,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(20),
            TargetName = TropicalItemList.Fish
        });
        return output;
    }

}

