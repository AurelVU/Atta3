using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Room;
using _10;
using ClassLibrary;
using _FileString;

namespace _10._30._30Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Открыть данные с файла? Введите Да или Нет: ");
            string comand = Console.ReadLine();
            Base Newbase = new Base();
            string[] arrstring;
            if (comand == "Да")
            {
                Console.Write("Введите путь к файлу: ");
                string name = Console.ReadLine();
                string File = _FileString.MyFileString.ReadF(name);
                arrstring = File.Split(new char[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < arrstring.Length; i += 5)
                {
                    Newbase.Add(new Room(arrstring[i], Convert.ToInt32(arrstring[i + 1]), Convert.ToDouble(arrstring[i + 2]), Convert.ToDouble(arrstring[i + 3]), Convert.ToDouble(arrstring[i + 4])));
                }
            }
            else if (comand == "Нет")
            {
                Console.Write("Введите количество квартир: ");
                int n = Convert.ToInt32(Console.ReadLine());
                arrstring = new string[5];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Введите через пробел название района, количество комнат, общую площадь, площать кухни и цену для {0}-ой квартиры", i + 1);
                    arrstring[i] = Console.ReadLine();
                }
                for (int i = 0; i < n; i++)
                {
                    string[] a = arrstring[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Newbase.Add(new Room(a[0], Convert.ToInt32(a[1]), Convert.ToDouble(a[2]), Convert.ToDouble(a[3]), Convert.ToDouble(a[4])));
                }
            }
            Console.Write("Введите необходимое количество комнат: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минимальную площадь: ");
            double Smin = Convert.ToDouble(Console.ReadLine());
            List<Room> Result = Newbase.Find(N, Smin);
            Console.Write("Сохранить данные в файл? Введите Да или Нет: ");
            comand = Console.ReadLine();
            if (comand == "Да")
            {
                Console.Write("Введите путь к файлу: ");
                string name = Console.ReadLine();
                _FileString.MyFileString.ClearF(name);
                for (int i = 0; i < Result.Count; i++)
                {
                    _FileString.MyFileString.WriteF(name,("Район: " + Result[i].name + " кол -во комнат: "+ Convert.ToString(Result[i].Nroom) + " площадь: " +Convert.ToString(Result[i].Smax)+  " площадь кухни: " + Convert.ToString(Result[i].Scook) + " цена: " + Convert.ToString(Result[i].Price) + '\r' + '\n'));

                }
            }
            else if (comand == "Нет")
            {
                for (int i = 0; i < Result.Count; i++)
                {
                    Console.WriteLine("Район: {0}, кол-во комнат: {1}, площадь: {2}, площадь кухни: {3}, цена: {4}", Result[i].name, Result[i].Nroom, Result[i].Smax, Result[i].Scook, Result[i].Price);
                }
            }
        }
    }
}
