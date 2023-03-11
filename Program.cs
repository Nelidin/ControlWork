// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
//                             ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//                             ["1234”, ”1567", ”-2”, "computer science"] -> ["-2"]
//                             ["Russia”, "Denmark", "Kazan"] -> []


Console.Clear();

string[] arrayInput = { "hallo", "2", "world", ":-)" };
//string[] arrayInput = { "1234", "1567", "-2", "computer science" };
//string[] arrayInput = { "Russia", "Denmark", "Kazan" };


int lengthArrayOutput(string[] array) //функция определения длины нового массива
{
    int count = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
        if (array[i].Length <= 3) count++;
    return count;
}

string[] FillArray(string[] array1, string[] array2) // функция заполнения нового массива в соотвествии с условием задачи
{
    int size = array1.Length;
    int i = 0;
    int j = 0;
    while (i < size)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
        i++;
    }
    return array2;
}

void PrintArray(string[] matrix) //метод вывода массива в консоль
{
    Console.Write("[");
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"\"{matrix[i]}\"");
        if (i == matrix.Length - 1) Console.Write("]");
        else Console.Write(", ");
    }
    Console.WriteLine("\n");
}

Console.WriteLine($"Имеющийся массив из {arrayInput.Length} строк: \n ");
PrintArray(arrayInput);

int len = arrayInput.Length; //длина имеющегося массива
int quantity = 0; //количество элементов нового массива
quantity = lengthArrayOutput(arrayInput); //подсчет элементов, удовлетворяющих условию
string[] arrayOutput = new string[quantity]; //задание нового массива
arrayOutput = FillArray(arrayInput, arrayOutput); //заполнение нового массива

if (arrayOutput.Length != 0) //ПРОВЕРКА, сформирован ли итоговый массив
{
    Console.Write($"Сформирован массив из {arrayOutput.Length} строк c длиной, меньшей либо равной 3: \n\n");
    PrintArray(arrayOutput);
}
else Console.WriteLine("Строк, длина которых меньше либо равна 3, нет. \n\n[]");