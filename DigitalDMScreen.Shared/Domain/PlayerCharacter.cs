
using System.ComponentModel.DataAnnotations;

namespace DigitalDMScreen.Shared.Domain
{
    // Inherits from Character which inherits from Combat which inherits from Entry
    public class PlayerCharacter: Character
    {
        public string? Player { get; set; }

        public string? Class { get; set; }
    }
}
