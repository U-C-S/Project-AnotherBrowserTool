namespace Satellite.Models
{
    public class Folder
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public ICollection<Link>? Links { get; set; }
    }
}
