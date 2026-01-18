namespace Phase04PowerPinsTimeReduction.DataAccess.Workers;
public class WorkerInstanceDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<UnlockModel> Workers { get; set; } = [];
}
