// поиск элемента массива с определенным значением
int[] array = {71,22,3,34,51,68,67,48,93};
int n = array.Length;
int find = 48;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // - прервет выполнение при нахождении первого элемента с заданным значением
    }
    index++;
}
