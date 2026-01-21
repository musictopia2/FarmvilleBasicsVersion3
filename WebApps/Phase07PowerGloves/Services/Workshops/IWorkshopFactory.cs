using Phase07PowerGloves.Services.Core;

namespace Phase07PowerGloves.Services.Workshops;
public interface IWorkshopFactory
{
    WorkshopServicesContext GetWorkshopServices(FarmKey farm);
}