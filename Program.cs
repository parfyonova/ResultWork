Console.Write("Введите текст через запятую для проверки по длине элемента: ");
string[] text = Console.ReadLine()!.Split(',');



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