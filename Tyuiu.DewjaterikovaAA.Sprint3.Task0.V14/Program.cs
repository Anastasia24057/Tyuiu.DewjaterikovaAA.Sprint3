// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikovaAA.Sprint3.Task0.V14.Lib;
DataService ds = new DataService();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


int value = 2;
int startvalue = 1;
int stopvalue = 5;

Console.WriteLine("Переменная n = " + 2);
Console.WriteLine("Старт шага = " + startvalue);
Console.WriteLine("Старт шага = " + stopvalue);


Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.Write("Произведение ряда = " + ds.GetMultiplySeries(value, startvalue, stopvalue));
Console.ReadKey();