using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Models;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class MonsterDetail
    {
        [Inject]
        public IMonsterDataService? MonsterDataService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public Monster? Monster { get; set; } = new Monster();

        protected async override Task OnInitializedAsync()
        {
            Monster = await MonsterDataService.GetMonsterDetails(int.Parse(Id));
        }
    }
}
