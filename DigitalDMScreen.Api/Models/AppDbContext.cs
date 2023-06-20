using DigitalDMScreen.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace DigitalDMScreen.Api.Models
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{

        //}

        public DbSet<Note> Notes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<NonPlayerCharacter> NPCs { get; set; }
        public DbSet<PlayerCharacter> PCs { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Note>();
            modelBuilder.Entity<Location>();
            modelBuilder.Entity<Monster>();
            modelBuilder.Entity<NonPlayerCharacter>();
            modelBuilder.Entity<PlayerCharacter>();

            // Seeding initial Notes
            modelBuilder.Entity<Note>().HasData(new Note
            {
                Id = 1,
                Name = "Wyn's outstanding debt to The Dreamer",
                Notes = "The Dreamer will show up randomly 25 times"
            });

            modelBuilder.Entity<Note>().HasData(new Note
            {
                Id = 2,
                Name = "Miralla's Eldritch Tattoo",
                Notes = "The tattoo is at stage 2"
            });

            modelBuilder.Entity<Note>().HasData(new Note
            {
                Id = 3,
                Name = "Plans to mess with the party",
                Notes = "1) Dreamer schenanigans, 2) The Deep, 3) Prim"
            });

            // Seeding initial Locations
            modelBuilder.Entity<Location>().HasData(new Location
            {
                Id = 1,
                Name = "Trunk Nose Inn",
                Type = "Port",
                Description = "A small but important trade hub at the centre of the Bay of the Seal",
                Notes = "Owned by Jeorg, an Elephant Selkie. Has both a magic item/spell store and an enchanter"
            });

            modelBuilder.Entity<Location>().HasData(new Location
            {
                Id = 2,
                Name = "Bay of the Seal",
                Type = "Archipelego",
                Description = "A mid size archepeligo and territory of the Selkie Kingdom, the Sultante of the Sands, and the former Grand Kingdom of Trytos",
                Notes = "The first/tutorial zone"
            });

            modelBuilder.Entity<Location>().HasData(new Location
            {
                Id = 3,
                Name = "The Rememberance",
                Type = "Ship",
                Description = "A sloop owned by Solv Kveoa, looks to have been repaired a few times",
                Notes = "The party's ship has a garden set up at the back of the ship behind the wheel"
            });

            // Seeding initial Monsters
            modelBuilder.Entity<Monster>().HasData(new Monster
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
            });

            modelBuilder.Entity<Monster>().HasData(new Monster
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
            });

            modelBuilder.Entity<Monster>().HasData(new Monster
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
            });

            // Seeding initial NPCs
            modelBuilder.Entity<NonPlayerCharacter>().HasData(new NonPlayerCharacter
            {
                Id = 4,
                Name = "Jeorg",
                Level = 15,
                Gender = Gender.Male,
                Race = "Elephant-Selkie",
                Role = "Trader",
                Appearance = "Twice as tall as the even the tallest men, with a stern expression and rough hands",
                Health = 169,
                MaxHealth = 169,
                TempHealth = 0,
                ArmourClass = 18,
                PassivePerception = 13,
                Notes = "Owner of the Trunk Nose Inn"
            });

            modelBuilder.Entity<NonPlayerCharacter>().HasData(new NonPlayerCharacter
            {
                Id = 5,
                Name = "High King Sehuet",
                Level = 15,
                Gender = Gender.Male,
                Race = "Undead",
                Role = "King",
                Appearance = "A large mummified man dressed in fine clothes and armour",
                Health = 150,
                MaxHealth = 150,
                TempHealth = 0,
                ArmourClass = 18,
                PassivePerception = 13,
                Notes = "High King of The Sea Chain"
            });

            modelBuilder.Entity<NonPlayerCharacter>().HasData(new NonPlayerCharacter
            {
                Id = 6,
                Name = "The Dreamer",
                Level = 20,
                Gender = Gender.Male,
                Race = "Divinity",
                Role = "God of Space and Dreams",
                Appearance = "A large humanoid form comprised of space itself, each of their four arms is clad in golden gauntlets",
                PassivePerception = 20,
                Notes = "Father of the Moon Goddess Selune, a shard of them dwells within Wyneira's rapier"
            });

            // Seeding initial PCs
            modelBuilder.Entity<PlayerCharacter>().HasData(new PlayerCharacter
            {
                Id = 7,
                Name = "Wyneira Weisestern",
                Level = 6,
                Gender = Gender.Female,
                Race = "Half Elf",
                Class = "Bladesinger Wizard",
                Player = "Connor",
                Health = 32,
                MaxHealth = 32,
                TempHealth = 0,
                ArmourClass = 16,
                PassivePerception = 10,
                Notes = "The crew's navigator"
            });

            modelBuilder.Entity<PlayerCharacter>().HasData(new PlayerCharacter
            {
                Id = 8,
                Name = "Rosastrex Carnellion",
                Level = 6,
                Gender = Gender.Female,
                Race = "Demon",
                Class = "Celestial Warlock 5 / Fighter 1",
                Player = "Luke",
                Health = 46,
                MaxHealth = 46,
                TempHealth = 0,
                ArmourClass = 16,
                PassivePerception = 10,
                Notes = "The crew's first mate"
            });

            modelBuilder.Entity<PlayerCharacter>().HasData(new PlayerCharacter
            {
                Id = 9,
                Name = "Solv Kveoa",
                Level = 6,
                Gender = Gender.Male,
                Race = "Satyr",
                Class = "Eloquence Bard 4 / Hexblade Warlock 2",
                Player = "Greg",
                Health = 45,
                MaxHealth = 45,
                TempHealth = 0,
                ArmourClass = 14,
                PassivePerception = 12,
                Notes = "The crew's captain"
            });

        }
    }
}
