namespace jan15;
class Program
{
    public static List<Person> users = new List<Person>();

    public class Address {
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }

        public Address(string _city, string _street, string _housenumber, string _postalcode) {
            City = _city;
            Street = _street;
            HouseNumber = _housenumber;
            PostalCode = _postalcode;
        }
    }

    public class Person {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime dateOfBirth { get; set; }
        public Address Address { get; set; }

        public int Age {
            get {
                TimeSpan diff = DateTime.Now - dateOfBirth;
                return (int)(diff.Days/365.25);
            }
        }

        public string GetFullName() {
            return $"{Name} {Surname}";
        }

        public Person(string _name, string _surname, DateTime _dateOfBirth) {
            Name = _name;
            Surname = _surname;
            dateOfBirth = _dateOfBirth;
        }

        public Person(string _name, string _surname, DateTime _dateOfBirth, Address _address) {
            Name = _name;
            Surname = _surname;
            dateOfBirth = _dateOfBirth;
            Address = _address;
        }
    }
    class Student : Person {
        public int studentNumber;

        public Student(string _name, string _surname, DateTime _dateOfBirth, int _studentNumber) : base(_name, _surname, _dateOfBirth) {
            studentNumber = _studentNumber;
        }
    }

    class Teacher : Person {
        public List<string> Subjects = new List<string>();

        public Teacher(string _name, string _surname, DateTime _dateOfBirth, List<string> subjects) : base(_name, _surname, _dateOfBirth) {
            Subjects = subjects;
        }
    }

    public static int DisplayMenu() {
        Console.WriteLine("Program do zarządzania użytkownikami\n");
        Console.WriteLine("1. Dodaj użytkownika");
        Console.WriteLine("2. Wyświetl użytkowników");
        Console.WriteLine("3. Usuń wszystkich użytkowników");
        Console.WriteLine("4. Wyjdź z programu");

        Console.Write("\nWybierz opcję:");
        return int.Parse(Console.ReadLine()!);

    }

    static void Main(string[] args)
    {
        /*
        Person p1 = new Person("Vin", "Outsider", new DateTime(2022, 2, 1), new Address("Poznan", "Polna", "1c", "69-420"));

        Student s1 = new Student("Kelsier", "Mistborn", new DateTime(2137, 2, 4), 1);
        Teacher t1 = new Teacher("Last", "Emperor", new DateTime(2138, 1, 1), new List<string>(){"amogus", "xdd"});

        Console.WriteLine($"{JsonSerializer.Serialize<Teacher>(t1)}");
        */

        int option = 0;
        do {
            option = DisplayMenu();

            switch (option) {
                case 1:
                    AddUser();
                    break;
                case 2:
                    DisplayUsers();
                    break;
                case 3:
                    users.Clear();
                    Console.WriteLine("\nWszyscy użytkownicy zostali usunięci\n");
                    break;
                case 4:
                    Console.WriteLine("\nDziękuję za skorzystanie z programu");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\n'Nieprawidłowa opcja");
                    break;
            }
        }
        while (option != 4);
    }

    private static void AddUser() {
        Console.WriteLine("Podaj imię użytkownika");
        string name = Console.ReadLine();
        Console.WriteLine("Podaj nazwisko użytkownika");
        string surname = Console.ReadLine();
        Console.WriteLine("Podaj rok urodzenia (RRRR-MM-DD)");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
    }
    
    private static void DisplayUsers() {

    }
}
