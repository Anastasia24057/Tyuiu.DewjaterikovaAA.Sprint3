// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikovaAA.Sprint3.Task1.V3.Lib;
DataService ds = new DataService();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startvalue = 1;
int stopvalue = 10;


Console.WriteLine("Старт шага = " + startvalue);
Console.WriteLine("Старт шага = " + stopvalue);


Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.Write("Произведение ряда = " + ds.GetMultiplySeries(startvalue, stopvalue));
Console.ReadKey();