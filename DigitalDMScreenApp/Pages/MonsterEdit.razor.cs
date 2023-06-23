using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class MonsterEdit
    {
        [Inject]
        public IMonsterDataService? MonsterDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string? Id { get; set; }
        public Monster? Monster { get; set; } = new Monster();

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        protected override async Task OnInitializedAsync()
        {
            Saved = false;
            Monster = await MonsterDataService.GetMonsterDetails(int.Parse(Id));
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;

            if(Monster.Id ==0) // Handling new Monster
            {
                var addedMonster = await MonsterDataService.AddMonster(Monster);
                if(addedMonster != null)
                {
                    StatusClass = "alert-success";
                    Message = "New Monster added successfully";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong ading the new Monster. Please try again";
                    Saved = false;
                }
            }
            else // Handling existing Monster
            {
                await MonsterDataService.UpdateMonster(Monster);
                StatusClass = "alert-success";
                Message = "Monster updated successfully";
                Saved = true;
            }
        }

        protected async Task HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again";
        }

        protected async Task DeleteMonster()
        {
            await MonsterDataService.DeleteMonster(Monster.Id);

            StatusClass = "alert-success";
            Message = "Deleted successfully";
            Saved = true;
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/monsteroverview");
        }
    }
}
