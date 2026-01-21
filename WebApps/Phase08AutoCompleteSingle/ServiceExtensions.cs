using Phase08AutoCompleteSingle.Components.Custom; //for now.
using Phase08AutoCompleteSingle.DataAccess.Animals;
using Phase08AutoCompleteSingle.DataAccess.Balance;
using Phase08AutoCompleteSingle.DataAccess.Catalog;
using Phase08AutoCompleteSingle.DataAccess.Core;
using Phase08AutoCompleteSingle.DataAccess.Crops;
using Phase08AutoCompleteSingle.DataAccess.InstantUnlimited;
using Phase08AutoCompleteSingle.DataAccess.Items;
using Phase08AutoCompleteSingle.DataAccess.OutputAugmentation;
using Phase08AutoCompleteSingle.DataAccess.Progression;
using Phase08AutoCompleteSingle.DataAccess.Quests; //not common enough.
using Phase08AutoCompleteSingle.DataAccess.Store;
using Phase08AutoCompleteSingle.DataAccess.TimedBoosts;
using Phase08AutoCompleteSingle.DataAccess.Trees;
using Phase08AutoCompleteSingle.DataAccess.Upgrades;
using Phase08AutoCompleteSingle.DataAccess.Workers;
using Phase08AutoCompleteSingle.DataAccess.Workshops;
using Phase08AutoCompleteSingle.DataAccess.Worksites;
//these was not common enough to put into global usings.

namespace Phase08AutoCompleteSingle;

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