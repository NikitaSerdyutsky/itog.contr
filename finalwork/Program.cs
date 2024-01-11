// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[number];
void array(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = Console.ReadLine();
    }
}
string[] result(string[] stringArray)
{
    int n = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            n++;
    }
    string[] rez = new string[n];
    int m = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            rez[m] = stringArray[i];
            m++;
        }
    }
    return rez;
}
void printA(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"‘{stringArray[i]}’, ");
    }
    Console.Write("]");
}
array(stringArray);
printA(result(stringArray));