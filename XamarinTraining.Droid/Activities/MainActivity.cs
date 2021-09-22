using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Ioc;
using XamarinTraining.Core.ViewModels;

namespace XamarinTraining.Droid.Activities
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class HomeActivity : AppCompatActivity
    {
        private Button button, navigateButton;
        private HomeViewModel viewModel;
        private Binding binding;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            button = FindViewById<Button>(Resource.Id.button);
            navigateButton = FindViewById<Button>(Resource.Id.navigateButton);

            viewModel = SimpleIoc.Default.GetInstance<HomeViewModel>();
            binding = this.SetBinding(() => viewModel.ApplicationTitle, () => button.Text);
            viewModel.ApplicationTitle = "Olá mundo!";
            button.SetCommand(viewModel.LoadDataCommand);

            navigateButton.Click += NavigateButton_Click;
        }

        private void NavigateButton_Click(object sender, System.EventArgs e)
        {
            StartActivity(new Intent(this, typeof(AboutActivity)));
        }
    }
}