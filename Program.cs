using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework19T1
{
    class Comp
    {
        public int CompId { get; set; }
        public string CompMark { get; set; }
        public string CpuType { get; set; }
        public int CpuFreq { get; set; }
        public int DdrMemory { get; set; }
        public int HddMemory { get; set; }
        public int GpuMemory { get; set; }
        public int CpuPrice { get; set; }
        public int Quantity { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Comp> listComp = new List<Comp>()
            {
                new Comp(){ CompId=1,CompMark="Huawei", CpuType="AMD", CpuFreq=2100, DdrMemory=16, HddMemory=1000, GpuMemory=4, CpuPrice=1500, Quantity=25 } ,
                new Comp(){ CompId=2,CompMark="MSI", CpuType="Intel", CpuFreq=5200, DdrMemory=32, HddMemory=4000, GpuMemory=11, CpuPrice=4000, Quantity=4 } ,
                new Comp(){ CompId=3,CompMark="Dell", CpuType="Intel", CpuFreq=4200, DdrMemory=64, HddMemory=8000, GpuMemory=24, CpuPrice=10000, Quantity=2 } ,
                new Comp(){ CompId=4,CompMark="HP", CpuType="AMD", CpuFreq=3000, DdrMemory=8, HddMemory=500, GpuMemory=4, CpuPrice=500, Quantity=57 } ,
                new Comp(){ CompId=5,CompMark="Lenovo", CpuType="Intel", CpuFreq=2900, DdrMemory=4, HddMemory=1000, GpuMemory=2, CpuPrice=700, Quantity=120 } ,
                new Comp(){ CompId=6,CompMark="Asus", CpuType="AMD", CpuFreq=4100, DdrMemory=16, HddMemory=2000, GpuMemory=4, CpuPrice=1200, Quantity=18 } ,
                new Comp(){ CompId=7,CompMark="Acer", CpuType="AMD", CpuFreq=4000, DdrMemory=16, HddMemory=2000, GpuMemory=8, CpuPrice=1300, Quantity=48 } ,
                new Comp(){ CompId=8,CompMark="MSI", CpuType="Intel", CpuFreq=5200, DdrMemory=32, HddMemory=8000, GpuMemory=24, CpuPrice=4200, Quantity=10 } ,
                new Comp(){ CompId=9,CompMark="Huawei", CpuType="AMD", CpuFreq=2700, DdrMemory=8, HddMemory=500, GpuMemory=2, CpuPrice=450, Quantity=20 } ,
                new Comp(){ CompId=10,CompMark="HP", CpuType="Intel", CpuFreq=4800, DdrMemory=32, HddMemory=2000, GpuMemory=6, CpuPrice=1500, Quantity=200 } ,
            };


            Console.WriteLine("Введите название компъютера для определения его в списке");

            string D = Console.ReadLine();
            List<Comp> Compsmark = listComp
                .Where(d => d.CompMark == D)
                .ToList();
            foreach (Comp d in Compsmark)
            {
                Console.WriteLine($"{d.CompId},{d.CompMark},{d.CpuType},{d.CpuFreq},{d.DdrMemory},{d.HddMemory},{d.GpuMemory},{d.CpuPrice},{d.Quantity}");
            }

            Console.WriteLine("Введите количество оперативной памяти,чтобы определить существуют ли компьютеры с объемом таким же или больше ");

            int O = Convert.ToInt32(Console.ReadLine());
            List<Comp> CompsDdr = listComp
                .Where(d => d.DdrMemory >= O)
                .ToList();
           
            foreach (Comp d in CompsDdr)
            {
                Console.WriteLine($"{d.CompId},{d.CompMark},{d.CpuType},{d.CpuFreq},{d.DdrMemory},{d.HddMemory},{d.GpuMemory},{d.CpuPrice},{d.Quantity}");
            }

            Console.WriteLine();
            Console.WriteLine("Список по увеличению стоимости");
            Console.WriteLine();
           
            List<Comp> Compsorderup = listComp
               .OrderBy(d => d.CpuPrice)
               .ToList();
           
            foreach (Comp d in Compsorderup)
            {
                Console.WriteLine($"{d.CompId},{d.CompMark},{d.CpuType},{d.CpuFreq},{d.DdrMemory},{d.HddMemory},{d.GpuMemory},{d.CpuPrice},{d.Quantity}");
            }

            Console.WriteLine();
            Console.WriteLine("Список по сгруппированный типу процессора");
            Console.WriteLine();



            var Compsgroup = listComp.GroupBy(d => d.CpuType).Select(d => new {CpuType = d.Key, Count = d.Count() }); ;


            foreach (var d in Compsgroup)
            {
                Console.WriteLine(d);
            }



            int Max = listComp.Max(a => a.CpuPrice);
            Console.WriteLine(Max);

            int Min = listComp.Min(a => a.CpuPrice);
            Console.WriteLine(Min);



            bool CompsQ = listComp.Any(d => d.Quantity >= 30);
            if (CompsQ)
            {
                Console.WriteLine("Да, есть хотя бы один компьютер в количестве более 30 штук!");
            }
            else
            {
                Console.WriteLine("Нет,в наличии нет позиций количеством от 30");
            }

            Console.ReadKey();
        }
    }
}


