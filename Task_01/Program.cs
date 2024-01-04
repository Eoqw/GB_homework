namespace Task_01
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Введите элементы массива строк через пробел: ");
            string input = Console.ReadLine();
            string[] originalArray = input.Split(' ');

            string[] newArray = FilterStrings(originalArray, 3);
            

            Console.WriteLine("Исходный массив строк:");
            PrintArray(originalArray);

            Console.WriteLine("\nНовый массив строк (длинан <= 3 символа):");
            PrintArray(newArray);
        }
    }
    static string[] FilterStrings(string[] array, int maxLenght)
    {
        int count = 0;

        for (int i = 0; i < arrayLength; i++)
        {
            if (array[i].Length <= maxLenght)
            {
                count++;
            }
        }
    
    string[] resultArray = new string[count];

    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLenght)
        {
            resultArray[index] = array[i];
            index++;
        }
    }

    return resultArray;

    }
    static void PrintArray(string[] array)
    {
        foreach (string element in array)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
}

        

    


