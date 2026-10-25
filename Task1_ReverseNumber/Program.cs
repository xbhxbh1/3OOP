namespace Task1 {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть ціле число: ");
            long number = long.Parse(Console.ReadLine());

            bool isNegative = number < 0;
            if (isNegative) {
                number = -number;
            }

            long reversed = 0;
            while (number > 0) {
                long lastDigit = number % 10;
                reversed = reversed * 10 + lastDigit;
                number = number / 10;
            }

            if (isNegative) {
                reversed = -reversed;
            }

            Console.WriteLine("Результат: " + reversed);
        }
    }
}
