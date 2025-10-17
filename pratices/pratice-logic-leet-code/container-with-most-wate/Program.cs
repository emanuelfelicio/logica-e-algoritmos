Solution solutio = new();
solutio.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);

public class Solution
{
    public int MaxArea(int[] height)
    {
        int n = height.Length;
        int max = 0;
        
        int left = 0;
        int right = n - 1;

        while (left < right)
        {
            int currentMin = Math.Min(height[left], height[right]);
            int area = currentMin * (right - left);
            max = Math.Max(area, max);

            if (height[left] <= height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return max;
    }
}