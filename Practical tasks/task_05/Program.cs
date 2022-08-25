/* Солдат хочет купить w бананов в магазине. Ему надо заплатить k долларов за первый банан, 
2k долларов — за второй и так далее (иными словами, за i-й банан надо заплатить i·k долларов).
У него есть n долларов. Сколько долларов ему придется одолжить у однополчанина, чтобы купить w бананов? */

int InputNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

Console.Clear();
int k = InputNumber("Цена первого банана: ");
int n = InputNumber("Количество долларов: ");
int w = InputNumber("Количество бананов: ");
int cost = 0;
for(int i=1; i<=w; i++)
{
    cost = cost + (i*k);
}
int result = cost - n;
Console.WriteLine(result);