using System;
using System.Runtime.CompilerServices;

namespace laba2_library
{
    /// <summary>
    /// Класс, описывающий матрицу.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Кол-во столбиков.
        /// </summary>
        public int Column { get; }
        /// <summary>
        /// Кол-во строк.
        /// </summary>
        public int Row { get; }
        /// <summary>
        /// Матрица
        /// </summary>
        public int[,] matrix;

        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        /// <param name="row">Кол-во строк.</param>
        /// <param name="column">Кол-во столбиков.</param>
        public Matrix(int row, int column)
        {
            this.Column = column;
            this.Row = row;
            matrix = new int[row, column];
        }

        /// <summary>
        /// Конструктор матрицы, в который передаётся вектор
        /// </summary>
        /// <param name="vector"></param>
        public Matrix(Vector vector)
        {
            this.Column = vector.Length;
            this.Row = 1;
            this.matrix = new int[this.Row, this.Column];
            for (int i = 0; i < vector.Length; i++)
                matrix[0, i] = vector.vect[i];
        }

        /// <summary>
        /// Инициализация элементов матрицы
        /// </summary>
        public void Init()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    do
                    {
                        Console.Write($"X[{i}][{j}] = ");
                       
                    }
                    while (!int.TryParse(Console.ReadLine(), out matrix[i, j]));
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вывести элементы матрицы
        /// </summary>
        public void GetOutput()
        {

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                   Console.Write($"X[{i}][{j}] = {matrix[i, j]}\t");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
        public override string ToString()
        {
            return base.ToString();
        }
        /// <summary>
        /// Перемножение матриц.
        /// </summary>
        /// <param name="A">Матрица 1</param>
        /// <param name="B">Матрица 2</param>
        public static Matrix Composition(Matrix A, Matrix B)
        {

            if (A.Column == B.Row)
            {
                Matrix result = new Matrix(A.Row, B.Column);
                int temp;

                for (int i = 0; i < A.Row; i++)
                {
                    for (int j = 0; j < B.Column; j++)
                    {
                        temp = 0;
                        for (int k = 0; k < B.Row; k++)
                        {
                            temp += A.matrix[i, k] * B.matrix[k, j];
                        }

                        result.matrix[i, j] = temp;
                    }
                }

                return result;
            }
            else
            {
                throw new ArgumentException("Неправильные размеры матриц");
            }
        }

        /// <summary>
        /// Умножение матрицы на вектор
        /// </summary>
        /// <param name="A">Матрица</param>
        /// <param name="B">Вектор</param>
        public static Matrix Composition(Matrix A, Vector vector)
        {
            Matrix B1 = new Matrix(vector);
            return Composition(A, B1);
        }

        public static Matrix Composition(Vector vector, Matrix A)
        {
            Matrix B1 = new Matrix(vector);
            return Composition(B1, A);
        }
    }
}