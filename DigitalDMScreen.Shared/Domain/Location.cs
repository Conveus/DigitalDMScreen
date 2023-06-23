using System.ComponentModel.DataAnnotations;

namespace DigitalDMScreen.Shared.Domain
{
    // Inherits from Entry
    public class Location : Entry
    {
        public string? Type { get; set; }
        public string? Description { get; set; }
    }
}
