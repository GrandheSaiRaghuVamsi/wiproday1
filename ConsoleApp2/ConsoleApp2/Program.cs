namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter name :");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter Surname");
            string? surname = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("my name is " + name + " and surname is " + surname + "with age " + age);
            //string interpolation
            Console.WriteLine($"My name is : {name} and Surname is {surname} with age {age}");
            //index positions
            Console.WriteLine("My name is : {0} and surname is {1} with age {2}", name, surname, age);

            int? a = 100;
            int b = a ?? 10;
            Console.WriteLine("values are "+a+" "+b);
            int d = 12; //value type
            object o = d; //reference type & boxing
            int ub = (int)o;
            Console.WriteLine(d+" "+o);
        
        }
    }
}