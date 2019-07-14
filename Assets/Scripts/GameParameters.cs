using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public static class GameParameters
    {
        public static bool AllowAcessToLobbyWithoutLogin() => false;
        public static string ServerAddress() => @"http://localhost:5000/";
        public static string AuthenticationRoute() => @"account/login";
        public static string LocalStorageNameAccessToken() => "ACCESS_TOKEN";
        /*
         TODO : FIX THIS UGLY SHIT
             */
        public static string LocalStorageNameUsername() => "USER_NAME";
        public static string LocalStorageNamePassword() => "USER_PASSWORD";

    }
}
