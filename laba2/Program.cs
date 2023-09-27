using laba2_library;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1, matrix2, matrix3;
            Vector vector;
            int choice, row, column, length; 

            while (true)
            {
                Console.Clear();
                Console.WriteLine("                    Меню");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("| 1. Создать 2 матрицы, перемножить их |");
                Console.WriteLine("|    и вывести результирующую матрицу  |");
                Console.WriteLine("| 2. Создать матрицу и вектор,         |");
                Console.WriteLine("|    перемножить их и вывести          |");
                Console.WriteLine("|    результирующую матрицу            |");
                Console.WriteLine("| 3. Завершить программу               |");
                Console.WriteLine("----------------------------------------");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите количество строк матрицы 1");
                        row = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите количество столбцов матрицы 1");
                        column = int.Parse(Console.ReadLine());
                        matrix1 = new Matrix(row, column);
                        matrix1.Init();
                        matrix1.GetOutput();
                        

                        Console.WriteLine("Введите количество строк матрицы 2");
                        row = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите количество столбцов матрицы 2");
                        column = int.Parse(Console.ReadLine());
                        matrix2 = new Matrix(row, column);
                        matrix2.Init();
                        matrix2.GetOutput();

                        matrix3 = Matrix.Composition(matrix1, matrix2);
                        Console.WriteLine("Итоговая матрица:");
                        matrix3.GetOutput();
                        break;
                    case 2:
                        Console.WriteLine("Введите количество строк матрицы 1");
                        row = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите количество столбцов матрицы 1");
                        column = int.Parse(Console.ReadLine());
                        matrix1 = new Matrix(row, column);
                        matrix1.Init();
                        matrix1.GetOutput();

                        Console.WriteLine("Введите количество элементов вектора");
                        length = int.Parse(Console.ReadLine());
                        vector = new Vector(length);
                        vector.Init();
                        vector.GetOutput();

                        matrix3 = Matrix.Composition(matrix1, vector);
                        Console.WriteLine("Итоговая матрица:");
                        matrix3.GetOutput();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Нет такого пункта меню");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}