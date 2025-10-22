// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikovaAA.Sprint3.Task2.V29.Lib;

DataService ds = new DataService();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


double value = 0.5;
int startvalue = 1;
int stopvalue = 18;

Console.WriteLine("Переменная a = " + value);
Console.WriteLine("Старт шага = " + startvalue);
Console.WriteLine("Старт шага = " + stopvalue);


Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.Write("Сумма ряда = " + ds.GetSumSeries(value, startvalue, stopvalue));
Console.ReadKey();