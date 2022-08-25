/* Слоник решил сходить в гости к другу. Оказалось, что дом слоника находится в точке 0, 
а дом его друга в точке x(x > 0) координатной прямой. За один шаг слоник может переместиться 
на 1, 2, 3, 4 или 5 позиций вперёд. 
Помогите ему определить, за какое минимальное количество шагов он может добраться до дома друга. */

int InputNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
Console.Clear();
int[] step = {1, 2, 3, 4, 5};
int homePosition = InputNumber("Введите позицию дома друга: ");
int result = 0;
for (int i = 4; i>=0; i-- )
{
    if(homePosition >= step[i]) 
    {
        result = result + homePosition / step[i];
        homePosition = homePosition%step[i];
    }
}
Console.WriteLine($"Минимальное количество шагов: {result}");