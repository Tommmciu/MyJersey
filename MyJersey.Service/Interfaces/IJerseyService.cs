using System.Collections.Generic;
using MyJersey.Entities;

namespace MyJersey.Service.Interfaces
{
    public interface IJerseyService:IBaseService<Jersey>
    {
        IEnumerable<Jersey> GetView();
    }
}