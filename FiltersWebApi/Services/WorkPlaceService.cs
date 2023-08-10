using Data.DataBase;
using Data.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace FiltersWebApi.Services
{
    public class WorkPlaceService:IWorkPlaceService
    {
        private readonly ApplicationDbContext _context;

        public WorkPlaceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<WorkPlace>> GetWorkPlaces()
        {
            List<WorkPlace> result = new List<WorkPlace>();
            result= await _context.WorkPlaces.Include(x => x.ProdProcesses.Take(10)).Where(x=>x.ProdProcesses.Count>10).Take(10).ToListAsync();
           
            return result;
        }
    }
}
