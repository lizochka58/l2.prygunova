using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Описание класса Rectangle (прямоугольник)
class Rectangle
{
    // Открытые поля для хранения высоты и ширины
    public double height;
    public double width;

    // Метод для показа данных о прямоугольнике
    public void Show()
    {
        Console.WriteLine("Прямоугольник:");
        Console.WriteLine($"  Высота: {height}");
        Console.WriteLine($"  Ширина: {width}");
    }

    // Метод для расчёта периметра прямоугольника
    public double Perimetr()
    {
        return 2 * height + 2 * width;
    }
}

class Program
{
    static void Main()
    {
        // 1. Создаём объект класса Rectangle
        Rectangle rect = new Rectangle();

        // 2. Задаём значения полям: высота = 2, ширина = 3
        rect.height = 2;
        rect.width = 3;

        // 3. Выводим данные объекта на экран
        rect.Show();

        // 4. Рассчитываем и выводим периметр
        double p = rect.Perimetr();
        Console.WriteLine($"Периметр прямоугольника: {p}");

        Console.ReadLine();
    }
}
