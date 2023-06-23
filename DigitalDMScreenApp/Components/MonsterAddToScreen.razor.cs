using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class MonsterAddToScreen
    {
        [Inject]
        public ScreenNotes? ScreenNotes { get; set; }

        [Parameter]
        public Monster Monster { get; set; } = default!;

        private Monster? _monsterAdd;

        public int panel = 2;

        //Sets _pc to input parameter allowing quickview to be seen
        protected override void OnParametersSet()
        {
            _monsterAdd = Monster;
        }

        public void AddtoScreen()
        {
            if (panel == 1)
            {
                ScreenNotes.P1UsedMonsters.Add(_monsterAdd);
            }
            else if (panel == 2)
            {
                ScreenNotes.P2UsedMonsters.Add(_monsterAdd);
            }
            else
            {
                ScreenNotes.P3UsedMonsters.Add(_monsterAdd);
            }
        }

        // Sets the used player character to null thus closing the popup
        public void Close () { _monsterAdd = null; }
    }
}
