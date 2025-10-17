
Solution solution = new();
solution.PlusOne([9, , 9, 9]);
public class Solution
{
    public int[] PlusOne(int[] digits)
    {


        int currentLastIndex = digits.Length - 1;
        int holder = 0;
        digits[currentLastIndex]++;

        do
        {
            if (currentLastIndex >= 0)
            {
                digits[currentLastIndex] += holder;
                holder = 0;
                if (digits[currentLastIndex] == 10)
                {
                    digits[currentLastIndex] = 0;
                    holder = 1;
                }
                currentLastIndex--;
            }

            else
            {
                digits = new int[digits.Length + 1];
                digits[0] = holder;
                return digits;
            }

        } while (holder != 0);

        return digits;
    }
}