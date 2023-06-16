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
                Text = "The Dreamer will show up randomly 15 times"
            };
            var n2 = new Note
            {
                Id = 2,
                Name = "Miralla's Eldritch Tattoo",
                Text = "The tattoo is at stage 2"
            };
            var n3 = new Note
            {
                Id = 3,
                Name = "Plans to mess with the party",
                Text ="1) Dreamer schenanigans, 2) The Deep, 3) Prim"
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
                Text = "Owned by Jorge, an Elephant Selkie. Has both a magic item/spell store and an enchanter",
                Type = "Port",
                Description = "A small but important trade hub at the centre of the Bay of the Seal"
            };

            var l2 = new Location
            {
                Id = 2,
                Name = "Bay of the Seal",
                Text = "The first/tutorial zone",
                Type = "Archipelego",
                Description = "A mid size archepeligo and territory of the Selkie Kingdom, the Sultante of the Sands, and the former Grand Kingdom of Trytos"
            };

            var l3 = new Location()
            {
                Id = 3,
                Name = "The Rememberance",
                Text = "The party's ship has a garden set up at the back of the ship behind the wheel",
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
                Health = 39,
                MaxHealth = 39,
                ArmourClass = 12,
                PassivePerception = 11,
                Text = "A kind of giant ant"
            };
            var m2 = new Monster
            {
                Id = 2,
                Name = "Ankheg Queen",
                Health = 110,
                MaxHealth = 110,
                ArmourClass = 16,
                PassivePerception = 12,
                Text = "The leader of Ankheg colonies"
            };
            var m3 = new Monster
            {
                Id = 3,
                Name = "Stonejaw Ankheg",
                Health = 141,
                MaxHealth = 141,
                ArmourClass = 21,
                PassivePerception = 12,
                Text = "The burrower of Ankheg colonies"
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
                Text = "The crew's navigator"
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
                Text = "The crew's first mate"
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
                Text = "The crew's captain"
            };

            return new List<PlayerCharacter> { p1, p2, p3 };
        }
    }
}
