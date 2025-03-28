using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введіть кількість телефонів: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Некоректне значення! Спробуйте ще раз.");
                Console.Write("Введіть кількість телефонів: ");
            }

            Phone[] phones = new Phone[n];

            for (int i = 0; i < n; i++)
            {
                phones[i] = new Phone();

                Console.WriteLine($"\nВведення даних для телефону {i + 1}:");

                Console.Write("Бренд: ");
                phones[i].Brand = Console.ReadLine();

                Console.Write("Модель: ");
                phones[i].Model = Console.ReadLine();

                Console.Write("Розмір екрана (в дюймах): ");
                phones[i].ScreenSize = double.Parse(Console.ReadLine());

                Console.Write("Оперативна пам'ять (ГБ): ");
                phones[i].RAM = int.Parse(Console.ReadLine());

                Console.Write("Пам'ять для зберігання (ГБ): ");
                phones[i].Storage = int.Parse(Console.ReadLine());

                Console.Write("Колір: ");
                phones[i].Color = Console.ReadLine();

                Console.Write("Ціна (грн): ");
                phones[i].Price = decimal.Parse(Console.ReadLine());

                Console.Write("Ємність акумулятора (мАг): ");
                phones[i].BatteryCapacity = int.Parse(Console.ReadLine());

                Console.Write("Операційна система: "); // Введення нового параметра
                phones[i].OperatingSystem = Console.ReadLine();
            }

            Console.WriteLine("\n--- Інформація про всі телефони ---");
            foreach (var phone in phones)
            {
                Console.WriteLine($"\nБренд: {phone.Brand}");
                Console.WriteLine($"Модель: {phone.Model}");
                Console.WriteLine($"Розмір екрана: {phone.ScreenSize}\"");
                Console.WriteLine($"Оперативна пам'ять: {phone.RAM} ГБ");
                Console.WriteLine($"Пам'ять для зберігання: {phone.Storage} ГБ");
                Console.WriteLine($"Колір: {phone.Color}");
                Console.WriteLine($"Ціна: {phone.Price:C}");
                Console.WriteLine($"Ємність акумулятора: {phone.BatteryCapacity} мАг");
                Console.WriteLine($"Операційна система: {phone.OperatingSystem}"); // Виведення нової властивості
                Console.WriteLine($"Ціна за 1 ГБ пам'яті: {phone.PricePerGB():F2} грн"); // Виклик функції без get
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}

 class Phone
 {
        public string Brand;
        public string Model;
        public double ScreenSize;
        public int RAM;
        public int Storage;
        public string Color;
        public decimal Price;
        public int BatteryCapacity;
        public string OperatingSystem; // Додана нова властивість

        // Обчислення ціни за 1 ГБ пам'яті без використання get-методу
        public double PricePerGB()
        {
            return Storage > 0 ? (double)Price / Storage : 0;
        }
    
 }

