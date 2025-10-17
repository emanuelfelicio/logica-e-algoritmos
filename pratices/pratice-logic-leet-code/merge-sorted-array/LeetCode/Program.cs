Solution.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);

public class Solution
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {

        int nums1Pointer = m - 1;
        int nums2Pointer = n - 1;
        int pointer = n + m - 1;

        while (nums1Pointer >= 0 && nums2Pointer >= 0)
        {
            if (nums1[nums1Pointer] >= nums2[nums2Pointer])
            {
                nums1[pointer] = nums1[nums1Pointer];
                nums1Pointer--;
            }
            else
            {
                nums1[pointer] = nums2[nums2Pointer];
                nums2Pointer--;
            }
            pointer--;
        }

        while (nums2Pointer >= 0)
        {
            nums1[pointer] = nums2[nums2Pointer];
            pointer--;
            nums2Pointer--;
        }


        // int[] nums3 = new int[n + m];

        // int i = 0;
        // int j = 0;


        // while (i < m && j < n)
        // {
        //     if (nums1[i] <= nums2[j])
        //     {
        //         nums3[i + j] = nums1[i];
        //         i++;
        //     }
        //     else
        //     {
        //         nums3[i + j] = nums2[j];
        //         j++;
        //     }
        // }

        // while (i < m)
        // {
        //     nums3[i + j] = nums1[i];
        //     i++;
        // }

        // while (j < n)
        // {
        //     nums3[i + j] = nums2[j];
        //     j++;
        // }

        // nums1 = nums3;

    }
}