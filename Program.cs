Console.Write("Введите текст через запятую для проверки по длине элемента: ");
string[] text = Console.ReadLine()!.Split(',');
Console.WriteLine("Изначальный массив данных: ");
PrintResult(text);

int count = 0;
int S = Quantity(text, count);
string[] Mass = new string[S];
Work(text, Mass);
Console.WriteLine("Отсортированный массив данных: ");
PrintResult(Mass);

//Метод подсчета кол-ва элементов (меньше или равны 3)
int Quantity(string[] massive, int num)
{
    for(int i = 0; i < massive.Length; i++)
    {
        if(massive[i].Length <= 3)
        {
            num++;
        }
    }
    return num;
}

//Метод присваивания нужных элементов изначального массива новому
string[] Work(string[] startMass, string[] endMass)
{
    int j = 0;
    for(int i = 0; i < text.Length; i++)
    {
        if(startMass[i].Length <= 3)
        {
            endMass[j] = startMass[i];
            j++;
        }
    }
    return endMass;
}

//Метод вывода элементов
void PrintResult(string[] endMass)
{
    Console.WriteLine($"[{String.Join(", ", endMass)}]");
}