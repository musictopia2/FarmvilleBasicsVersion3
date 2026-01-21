using Phase09AutoCompleteAll.Services.Core;

namespace Phase09AutoCompleteAll.Services.Workshops;
public interface IWorkshopFactory
{
    WorkshopServicesContext GetWorkshopServices(FarmKey farm);
}