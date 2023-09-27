using laba2_library;

namespace Tests1
{
    /// <summary>
    /// Класс для модульных тестов 
    /// </summary>
    [TestClass]
    public class Tests
    {
        /// <summary>
        /// Метод для проверки равности двух двумерных массивов
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns>True, если массивы равно поэлментно, иначе False.</returns>
        public static bool AreTwoDimensionalArraysEqual(int[,] array1, int[,] array2)
        {
            if (array1 == null || array2 == null)
            {
                return false;
            }

            if (array1.GetLength(0) != array2.GetLength(0) || array1.GetLength(1) != array2.GetLength(1))
            {
                return false;
            }

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    if (array1[i, j] != array2[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Тестирование матрицы 3x1 и вектора 1x3
        /// </summary>
        [TestMethod]
        public void TestComposition1()
        {
            Matrix result = new(1, 1);
            result.matrix[0, 0] = 38;

            Vector vector = new Vector(3);
            vector.vect = new int[3] { 5, 6, 7 };

            Matrix matrix2 = new(3, 1);
            matrix2.matrix = new int[3, 1] { { 1 }, { 2 }, { 3 } };

            Matrix matrix3 = Matrix.Composition( vector, matrix2);

            Assert.IsTrue(AreTwoDimensionalArraysEqual(result.matrix, matrix3.matrix));
        }

        /// <summary>
        /// Тестирование умножения 2 матриц размерностью 2x2.
        /// </summary>
        [TestMethod]        
        public void TestComposition2()
        {
            Matrix result = new(2, 2);
            result.matrix = new int[2, 2] { {-75, 13 }, { 135, -81} };

            Matrix matrix1 = new(2, 2);
            matrix1.matrix = new int[2, 2] { { -5, 16}, { 9, 0} };

            Matrix matrix2 = new(2, 2);
            matrix2.matrix = new int[2, 2] { {15, -9 }, { 0, -2} };

            Matrix matrix3 = Matrix.Composition(matrix1, matrix2);

            Assert.IsTrue(AreTwoDimensionalArraysEqual(result.matrix, matrix3.matrix));
        }

        /// <summary>
        /// Тестирование умножения матрицы 3x3 и матрицы 3x1
        /// </summary>
        [TestMethod]
        public void TestComposition3()
        {
            Matrix result = new(3, 1);
            result.matrix = new int[3, 1] { { -43 }, { 84 }, { 3 } };

            Matrix matrix1 = new(3, 3);
            matrix1.matrix = new int[3, 3] { { -5, 16, 2 }, { 9, -1, 5}, { 0, -3, 0} };

            Matrix matrix2 = new(3, 1);
            matrix2.matrix = new int[3, 1] { { 7 }, { -1 }, { 4 } };

            Matrix matrix3 = Matrix.Composition(matrix1, matrix2);

            Assert.IsTrue(AreTwoDimensionalArraysEqual(result.matrix, matrix3.matrix));
        }

        /// <summary>
        /// Проверка на вызов исключения при попытке перемножения матрицы 3x3 и матрицы 1x3.
        /// </summary>
        [TestMethod]
        public void TestCompositionException1()
        {
            Matrix matrix1 = new(3, 3);
            matrix1.matrix = new int[3, 3] { { -5, 16, 2 }, { 9, -1, 5 }, { 0, -3, 0 } };

            Matrix matrix2 = new(1, 3);
            matrix2.matrix = new int[1, 3] { { 7 , -1, 4 } };

            Assert.ThrowsException<ArgumentException>(() => Matrix.Composition(matrix1, matrix2));
        }
    }
}