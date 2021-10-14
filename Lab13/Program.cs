using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building(10, 12, 30, "Мира, 17");
            house.Print();
            Console.WriteLine();
            MultiBuilding building = new MultiBuilding(20, 40, 60, "Ленина 85б", 3);
            building.Print();

            Console.WriteLine();
            try
            {
                Console.WriteLine("Введите длину здания");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите ширину здания");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите высоту здания");
                double heigth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Сколько в здании этажей?");
                int floor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите адрес здания");
                string adress = Convert.ToString(Console.ReadLine());

                MultiBuilding building1 = new MultiBuilding(length, width, heigth, adress, floor);
                building1.Print();
                building1.Print_floor();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        class Building
        {
            public string adress;
            public double length;
            public double width;
            public double height;


            public string Adress                // свойство поля adress
            {
                set
                {
                    if (value != "")
                        adress = value;
                    else
                        Console.WriteLine("Не указан адрес здания");
                }
                get
                { return adress; }
            }
            public double Length                     // свойство поля length
            {
                set
                {
                    if (value > 0)
                        length = value;
                    else
                        Console.WriteLine("Значение длины здания должно быть положительным числом");
                }
                get
                { return length; }
            }


            public double Width                     // свойство поля width
            {
                set
                {
                    if (value > 0)
                        width = value;
                    else
                        Console.WriteLine("Значение ширины здания должно быть положительным числом");
                }
                get
                { return width; }
            }

            public double Height                     // свойство поля height
            {
                set
                {
                    if (value > 0)
                        height = value;
                    else
                        Console.WriteLine("Значение высоты здания должно быть положительным числом");
                }
                get
                { return height; }
            }

            public Building()
            { }

            public Building(double length, double width, double height, string adress)
            {
                Length = length;
                Width = width;
                Height = height;
                Adress = adress;
            }

            public void Print()
            {
                Console.WriteLine("Здание по адресу:  {0}, габариты: длина - {1}, ширина - {2}, высота - {3}, объем - {4:C} m2", adress, length, width, height, width * length * height);

            }
        }

        sealed class MultiBuilding : Building
        {

            public int floor;

            public int Floor                     // свойство поля floor
            {
                set
                {
                    if (value > 0)
                        floor = value;
                    else
                        Console.WriteLine("Количество этажей должно быть положительным числом");
                }
                get
                { return floor; }
            }
            public MultiBuilding(double len, double wi, double hei, string adr, int floor)
                : base(len, wi, hei, adr)
            {
                Floor = floor;
            }

            public void Print_floor()                               // метод для вывода этажности здания
            {
                Console.WriteLine("В данном здании {0} этаж(а/ей)", floor);
            }
        }
    }
}

