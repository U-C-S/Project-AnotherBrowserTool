namespace Satellite.Models
{
    public class Link
    {
        public Guid id { get; init; }
        public string name { get; set; }
        public string url { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime? updatedOn { get; set; }
    }
}
