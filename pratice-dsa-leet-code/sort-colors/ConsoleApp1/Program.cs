using System.Globalization;


var solution = new Solution();
solution.SortColors([0, 2, 1, 2, 0, 2, 0, 1]);

public class Solution
{
    public void SortColors(int[] nums)
    {
        QuickSort(nums, 0, nums.Length - 1);
    }

    void QuickSort(int[] nums, int low, int high)
    {

        if (low < high)
        {

            int pivotIndex = Partition(nums, low, high);
            // aplicando nos valores menores
            QuickSort(nums, low, pivotIndex - 1);
            //aplicando nos valores maiores
            QuickSort(nums, pivotIndex + 1, high);

        }

        //encontrar pivot e colocá-lo na ultima posição
        void SelectPivot(int[] nums, int low, int high)
        {
            //encontrando meio
            int mid = (low + high) / 2;

            //descobrir quem é a mediana dos três valores e deixá-la no meio.
            if (nums[low] > nums[mid])
            {
                Swap(nums, low, mid);
            }
            if (nums[high] < nums[low])
            {
                Swap(nums, low, high);
            }
            if (nums[mid] > nums[high])
            {
                Swap(nums, mid, high);
            }

            //colocar mediana na ultima posição e retornar index
            Swap(nums, mid, high);

        }

        void Swap(int[] nums, int i, int j)

        {
            (nums[j], nums[i]) = (nums[i], nums[j]);
        }
        // deixa valores menores que que pivot a esquerda, e valores maiores a direita. coloca pivto na posição correta
        int Partition(int[] nums, int low, int high)
        {
            SelectPivot(nums, low, high);
            int i = -1;
            for (int j = 0; j < high; j++)
            {
                if (nums[j] <= nums[high])
                {
                    i++;
                    Swap(nums, i, j);
                }
            }
            // colocar pivot na posição correta
            Swap(nums, high, i + 1);

            //retornar a posição correta do pivot
            return i + 1;
        }
    }
}