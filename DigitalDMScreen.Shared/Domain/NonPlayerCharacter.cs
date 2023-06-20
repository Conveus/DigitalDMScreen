
using System.ComponentModel.DataAnnotations;

namespace DigitalDMScreen.Shared.Domain
{
    public class NonPlayerCharacter: Character
    {
        //[Key]
        //public int NpcId { get; set; }
        public string? Role;
        public string? Appearance;
    }
}
