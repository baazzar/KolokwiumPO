using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1
{        
    enum Kolor
    {
            Biel,
            Czerwony,
            Zielony,
            Czarny
    };
    class Program
    {
        private static char klawisz;
        public static void Aplikacja()
        {
            SzefBudowy szef = new SzefBudowy();
            Menu();
            klawisz = Convert.ToChar(Console.ReadKey().KeyChar);

            Console.WriteLine(Environment.NewLine);
            while (klawisz != 'X' || klawisz != 'x')
            {
                if (klawisz == 'A' || klawisz == 'a')
                {
                    Biurowiec biurowiec = new Biurowiec();
                    bool blad = false;
                    string okno;
                    string drzwi = "Szklane";
                    Kolor kolor;
                    szef.WybierzProjekt(biurowiec);
                    try
                    {
                        Console.WriteLine("Wybrano projekt: Biurowiec");
                        do
                        {
                            Console.WriteLine("Wybierz kolor elewacji: Biel, Czerwony, Zielony, Czarny");

                            Enum.TryParse(Console.ReadLine(), out kolor);
                        } while (Convert.ToString(kolor).Length < 2);
                        do
                        {
                            Console.WriteLine("Wybierz rodzaj okien:");
                            okno = Console.ReadLine();
                        } while (okno.Length < 2);
                        szef.Buduj(okno, drzwi, kolor);
                    }
                    catch
                    {
                        blad = true;
                    }
                    if (!blad)
                        Console.WriteLine("Pomyslne zbudowano: {0}", biurowiec.ToString());
                    else
                        Console.WriteLine("Nie udalo sie pomyslnie zbudowac obiektu: {0}", biurowiec.ToString());
                    return;
                }
                else if (klawisz == 'B' || klawisz == 'b')
                {
                    DomJednorodzinny dom = new DomJednorodzinny();
                    bool blad = false;
                    string okno;
                    string drzwi;
                    Kolor kolor = Kolor.Czerwony;
                    szef.WybierzProjekt(dom);
                    try
                    {
                        Console.WriteLine("Wybrano projekt: Dom Jednorodzinny");
                        do
                        {
                            Console.WriteLine("Wybierz rodzaj okien:");
                            okno = Convert.ToString(Console.ReadLine());
                        } while (okno.Length < 2);
                        do
                        {
                            Console.WriteLine("Wybierz rodzaj drzwi");
                            drzwi = Convert.ToString(Console.ReadLine());
                        } while (drzwi.Length < 2);
                        szef.Buduj(okno, drzwi, kolor);
                    }
                    catch
                    {
                        blad = true;
                    }
                    if (!blad)
                        Console.WriteLine("Pomyslne zbudowano: {0}", dom.ToString());
                    else
                        Console.WriteLine("Nie udalo sie pomyslnie zbudowac obiektu: {0}", dom.ToString());
                    return;
                }
            }
        }
        public static void Menu()
        {
            Console.WriteLine("Co chcesz zrobic?");
            Console.WriteLine("A - buduj biurowiec");
            Console.WriteLine("B - buduj dom jednorodzinny");
            Console.WriteLine("X - wyjscie z aplikacji");
            Console.WriteLine(Environment.NewLine);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Aplikacja();
                if (klawisz == 'X' || klawisz == 'x')
                    Environment.Exit(0);
            }
        }
    }
}
