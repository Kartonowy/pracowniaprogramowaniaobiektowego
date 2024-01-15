namespace jan15;
class Program
{
    class Address {
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
    class Person {
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
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
