namespace laba2_library
{
    /// <summary>
    /// Класс, описывающий вектор
    /// </summary>
    public class Vector
    {
        /// <summary>
        /// Кол-во элементов в векторе
        /// </summary>
        public int Length;
        /// <summary>
        /// Массив элементов вектора
        /// </summary>
        public int[] vect;

        /// <summary>
        /// Базовый конструктор вектора.
        /// </summary>
        /// <param name="length"></param>
        public Vector(int length)
        {
            this.Length = length;
            vect = new int[length];
        }

        /// <summary>
        /// Инициализация элементов вектора
        /// </summary>
        public void Init()
        {
            for (int i = 0; i < vect.Length; i++)
            {
                do
                Console.Write($"X[{i}] = ");
                while (!int.TryParse(Console.ReadLine(), out vect[i]));
            }
        }

        /// <summary>
        /// Вывод всех элементов вектора
        /// </summary>
        public void GetOutput()
        {
            for (int i = 0; i < vect.Length; i++)
            {
                Console.Write($"X[{i}] = {vect[i]}\t");
            }

            Console.ReadLine();
        }
    }
}
