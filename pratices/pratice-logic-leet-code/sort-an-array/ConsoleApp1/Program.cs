

int[] test = [0, 0, 1, 1, 4, 5, 0, 3, 4, 6, 10];
int[] result = new int[test.Length];
result = Solution.SortArray(test);
foreach (int i in result)
{
    Console.WriteLine(i);
}


class Solution
{
    public static int[] SortArray(int[] nums)
    {

        return MergeSort(nums);
    }

    public static int[] MergeSort(int[] nums)
    {
        int lenght = nums.Length;
        if (lenght <= 1) return nums;
        int midle = nums.Length / 2;
        int[] leftArray = new int[midle];
        int[] rightArray = new int[lenght - midle];
        int i = 0, right = 0;
        while (i < lenght)
        {
            if (i < midle)
            {
                leftArray[i] = nums[i];

            }
            else
            {
                rightArray[right] = nums[i];
                right++;
            }
            i++;
        }
        MergeSort(leftArray);
        MergeSort(rightArray);
        return Merge(leftArray, rightArray, nums);

    }
    public static int[] Merge(int[] leftArray, int[] rightArray, int[] nums)
    {
        int leftLenght = leftArray.Length;
        int rightLenght = rightArray.Length;
        int l = 0, r = 0, i = 0;
        while (l < leftLenght && r < rightLenght)
        {
            if (leftArray[l] <= rightArray[r])
            {
                nums[i] = leftArray[l];
                l++;
                i++;
            }
            else
            {
                nums[i] = rightArray[r];
                r++;
                i++;
            }
        }
        while (l < leftLenght)
        {
            nums[i] = leftArray[l];
            i++;
            l++;
        }
        while (r < rightLenght)
        {
            nums[i] = rightArray[r];
            i++;
            r++;
        }
        return nums;
    }
}