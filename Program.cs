/*
Написать программу, которая из имеющегося массива 
формирует массив из строк, длина которых мельше либо равна 
3символа.
Первоначальный массив можно ввести с клавиатуры, либо задать
на старте выполнения алгоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно 
массивами.

Примеры:
["hello", "2", "world", ":"] -> ["2", ":-)"]
*/

public class clsArraySubSet
{
    static void PrintStringAray(string[] arr, string message = "")
    {
        if (message != "") Console.WriteLine(message);
        if (arr.Length > 0)
        {
            Console.Write($"['{arr[0]}'");
            for (int i = 1; i < arr.Length; i++)
                Console.Write($", '{arr[i]}'");
            Console.WriteLine("]");
        }
        else
            Console.WriteLine("Массив нулевой длины!");
    }

    static int GetCountOfStrings(string[] arr, int controlStringLength)
    {
        int resCount = 0;
        if ((controlStringLength > 0) && (arr.Length > 0))
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= controlStringLength)
                    resCount++;
            }
        }
        return resCount;
    }

    static void CopyStrings(string[] initArr, string[] resArr, int controlStringLength)
    {
        int resArrayIndex = 0;
        if ((controlStringLength > 0) && (initArr.Length > 0) && (resArr.Length > 0))
        {
            for (int i = 0; i < initArr.Length; i++)
            {
                if (initArr[i].Length <= controlStringLength)
                {
                    resArr[resArrayIndex] = initArr[i];
                    resArrayIndex++;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        //Несколько тестовых наборов
        // задаем их переменной strArray, которая далее везде используется
        string[] strArray1 = { "12345", "1456", "-2", "hv", " " };
        string[] strArray2 = { };
        string[] strArray3 = { "hgdd", "dsfdf", "hsf:dsf", "00000", "     " };
        string[] strArray4 = {"1", "0", "-yf", "-6", "-  "};


        string[] strArray = strArray4;
        int ControlLength = 3;
        string[] resArray = new string[GetCountOfStrings(strArray, ControlLength)];

        CopyStrings(strArray, resArray, ControlLength);

        PrintStringAray(strArray, "Исходный массив:");
        PrintStringAray(resArray, "Результирующий массив:");
    }
}