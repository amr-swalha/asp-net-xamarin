using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestXamarin
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    //.DeviceSerial("HQ695BT80857")
                    .ApkFile(@"C:\Users\afswa\Documents\Visual Studio 2015\Projects\XamarinForms\Udemy\Udemy.Droid\bin\Release\Udemy.Droid.apk")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

