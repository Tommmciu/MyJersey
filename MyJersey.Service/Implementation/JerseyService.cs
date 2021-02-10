using MyJersey.Database;
using MyJersey.Entities;
using MyJersey.Service.Interfaces;

namespace MyJersey.Service.Implementation
{
    public class JerseyService: BaseService<Jersey>, IJerseyService
    {
        public JerseyService(MyJerseyDbContext context) : base(context)
        {
        }
    }
}