using System;

namespace obwee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1\n\n");
            Phone phone1 = new Phone("+375291234567", "Samsung S20FE");
            Phone phone2 = new Phone("+375297654321", "Samsung A70", 1003.4);
            Phone phone3 = new Phone("+375445153004", "Xiaomi mi 11 lite");

            Console.WriteLine(phone1.ToString());
            Console.WriteLine(phone1.receiveCall("Дмитрий"));
            Console.WriteLine(phone1.getNumber());
            Console.WriteLine(phone2.ToString());
            Console.WriteLine(phone2.receiveCall("Василий"));
            Console.WriteLine(phone2.getNumber());
            Console.WriteLine(phone3.ToString());
            Console.WriteLine(phone3.receiveCall("Егор"));
            Console.WriteLine(phone3.getNumber());

            phone1.sendMessage("Привет", "+375291234567", "+375297654321", "+375445153004");

            /////              zd2         /////////////////////////
            Console.WriteLine("Задание 2\n\n");
            Person per = new Person();
            per.SetAge(3);
            per.SetName("Антон");
            Console.WriteLine(per.Move());
            Console.WriteLine(per.Talk());

            Person per2 = new Person("Костя", 10);
            Console.WriteLine(per2.Move());
            Console.WriteLine(per2.Talk());

            /////           zd3           /////////////////////
            Console.WriteLine("Задание 3\n\n");
            Matrix mat = new Matrix(3, 3);
            mat.fillMatrix();
            Matrix mat2 = new Matrix(3, 3);
            mat2.fillMatrix();
            Matrix mat3 = new Matrix(3, 3);
            mat.Show();
            Console.WriteLine();
            mat2.Show();
            Console.WriteLine();
            mat3 = mat + mat2;
            mat3.Show();
            Console.WriteLine("\n");

            /////           zd4           /////////////////////
            Console.WriteLine("Задание 4\n\n");
            Reader reader = new Reader("Раткевич Д.Ю", 3, "ПОИТ", "24.10.2003", "+375293524636");
            Console.WriteLine(reader.takeBook(3));
            Console.WriteLine(reader.takeBook("Гарри Поттер", "Война и мир"));
            Book book1 = new Book("1984", "Джордж Овал");
            Book book2 = new Book("Мастер и маргарита", "Булгак М.");
            Book book3 = new Book("Анна Каренина", "Лев Толстой");
            Console.WriteLine(reader.takeBook(book1, book2, book3));
            Console.WriteLine(reader.returnBook(3));
            Console.WriteLine(reader.returnBook("Гарри Поттер", "Война и мир"));
            Console.WriteLine(reader.returnBook(book1, book2, book3));

            /////           zd5          /////////////////////
            Console.WriteLine("Задание 5\n\n");
            Complex comp = new Complex();
            Complex comp1 = new Complex(3, -1);
            Complex comp2 = new Complex(2, 3);
            Console.WriteLine($"z1 = {comp1.r} + {comp1.i}i\nz2 = {comp2.r} + {comp2.i}");
            Console.WriteLine($"Сумма {comp1.Sum(comp2).r} + {comp1.Sum(comp2).i}");
            Console.WriteLine($"Разность {comp1.Razn(comp2).r} + {comp1.Razn(comp2).i}");
            Console.WriteLine($"Умножение {comp1.Multi(comp2).r} + {comp1.Multi(comp2).i}");
            Console.WriteLine($"Деление {comp1.Div(comp2).r} + {comp1.Div(comp2).i}");
            Console.WriteLine("z1==z2 " + ((comp1 == comp2) ? true : false));
            Console.WriteLine("z1!=z2 " + ((comp1 != comp2) ? true : false));

            /////           zd6          /////////////////////
            Console.WriteLine("Задание 6\n\n");
            Vector3D vector1 = new Vector3D(4, 2, 5);
            Vector3D vector2 = new Vector3D(2, 1, 3);
            Vector3D vector3 = new Vector3D();
            Console.WriteLine("Первый вектор с координатами х=4 y=2 z=5");
            Console.WriteLine("Второй вектор с координатами x=2 y=1 z=3");
            vector3 = vector1.Add(vector2);
            Console.WriteLine(vector3.ToString());
            vector3 = vector3.Add(vector2);
            Console.WriteLine(vector3.ToString());
            Console.WriteLine("Скалярное умножение векторов = " + vector1.scalarMultiply(vector2));
            vector3 = vector1.multiplyVectorOnScalar(2);
            Console.WriteLine(vector3.ToString());
            vector3 = vector2.multiplyVectorOnScalar(4);
            Console.WriteLine(vector3.ToString());
            Console.WriteLine("Длина вектора: " + vector1.lengthOfVector());
            vector2.lengthComparison(vector2);
            vector1.isEqual(vector2);

            /////           zd7          /////////////////////
            Console.WriteLine("Задание 7\n\n");
            YearMonthDay date1 = new YearMonthDay(2017, 11, 30);
            YearMonthDay date2 = new YearMonthDay(2019, 12, 1);
            Console.WriteLine("дата1 = 30.11.2017");
            Console.WriteLine("дата2 = 1.12.2019");
            Console.WriteLine(date1.addDayToData(5).getData());
            Console.WriteLine(date2.subFromData(5).getData());
            date2.dateComparison(date1);
            date1.subtractionDaysBetweenData(date2);
        }
    }
}
