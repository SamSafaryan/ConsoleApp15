namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Count = 0;
            int Sum = 0;
            int number = Number;
            int Mult = 1;
            int Number_ = Number;
            while(number > 0)
            {
                number /= 10;
                Count++;
            }
            while (Number > 0)
            {
                number = Number %= 10;
                
                for (int i = 0; i < Count; i++)
                {
                    Mult *= number;
                    Sum += Mult;
                }
                Number /= 10;
            }
            Console.WriteLine(Sum);
            if (Sum == Number)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False"); 
            }
        }
    }
}