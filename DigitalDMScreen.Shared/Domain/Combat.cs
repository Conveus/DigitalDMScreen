
using System.ComponentModel.DataAnnotations;

namespace DigitalDMScreen.Shared.Domain
{
    public abstract class Combat: Entry
    {
        public int? Level;

        public int? Health;

        public int? MaxHealth;

        public int? TempHealth;

        public int? ArmourClass;

        public int? PassivePerception;

        public string? Attacks;
    }
}
