using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
        public class UjAuto : Jarmu
        {
            private int hengerürtartalom;

            public int Hengerurtartalom
            {
                get { return hengerürtartalom; }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("A hengerürtartalom nem lehet negatív!");
                    }
                    else if (value < 2000)
                    {
                        Console.WriteLine("az autó 4 hemgeres");
                    }
                    else if (value >= 2100 && value < 3000)
                    {
                        Console.WriteLine("az autó 6 hemgeres");
                    }
                    else if (value >= 3000)
                    {
                        Console.WriteLine("az autó 8 hemgeres");
                    }
                    else
                    {
                        hengerürtartalom = value;
                    }
                }
            }

            public UjAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int hengerürtartalom)
                : base(rendszam, kor, kilometerOra, uzemanyagSzint)
            {
                Hengerurtartalom = hengerürtartalom;
            }

            public override void InformaciotAd()
            {
                Console.WriteLine($"{Rendszam} - {Kor} éves új autó, {KilometerOra} km-rel, hengerűrtartalom: {Hengerurtartalom} cm³");
            }

            public override void Szervizel(int dij)
            {
                if (dij > 50000)
                {
                    KilometerOra -= 5000;
                }
                Console.WriteLine("Az új autó szervizelése megtörtént.");
            }


        }
    }
