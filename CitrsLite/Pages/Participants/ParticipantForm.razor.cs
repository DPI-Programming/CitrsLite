using CitrsLite.Business.Services;
using CitrsLite.Business.ViewModels.ParticipantViewModels;
using CitrsLite.Business.ViewModels.VarietyCloneViewModels;
using CitrsLite.Data.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MudBlazor;

namespace CitrsLite.Pages.Participants

{
    public partial class ParticipantForm
    {
        [Inject]
        protected ParticipantService ParticipantService { get; set; }

        [Inject]
        public ParticipantFormViewModel Model { get; set; }

        [Inject]
        public NavigationManager? NavigationManager { get; set; }

        [Parameter]
        public int? Id { get; set; }

        [Parameter]
        public Participant? Participant { get; set; }

        private IEnumerable<Participant>? Participants { get; set; }

        //protected override async Task OnInitializedAsync()
        //{
        //    Participant = new Participant();
        //    Participants = await ParticipantService.GetParticipantList();
        //}

        public void CreateParticipant()
        {
            participantService.CreateAysnc(Model);
        }

        protected override async Task OnInitializedAsync()
        {
            var authState = await authenticationStateProvider.GetAuthenticationStateAsync();

            Model.UserName = authState.User.Identity?.Name ?? "Unknown user";
        }

        //private async void SubmitForm()
        //{
        //    var authorizationState = await AuthenticationStateProvider.GetAuthenticationStateAsync();

        //    model.UserName = authorizationState?.User?.Identity?.Name ?? "No Username";

        //    ParticipantService.CreateAysnc(model);

        //    NavigationManager.NavigateTo("/index");
        //}



        private String Message = String.Empty;


        #region Table Code

        //Table Search feature
        private string searchString1 = "";
        //private cloneList selectedItem1 = null;
        //private HashSet<VarietyClones> selectedItems = new HashSet<VarietyClones>();

        //private bool FilterFunc1(VarietyClones cloneList) => FilterFunc(cloneList, searchString1);

        //private bool FilterFunc(VarietyClones cloneList, string searchString)
        //{
        //    if (string.IsNullOrWhiteSpace(searchString))
        //        return true;
        //    if (cloneList.Id.Contains(searchString, StringComparison.OrdinalIgnoreCase))
        //        return true;
        //    if (cloneList.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
        //        return true;
        //    if (cloneList.Description.Contains(searchString, StringComparison.OrdinalIgnoreCase))
        //        return true;
        //    if (cloneList.IsActive.Contains(searchString, StringComparison.OrdinalIgnoreCase))
        //        return true;
        //    return false;
        //}

        #endregion

    }
}
