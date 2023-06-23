using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp
{
    public class ScreenNotes
    {

        [Inject]
        public INPCDataService? NPCDataService { get; set; }
        [Inject]
        public IPCDataService? PCDataService { get; set; }
        [Inject]
        public IMonsterDataService? MonsterDataService { get; set; }
        [Inject]
        public ILocationDataService? LocationDataService { get; set; }
        [Inject]
        public INoteDataService? NoteDataService { get; set; }

        // Notes in Panel 1
        public List<PlayerCharacter>? P1UsedPCs = new List<PlayerCharacter>();
        public List<NonPlayerCharacter>? P1UsedNPCs = new List<NonPlayerCharacter>();
        public List<Note>? P1UsedNotes = new List<Note>();
        public List<Location>? P1UsedLocations = new List<Location>();
        public List<Monster>? P1UsedMonsters = new List<Monster>();

        // Notes in Panel 2
        public List<PlayerCharacter>? P2UsedPCs = new List<PlayerCharacter>();
        public List<NonPlayerCharacter>? P2UsedNPCs = new List<NonPlayerCharacter>();
        public List<Note>? P2UsedNotes = new List<Note>();
        public List<Location>? P2UsedLocations = new List<Location>();
        public List<Monster>? P2UsedMonsters = new List<Monster>();

        // Notes in Panel 3
        public List<PlayerCharacter>? P3UsedPCs = new List<PlayerCharacter>();
        public List<NonPlayerCharacter>? P3UsedNPCs = new List<NonPlayerCharacter>();
        public List<Note>? P3UsedNotes = new List<Note>();
        public List<Location>? P3UsedLocations = new List<Location>();
        public List<Monster>? P3UsedMonsters = new List<Monster>();

    }
}
