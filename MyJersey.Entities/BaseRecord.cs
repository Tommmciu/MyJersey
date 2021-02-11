using System.ComponentModel.DataAnnotations;

namespace MyJersey.Entities
{
    public class BaseRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}