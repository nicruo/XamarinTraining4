using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Threading.Tasks;
using XamarinTraining.Core.Domain;
using XamarinTraining.Core.Services;

namespace XamarinTraining.Core.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {
        private IDataService dataService;
        private IToastService toastService;
        private int counter;


        private string aboutTitle;
        public string AboutTitle
        {
            get => aboutTitle;
            set => Set(nameof(AboutTitle), ref aboutTitle, value);
        }

        //public HomeViewModel(IDataService dataService, IToastService toastService)
        //{
        //    this.dataService = dataService;
        //    this.toastService = toastService;
        //}

        //private async void LoadApplicationTitleAsync()
        //{
        //    toastService.ShowToast("button clicked");
        //    await Task.Delay(1000);
        //    ApplicationTitle = counter++ + " volta(s)";
        //    Character result = await dataService.GetCharacterAsync(2);
        //    ApplicationTitle = "Result = " + result;
        //}

        
    }
}