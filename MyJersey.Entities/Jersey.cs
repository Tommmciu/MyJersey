using System.Collections.Generic;

namespace MyJersey.Entities
{
    public class Jersey : BaseRecord
    {
public virtual List<Photo> Photos { get; set; }
    }
}