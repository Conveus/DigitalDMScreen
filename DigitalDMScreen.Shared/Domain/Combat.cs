
using System.ComponentModel.DataAnnotations;

namespace DigitalDMScreen.Shared.Domain
{
    // Inherits from Entry
    public abstract class Combat: Entry
    {
        public int? Level { get; set; }

        public int? Health { get; set; }

        public int? MaxHealth { get; set; }

        public int? TempHealth { get; set; }

        public int? ArmourClass { get; set; }

        public int? PassivePerception { get; set; }

        public string? Attacks { get; set; }
    }
}
