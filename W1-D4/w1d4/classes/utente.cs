using System;
using System.Collections.Generic;

namespace LoginConsoleApp
{
    public static class Utente
    {
        public static string Username { get; private set; }
        private static string Password { get; set; }
        public static DateTime? LoginTime { get; private set; }
        public static List<DateTime> Accessi { get; private set; } = new List<DateTime>();

        public static bool IsLoggedIn => !string.IsNullOrEmpty(Username);

        public static bool Login(string username, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(username))
                return false;

            if (password != confirmPassword)
                return false;

            Username = username;
            Password = password;
            LoginTime = DateTime.Now;
            Accessi.Add(LoginTime.Value);
            return true;
        }

        public static void Logout()
        {
            Username = null;
            Password = null;
            LoginTime = null;
        }
    }
}
