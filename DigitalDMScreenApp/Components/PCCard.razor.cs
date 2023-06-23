using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class PCCard
    {
        [Parameter]
        public PlayerCharacter PC { get; set; } = default!;

        [Parameter]
        public EventCallback<PlayerCharacter> PCQuickViewClicked { get; set; }
		
		[Parameter]
        public EventCallback<PlayerCharacter> PCAddToScreenClicked { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        public void NavigateToDetails(PlayerCharacter selectedPC)
        {
            NavigationManager.NavigateTo($"/pcdetail/{selectedPC.Id}");
        }
    }
}
