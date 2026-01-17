namespace Phase13InstantUnlimited.ImportClasses;

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
    private static BasicList<CatalogOfferModel> ImportCountryUnlimitedItems()
    {
        //this is where i set the prices
        BasicList<CatalogOfferModel> output = [];
        EnumCatalogCategory category = EnumCatalogCategory.InstantUnlimited;
        output.Add(new()
        {
            Category = category,
            LevelRequired = 1,
            Costs = FarmHelperClass.GetFreeCosts,
            TargetName = CountryItemList.Wheat
        });
        output.Add(new()
        {
            Category = category,
            LevelRequired = 1,
            Costs = FarmHelperClass.GetFreeCosts,
            TargetName = CountryItemList.Apple
        });
        output.Add(new()
        {
            Category = category,
            LevelRequired = 1,
            Costs = FarmHelperClass.GetFreeCosts,
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
            LevelRequired = 1,
            Costs = FarmHelperClass.GetFreeCosts,
            TargetName = TropicalItemList.Pineapple
        });
        output.Add(new()
        {
            Category = category,
            LevelRequired = 1,
            Costs = FarmHelperClass.GetFreeCosts,
            TargetName = TropicalItemList.Coconut
        });
        output.Add(new()
        {
            Category = category,
            LevelRequired = 1,
            Costs = FarmHelperClass.GetFreeCosts,
            TargetName = TropicalItemList.Fish
        });
        return output;
    }

}

