namespace Task4 {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть текст: ");
            string text = Console.ReadLine();

            string result = "";
            for (int i = 0; i < text.Length; i++) {
                int position = i + 1;

                if (position % 15 == 0) {
                    result = result + "?";
                } else if (position % 3 == 0) {
                    result = result + "X";
                } else if (position % 5 == 0) {
                    result = result + "9";
                } else {
                    result = result + text[i];
                }
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
