
using System.ComponentModel.DataAnnotations;

namespace DigitalDMScreen.Shared.Domain
{
    public class PlayerCharacter: Character
    {
        //[Key]
        //public int PcId { get; set; }
        public string? Player;

        public string? Class;
    }
}
