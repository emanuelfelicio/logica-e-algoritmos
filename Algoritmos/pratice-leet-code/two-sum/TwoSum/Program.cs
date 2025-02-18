



//fazer loop for aninhado para comparar 1 elemento com todos os outros e retorna os índices caso arr[i]+arr[j]==target
// time complexity tem que ser menos que O(N^2)

// aprroach 01 , brute force : 
static int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return [i, j];
            }
        }
    }
    return [];
}

static int[] TwoSumHashMap(int[] nums, int target)
{

    Dictionary<int, int> map = [];


    for (int i = 0; i < nums.Length; i++)
    {
        // será que o contrário não faz mais sentido ? map[i] = nums[i]
        map[nums[i]] = i;
    }

    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];
        if (map.ContainsKey(complement))
        {
            // nums[complement] obtém valor associado a chave complement, que é justamente o index do array
            return [i, map[complement]];
        }
    }

    return [];
}

