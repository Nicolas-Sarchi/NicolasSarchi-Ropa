using System.Linq.Expressions;
using Domain.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository
{
    public class PaisRepository : GenericRepository<Pais> , IPais
    {
     private readonly AppDbContext _context;
        public PaisRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

   public override async Task<IEnumerable<Pais>> GetAllAsync()
{
 return await _context.Paises.ToListAsync();
}  
}
}