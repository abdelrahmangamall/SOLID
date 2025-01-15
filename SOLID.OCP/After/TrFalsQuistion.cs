namespace SOLID.OCP.After
{
    class TrFalsQuistion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            Console.WriteLine("  1. T");
            Console.WriteLine("  2. F");
        }
    }
}
