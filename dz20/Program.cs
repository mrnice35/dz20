using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz20
{
    class Program
    {
        delegate double MyDelegate(double r);//делегат принимает значение r
        static void Main(string[] args)
        {
            double r;
            Console.WriteLine("введите радиус окружности");
            r = Convert.ToDouble(Console.ReadLine());//конвертирует в формат дабл значение с консоли
            MyDelegate myDelegate1 = new MyDelegate(GetLength); //объявлем переменную делегата и присваиваем ей метод
            myDelegate1?.Invoke(r);//ПРОВЕРКА НА НОЛЬ 
            MyDelegate myDelegate2 = new MyDelegate(GetArea);//добавляем к делегату метод
            myDelegate2?.Invoke(r);//ПРОВЕРКА НА НОЛЬ 
            MyDelegate myDelegate3 = new MyDelegate(GetV);//добавляем к делегату метод
            myDelegate3?.Invoke(r);//ПРОВЕРКА НА НОЛЬ 
            
            
            double length = myDelegate1(r);//присваиваем переменной значение для вывода результата метода  
            double area = myDelegate2(r);
            double V = myDelegate3(r);
            Console.WriteLine($"длина окружности равна {length},площадь окружности равна {area},объем шара равен {V}");
            Console.ReadKey();
        }
        public static double GetLength(double r)//метод нахождения длины окружности
        {
            double length;
            length = Math.PI * 2 * r;
            return length;
            
        }
         public static double GetArea(double r)//метод нахождения площадь окружности
        {
            double area;
            area = Math.PI * r * r;
            return area;
        }
        public static double GetV(double r)//метод нахождения объема шара
        {
            double V;
            V = Math.PI * r * r * r * 4.0 / 3.0;
            return V;
        }
    }
}
