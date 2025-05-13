

int[] arr = [0, 4, 5, 3, 6, 11, 12];
MergeSort(arr);
PrintArray(arr);


static void MergeSort(int[] arr)
{
    int n = arr.Length;
    if (n <= 1) return;


    int midle = n / 2;
    int[] l = new int[midle];
    int[] r = new int[n - midle];
    int left = 0;
    int right = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < midle)
        {

            l[left] = arr[i];
            left++;
        }
        else
        {
            r[right] = arr[i];
            right++;
        }
    }

    MergeSort(l);
    MergeSort(r);
    Merge(l, r, arr);


}

static void Merge(int[] left, int[] right, int[] arr)
{
    int leftSize = arr.Length / 2;
    int rightSize = arr.Length - leftSize;
    int l = 0, r = 0, i = 0;

    while (l < leftSize && r < rightSize)
    {
        if (arr[l] < right[r])
        {
            arr[i] = left[l];
            i++;
            l++;
        }
        else
        {
            arr[i] = right[r];
            i++;
            r++;
        }
    }
    while (l < leftSize)
    {
        arr[i] = left[l];
        i++;
        l++;
    }
    while (r < rightSize)
    {
        arr[i] = right[r];
        i++;
        r++;
    }

}

static void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.WriteLine(item);
    }
}



