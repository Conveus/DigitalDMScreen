using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class MonsterScreenCard
    {
        [Parameter]
        public Monster Monster { get; set; } = default!;

        [Parameter]
        public EventCallback<Monster> MonsterQuickViewClicked { get; set; }

        //[Inject]
        //public NavigationManager NavigationManager { get; set; } = default!;

        //public void NavigateToDetails(Monster selectedMonster)
        //{
        //    NavigationManager.NavigateTo($"/monsterdetail/{selectedMonster.Id}");
        //}
    }
}
