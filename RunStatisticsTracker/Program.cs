string name;
string surname;
string userChoice = "";
string info = "";
string getKm;
string getM;
bool isQuit = false;

while (!isQuit)
{
    DisplayText("");
    name = GetData("Wprowadź imię:");
    surname = GetData("Wprowadź Nazwisko:");


    while (!isQuit)
    {
        DisplayMenu1(info, name);
        userChoice = GetData("");

        switch (userChoice)
        {
            case "1":
                DisplayText("BIEG NA ZEWNĄTRZ\n");
                getKm = GetData("Wprowadź ilość przebiegniętych pełnych kilometrów:");
                getM = GetData("Wprowadź ilość przebiegniętych metrów:");
                break;

            case "2":
                DisplayText("BIEGI NA BIEŻNI\n");
                getKm = GetData("Wprowadź ilość pełnych przebiegniętych kilometrów:");
                getM = GetData("Wprowadź ilość przebiegniętych metrów:");
                break;

            case "3":
                DisplayText("STARYSTYKI\n");
                break;

            case "4":
                isQuit = true;
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
    Console.WriteLine($"Witaj {name}! Jaki rodzaj biegu chcesz wprowadzić?\n");
    Console.WriteLine("1. Bieg na zewnątrz");
    Console.WriteLine("2. Bieg na bieżni");
    Console.WriteLine("");
    Console.WriteLine("3. Odczytaj statystyki");
    Console.WriteLine("4. Zakończ program");
    Console.WriteLine($"\u001b[31m{info}\u001b[0m");
    Console.WriteLine("Wybierz jedną z powyższych opcji (1-4) i naciśnij enter: ");

}
void DisplayText(string text)
{
    Console.Clear();
    WelcomeDisplay();
    Console.WriteLine(text);
}
string GetData(string info)
{
    Console.WriteLine(info);
    var input = Console.ReadLine();
    return input;
}