internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        bool isWork = true;

        while (isWork)
        {
            Console.Clear();
            Console.Write("Какое задание вы хотите проверить?\nВведите целое число от 1 до 3\nЛибо напишите exit для выхода\n\nВаш выбор: ");

            var word = Console.ReadLine();
            if (word == "1" || word == "2" || word == "3")
            {
                int.TryParse(word, out var n);
                switch (n)
                {
                    case 1: //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
                        {
                            Console.Clear();
                            Console.Write("Вы выбрали задачу номер 1\nПроверка пятизначного числа на палиндром.\n\nВведите пятизначное число: ");
                            string? number = Console.ReadLine();

                            void CheckingNumber(string number)
                            {
                                if (number[0] == number[4] || number[1] == number[3])
                                {
                                    Console.WriteLine($"Ваше число: {number} - палиндром.");
                                }
                                else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
                            }
                            if (number!.Length == 5)
                            {
                                CheckingNumber(number);
                            }
                            else Console.WriteLine($"Вы ввели не правильно число");




                            Console.Write("\nНажмите любую кнопку для возврата в главное меню");
                            Console.ReadKey();

                            break;



                        }

                    case 2: //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
                        {
                            Console.Clear();
                            Console.Write("Вы выбрали задачу номер 2\nРасстояное между двух точек в 3D пространстве.\n");

                            int x1 = Coordinate("x", "A");
                            int y1 = Coordinate("y", "A");
                            int z1 = Coordinate("z", "A");
                            int x2 = Coordinate("x", "B");
                            int y2 = Coordinate("y", "B");
                            int z2 = Coordinate("z", "B");

                            int Coordinate(string coorName, string pointName)
                            {
                                Console.Write($"Введите координату {coorName} точки {pointName}: ");
                                return Convert.ToInt16(Console.ReadLine());
                            }

                            double Decision(double x1, double x2,
                                            double y1, double y2,
                                            double z1, double z2)
                            {
                                return Math.Sqrt(Math.Pow(x2 - x1, 2) +
                                                 Math.Pow(y2 - y1, 2) +
                                                 Math.Pow(z2 - z1, 2));
                            }
                            double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

                            Console.WriteLine($"Длина отрезка  {segmentLength}");
                            Console.Write("\nНажмите любую кнопку для возврата в главное меню");
                            Console.ReadKey();
                            break;
                        }

                    case 3: //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
                        {
                            Console.Clear();
                            Console.Write("Вы выбрали задачу номер 3\nТаблица кубов от 1 до введенного числа.\n\nВведите число: ");

                            int N;
                            while (!int.TryParse(Console.ReadLine(), out N)) Console.WriteLine("Вы ввели не число");
                            int index = 1;
                            while (index <= N)
                            {
                                Console.Write($"{Math.Pow(index, 3)} ");
                                index++;
                            }
                            Console.ReadKey();
                            Console.Write("\nНажмите любую кнопку для возврата в главное меню");
                            Console.ReadKey();



                            break;
                        }



                }
            }
            else if ( word.ToLower() == "exit" || word.ToLower() == "e")
            {
                isWork = false;
            }
            else
            {
                Console.WriteLine("Неизвестная команда, повторите выбор\n\nНажмите любую кнопку для возврата в главное меню");
                Console.ReadKey();
            }
        }
    }
}