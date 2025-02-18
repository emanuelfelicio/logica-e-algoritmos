/*
    Usar técnica do TwoPoints 
    o grande ponto aqui é : se a ponta esquerda + a ponta direita satisfaz a condição então todos os pares entre esses valores também satisfaz
    por isso count += right - left
*/

IList<int> list = [-1, 1, 2, 3, 1];




Console.WriteLine(CountPairs(list, 2));

int CountPairs(IList<int> nums, int target)
{
    int[] array = nums.ToArray();
    Array.Sort(array);
    int count = 0;
    int left = 0;
    int right = array.Length - 1;

    while (left < right)
    {
        if (array[left] + array[right] < target)
        {
            count += right - left;
            left++;
        }
        else
        {
            right--;
        }

    }
    return count;
}