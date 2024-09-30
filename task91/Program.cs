int[] arr = { 1, 12, 31, 18, 15, 16, 17, 18 };
int n = arr.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (arr[index] == find)
    {
        System.Console.WriteLine(index);
        break; //если нужно найти только индекс только первого встретившегося элемента
    }
    index++;
}
//поиск индекса элемента
