int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 11, 63 };
for(int i = 0; i < nums.Length; i++)
{
    for (int j = 2; j < nums.Length; j++)
    {
        if (nums[i] % j == 0 && nums[i]!=2)
        {
            Console.WriteLine(nums[i]);
            break;
        }
    }
}