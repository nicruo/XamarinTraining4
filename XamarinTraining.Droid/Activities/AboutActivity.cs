using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinTraining.Core.ViewModels;

namespace XamarinTraining.Droid.Activities
{
    [Activity]
    class AboutActivity : AppCompatActivity
    {
        private EditText editText;
        private TextView textView;
        private AboutViewModel viewModel;
        private Binding binding;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_about);
            editText = FindViewById<EditText>(Resource.Id.editText);
            textView = FindViewById<TextView>(Resource.Id.textView);

            viewModel = SimpleIoc.Default.GetInstance<AboutViewModel>();
            binding = this.SetBinding(() => editText.Text, () => textView.Text, BindingMode.TwoWay);
            viewModel.AboutTitle = "About title";
        }
    }
}