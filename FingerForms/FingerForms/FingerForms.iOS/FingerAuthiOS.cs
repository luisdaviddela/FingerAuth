using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FingerForms.iOS;
using Foundation;
using LocalAuthentication;
using UIKit;
using Xamarin.Forms;
[assembly: Xamarin.Forms.Dependency(typeof(FingerAuthiOS))]
namespace FingerForms.iOS
{
   public class FingerAuthiOS:IFingerService
    {
        private LAContextReplyHandler replyHandler;
        public bool Auth()
        {
            bool aut = false;
            var context = new LAContext();
            NSError AuthError;
            //var localizedReason = new NSString("To add a new chore");

            if (context.CanEvaluatePolicy(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, out AuthError))
            {
                replyHandler = new LAContextReplyHandler((success, error) =>
                {
                    Device.BeginInvokeOnMainThread(() => {
                        if (success)
                        {
                            aut = true;
                        }
                        else
                        {
                            //Show fallback mechanism here
                            aut = false;
                        }
                    });
                });
                //context.EvaluatePolicy(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, localizedReason, replyHandler);
            };
            return aut;
        }
    }
}