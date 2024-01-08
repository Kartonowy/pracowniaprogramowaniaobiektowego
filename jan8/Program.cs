namespace jan8;
class Program
{
    /*
 1) Napisz program, który wczytuje z klawiatury liczbę n, a następnie n imion i wieków
osób.
2) Użyj tablicy, aby przechować wczytane imiona i wieki.
3) Użyj listy, aby przechować tylko te imiona, które zaczynają się na literę A.
4) Użyj słownika, aby przechować pary (imie, wiek) dla wszystkich osób, których wiek jest
większy niż 18 lat.
5) Wypisz na ekranie zawartość tablicy, listy i słownika.
*/

    static void Main(string[] args)

    {
        int n = ReadInt("Podaj liczbę osób: ", 0, int.MaxValue);

        int[] ages = new int[n];
        string[] names = new string[n];
    
        for (int i = 0; i < n; ++i) {
            names[i] = ReadString($"Podaj imie {i + 1} \n");
            ages[i] = ReadInt($"Podaj wiek osoby {i + 1} \n", 0, 150);
        }

        Console.WriteLine("Tablica imion i wieków:");
        PrintTables(names, ages);

        List<String> namesWithA = names.Where(e => e.ToUpper().StartsWith("A")).ToList();

        Console.WriteLine("Lista imion zaczynajacych sie na litere a lub A");
        PrintList(namesWithA);

        Dictionary<string, int> adults = new Dictionary<string, int>();
        for (int i = 0; i < n; ++i) {
            if (ages[i] >= 18) {
                adults.Add(names[i], ages[i]);
            }
        }
        Console.WriteLine("Osoby pełnoletnie: ");
        PrintDictionary(adults);

        Console.ReadKey();
    }


    static int ReadInt(string prompt, int low, int high) {
        int result;
        bool valid;
        do {
            Console.Write(prompt);
            valid = int.TryParse(Console.ReadLine(), out result) && result >= low && result <= high;
            if (!valid) {
                Console.WriteLine($"Podaj liczbe z zakresu: {low} {high}");
            }
        } while (!valid);
        return result;
    }

    static string ReadString(string prompt) {
        string result;
        do {
           Console.WriteLine(prompt);
           result = Console.ReadLine();
           if (string.IsNullOrEmpty(result)) {
               Console.WriteLine("Podaj niepusty ciąg znaku");
           }
        } while (string.IsNullOrEmpty(result));

        return result;
    }
    static void PrintTables(string[] names, int[] ages) {
        for (int i = 0; i < names.Length ; ++i) {
            Console.WriteLine($"{names[i]} - {ages[i]}");
        }
    }
    static void PrintList(List<string> names) {
        foreach(string name in names) {
           Console.WriteLine($"{name}");
        };
    }
    static void PrintDictionary(Dictionary<string, int> adults) {
        foreach(var pair in adults) {
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
    }

}

