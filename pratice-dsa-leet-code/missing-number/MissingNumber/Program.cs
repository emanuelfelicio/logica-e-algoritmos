/* meu input é um array em que cada elemento 
é um número distinto de em range 0 to N em que  N é o numero total de elemento
meu objetivo é enconrar o UNICO elemetno que está faltando no range especificado*/

int MissingNumber(int[] nums)
{
    Array.Sort(nums);
    int n = nums.Length;
    for (int i = 0; i < n; i++)
    {
        if (nums[i] != i)
        {
            return i;
        }
    }
    return n;

}

int MissingNumber2(int[] nums)
{
    int res = 0;
    for (int i = 0; i <= nums.Length; i++)
    {
        res ^= i;
    }
    foreach (int num in nums)
    {
        res ^= num;
    }
    return res;
}



