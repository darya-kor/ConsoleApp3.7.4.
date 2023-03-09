namespace ConsoleApp3._7._4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.Write("Enter your birthdate: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Your birthdate is {0}", birthdate);

        }
    }
}