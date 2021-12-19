using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Comp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpu { get; set; }
        public int Ghz { get; set; }
        public int Ozu { get; set; }
        public int Hard { get; set; }
        public int Card { get; set; }
        public int Price { get; set; }
        public int Number { get; set; }
        public List<string> Specific { get; set; }

    }
    static class Program
    {
        static void Main(string[] args)
        {
            List<Comp> listComp = new List<Comp>()
            {
                new Comp(){Id=1, Name="htc",Cpu="Intel",Ghz=14142,Ozu=10,Hard=500,Card=1,Price=10000,Number=5 },
                new Comp(){Id=2, Name="acer",Cpu="Intel",Ghz=26224,Ozu=8,Hard=800,Card=2,Price=20000,Number=6 },
                new Comp(){Id=3, Name="asus",Cpu="Intel",Ghz=27628,Ozu=16,Hard=1000,Card=10,Price=50000,Number=4 },
                new Comp(){Id=4, Name="sony",Cpu="AMD",Ghz=20412,Ozu=12,Hard=550,Card=8,Price=40000,Number=35 },
                new Comp(){Id=5, Name="lenovo",Cpu="Intel",Ghz=20412,Ozu=10,Hard=500,Card=4,Price=30000,Number=8 },
                new Comp(){Id=6, Name="aple",Cpu="Intel",Ghz=25593,Ozu=8,Hard=800,Card=6,Price=50000,Number=5 },
                new Comp(){Id=7, Name="dell",Cpu="AMD",Ghz=20412,Ozu=6,Hard=550,Card=4,Price=20000,Number=45 },
                new Comp(){Id=8, Name="hp",Cpu="Intel",Ghz=21440,Ozu=8,Hard=750,Card=4,Price=40000,Number=3 },
                new Comp(){Id=9, Name="msi",Cpu="AMD",Ghz=26224,Ozu=12,Hard=800,Card=10,Price=50000,Number=7 },
                new Comp(){Id=10, Name="lg",Cpu="AMD",Ghz=20412,Ozu=8,Hard=500,Card=4,Price=30000,Number=6 },
            };
            Console.Write("Укажите название процессора: ");
            string first = Console.ReadLine();
            List<Comp> comps1 = listComp
                .Where(d => d.Cpu == first)
                .ToList();
            foreach (Comp d in comps1)
                Console.WriteLine($"{d.Id} {d.Name} {d.Cpu} {d.Ghz} {d.Ozu} {d.Hard} {d.Card} {d.Price} {d.Number}");

            Console.Write("Укажите минимальный объем оперативной памяти: ");
            int second = Convert.ToInt32(Console.ReadLine());
            List<Comp> comps2 = listComp
                .Where(d2 => d2.Ozu >= second)
                .ToList();
            foreach (Comp d in comps2)
                Console.WriteLine($"{d.Id} {d.Name} {d.Cpu} {d.Ghz} {d.Ozu} {d.Hard} {d.Card} {d.Price} {d.Number}");

            Console.WriteLine("Весь список доступных компьютеров, отсортированный по увеличению стоимости:");
            
            List<Comp> comps3 = listComp
               .OrderBy(d3 => d3.Price)
                .ToList();
            foreach (Comp d in comps3)
                Console.WriteLine($"{d.Id} {d.Name} {d.Cpu} {d.Ghz} {d.Ozu} {d.Hard} {d.Card} {d.Price} {d.Number}");

            Console.WriteLine("Весь список доступных компьютеров, сгруппированный по типу процессора:");
            var comps4 = listComp
               .GroupBy(d4 => d4.Cpu)
                .ToArray();

            foreach (var d in comps4)
            {
                Console.WriteLine($"{d.Key}");

            }


            Console.WriteLine("Самый дорогой и самый бюджетный конмпьютер:");
            Comp comps5Min = listComp
               .OrderBy(d5 => d5.Price)
                .First();
            Comp comps5Max = listComp
               .OrderByDescending(d5 => d5.Price)
                .First();

            Console.WriteLine($"{comps5Max.Id} {comps5Max.Name} {comps5Max.Cpu} {comps5Max.Ghz} {comps5Max.Ozu} {comps5Max.Hard} {comps5Max.Card} {comps5Max.Price} {comps5Max.Number}");

            Console.WriteLine($"{comps5Min.Id} {comps5Min.Name} {comps5Min.Cpu} {comps5Min.Ghz} {comps5Min.Ozu} {comps5Min.Hard} {comps5Min.Card} {comps5Min.Price} {comps5Min.Number}");


            Console.WriteLine("Компьютеры в количестве не менее 30 штук: ");
            List<Comp> comps6 = listComp
                .Where(d6 => d6.Number >= 30)
                .ToList();
            foreach (Comp d in comps6)
                Console.WriteLine($"{d.Id} {d.Name} {d.Cpu} {d.Ghz} {d.Ozu} {d.Hard} {d.Card} {d.Price} {d.Number}");
            Console.ReadKey();
        }   

    }
}
