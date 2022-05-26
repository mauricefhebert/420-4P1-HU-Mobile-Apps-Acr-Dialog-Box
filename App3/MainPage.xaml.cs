using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Acr.UserDialogs;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //UserDialogs.Instance.ActionSheet(new ActionSheetConfig { Title = "Info", Message = "Message", UseBottomSheet = true, Cancel = new ActionSheetOption("Annuler")});
            //UserDialogs.Instance.Alert(new AlertConfig { Title="Info", Message="Message", OkText="Ok" });
            //UserDialogs.Instance.Confirm(new ConfirmConfig { Title = "Info", Message = "Message", OkText = "Ok", CancelText = "Annuler" });
            //UserDialogs.Instance.DatePrompt(new DatePromptConfig { Title = "Info", OkText = "Ok", CancelText = "Annuler", SelectedDate = new DateTime() });
            //UserDialogs.Instance.Prompt(new PromptConfig { Title = "Info", Message = "Message", OkText = "Ok", CancelText = "Annuler",
            //    OnAction = (entries) =>
            //    {
            //        if (entries.Ok) UserDialogs.Instance.Alert(new AlertConfig { Title = "Information", OkText = "Ok" });
            //        else UserDialogs.Instance.Alert(new AlertConfig { Title = "Information", OkText = "Annuler" });
            //    }});
            //UserDialogs.Instance.Loading("Telechargement des donnees...", () => { UserDialogs.Instance.HideLoading(); }, "Annuler");
            //await UserDialogs.Instance.LoginAsync(new LoginConfig { Title = "Connection", OkText="Ok", CancelText="Annuler", LoginPlaceholder="Nom d'utilisateur", PasswordPlaceholder="Mot de passe" });
        }
    }
}
