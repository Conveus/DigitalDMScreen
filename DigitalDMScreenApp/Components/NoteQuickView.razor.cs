using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class NoteQuickView
    {
        [Parameter]
        public Note Note { get; set; } = default!;

        private Note? _note;

        //Sets _pc to input parameter allowing quickview to be seen
        protected override void OnParametersSet()
        {
            _note = Note;
        }

        // Sets the used player character to null thus closing the popup
        public void Close () { _note = null; }
    }
}
