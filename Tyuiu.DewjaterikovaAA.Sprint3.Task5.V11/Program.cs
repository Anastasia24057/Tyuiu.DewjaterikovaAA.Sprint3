// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikovaAA.Sprint3.Task5.V11.Lib;
DataService ds = new DataService();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


int  x = 5;
int startvalue1 = 1;
int stopvalue1 = 3;
int startvalue2 = 1;
int stopvalue2 = 10;

Console.WriteLine("Переменная x = " + x);
Console.WriteLine("Старт шага 1 = " + startvalue1);
Console.WriteLine("Старт шага 1 = " + stopvalue1);
Console.WriteLine("Старт шага 2 = " + startvalue2);
Console.WriteLine("Старт шага 2 = " + stopvalue2);


Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.Write("Сумма сумм ряда = " + ds.GetSumSumSeries(x, startvalue1, startvalue2, stopvalue1, stopvalue2));
Console.ReadKey();