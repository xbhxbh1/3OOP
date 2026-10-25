namespace Task3 {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Площу якої фігури обчислити?");
            Console.WriteLine("1. Квадрат");
            Console.WriteLine("2. Круг");
            Console.WriteLine("3. Прямокутник");
            Console.WriteLine("4. Трикутник");
            Console.Write("Ваш вибір: ");
            int choice = int.Parse(Console.ReadLine());

            double area = 0;

            switch (choice) {
                case 1: {
                        double side = ReadNumber("Введіть довжину сторони: ");
                        area = side * side;
                        break;
                    }
                case 2: {
                        double radius = ReadNumber("Введіть радіус: ");
                        area = Math.PI * radius * radius;
                        break;
                    }
                case 3: {
                        double sideA = ReadNumber("Введіть першу сторону: ");
                        double sideB = ReadNumber("Введіть другу сторону: ");
                        area = sideA * sideB;
                        break;
                    }
                case 4: {
                        double baseLength = ReadNumber("Введіть основу: ");
                        double height = ReadNumber("Введіть висоту: ");
                        area = baseLength * height / 2;
                        break;
                    }
                default: {
                        Console.WriteLine("Такої фігури немає в списку");
                        return;
                    }
            }

            Console.WriteLine("Площа = " + Math.Round(area, 2));
        }

        static double ReadNumber(string message) {
            Console.Write(message);
            string input = Console.ReadLine();
            input = input.Replace(',', '.');
            return double.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
