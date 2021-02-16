using System.Collections.Generic;

namespace MyJersey.Entities
{
    public class Jersey : BaseRecord
    {
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public virtual List<Photo> Photos { get; set; }
    }
}