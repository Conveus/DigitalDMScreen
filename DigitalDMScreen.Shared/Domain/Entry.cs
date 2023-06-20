using System.ComponentModel.DataAnnotations;

namespace DigitalDMScreen.Shared.Domain
{
    public abstract class Entry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Notes { get; set; }
    }
}
