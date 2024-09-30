//int n = 10; // если arr.Length то эта строка не нужна
int[] arr = { 2, 5, 4, 7, 8, 36, 1, 3, 8, 5 };
int i = 0;

while (i < arr.Length)
{
    if(arr[i] % 2 == 0)
    {
        System.Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}