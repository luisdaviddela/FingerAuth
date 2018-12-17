using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.Hardware.Fingerprints;
using Android.OS;
using Android.Runtime;
using Android.Security.Keystore;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using FingerForms.Droid;
using Java.Security;
using Javax.Crypto;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(FingerAuthDroid))]
namespace FingerForms.Droid
{
    public class FingerAuthDroid /*: IFingerService*/
    {
        //FingerprintManager fingerprintManager = (FingerprintManager)GetSystemService(FingerprintService);
        //private KeyStore keyStore;
        //private Context mainActivity;
        //private Cipher cipher;
        //private string KEY_NAME = "Ahsan";
        //public bool Auth()
        //{
        //    CancellationSignal cancellationSignal = new CancellationSignal();
        //    try
        //    {
        //        cipher = Cipher.GetInstance(KeyProperties.KeyAlgorithmAes
        //            + "/"
        //            + KeyProperties.BlockModeCbc
        //            + "/"
        //            + KeyProperties.EncryptionPaddingPkcs7);
        //        keyStore.Load(null);
        //        IKey key = (IKey)keyStore.GetKey(KEY_NAME, null);
        //        cipher.Init(CipherMode.EncryptMode, key);
        //        return true;
        //    }
        //    catch (Exception ex) { return false; }
        //}

        //public void validation()
        //{
        //    if (ActivityCompat.CheckSelfPermission(mainActivity, Manifest.Permission.UseFingerprint)
        //        != (int)Android.Content.PM.Permission.Granted)
        //        return;
        //    fingerprintManager.Authenticate(cryptoObject, cancellationSignal, 0, this, null);
        //}
    }
}