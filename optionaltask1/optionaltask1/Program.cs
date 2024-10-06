int[] nums = { 3, 5, 6, 7, 4, 8, 9, 2, 10 };
int n = 0;
int k = 0;
int missedNumber = 0;
for(int i = 0; i < nums.Length; i++)
{
    n += nums[i];
}
for(int i=1;i<=10;i++)
{
    k += i;
}
missedNumber = k - n;
Console.WriteLine(missedNumber);