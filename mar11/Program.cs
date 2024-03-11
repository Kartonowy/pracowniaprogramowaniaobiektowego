namespace mar11;
class Program
{

    public delegate void AnimalSoundHandler(string sound);

    public class Animal {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }

        public event AnimalSoundHandler ?AnimalSoundEvent;

        public Animal(string name, string species, int age) {
            Name = name;
            Species = species;
            Age = age;
        }

        public void MakeSound(string sound) {
            if (AnimalSoundEvent != null) AnimalSoundEvent(sound);
        }

        public void OnAnimalSound(string sound) {
            Console.WriteLine($"{Name} wydaje dźwięk: {sound}");
        }

        public void PrintInfo() {
            Console.WriteLine($"Nazwa: {Name}, Gatunek: {Species}, Wiek: {Age}");
        }
    }

    public class Food {
        public string Name { get; set; }
        public int Calories { get; set; }

        public Food(string name, int calories) {
            Name = name;
            Calories = calories;
        }

        public void PrintInfo() {
            Console.WriteLine($"Nazwa: {Name}, Kalorie: {Calories}");
        }
    }

    static void Main(string[] args)
    {
        Animal papuga = new Animal("Kazik", "Papuga", 3);
        Animal pies = new Animal("Burek", "Pies", 5);
        Animal kot = new Animal("Filemon", "Kot", 2);

        Food marchew = new Food("Marchew", 100);
        Food jablko = new Food("Jabłko", 50);
        Food mieso = new Food("Mięso", 143);

        papuga.AnimalSoundEvent += papuga.OnAnimalSound;
        pies.AnimalSoundEvent += pies.OnAnimalSound;
        kot.AnimalSoundEvent += kot.OnAnimalSound;

        papuga.MakeSound("Kra kra");
        kot.MakeSound("Miau miau");
        pies.MakeSound("Hau hau");

        papuga.PrintInfo();
        pies.PrintInfo();
        kot.PrintInfo();
        marchew.PrintInfo();
        jablko.PrintInfo();
        mieso.PrintInfo();
    }
}
