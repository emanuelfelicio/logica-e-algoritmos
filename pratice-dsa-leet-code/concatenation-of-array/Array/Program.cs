using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {



        int[] GetConcatenation(int[] nums)
        {
            int[] result = new int[nums.Length * 2];
            int n = nums.Length;
            for (int i = 0; i < result.Length; i++)
            {

                if (i < n)
                {
                    result[i] = nums[i];
                }
                else
                {
                    result[i] = nums[i - n];
                }

            }

            return result;

        }

        // outra versão

        int[] GetConcatenation2(int[] nums)
        {
            var n = new int[nums.Length * 2];
            for (int i = 0; i < nums.Length; i++)
            {
                n[i] = nums[i];
                n[i + nums.Length] = nums[i];
            }
            return n;
        }


    }
}
