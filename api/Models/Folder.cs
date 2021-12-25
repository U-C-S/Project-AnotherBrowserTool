namespace Satellite.Models
{
    public class Folder
    {
        public Guid id { get; init; }
        public string name { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime updatedOn { get; set; }
        public ICollection<Link>? links { get; set; }
    }
}
