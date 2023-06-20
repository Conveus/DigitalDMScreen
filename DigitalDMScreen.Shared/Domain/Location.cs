using System.ComponentModel.DataAnnotations;

namespace DigitalDMScreen.Shared.Domain
{
    public class Location : Entry
    {
        //[Key]
        //public int LocationId { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
    }
}
