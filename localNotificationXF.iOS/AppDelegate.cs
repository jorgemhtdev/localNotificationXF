﻿namespace localNotificationXF.iOS
{
    using Foundation;
    using LocalNotificationXF.iOS.Services;
    using UIKit;
    using UserNotifications;
    using Xamarin.Forms;
    using Xamarin.Forms.Platform.iOS;

    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

            // UNUserNotificationCenterDelegate
            UNUserNotificationCenter.Current.Delegate = new iOSNotificationReceiver(); 

            LoadApplication(new App());
            return base.FinishedLaunching(app, options);
        }
    }
}
