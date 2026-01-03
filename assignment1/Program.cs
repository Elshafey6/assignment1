namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Estimate for carpet cleaning service-_-");
            Console.WriteLine("Number of small carpets: ");
            int SCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of large carpets: ");
            int LCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small carpet: $25");
            Console.WriteLine("Price per large carpet: $35");
            int cost = (SCarpets * 25) + (LCarpets * 35);
            Console.WriteLine($"Cost: ${cost}");
            double tax = cost * 0.06;
            Console.WriteLine($"Tax: ${tax}");
            double total = cost + tax;
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate: ${total}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
