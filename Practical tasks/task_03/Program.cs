/* Кажется, еще совсем недавно наступил новый 2013 год. А знали ли Вы забавный факт о том, 
что 2013 год является первым годом после далекого 1987 года, в котором все цифры различны?
Теперь же Вам предлагается решить следующую задачу: задан номер года, найдите наименьший номер года, 
который строго больше заданного и в котором все цифры различны. */

int InputNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
int SizeNumber(int number)
{
    int size = 0;
    for(int j=0; number > 0; j++)
    {
        number = number / 10;
        size++;
    }
    return size;
}
void ConvertToArray(int[] array, int number, int size)
{
    for(int i=size-1; i>=0; i--)
    {
        array[i] = number % 10;
        number = number / 10;
    }
}
bool FindDifferent(int[] array)
{
    bool result = true;
    for(int i=0; i<array.Length-1; i++)
    {    
        for(int j=i+1; j<array.Length; j++)
        {
            if(array[i] == array[j]) 
            {    
                result = false;
                break;
            }
        }
    }
    return result;
}
void PrintArray(int[] array, string text)
{
    Console.WriteLine(text);
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

Console.Clear();
int year = InputNumber("Введите год: ");
int size = SizeNumber(year);
int[] yearArray = new int[size];
ConvertToArray(yearArray, year, size);
for(int j=1;  ; j++)
{
    ConvertToArray(yearArray, year+j, size);
    bool result = FindDifferent(yearArray);
    if (result == true)
    {
        PrintArray(yearArray, "Последующий год с различными цифрами: ");
        break;
    }
}



