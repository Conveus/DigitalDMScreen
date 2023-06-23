using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class NoteAddToScreen
    {
        [Inject]
        public ScreenNotes? ScreenNotes { get; set; }

        [Parameter]
        public Note Note { get; set; } = default!;

        private Note? _noteAdd;

        public int panel = 2;

        //Sets _pc to input parameter allowing quickview to be seen
        protected override void OnParametersSet()
        {
            _noteAdd = Note;
        }

        public void AddtoScreen()
        {
            if (panel == 1)
            {
                ScreenNotes.P1UsedNotes.Add(_noteAdd);
            }
            else if (panel == 2)
            {
                ScreenNotes.P2UsedNotes.Add(_noteAdd);
            }
            else
            {
                ScreenNotes.P3UsedNotes.Add(_noteAdd);
            }
        }

        // Sets the used player character to null thus closing the popup
        public void Close () { _noteAdd = null; }
    }
}
