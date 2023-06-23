using System.ComponentModel.DataAnnotations;

namespace DigitalDMScreen.Shared.Domain
{
    // Base class
    public abstract class Entry
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name is too long")]
        public string Name { get; set; }

        public string? Notes { get; set; }
    }
}
