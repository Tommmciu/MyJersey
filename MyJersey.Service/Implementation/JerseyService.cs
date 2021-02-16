using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyJersey.Database;
using MyJersey.Entities;
using MyJersey.Service.Interfaces;

namespace MyJersey.Service.Implementation
{
    public class JerseyService: BaseService<Jersey>, IJerseyService
    {
        private readonly MyJerseyDbContext _context;

        public JerseyService(MyJerseyDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Jersey> GetView()
        {
            return _context.Set<Jersey>().Include(x => x.Photos).Include(x => x.Team);
        }
    }
}