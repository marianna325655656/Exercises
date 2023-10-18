int x = 1;
int sum = 0;
while (x <= 100)
{
    sum = sum + x;
    x++;
}
Console.WriteLine("sum: " + sum);

int x1 = 1;
int sum1 = 0;
do
{
    sum1 = sum1 + x1;
    x1++;

}
while (x <= 100);
Console.WriteLine("sum: " + sum1);

int sum2 = 0;
for (int i = 1; i <= 100; i++)
{
    sum2 = sum2 + i;

}
Console.WriteLine("sum: " + sum2);