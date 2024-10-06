//task4
Console.WriteLine("eded daxil edin:");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int k = 0;
while (n>0)
{
    k = n % 10;
    n = n / 10;
    sum += k;
}
Console.WriteLine(sum);