using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TesteXamarin.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Sobre";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/ronilsonsilva/overview_xamarin"));
        }

        public ICommand OpenWebCommand { get; }
    }
}