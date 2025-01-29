internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a mark : ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (n % 2 == 0)
        {
            Console.WriteLine("Its a even");
        }
        else 
        {
            Console.WriteLine("Its a ODD");
        }
    }
}