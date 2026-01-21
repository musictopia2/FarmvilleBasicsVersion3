using Phase07PowerGloves.Components.Custom; //for now.
using Phase07PowerGloves.DataAccess.Animals;
using Phase07PowerGloves.DataAccess.Balance;
using Phase07PowerGloves.DataAccess.Catalog;
using Phase07PowerGloves.DataAccess.Core;
using Phase07PowerGloves.DataAccess.Crops;
using Phase07PowerGloves.DataAccess.InstantUnlimited;
using Phase07PowerGloves.DataAccess.Items;
using Phase07PowerGloves.DataAccess.OutputAugmentation;
using Phase07PowerGloves.DataAccess.Progression;
using Phase07PowerGloves.DataAccess.Quests; //not common enough.
using Phase07PowerGloves.DataAccess.Store;
using Phase07PowerGloves.DataAccess.TimedBoosts;
using Phase07PowerGloves.DataAccess.Trees;
using Phase07PowerGloves.DataAccess.Upgrades;
using Phase07PowerGloves.DataAccess.Workers;
using Phase07PowerGloves.DataAccess.Workshops;
using Phase07PowerGloves.DataAccess.Worksites;
//these was not common enough to put into global usings.

namespace Phase07PowerGloves;

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