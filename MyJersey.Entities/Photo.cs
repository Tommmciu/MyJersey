namespace MyJersey.Entities
{
    public class Photo : BaseRecord
    {
        public byte[] Data { get; set; }
        public int JerseyId { get; set; }
        public Jersey Jersey { get; set; }
    }
}