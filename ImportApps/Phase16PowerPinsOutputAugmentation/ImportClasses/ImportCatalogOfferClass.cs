namespace Phase16PowerPinsOutputAugmentation.ImportClasses;
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
        list.AddRange(ImportSpeedSeedOffers());
        list.AddRange(ImportUnlimitedSpeedSeeds());
        if (farm.Theme == FarmThemeList.Country)
        {
            list.AddRange(ImportCountryUnlimitedItems());
            list.AddRange(ImportCountryTimeReductionPowerPins());
            list.AddRange(ImportCountryOutputAugmentationOffers());
        }
        else if (farm.Theme == FarmThemeList.Tropical)
        {
            list.AddRange(ImportTropicalUnlimitedItems());
            list.AddRange(ImportTropicalTimeReductionPowerPins());
            list.AddRange(ImportTropicalOutputAugmentationOffers());
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

    private static BasicList<CatalogOfferModel> ImportCountryOutputAugmentationOffers()
    {
        EnumCatalogCategory category = EnumCatalogCategory.TimedBoost;
        BasicList<CatalogOfferModel> output = [];
        TimeSpan duration = TimeSpan.FromHours(2);
        output.Add(new()
        {
            Category = category,
            TargetName = CountryWorksiteListClass.Mines,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(2),
            Duration = duration,
            OutputAugmentationKey = CountryAugmentationKeys.MinesGuaranteedGranolaBlanket,
            LevelRequired = 18
        });

        output.Add(new()
        {
            Category = category,
            TargetName = CountryAnimalListClass.Sheep, //should give the animal name this time.
            Costs = FarmHelperClass.GetCoinOnlyDictionary(2),
            Duration = duration,
            OutputAugmentationKey = CountryAugmentationKeys.SheepDoubleWoolGuaranteed,
            LevelRequired = 16
        });

        output.Add(new()
        {
            Category = category,
            TargetName = CountryItemList.Peach,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(2),
            Duration = duration,
            OutputAugmentationKey = CountryAugmentationKeys.PeachTreeChanceExtraPeach,
            LevelRequired = 10
        });

        output.Add(new()
        {
            Category = category,
            TargetName = CountryItemList.ApplePie, //i think this time needs to be apple pies.
            Costs = FarmHelperClass.GetCoinOnlyDictionary(2),
            Duration = duration,
            OutputAugmentationKey = CountryAugmentationKeys.ApplePieChanceExtraApplePie,
            LevelRequired = 9
        });

        output.Add(new()
        {
            Category = category,
            TargetName = CountryAnimalListClass.Cow,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(2),
            Duration = duration,
            OutputAugmentationKey = CountryAugmentationKeys.CowChanceButter,
            LevelRequired = 10
        });

        output.Add(new()
        {
            Category = category,
            TargetName = CountryItemList.Tomato,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(2),
            Duration = duration,
            OutputAugmentationKey = CountryAugmentationKeys.TomatoChanceFarmersSoup,
            LevelRequired = 11
        });


        return output;
    }

    private static BasicList<CatalogOfferModel> ImportTropicalOutputAugmentationOffers()
    {
        EnumCatalogCategory category = EnumCatalogCategory.TimedBoost;
        BasicList<CatalogOfferModel> output = [];
        TimeSpan duration = TimeSpan.FromHours(2);
        output.Add(new()
        {
            Category = category,
            TargetName = TropicalWorksiteListClass.SmugglersCave,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(2),
            Duration = duration,
            OutputAugmentationKey = TropicalAugmentationKeys.SmugglersCaveGuaranteedTruffleFriesAndFriedRice,
            LevelRequired = 18
        });

        output.Add(new()
        {
            Category = category,
            TargetName = TropicalItemList.Rice, //should give the animal name this time.
            Costs = FarmHelperClass.GetCoinOnlyDictionary(2),
            Duration = duration,
            OutputAugmentationKey = TropicalAugmentationKeys.RiceChanceExtraSteamedRice,
            LevelRequired = 16
        });

        output.Add(new()
        {
            Category = category,
            TargetName = TropicalItemList.Lime,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(2),
            Duration = duration,
            OutputAugmentationKey = TropicalAugmentationKeys.LimeChanceExtraLime,
            LevelRequired = 10
        });

        output.Add(new()
        {
            Category = category,
            TargetName = TropicalItemList.GrilledCrab, //i think this time needs to be apple pies.
            Costs = FarmHelperClass.GetCoinOnlyDictionary(2),
            Duration = duration,
            OutputAugmentationKey = TropicalAugmentationKeys.GrilledCrabChanceExtraGrilledCrab,
            LevelRequired = 9
        });

        output.Add(new()
        {
            Category = category,
            TargetName = TropicalAnimalListClass.Dolphin,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(2),
            Duration = duration,
            OutputAugmentationKey = TropicalAugmentationKeys.DolphinChanceSearedFish,
            LevelRequired = 10
        });

        output.Add(new()
        {
            Category = category,
            TargetName = TropicalAnimalListClass.Chicken,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(2),
            Duration = duration,
            OutputAugmentationKey = TropicalAugmentationKeys.ChickenDoubleEggsGuaranteed,
            LevelRequired = 11
        });
        return output;
    }

    private static BasicList<CatalogOfferModel> ImportSpeedSeedOffers()
    {
        BasicList<CatalogOfferModel> output = [];
        EnumCatalogCategory category = EnumCatalogCategory.Misc;
        int levelRequired = 10;
        output.Add(new()
        {
            Category = category,
            Quantity = 10,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(20),
            TargetName = CurrencyKeys.SpeedSeed,
            LevelRequired = levelRequired,
            
        });
        output.Add(new()
        {
            Category = category,
            Quantity = 20,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(15), //you pay less per item if doing bulk.
            TargetName = CurrencyKeys.SpeedSeed,
            LevelRequired = levelRequired

        });
        return output;
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

    private static BasicList<CatalogOfferModel> ImportCountryTimeReductionPowerPins()
    {
        EnumCatalogCategory category = EnumCatalogCategory.TimedBoost;
        BasicList<CatalogOfferModel> output = [];
        output.Add(new()
        {
            Category = category,
            TargetName = CountryWorksiteListClass.Pond,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(5),
            Duration = TimeSpan.FromHours(2),
            ReduceBy = TimeSpan.FromHours(2),
            LevelRequired = 14
        });
        output.Add(new()
        {
            Category = category,
            TargetName = CountryWorksiteListClass.Pond, //need to make sure that if reduceby is different, can't stack them.
            Costs = FarmHelperClass.GetCoinOnlyDictionary(5),
            Duration = TimeSpan.FromMinutes(10),
            ReduceBy = TimeSpan.FromHours(3),
            LevelRequired = 14
        });
        output.Add(new()
        {
            Category = category,
            TargetName = CountryItemList.Peach,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(5),
            Duration = TimeSpan.FromMinutes(1),
            ReduceBy = TimeSpan.FromHours(2), //this applies to all 4 (so do math to see how it would affect each one).
            LevelRequired = 14
        });
        output.Add(new()
        {
            Category = category,
            TargetName = CountryWorkshopList.Loom,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(5),
            Duration = TimeSpan.FromMinutes(1),
            ReduceBy = TimeSpan.FromMinutes(5),
            LevelRequired = 14
        });
        output.Add(new()
        {
            Category = category,
            TargetName = CountryItemList.Strawberry,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(5),
            Duration = TimeSpan.FromMinutes(1),
            ReduceBy = TimeSpan.FromMinutes(50),
            LevelRequired = 14
        });
        output.Add(new()
        {
            Category = category,
            TargetName = CountryItemList.Wool,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(5),
            Duration = TimeSpan.FromMinutes(1),
            ReduceBy = TimeSpan.FromMinutes(15),
            LevelRequired = 14
        });


        return output;
    }

    private static BasicList<CatalogOfferModel> ImportTropicalTimeReductionPowerPins()
    {
        EnumCatalogCategory category = EnumCatalogCategory.TimedBoost;
        BasicList<CatalogOfferModel> output = [];
        output.Add(new()
        {
            Category = category,
            TargetName = TropicalWorksiteListClass.HotSprings,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(5),
            Duration = TimeSpan.FromMinutes(1),
            ReduceBy = TimeSpan.FromHours(1),
            LevelRequired = 14
        });
        output.Add(new()
        {
            Category = category,
            TargetName = TropicalItemList.Lime,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(5),
            Duration = TimeSpan.FromMinutes(1),
            ReduceBy = TimeSpan.FromHours(2), //this applies to all 4 (so do math to see how it would affect each one).
            LevelRequired = 14
        });
        output.Add(new()
        {
            Category = category,
            TargetName = TropicalWorkshopList.BeachfrontKitchen,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(5),
            Duration = TimeSpan.FromMinutes(2),
            ReduceBy = TimeSpan.FromMinutes(5),
            LevelRequired = 14
        });
        output.Add(new()
        {
            Category = category,
            TargetName = TropicalItemList.Tapioca,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(5),
            Duration = TimeSpan.FromMinutes(2),
            ReduceBy = TimeSpan.FromMinutes(5),
            LevelRequired = 14
        });
        output.Add(new()
        {
            Category = category,
            TargetName = TropicalItemList.Mushroom,
            Costs = FarmHelperClass.GetCoinOnlyDictionary(5),
            Duration = TimeSpan.FromMinutes(2),
            ReduceBy = TimeSpan.FromMinutes(1),
            LevelRequired = 14
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
            TargetName = CountryItemList.Milk,
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
            TargetName = TropicalItemList.Fish,
        });
        return output;
    }

}

