using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DigitalDMScreen.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: true),
                    Health = table.Column<int>(type: "int", nullable: true),
                    MaxHealth = table.Column<int>(type: "int", nullable: true),
                    TempHealth = table.Column<int>(type: "int", nullable: true),
                    ArmourClass = table.Column<int>(type: "int", nullable: true),
                    PassivePerception = table.Column<int>(type: "int", nullable: true),
                    Attacks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NPCs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Appearance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Health = table.Column<int>(type: "int", nullable: true),
                    MaxHealth = table.Column<int>(type: "int", nullable: true),
                    TempHealth = table.Column<int>(type: "int", nullable: true),
                    ArmourClass = table.Column<int>(type: "int", nullable: true),
                    PassivePerception = table.Column<int>(type: "int", nullable: true),
                    Attacks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PCs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Player = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Health = table.Column<int>(type: "int", nullable: true),
                    MaxHealth = table.Column<int>(type: "int", nullable: true),
                    TempHealth = table.Column<int>(type: "int", nullable: true),
                    ArmourClass = table.Column<int>(type: "int", nullable: true),
                    PassivePerception = table.Column<int>(type: "int", nullable: true),
                    Attacks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "Type", "Description", "Notes" },
                values: new object[,]
                {
                    { 1, "Trunk Nose Inn", "Port", "A small but important trade hub at the centre of the Bay of the Seal", "Owned by Jeorg, an Elephant Selkie. Has both a magic item/spell store and an enchanter" },
                    { 2, "Bay of the Seal", "Archipelego", "A mid size archepeligo and territory of the Selkie Kingdom, the Sultante of the Sands, and the former Grand Kingdom of Trytos", "The first/tutorial zone" },
                    { 3, "The Rememberance", "Ship", "A sloop owned by Solv Kveoa, looks to have been repaired a few times", "The party's ship has a garden set up at the back of the ship behind the wheel" }
                });

            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "Id", "Name", "Level", "Health", "MaxHealth", "TempHealth", "ArmourClass", "PassivePerception", "Attacks", "Notes" },
                values: new object[,]
                {
                    { 1, "Ankheg", 2, 39, 39, null, 12, 11, "Bite. Melee Weapon Attack: +5 to hit, reach 5 ft., one target. Hit: 10 (2d6 + 3) slashing damage plus 3 (1d6) acid damage. If the target is a Large or smaller creature, it is grappled (escape DC 13). Until this grapple ends, the ankheg can bite only the grappled creature and has advantage on attack rolls to do so.", "A kind of giant ant" },
                    { 2, "Ankheg Queen", 5, 110, 110, null, 16, 12, "Bite. Melee Weapon Attack: +8 to hit, reach 5 ft., one target. Hit: 16 (2d10 + 5) slashing damage plus 9 (2d6) acid damage. If the target is a Huge or smaller creature, it is grappled (escape DC 15). Until this grapple ends, the ankheg can bite only the grappled creature and has advantage on the attack rolls to do so.", "The leader of Ankheg colonies" },
                    { 3, "Stonejaw Ankheg", 8, 141, 141, null, 21, 12, "Bite. Melee Weapon Attack: +9 to hit, reach 5 ft., one target. Hit: 27 (4d10 + 6) slashing damage. If the target is a Huge or smaller creature, it is grappled (escape DC 16). Until this grapple ends, the ankheg can bite only the grappled creature and has advantage on the attack rolls to do so.\r\n\r\nPetrification Breath (Recharge 6). The ankheg exhales petrifying dust in a line that is 30 feet long and 5 feet wide, provided that it has no creature grappled. Each creature in that line must make a DC 16 saving throw against being magically petrified. On a failed save, the creature begins to turn to stone and is restrained. It must repeat the saving throw at the end of its next turn. On a success, the effect ends. On a failure the creature is petrified until freed by the greater restoration spell or other magic.", "The burrower of Ankheg colonies" }
                });

            migrationBuilder.InsertData(
                table: "NPCs",
                columns: new[] { "Id", "Name", "Level", "Gender", "Race", "Role", "Appearance", "Health", "MaxHealth", "TempHealth", "ArmourClass", "PassivePerception", "Attacks", "Notes" },
                values: new object[,]
                {
                    { 1, "Jeorg", 15, 0, "Elephant-Selkie", "Trader", "Twice as tall as the even the tallest men, with a stern expression and rough hands", 169, 169, 0, 18, 13, null, "Owner of the Trunk Nose Inn" },
                    { 2, "High King Sehuet", 15, 0, "Undead", "King", "A large mummified man dressed in fine clothes and armour", 150, 150, 0, 18, 13, null, "High King of The Sea Chain" },
                    { 3, "The Dreamer", 20, 0, "Divinity", "God of Space and Dreams", "A large humanoid form comprised of space itself, each of their four arms is clad in golden gauntlets", null, null, null, null, 20, null, "Father of the Moon Goddess Selune, a shard of them dwells within Wyneira's rapier" }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Name", "Notes" },
                values: new object[,]
                {
                    { 1, "Wyn's outstanding debt to The Dreamer", "The Dreamer will show up randomly 25 times" },
                    { 2, "Miralla's Eldritch Tattoo", "The tattoo is at stage 2" },
                    { 3, "Plans to mess with the party", "1) Dreamer schenanigans, 2) The Deep, 3) Prim" }
                });

            migrationBuilder.InsertData(
                table: "PCs",
                columns: new[] { "Id", "Name", "Level", "Gender", "Race", "Class", "Player", "Health", "MaxHealth", "TempHealth", "ArmourClass", "PassivePerception", "Attacks", "Notes" },
                values: new object[,]
                {
                    { 1, "Wyneira Weisestern", 6, 1, "Half Elf", "Bladesinger Wizard", "Connor", 32, 32, 0, 16, 10, null, "The crew's navigator" },
                    { 2, "Rosastrex Carnellion", 6, 1, "Demon", "Celestial Warlock 5 / Fighter 1", "Luke", 46, 46, 0, 16, 10, null, "The crew's first mate" },
                    { 3, "Solv Kveoa", 6, 0, "Satyr", "Eloquence Bard 4 / Hexblade Warlock 2", "Greg", 45, 45, 0, 14, 12, null, "The crew's captain" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Monsters");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "NPCs");

            migrationBuilder.DropTable(
                name: "PCs");
        }
    }
}
