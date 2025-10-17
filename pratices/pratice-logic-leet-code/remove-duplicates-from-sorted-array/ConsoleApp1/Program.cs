public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int retirou = 0;
        int countElementoUnicos = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {

            if (nums[i] == nums[i + 1])
            {
                retirou++;
            }
            else
            {  
                countElementoUnicos++;
                nums[countElementoUnicos] = nums[i + 1];

            }
        }
        return nums.Length - retirou;
    }
}