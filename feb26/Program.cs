namespace feb26;
delegate bool Logic(bool a, bool b);
class Program
{
    static bool And(bool a, bool b) {
        return a && b;
    }

    static bool Or(bool a, bool b) {
        return a || b;
    }

    static bool Xor(bool a, bool b) {
        return a ^ b;
    }

    static bool Not(bool a, bool b) {
        return !a; 
    }

    static void DisplayResult(Logic logic, bool a, bool b) {
        try {
            bool result = logic(a, b);
            Console.WriteLine($"Result: {logic.Method.Name} {a}, {b} equals {result}");
        } catch (ArgumentNullException e) {
            Console.WriteLine(e.Message);
        }
    }

    static bool GetBoolFromUser() {
        while (true) {
            Console.WriteLine("Insert boolean value");
            string input = Console.ReadLine();
            bool val;

            if (bool.TryParse(input, out val)) {
                return val;
            } else {
                Console.WriteLine("Invalid data. Insert boolean value.");
            }
        }
    }

    static void Main(string[] args)
    {
        bool x = GetBoolFromUser();
        bool y = GetBoolFromUser();

        Logic and = new Logic(And);
        Logic or = new Logic(Or);
        Logic xor = new Logic(Xor);
        Logic not = new Logic(Not);

        DisplayResult(and, x, y);
        DisplayResult(or, x, y);
        DisplayResult(xor, x, y);
        DisplayResult(not, x, y);
    }
}
