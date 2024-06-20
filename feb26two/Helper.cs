namespace car {
    internal class Helper {
        public static Car[] Filter(Car[] cars, ContainerFilterService filter) {
            int count = 0;
            foreach (Car car in cars) {
                if (filter(car)) ++count;
            }

            return cars;
        }
    }
}
