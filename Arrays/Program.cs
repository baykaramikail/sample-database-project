
namespace Arrays
{

    class Program
    {
        private static void Main(string[] args)
        {
            void ArkadasSayiMi(int sayi1, int sayi2)
            {

                var toplam1 = 0;
                var toplam2 = 0;

                for (int i = 1; i < sayi1; i++)
                {
                    if (sayi1 % i == 0)
                    {
                        toplam1 += i;
                    }
                }

                for (int i = 1; i < sayi2; i++)
                {
                    if (sayi2 % i == 0)
                    {
                        toplam2 += i;
                    }
                }

                if (toplam1 == sayi2 && toplam2 == sayi1)
                {
                    Console.WriteLine($"{sayi1} ve {sayi2} arkadaş sayılardır");
                }
                else
                {
                    Console.WriteLine($"{sayi1} ve {sayi2} arkadaş sayı değillerdir.");

                }

            }


            List<string> citys = new List<string> { "istanbul", "ankara", "izmir" };

            var a = citys.ToArray();

            string[] citys2 = { "istanbul", "ankara", "izmir" };

            var b = citys2.ToList();

            Console.WriteLine(citys.First());
        }
    }
}