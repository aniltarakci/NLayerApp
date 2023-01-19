using Core.UnitOfWorks;
using Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NLayerDbContext _context;

        public UnitOfWork(NLayerDbContext context)
        {
            _context = context;
        }

        public void Commit() //SaveChanges();
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync() //SaveChangesAsync();
        {
            await _context.SaveChangesAsync();
        }
    }
}
