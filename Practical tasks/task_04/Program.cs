/* Петя любит счастливые числа. Всем известно, что счастливыми являются положительные целые числа, 
в десятичной записи которых содержатся только счастливые цифры 4 и 7. Например, числа 47, 744, 4 являются счастливыми, 
а 5, 17, 467 — не являются. К сожалению, не все числа счастливые. Петя называет число почти счастливым, 
если количество счастливых цифр в нем — счастливое число. Ему интересно, является ли число n почти счастливым. 
В единственной строке выведите «YES», если число n — почти счастливое, и «NO» в противном случае (без кавычек). */

long InputNumber(string text)
{
    Console.WriteLine(text);
    long number = long.Parse(Console.ReadLine() ?? "0");
    return number;
}
long SizeNumber(long number)
{
    long size = 0;
    for(long j=0; number > 0; j++)
    {
        number = number / 10;
        size++;
    }
    return size;
}
void ConvertToArray(long[] array, long number, long size)
{
    for(long i=size-1; i>=0; i--)
    {
        array[i] = number % 10;
        number = number / 10;
    }
}
void PrlongArray(long[] array, string text)
{
    Console.WriteLine(text);
    for(long i=0; i<array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

Console.Clear();
long n = InputNumber("Введите число: ");
long size = SizeNumber(n);
long[] array = new long[size];
ConvertToArray(array, n, size);
long count = 0;
for(long i=0; i<size; i++)
{
    if(array[i] == 4 || array[i] == 7) count++;
}
Console.WriteLine(count);
if(count == 4 || count == 7) Console.WriteLine($"YES");
else Console.WriteLine($"NO");