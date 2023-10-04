using RunStatisticsTracker;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

string name;
string surname;
string userChoice = "";
string info = "";
string distance;
bool isQuit = false;


while (!isQuit)
{
    DisplayText("");
    name = GetData("\u001b[33mWprowadź imię:\u001b[0m");
    surname = GetData("\u001b[33mWprowadź Nazwisko:\u001b[0m");

    while (!isQuit)
    {
        var outdoorRunner = new OutdoorRun(name, surname);
        var treadmillRunner = new TreadmillRun(name, surname);
        DisplayMenu1(info, name);
        userChoice = GetData("");

        switch (userChoice)
        {
            case "1":

                DisplayText("BIEG NA ZEWNĄTRZ\n");
                outdoorRunner.ReadDistance(GetData("\u001b[33mWprowadź ilość przebiegniętych kilometrów (np. 21,0975) a następnie naciśnij enter:\u001b[0m"));
                break;

            case "2":
                DisplayText("BIEGI NA BIEŻNI\n");
                treadmillRunner.ReadDistance(GetData("\u001b[33mWprowadź ilość przebiegniętych kilometrów (np. 21,0975) a następnie naciśnij enter:\u001b[0m"));

                break;

            case "3":
                DisplayText("");
                if (treadmillRunner.StatExists())
                {
                    var trStatistics = treadmillRunner.GetStatistics();
                    DisplayStatistics(trStatistics.Count, trStatistics.DistSum, trStatistics.LongestDist, trStatistics.ShortestDist, trStatistics.AvgDist, "bieżni");
                }
                else
                {
                    Console.WriteLine($"\u001b[31mBRAK STATYSTYK BIEGÓW NA BIEŻNI\n\u001b[0m");
                }

                if (outdoorRunner.StatExists())
                {
                    var orStatistics = outdoorRunner.GetStatistics();
                    DisplayStatistics(orStatistics.Count, orStatistics.DistSum, orStatistics.LongestDist, orStatistics.ShortestDist, orStatistics.AvgDist, "zewnątrz");
                }
                else
                {
                    Console.WriteLine($"\u001b[31mBRAK STATYSTYK BIEGÓW NA ZEWNĄTRZ\n\u001b[0m");
                }

                GetData("\u001b[33mWciśnij jakiś przycisk aby wrócić do menu.\u001b[0m");
                break;

            case "4":
                isQuit = true;
                DisplayText("\u001b[33mDZIĘKUJĘ ZA SKORZYSTANIE Z TEGO PROGRAMU!\u001b[0m");
                Console.WriteLine("");
                break;

            default:
                info = $"Nieprawidłowy wybór - {userChoice}";
                continue;
        }
    }
}

void WelcomeDisplay()
{
    Console.WriteLine("   ___              ______       __  _     __  _           ______             __          \r\n  / _ \\__ _____    / __/ /____ _/ /_(_)__ / /_(_)______   /_  __/______ _____/ /_____ ____\r\n / , _/ // / _ \\  _\\ \\/ __/ _ `/ __/ (_-</ __/ / __(_-<    / / / __/ _ `/ __/  '_/ -_) __/\r\n/_/|_|\\_,_/_//_/ /___/\\__/\\_,_/\\__/_/___/\\__/_/\\__/___/   /_/ /_/  \\_,_/\\__/_/\\_\\\\__/_/   \r\n                                                                                          ");
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine($"-----------------------------------------------------");
    Console.WriteLine($"        Witaj w programie RunStatisticsTracker       ");
    Console.WriteLine($"     Zapisz swoje biegi i odczytaj statystyki! :)    ");
    Console.WriteLine($"-----------------------------------------------------");
    Console.WriteLine($"");
    Console.ResetColor();
}
void DisplayMenu1(string info, string name)
{
    Console.Clear();
    WelcomeDisplay();
    Console.WriteLine($"Witaj {name}!");
    Console.WriteLine("\u001b[33mWybierz jedną z poniższych opcji (1-4) i naciśnij enter:\n \u001b[0m");
    Console.WriteLine("1. Wprowadź bieg na zewnątrz");
    Console.WriteLine("2. Wprowadź bieg na bieżni");
    Console.WriteLine("3. Odczytaj statystyki");
    Console.WriteLine("4. Zakończ program");
    Console.WriteLine($"\u001b[31m{info}\u001b[0m");


}
void DisplayText(string text)
{
    Console.Clear();
    WelcomeDisplay();
    Console.WriteLine(text);
}
void DisplayStatistics(int count, double distSum, double longestDist, double shortestDist, double avgDist, string text)
{
    Console.WriteLine();
    Console.WriteLine("\u001b[32m╔══════════════════════════════════════════════════════════╗\u001b[0m");
    Console.WriteLine($"               Statystyki biegów na {text}:               ");
    Console.WriteLine("\u001b[32m╚══════════════════════════════════════════════════════════╝\u001b[0m");
    Console.WriteLine($"            Ilość biegów              \u001b[32m│\u001b[0m        {count}    ");
    Console.WriteLine($"         Najdłuższy bieg [km]         \u001b[32m│\u001b[0m      {Math.Round(longestDist, 3)}");
    Console.WriteLine($"         Najkrótszy bieg [km]         \u001b[32m│\u001b[0m      {Math.Round(shortestDist, 3)}");
    Console.WriteLine($"       Suma przebiegniętych [km]      \u001b[32m│\u001b[0m      {Math.Round(distSum, 3)}");
    Console.WriteLine($"         Średni dystans [km]          \u001b[32m│\u001b[0m      {Math.Round(avgDist, 3)}");
    Console.WriteLine();

}
string GetData(string info)
{
    Console.WriteLine(info);
    var input = Console.ReadLine();
    return input;
}

