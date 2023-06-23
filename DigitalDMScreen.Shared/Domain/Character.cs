
using System.ComponentModel.DataAnnotations;

namespace DigitalDMScreen.Shared.Domain
{
    // Inherits from Combat which inherits from Entry
    public abstract class Character: Combat
    {
        public string? Race { get; set; }

        public Gender? Gender { get; set; }
    }
}
