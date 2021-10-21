using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building zdanie1 = new Building();
            MultiBuilding zdanie2 = new MultiBuilding();
            try
            {
                Console.Write("Введите адресс первого здания: ");
                zdanie1.Adress = Console.ReadLine();
                Console.Write("Введите длину первого здания: ");
                zdanie1.Length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите ширину первого здания: ");
                zdanie1.Width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите высоту первого здания: ");
                zdanie1.Height = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите адресс второго здания: ");
                zdanie2.Adress = Console.ReadLine();
                Console.Write("Введите длину второго здания: ");
                zdanie2.Length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите ширину второго здания: ");
                zdanie2.Width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите высоту второго здания: ");
                zdanie2.Height = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите высоту второго здания: ");
                zdanie2.Floor = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("\t{0}", ex.Message);                
            }
            zdanie1.Print();
            zdanie2.MultiPrint();
            Console.ReadKey();
        }
    }
    class Building
    {
        double length;
        double width;
        double height;
        public string Adress { get; set; }
        public double Length
        {
            set
            {
                if (value >= 0) length = value;
                else Console.WriteLine("\tВведено отрицательное число!");
            }
            get
            { return length; }
        }
        public double Width
        {
            set
            {
                if (value >= 0) width = value;
                else Console.WriteLine("\tВведено отрицательное число!");
            }
            get
            { return width; }
        }
        public double Height
        {
            set
            {
                if (value >= 0) height = value;
                else Console.WriteLine("\tВведено отрицательное число!");
            }
            get
            { return height; }
        }
        public Building(string adress = "Нет данных", double length=0, double width=0, double height=0)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Адрес здания: {0}", Adress);
            Console.WriteLine("Длина здания: {0}", Length);
            Console.WriteLine("Ширина здания: {0}", Width);
            Console.WriteLine("Высота здания: {0}", Height);
        }
    }
    sealed class MultiBuilding : Building
    {
        int floor;
        public int Floor
        {
            set
            {
                if (value >= 0) floor = value;
                else Console.WriteLine("\tВведено отрицательное число!");
            }
            get
            { return floor; }
        }
        public MultiBuilding(string adress="Нет данных", double length=0, double width=0, double height=0, int floor = 0)
            :base(adress,length,width,height)
        {
            Floor = floor;
        }
        public void MultiPrint()            
        {
            base.Print();
            Console.WriteLine("Этажность здания: {0}", Floor);
        }
        
    }
}
