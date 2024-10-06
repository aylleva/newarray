//task3
int[] nums = {  85, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
int maxindex = 0;
int minindex = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > nums[maxindex])
    {
        maxindex = i;

    }

}
Console.WriteLine(maxindex);
     for(int i = 0; i < nums.Length; i++)
{
    if (nums[i] < nums[minindex])
    {
        minindex = i;
    }
}
Console.WriteLine(minindex);