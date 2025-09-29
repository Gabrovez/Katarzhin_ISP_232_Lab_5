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
            //void printPerson(string pname, int age)
            //{
            //    Console.WriteLine($"Имя: {pname}, возраст: {age}");
            //}
            //printPerson("Соня", 22);
            //void Person(string name, int age = 18, string vuz = "BФ BолГУ") =>
            //    Console.WriteLine($"Имя: {name} \nВозраст: {age} \nВуз: {vuz}");
            //Person( "Александр");
            //Person( "Иван", 30);
            //Person( "Дмитрий", 20, "МГУ");
            //Person(age: 30, name: "Иван");
            //Person(vuz: "МГУ", age: 20, name: "Дмитрий");
            //string getMessage()
            //{
            //    return "Hello";
            //}
            //Console.WriteLine(getMessage());
            //int Sum(int a, int b)
            //{
            //    return a + b;
            //}
            //Console.WriteLine(Sum(10, 20));
            //int number = Convert.ToInt32(Console.ReadLine());
            //void CheckValue(int number)
            //{
            //    if (number < 0)
            //    {
            //        Console.WriteLine("Отрицательное число");
            //        return;
            //    }
            //    Console.WriteLine("Положительное число");
            //}
            //CheckValue(number);
            //string GetMessage() => "Hello";
            //string mes = GetMessage();
            //Console.WriteLine(mes);
            //void PrintMessage(string message)
            //{
            //    Console.WriteLine(message);
            //}
            //PrintMessage(GetMessage());
            //void PrintPerson(string name, int age)
            //{
            //    if (age > 2000 || age < 1)
            //    {
            //        Console.WriteLine("Недопустимый возраст");
            //        return;
            //    }
            //    Console.WriteLine($"Имя: {name} Возраст: {age}");
            //}
            //PrintPerson(name: "Алексей", age: 32);
            //PrintPerson(name: "Dunkan", age: 12345);
            //Random random = new Random();
            //int numb = random.Next(0, 100);
            //Console.WriteLine($"Случайное число: {numb}");
            //double randomDouble = random.NextDouble();
            //Console.WriteLine($"Случайное число: {randomDouble}");
            //void ShowWelcomeMessage() => Console.WriteLine("Добро пожаловать в консольный прогноз погоды!");
            //void ShowGoodbyeMessage() => Console.WriteLine("Спасибо за использование нашего прогноза! Хорошего дня!");
            //string getWeather()
            //{
            //    string[] weathers = { "Солнечно", "Облачно", "Дождь", "Снег", "Гроза" };
            //    Random random = new Random();
            //    int index = random.Next(weathers.Length);
            //    return weathers[index];
            //}
            //ShowWelcomeMessage();
            //Console.WriteLine($"Погода на сегодня: {getWeather()}");
            //ShowGoodbyeMessage();
            int Factorial(int n)
            {
                if (n == 1) return 1;
                return n * Factorial(n - 1);
            }
            int factorial = Factorial(n: 4);
            int factorial2 = Factorial(n: 5);
            int factorial3 = Factorial(n: 6);
            Console.WriteLine($"Факториал числа 4 = {factorial}");
            Console.WriteLine($"Факториал числа 5 = {factorial2}");
            Console.WriteLine($"Факториал числа 6 = {factorial3}");

        }
    }
}
