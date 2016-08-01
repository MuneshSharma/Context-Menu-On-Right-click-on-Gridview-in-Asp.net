using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using FacebookLoginMVCApplication.Models;

namespace FacebookLoginMVCApplication
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "907552512704446",
                appSecret: "62f9083a9f410a56f8fd25ba444641a6");

            OAuthWebSecurity.RegisterTwitterClient(
               consumerKey: "dehAbmGainTnbfVoyrp8jP2OD",
               consumerSecret: "	EqDT51RO51Lk60RmsNk7VP6gjsmWEQRVvPvvWEODhHpzl8qekr");

            //OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
