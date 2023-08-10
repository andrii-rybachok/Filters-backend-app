using Data.DataBase.Entities;

namespace FiltersWebApi.Services
{
    public interface IWorkPlaceService
    {
        Task<List<WorkPlace>> GetWorkPlaces();
    }
}
