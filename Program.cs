namespace Bussen
{
    class Program
    {
        public static void Main(string[] args)
        {            
            var minbuss = new Buss();           
            minbuss.Run();           
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
            
        }
    }
}


