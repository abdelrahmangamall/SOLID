namespace SOLID.ISP
{
    class Program
    {
        public static void Main(string[] args)
        {
            var employe =After.Repository.LoadEmployees();
            foreach (var item in employe) 
            {
                Console.WriteLine(item.PrintSalarySlip());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}