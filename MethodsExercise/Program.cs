namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Whats your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("Whats your favorite animal");
            string animal = Console.ReadLine();
            Console.WriteLine("Whats your favorite dog");
            string dog = Console.ReadLine();
            Console.WriteLine("Whats your favorite cat");
            string cat = Console.ReadLine();
            Console.WriteLine($"Hello {name}your color is {color} and {animal} and {dog} and {cat}");
            var results = Sum(1, 3);
            Console.WriteLine(results);
            var results2 = Multiply(2, 3);
            Console.WriteLine(results2);

        }

        public static int Sum(int a, int b)
        {
            return a + b;
            
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}   
