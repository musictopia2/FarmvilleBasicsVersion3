using Phase11MVP3.Services.Core;

namespace Phase11MVP3.Services.Workshops;
public interface IWorkshopFactory
{
    WorkshopServicesContext GetWorkshopServices(FarmKey farm);
}