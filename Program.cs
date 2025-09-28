    namespace Katarzhin_ISP_232_Lab_5
{
    class Program
    {
        //static void SayHello() => Console.WriteLine("Hello");
        static void Game()
        {
            string mGame = "Limbus Company";
            Console.WriteLine(mGame);
        }
        static void Main()
        {
            Game();
            Console.WriteLine("Введите своё имя: ");
            string? name = Console.ReadLine();
            Console.Write("Введите ваш язык(русский, английский, немецкий): ");
            string language = Console.ReadLine()!.ToLower();

            void SayHelloRu() => Console.WriteLine($"Привет, {name}!");
            void SayHelloEn() => Console.WriteLine($"Hello, {name}!");
            void SayHelloDe() => Console.WriteLine($"Guten Tag, {name}!");
            switch (language)
            {
                case "английский": SayHelloEn(); break;
                case "русский": SayHelloRu(); break;
                case "немецкий": SayHelloDe(); break;
                default: Console.WriteLine("Язык не найден!"); break;
            }
        }
    }
}
