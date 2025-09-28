    namespace Katarzhin_ISP_232_Lab_5
{
    class Program
    {
        //static void SayHello() => Console.WriteLine("Hello");
        //static void Game()
        //{
        //    string mGame = "Limbus Company";
        //    Console.WriteLine(mGame);
        //}

        static void Main()
        {
            //void print(string message)
            //{
            //    Console.WriteLine(message);
            //}
            //Console.WriteLine("Как тебя зовут?");
            //Console.Write("Введите своё имя: ");
            //string? name2 = Console.ReadLine();
            //print(message: $"Твоё имя: {name2}");
            //Game();
            //Console.WriteLine("Введите своё имя: ");
            //string? name = Console.ReadLine();
            //Console.Write("Введите ваш язык(русский, английский, немецкий): ");
            //string language = Console.ReadLine()!.ToLower();

            //void SayHelloRu() => Console.WriteLine($"Привет, {name}!");
            //void SayHelloEn() => Console.WriteLine($"Hello, {name}!");
            //void SayHelloDe() => Console.WriteLine($"Guten Tag, {name}!");
            //switch (language)
            //{
            //    case "английский": SayHelloEn(); break;
            //    case "русский": SayHelloRu(); break;
            //    case "немецкий": SayHelloDe(); break;
            //    default: Console.WriteLine("Язык не найден!"); break;
            //}
            //void Sum(int x, int y)
            //{
            //    int res = x + y;
            //    Console.WriteLine($"{x} + {y} = {res}");
            //}
            //Sum(10, 20);
            //Console.Write("Введите переменную x: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите переменную y: ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Sum(x, y);
            void printPerson(string pname, int age)
            {
                Console.WriteLine($"Имя: {pname}, возраст: {age}");
            }
            printPerson("Соня", 22);
        }
    }
}
