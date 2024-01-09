int num= 123456789;

while (num > 0)
{
    int  rod = num % 10;
Console.Write (rod);
if (num >= 10)
{
Console. Write (",");
}
num = num / 10;
}
