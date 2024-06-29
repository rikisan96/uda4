using System;

namespace LoginConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("===============OPERAZIONI==============");
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("1.: Login");
                Console.WriteLine("2.: Logout");
                Console.WriteLine("3.: Verifica ora e data di login");
                Console.WriteLine("4.: Lista degli accessi");
                Console.WriteLine("5.: Esci");
                Console.WriteLine("========================================");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PerformLogin();
                        break;
                    case "2":
                        PerformLogout();
                        break;
                    case "3":
                        CheckLoginTime();
                        break;
                    case "4":
                        ShowAccessHistory();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida. Premi un tasto per continuare...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void PerformLogin()
        {
            Console.Write("Inserisci username: ");
            var username = Console.ReadLine();

            Console.Write("Inserisci password: ");
            var password = Console.ReadLine();

            Console.Write("Conferma password: ");
            var confirmPassword = Console.ReadLine();

            if (Utente.Login(username, password, confirmPassword))
            {
                Console.WriteLine("Login effettuato con successo!");
            }
            else
            {
                Console.WriteLine("Errore nel login. Username mancante o le password non coincidono.");
            }

            Console.WriteLine("Premi un tasto per continuare...");
            Console.ReadKey();
        }

        private static void PerformLogout()
        {
            if (Utente.IsLoggedIn)
            {
                Utente.Logout();
                Console.WriteLine("Logout effettuato con successo!");
            }
            else
            {
                Console.WriteLine("Errore: Nessun utente è attualmente loggato.");
            }

            Console.WriteLine("Premi un tasto per continuare...");
            Console.ReadKey();
        }

        private static void CheckLoginTime()
        {
            if (Utente.IsLoggedIn)
            {
                Console.WriteLine($"L'utente {Utente.Username} ha effettuato il login in data e ora: {Utente.LoginTime}");
            }
            else
            {
                Console.WriteLine("Errore: Nessun utente è attualmente loggato.");
            }

            Console.WriteLine("Premi un tasto per continuare...");
            Console.ReadKey();
        }

        private static void ShowAccessHistory()
        {
            if (Utente.Accessi.Count > 0)
            {
                Console.WriteLine("Storico degli accessi:");
                foreach (var accesso in Utente.Accessi)
                {
                    Console.WriteLine(accesso);
                }
            }
            else
            {
                Console.WriteLine("Nessun accesso registrato.");
            }

            Console.WriteLine("Premi un tasto per continuare...");
            Console.ReadKey();
        }
    }
}
