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
        int[] names = new int[n];
    
        for (int i = 0; i < n; ++i) {
            ages[i] = ReadInt($"Podaj wiek osoby {i + 1}", 0, 150);
        }
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
           result = Console.ReadLine()?;
           if (string.IsNullOrEmpty(result)) {
               Console.WriteLine("Podaj niepusty ciąg znaku");
           }
        } while (string.IsNullOrEmpty(result));

        return result;
    }
}
