using CityLibrary;
namespace CityLibrary;

class Program
{
    static void Main(string[] args)
    {
        string Strsay;
        int say;
        do
        {
            Console.WriteLine("nece eded seher yerlesdireceksiniz?");
            Strsay = Console.ReadLine();

        } while (!int.TryParse(Strsay, out say));

        ChinaCity[] chinaCities = new ChinaCity[say];

        for (int i = 0; i < say; i++)
        {
            ChinaCity chinaCity = new ChinaCity();

            string chinaCityy;
            do
            {
                Console.WriteLine("seherin adini daxil edin:");
                chinaCityy = Console.ReadLine();
            } while (String.IsNullOrWhiteSpace(chinaCityy));

            chinaCity.Name = chinaCityy;

            string StrchinaCityPop;
            int chinaCityPop;
            do
            {
                Console.WriteLine("seherin ehalisini daxil edin:");
                StrchinaCityPop = Console.ReadLine();

            } while (!int.TryParse(StrchinaCityPop, out chinaCityPop));

            chinaCity.Population = chinaCityPop;

            chinaCities[i] = chinaCity;
        }
        int avaragePopulation = 0;
        for (int i = 0; i < chinaCities.Length; i++)
        {
            Console.WriteLine($"{chinaCities[i].Name}-{chinaCities[i].Population}");
            avaragePopulation += chinaCities[i].Population;
        }
        Console.WriteLine($"ortalama ehali: " + avaragePopulation / chinaCities.Length);

        Console.ReadLine();
    }
}

