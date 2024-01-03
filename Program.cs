namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tahmin;
            int can = 100;
            Console.WriteLine("Zorluk seçiniz:\n 1 - Kolay \n 2 - Normal \n 3 - Zor :*");
            int zorluk = int.Parse(Console.ReadLine());
            int değer = 0; int eksilt = 0;

            switch (zorluk)
            {
                case 1:
                    değer = 10;
                    eksilt = 10;
                    break;
                case 2:
                    değer = 55;
                    eksilt = 50;
                    break;
                case 3:
                    değer = 100;
                    eksilt = 100;
                    break;
                default:
                    break;
            }

            Random rnd = new Random();
            int number = rnd.Next(değer);
            do
            {
                Console.WriteLine("Guess a number.");
                tahmin = int.Parse(Console.ReadLine());

                if (tahmin == number)
                {
                    Console.WriteLine("Congrats brat!");
                }
                else
                {
                    can -= eksilt;
                }
                if (can == 0) { break; }
            }
            while (tahmin != number);
        }
    }
}