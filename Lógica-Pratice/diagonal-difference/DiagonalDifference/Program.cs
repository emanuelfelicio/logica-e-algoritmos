namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<List<int>> list = new List<List<int>>
            {
                new List<int>{11,2,4},
                new List<int>{4,5,6},
                new List<int>{10,8,-12}
            };

            Console.WriteLine(diagonalDifference(list));

            static int diagonalDifference(List<List<int>> arr)
            {
                // o argumento recebido é uma matriz quadrada, devo encotrar o somatório das duas diagonais somar e atribuí-los a uma variável D1 E D2
                // retornar o módulo de D1-D2

                int D1 = 0;
                int D2 = 0;
                for (int i = 0; i < arr.Count; i++)
                {
                    for (int j = 0; j < arr.Count; j++)
                    {
                        if (i == j)
                        {
                            D1 += arr[i][j];
                        }
                        if (i + j == arr.Count - 1)
                        {
                            D2 += arr[i][j];
                        }
                    }
                }

                return Math.Abs(D1 - D2);
            }

            

        }
    }
}
