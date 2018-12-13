using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Security.Keystore;
using Android.Views;
using Android.Widget;
using FingerForms.Droid;
using Java.Security;
using Javax.Crypto;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(FingerAuthDroid))]
namespace FingerForms.Droid
{
    public class FingerAuthDroid : IFingerService
    {
        private KeyStore keyStore;
        private Cipher cipher;
        private string KEY_NAME = "Ahsan";
        public bool Auth()
        {
            try
            {
                cipher = Cipher.GetInstance(KeyProperties.KeyAlgorithmAes
                    + "/"
                    + KeyProperties.BlockModeCbc
                    + "/"
                    + KeyProperties.EncryptionPaddingPkcs7);
                keyStore.Load(null);
                IKey key = (IKey)keyStore.GetKey(KEY_NAME, null);
                cipher.Init(CipherMode.EncryptMode, key);
                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}