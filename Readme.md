# Итоговое задание по вводному блоку
Написать программу, которая из имеющегося массива 
формирует массив из строк, длина которых мельше либо равна 
**_3 символа_**.
Первоначальный массив можно ввести с клавиатуры, либо задать
на старте выполнения алгоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно 
**_массивами_**.

## Решение

Решение реализовано классом `public class clsArraySubSet`

Класс предоставляет следующие методы:
1. Вывод строкового массива на печать:
   
    `static void PrintStringAray(string[] arr, string message = "")`

    `string[] arr`  - массив, который надо распечатать

    `string message` - сообщение, которое выводится перед выводом элементов массива
2. Подсчет количества элементов итогового массива

    `static int GetCountOfStrings(string[] arr, int controlStringLength)`

    `string[] arr` - массив, в котором ищем элементы

    `int controlStringLength` - максимальная длина строк для итогового массива

3. Копирование элементов массива, соответствующих условию

    `static void CopyStrings(string[] initArr, string[] resArr, int controlStringLength)`

    `string[] initArr` - исходный массив

    `string[] resArr` - результирующий массив

    `int controlStringLength` - максимальная длина строк для итогового массива

4. Основной метод выполнения программы

    `static void Main(string[] args)`