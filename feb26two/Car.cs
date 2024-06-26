namespace car {
    internal class Car {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public float Price { get; set; }

        public Car(string brand, string model, int year, int mileage, float price) {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            Price = price;
        }

        public override string ToString() {
            return $"{Brand} {Model} {Year}, mileage: {Mileage}, price: {Price}";
        }

        delegate bool Filter(Car car);
    }
}
