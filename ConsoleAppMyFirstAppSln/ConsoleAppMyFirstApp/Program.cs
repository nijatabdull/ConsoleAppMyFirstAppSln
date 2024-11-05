namespace ConsoleAppMyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Age: ");
            string inputAge = Console.ReadLine();

            byte age = Convert.ToByte(inputAge);

            //byte age = 25;
            //double salary = 500.50;
            //char gender = 'm';
            //bool hasEmail = false;
            //DateTime birthDate = new DateTime(1999,10,29);

            Console.WriteLine("New student:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Age: " + age);
        }
    }
}
