using ConsoleApp4;

namespace Cecaaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ceca macska1 = new Ceca(2, 4, "Cirmi", "Maine Coon", "szürke", 80, "nőstény", 3);
            Ceca macska2 = new Ceca(4, 5, "Morzsi", "Perzsa", "narancssárga", 90, "hím", 4);
            Ceca macska3 = new Ceca(1, 3, "Foltos", "Sziámi", "fehér", 70, "nőstény", 2);
            Ceca macska4 = new Ceca(3, 6, "Vakarcs", "Brit", "fekete", 60, "hím", 5);

            List<Ceca> macskak = new List<Ceca> { macska1, macska2, macska3, macska4 };

            foreach (var macska in macskak)
            {
                macska.Jatek();
                macska.HangotAd();
            }
        }
    }
}

