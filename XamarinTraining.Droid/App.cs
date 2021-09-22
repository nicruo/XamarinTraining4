using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinTraining.Core.Services;
using XamarinTraining.Core.ViewModels;
using XamarinTraining.Droid.Services;

namespace XamarinTraining.Droid
{
    [Application]
    public class App : Application
    {
        public App()
        {
        }

        protected App(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            SimpleIoc.Default.Register<IDataService, DataService>();
            SimpleIoc.Default.Register<IToastService>(() => new ToastService(ApplicationContext));
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<AboutViewModel>();
        }
    }
}