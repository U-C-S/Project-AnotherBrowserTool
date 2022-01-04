namespace Satellite.Models
{
    public class Link
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Url { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
