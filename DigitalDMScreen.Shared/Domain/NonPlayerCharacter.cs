
using System.ComponentModel.DataAnnotations;

namespace DigitalDMScreen.Shared.Domain
{
    // Inherits from Character which inherits from Combat which inherits from Entry
    public class NonPlayerCharacter: Character
    {
        public string? Role { get; set; }
        public string? Appearance { get; set; }
    }
}
