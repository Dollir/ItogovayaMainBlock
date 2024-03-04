// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
string[] Prompt(string message)
{
    System.Console.WriteLine(message);
    string[] array = Console.ReadLine().Split(",");
    return array;
}
void PrintArray(string[] array)
{
    System.Console.WriteLine("[ "+ string.Join(" , ", array ) +" ]");
}

string[] CheckArrayElements(string[] array)
{
    string[] NewArray = new string[array.Length];
    int count =0;
    for(int i=0; i<array.Length;i++)
    {
        if(array[i].Length<=3)
        {
            NewArray[i] = array[i];
            count++;
        }
    }
    string[] FinalNewArray = new string[count];
    for(int i =0;i<FinalNewArray.Length;i++)
    {
        FinalNewArray[i]= NewArray[i];
    }
    return FinalNewArray;
}

string[] array = Prompt("Введите элементы массива строго через запятую: ");
string[] NewArray = CheckArrayElements(array);
PrintArray(array);
PrintArray(NewArray);
