using Phase06WorksitesNoSupplies.Components.Custom; //for now.
using Phase06WorksitesNoSupplies.DataAccess.Animals;
using Phase06WorksitesNoSupplies.DataAccess.Balance;
using Phase06WorksitesNoSupplies.DataAccess.Catalog;
using Phase06WorksitesNoSupplies.DataAccess.Core;
using Phase06WorksitesNoSupplies.DataAccess.Crops;
using Phase06WorksitesNoSupplies.DataAccess.InstantUnlimited;
using Phase06WorksitesNoSupplies.DataAccess.Items;
using Phase06WorksitesNoSupplies.DataAccess.OutputAugmentation;
using Phase06WorksitesNoSupplies.DataAccess.Progression;
using Phase06WorksitesNoSupplies.DataAccess.Quests; //not common enough.
using Phase06WorksitesNoSupplies.DataAccess.Store;
using Phase06WorksitesNoSupplies.DataAccess.TimedBoosts;
using Phase06WorksitesNoSupplies.DataAccess.Trees;
using Phase06WorksitesNoSupplies.DataAccess.Upgrades;
using Phase06WorksitesNoSupplies.DataAccess.Workers;
using Phase06WorksitesNoSupplies.DataAccess.Workshops;
using Phase06WorksitesNoSupplies.DataAccess.Worksites;
//these was not common enough to put into global usings.

namespace Phase06WorksitesNoSupplies;

public static class ServiceExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection RegisterFarmServices()
        {
            services.AddHostedService<GameTimerService>()
                .AddSingleton<GameRegistry>()
                .AddSingleton<IInventoryRepository, InventoryStockDatabase>()
                .AddSingleton<IStartFarmRegistry, StartFarmDatabase>()
                .AddSingleton<IInventoryFactory, InventoryFactory>()
                .AddSingleton<ITreeFactory, TreeFactory>()
                .AddSingleton<ICropFactory, CropFactory>()
                .AddSingleton<IAnimalFactory, AnimalFactory>()
                .AddSingleton<IWorkshopFactory, WorkshopFactory>()
                .AddSingleton<IWorksiteFactory, WorksiteFactory>()
                .AddSingleton<IWorkerFactory, WorkerFactory>()
                .AddSingleton<IQuestFactory, QuestFactory>()
                .AddSingleton<IUpgradeFactory, UpgradeFactory>()
                .AddSingleton<IProgressionFactory, ProgressionFactory>()
                .AddSingleton<ICatalogFactory, CatalogFactory>()
                .AddSingleton<IStoreFactory, StoreFactory>()
                .AddSingleton<IItemFactory, ItemFactory>()
                .AddSingleton<IInstantUnlimitedFactory, InstantUnlimitedFactory>()
                .AddSingleton<ITimedBoostFactory, TimedBoostFactory>()
                .AddSingleton<IOutputAugmentationFactory, OutputAugmentationFactory>()
                .AddScoped<ReadyStatusService>()
                .AddScoped<OverlayService>()
                .AddScoped<FarmContext>()
                .AddSingleton<IBaseBalanceProvider, BalanceProfileDatabase>() //i think this is safe this time (refer to inventory persistence)
                ;
            return services;
        }
        //not sure about quests.  not until near the end
    }
}