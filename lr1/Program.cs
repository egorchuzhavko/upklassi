using System;

namespace lr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЛР 1");
            Console.WriteLine("Задание 1\n");
            Z1 z1 = new Z1(5, 5);
            Console.WriteLine(z1.ToString());
            Console.WriteLine("Длина дуги = " + z1.lengthDugi());
            Console.WriteLine("\n\nЗадание 2\n");
            Z2 z2 = new Z2(4, 4, 4);
            Console.WriteLine(z2.ToString());
            Console.WriteLine("Среднее геометрическое = " + z2.average());
            Console.WriteLine("Кол-во цифр в сумме чисел = " + z2.countOfNumbers());
            Console.WriteLine("\n\nЛР2");
            Console.WriteLine("qeqweqwe");
            LR2[] lr2 = new LR2[2];
            lr2[0] = new LR2();
            lr2[0].setKuda("Бразилия");
            lr2[0].setTicket(1212);
            lr2[0].setTypeofplane("истребитель");
            lr2[1] = new LR2();
            lr2[1].setTypeofplane("Кукурузник");
            lr2[1].setTicket(1515);
            lr2[1].setKuda("Лондон");
            for (int i = 0; i < lr2.Length; i++)
                Console.WriteLine($"{i + 1}:\nКуда: {lr2[i].getKuda()}\nНомер билета: " +
                    $"{lr2[i].getTicket()}\nТип самолёта: {lr2[i].getTypeofplane()}");
            Console.WriteLine("Введите номер рейса: ");
            int nt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Тип самолёта: " + lr2[0].isCorrectTicket(nt));
        }
    }
}
