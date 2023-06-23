using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreenApp.Models
{
    public class MockDataService
    {
        private static List<Note>? _notes = default!;
        private static List<Location>? _locations = default!;
        private static List<Monster>? _monsters = default!;
        private static List<PlayerCharacter>? _pcs = default!;

        public static List<Note> Notes
        {
            get
            {
                _notes ??= InitializeMockNotes();

                return _notes;
            }
        }

        private static List<Note> InitializeMockNotes()
        {
            var n1 = new Note
            {
                Id = 1,
                Name = "Wyn's outstanding debt to The Dreamer",
                Notes = "The Dreamer will show up randomly 15 times"
            };
            var n2 = new Note
            {
                Id = 2,
                Name = "Miralla's Eldritch Tattoo",
                Notes = "The tattoo is at stage 2"
            };
            var n3 = new Note
            {
                Id = 3,
                Name = "Plans to mess with the party",
                Notes ="1) Dreamer schenanigans, 2) The Deep, 3) Prim"
            };

            return new List<Note> { n1,n2,n3 };
        }

        public static List<Location> Locations
        {
            get
            {
                _locations ??= InitializeMockLocations();

                return _locations;
            }
        }

        private static List<Location> InitializeMockLocations()
        {
            var l1 = new Location
            {
                Id = 1,
                Name = "Trunk Nose Inn",
                Notes = "Owned by Jorge, an Elephant Selkie. Has both a magic item/spell store and an enchanter",
                Type = "Port",
                Description = "A small but important trade hub at the centre of the Bay of the Seal"
            };

            var l2 = new Location
            {
                Id = 2,
                Name = "Bay of the Seal",
                Notes = "The first/tutorial zone",
                Type = "Archipelego",
                Description = "A mid size archepeligo and territory of the Selkie Kingdom, the Sultante of the Sands, and the former Grand Kingdom of Trytos"
            };

            var l3 = new Location()
            {
                Id = 3,
                Name = "The Rememberance",
                Notes = "The party's ship has a garden set up at the back of the ship behind the wheel",
                Type = "Ship",
                Description = "A sloop owned by Solv Kveoa, looks to have been repaired a few times"
            };

            return new List<Location> { l1, l2, l3 };
        }

        public static List<Monster> Monsters
        {
            get
            {
                _monsters ??= InitializeMockMonsters();

                return _monsters;
            }
        }

        private static List<Monster> InitializeMockMonsters()
        {
            var m1 = new Monster
            {
                Id = 1,
                Name = "Ankheg",
                Level = 2,
                Health = 39,
                MaxHealth = 39,
                ArmourClass = 12,
                PassivePerception = 11,
                Attacks = "Bite. Melee Weapon Attack: +5 to hit, reach 5 ft., one target. Hit: 10 (2d6 + 3) slashing damage plus 3 (1d6) acid damage. If the target is a Large or smaller creature, it is grappled (escape DC 13). Until this grapple ends, the ankheg can bite only the grappled creature and has advantage on attack rolls to do so.",
                Notes = "A kind of giant ant"
            };
            var m2 = new Monster
            {
                Id = 2,
                Name = "Ankheg Queen",
                Level = 5,
                Health = 110,
                MaxHealth = 110,
                ArmourClass = 16,
                PassivePerception = 12,
                Attacks = "Bite. Melee Weapon Attack: +8 to hit, reach 5 ft., one target. Hit: 16 (2d10 + 5) slashing damage plus 9 (2d6) acid damage. If the target is a Huge or smaller creature, it is grappled (escape DC 15). Until this grapple ends, the ankheg can bite only the grappled creature and has advantage on the attack rolls to do so.",
                Notes = "The leader of Ankheg colonies"
            };
            var m3 = new Monster
            {
                Id = 3,
                Name = "Stonejaw Ankheg",
                Level = 8,
                Health = 141,
                MaxHealth = 141,
                ArmourClass = 21,
                PassivePerception = 12,
                Attacks = "Bite. Melee Weapon Attack: +9 to hit, reach 5 ft., one target. Hit: 27 (4d10 + 6) slashing damage. If the target is a Huge or smaller creature, it is grappled (escape DC 16). Until this grapple ends, the ankheg can bite only the grappled creature and has advantage on the attack rolls to do so.\r\n\r\nPetrification Breath (Recharge 6). The ankheg exhales petrifying dust in a line that is 30 feet long and 5 feet wide, provided that it has no creature grappled. Each creature in that line must make a DC 16 saving throw against being magically petrified. On a failed save, the creature begins to turn to stone and is restrained. It must repeat the saving throw at the end of its next turn. On a success, the effect ends. On a failure the creature is petrified until freed by the greater restoration spell or other magic.",
                Notes = "The burrower of Ankheg colonies"
            };

            return new List<Monster> { m1, m2, m3 };
        }

        public static List<PlayerCharacter> PCs
        {
            get
            {
                _pcs ??= InitializeMockPCs();

                return _pcs;
            }
        }

        private static List<PlayerCharacter> InitializeMockPCs()
        {
            var p1 = new PlayerCharacter
            {
                Id = 1,
                Name = "Wyneira Weisestern",
                Level = 6,
                Race = "Half Elf",
                Gender = Gender.Female,
                Player = "Connor",
                Class = "Bladesinger Wizard",
                Health = 32,
                MaxHealth = 32,
                TempHealth = 0,
                ArmourClass = 16,
                PassivePerception = 10,
                Notes = "The crew's navigator"
            };
            var p2 = new PlayerCharacter
            {
                Id = 2,
                Name = "Rosastrex Carnellion",
                Level = 6,
                Race = "Demon",
                Gender = Gender.Female,
                Player = "Luke",
                Class = "Celestial Warlock 5 / Fighter 1",
                Health = 46,
                MaxHealth = 46,
                TempHealth = 0,
                ArmourClass = 16,
                PassivePerception = 10,
                Notes = "The crew's first mate"
            };
            var p3 = new PlayerCharacter
            {
                Id = 3,
                Name = "Solv Kveoa",
                Level = 6,
                Race = "Satyr",
                Gender = Gender.Male,
                Player = "Greg",
                Class = "Eloquence Bard 4 / Hexblade Warlock 2",
                Health = 45,
                MaxHealth = 45,
                TempHealth = 0,
                ArmourClass = 14,
                PassivePerception = 12,
                Notes = "The crew's captain"
            };

            return new List<PlayerCharacter> { p1, p2, p3 };
        }
    }
}
