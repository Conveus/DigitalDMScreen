﻿// <auto-generated />
using System;
using DigitalDMScreen.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DigitalDMScreen.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DigitalDMScreen.Shared.Domain.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A small but important trade hub at the centre of the Bay of the Seal",
                            Name = "Trunk Nose Inn",
                            Notes = "Owned by Jeorg, an Elephant Selkie. Has both a magic item/spell store and an enchanter",
                            Type = "Port"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A mid size archepeligo and territory of the Selkie Kingdom, the Sultante of the Sands, and the former Grand Kingdom of Trytos",
                            Name = "Bay of the Seal",
                            Notes = "The first/tutorial zone",
                            Type = "Archipelego"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A sloop owned by Solv Kveoa, looks to have been repaired a few times",
                            Name = "The Rememberance",
                            Notes = "The party's ship has a garden set up at the back of the ship behind the wheel",
                            Type = "Ship"
                        });
                });

            modelBuilder.Entity("DigitalDMScreen.Shared.Domain.Monster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ArmourClass")
                        .HasColumnType("int");

                    b.Property<string>("Attacks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Health")
                        .HasColumnType("int");

                    b.Property<int?>("Level")
                        .HasColumnType("int");

                    b.Property<int?>("MaxHealth")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PassivePerception")
                        .HasColumnType("int");

                    b.Property<int?>("TempHealth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Monsters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArmourClass = 12,
                            Attacks = "Bite. Melee Weapon Attack: +5 to hit, reach 5 ft., one target. Hit: 10 (2d6 + 3) slashing damage plus 3 (1d6) acid damage. If the target is a Large or smaller creature, it is grappled (escape DC 13). Until this grapple ends, the ankheg can bite only the grappled creature and has advantage on attack rolls to do so.",
                            Health = 39,
                            Level = 2,
                            MaxHealth = 39,
                            Name = "Ankheg",
                            Notes = "A kind of giant ant",
                            PassivePerception = 11
                        },
                        new
                        {
                            Id = 2,
                            ArmourClass = 16,
                            Attacks = "Bite. Melee Weapon Attack: +8 to hit, reach 5 ft., one target. Hit: 16 (2d10 + 5) slashing damage plus 9 (2d6) acid damage. If the target is a Huge or smaller creature, it is grappled (escape DC 15). Until this grapple ends, the ankheg can bite only the grappled creature and has advantage on the attack rolls to do so.",
                            Health = 110,
                            Level = 5,
                            MaxHealth = 110,
                            Name = "Ankheg Queen",
                            Notes = "The leader of Ankheg colonies",
                            PassivePerception = 12
                        },
                        new
                        {
                            Id = 3,
                            ArmourClass = 21,
                            Attacks = "Bite. Melee Weapon Attack: +9 to hit, reach 5 ft., one target. Hit: 27 (4d10 + 6) slashing damage. If the target is a Huge or smaller creature, it is grappled (escape DC 16). Until this grapple ends, the ankheg can bite only the grappled creature and has advantage on the attack rolls to do so.\r\n\r\nPetrification Breath (Recharge 6). The ankheg exhales petrifying dust in a line that is 30 feet long and 5 feet wide, provided that it has no creature grappled. Each creature in that line must make a DC 16 saving throw against being magically petrified. On a failed save, the creature begins to turn to stone and is restrained. It must repeat the saving throw at the end of its next turn. On a success, the effect ends. On a failure the creature is petrified until freed by the greater restoration spell or other magic.",
                            Health = 141,
                            Level = 8,
                            MaxHealth = 141,
                            Name = "Stonejaw Ankheg",
                            Notes = "The burrower of Ankheg colonies",
                            PassivePerception = 12
                        });
                });

            modelBuilder.Entity("DigitalDMScreen.Shared.Domain.NonPlayerCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Appearance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ArmourClass")
                        .HasColumnType("int");

                    b.Property<string>("Attacks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<int?>("Health")
                        .HasColumnType("int");

                    b.Property<int?>("Level")
                        .HasColumnType("int");

                    b.Property<int?>("MaxHealth")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PassivePerception")
                        .HasColumnType("int");

                    b.Property<string>("Race")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TempHealth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NPCs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Appearance = "Twice as tall as the even the tallest men, with a stern expression and rough hands",
                            ArmourClass = 18,
                            Gender = 0,
                            Health = 169,
                            Level = 15,
                            MaxHealth = 169,
                            Name = "Jeorg",
                            Notes = "Owner of the Trunk Nose Inn",
                            PassivePerception = 13,
                            Race = "Elephant-Selkie",
                            Role = "Trader",
                            TempHealth = 0
                        },
                        new
                        {
                            Id = 2,
                            Appearance = "A large mummified man dressed in fine clothes and armour",
                            ArmourClass = 18,
                            Gender = 0,
                            Health = 150,
                            Level = 15,
                            MaxHealth = 150,
                            Name = "High King Sehuet",
                            Notes = "High King of The Sea Chain",
                            PassivePerception = 13,
                            Race = "Undead",
                            Role = "King",
                            TempHealth = 0
                        },
                        new
                        {
                            Id = 3,
                            Appearance = "A large humanoid form comprised of space itself, each of their four arms is clad in golden gauntlets",
                            Gender = 0,
                            Level = 20,
                            Name = "The Dreamer",
                            Notes = "Father of the Moon Goddess Selune, a shard of them dwells within Wyneira's rapier",
                            PassivePerception = 20,
                            Race = "Divinity",
                            Role = "God of Space and Dreams"
                        });
                });

            modelBuilder.Entity("DigitalDMScreen.Shared.Domain.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Wyn's outstanding debt to The Dreamer",
                            Notes = "The Dreamer will show up randomly 25 times"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Miralla's Eldritch Tattoo",
                            Notes = "The tattoo is at stage 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Plans to mess with the party",
                            Notes = "1) Dreamer schenanigans, 2) The Deep, 3) Prim"
                        });
                });

            modelBuilder.Entity("DigitalDMScreen.Shared.Domain.PlayerCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ArmourClass")
                        .HasColumnType("int");

                    b.Property<string>("Attacks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<int?>("Health")
                        .HasColumnType("int");

                    b.Property<int?>("Level")
                        .HasColumnType("int");

                    b.Property<int?>("MaxHealth")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PassivePerception")
                        .HasColumnType("int");

                    b.Property<string>("Player")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TempHealth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PCs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArmourClass = 16,
                            Class = "Bladesinger Wizard",
                            Gender = 1,
                            Health = 32,
                            Level = 6,
                            MaxHealth = 32,
                            Name = "Wyneira Weisestern",
                            Notes = "The crew's navigator",
                            PassivePerception = 10,
                            Player = "Connor",
                            Race = "Half Elf",
                            TempHealth = 0
                        },
                        new
                        {
                            Id = 2,
                            ArmourClass = 16,
                            Class = "Celestial Warlock 5 / Fighter 1",
                            Gender = 1,
                            Health = 46,
                            Level = 6,
                            MaxHealth = 46,
                            Name = "Rosastrex Carnellion",
                            Notes = "The crew's first mate",
                            PassivePerception = 10,
                            Player = "Luke",
                            Race = "Demon",
                            TempHealth = 0
                        },
                        new
                        {
                            Id = 3,
                            ArmourClass = 14,
                            Class = "Eloquence Bard 4 / Hexblade Warlock 2",
                            Gender = 0,
                            Health = 45,
                            Level = 6,
                            MaxHealth = 45,
                            Name = "Solv Kveoa",
                            Notes = "The crew's captain",
                            PassivePerception = 12,
                            Player = "Greg",
                            Race = "Satyr",
                            TempHealth = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
