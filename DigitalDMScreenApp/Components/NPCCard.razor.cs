using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class NPCCard
    {
        [Parameter]
        public NonPlayerCharacter NPC { get; set; } = default!;

        [Parameter]
        public EventCallback<NonPlayerCharacter> NPCQuickViewClicked { get; set; }

        [Parameter]
        public EventCallback<NonPlayerCharacter> NPCAddToScreenClicked { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        public void NavigateToDetails(NonPlayerCharacter selectedNPC)
        {
            NavigationManager.NavigateTo($"/npcdetail/{selectedNPC.Id}");
        }
    }
}
