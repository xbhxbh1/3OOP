namespace Task2 {
    internal class Program {

        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть текст: ");
            string text = Console.ReadLine();

            Console.Write("Скільки перших слів видалити: ");
            int count = int.Parse(Console.ReadLine());

            if (count < 0) {
                count = 0;
            }

            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string result = "";
            for (int i = count; i < words.Length; i++) {
                if (result != "") {
                    result = result + " ";
                }
                result = result + words[i];
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
