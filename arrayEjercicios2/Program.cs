/*//1
string[] arrayStr = { "ojo", "hoja", "agua", "sol", "oreja", "gusano", "himalaya", "yo", "tu", "el" };
foreach (string str in arrayStr)
{
    Console.Write(str + ",");
}
Console.WriteLine("");

//2
for (int i = 0; i < arrayStr.Length; i++)
{
    Console.Write(arrayStr[i] + ", ");
}
Console.WriteLine("");

//3
int[] arrayInt = { 3, 2, 6, 5, 4, 8, 7 };
for (int i = 1; i < arrayInt.Length; i += 2)
{
    Console.Write(arrayInt[i] + ", ");
}
Console.WriteLine("");

//4
int[] arrayProm = { 4, 5, 1, 8, 9 };
Console.WriteLine(arrayProm.Average());

//5
int[] arrayRplc = new int[5];
for (int i = 0; i < arrayProm.Length; i++)
{
    Console.WriteLine("Ingrese un número:");
    string? numStr = Console.ReadLine();
    int num = int.Parse(numStr);
    arrayRplc[i] = num;
}
Array.ForEach(arrayRplc, n => Console.Write(n + ", "));
Array.Clear(arrayRplc, arrayRplc.Length - 1, 1);
arrayRplc[arrayRplc.Length - 1] = 50;
Console.WriteLine("");

//6
int[] arraySum = { 3, 7, 6, 1, 9 };
Console.WriteLine("Ingrese un número para buscar:");
string? numberStr = Console.ReadLine();
int index = Array.IndexOf(arraySum, int.Parse(numberStr));
arraySum[index] += 10;
Console.WriteLine(arraySum[index]);

//7
int[] arrayIngreso = new int[10];
for (int i = 0; i < arrayIngreso.Length; i++)
{
    Console.WriteLine("Ingrese un número:");
    string? numStr = Console.ReadLine();
    int num = int.Parse(numStr);
    arrayIngreso[i] = num;
}
Array.ForEach(arrayIngreso, n => Console.Write(n + ", "));
Console.WriteLine("");
int count = 0;
foreach (int i in arrayIngreso)
{
    if (i > 20)
    {
        count++;
    }
}
Console.WriteLine($"Hay {count} elementos mayores a 20");*/

//8
int[] arrayCounters = new int[10];
int countNeg = 0;
int countPos = 0;
int countZero = 0;
for (int i = 0; i < arrayCounters.Length; i++)
{
    Console.WriteLine("Ingrese un número:");
    string? numStr = Console.ReadLine();
    int num = int.Parse(numStr);
    arrayCounters[i] = num;
    if (arrayCounters[i] > 0)
    {
        countPos++;
    } else if (arrayCounters[i] < 0)
    {
        countNeg++;
    } else
    {
        countZero++;
    }
}
Console.WriteLine($"Hay {countPos} elementos positivos \n Hay {countNeg} elementos negativos \n Hay {countZero} ceros");