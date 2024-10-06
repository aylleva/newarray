//task2
int[] arr1 = { 36, 3, 76, 74, 92, 56 };
int[] arr2 = { 3,65,128,76,54,34,56,32,87,218901};

for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {
            Console.WriteLine(arr1[i]);
        }
    }
}


