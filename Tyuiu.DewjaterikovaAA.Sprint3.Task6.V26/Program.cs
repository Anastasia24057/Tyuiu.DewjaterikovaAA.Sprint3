// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikovaAA.Sprint3.Task6.V26.Lib;

DataService ds = new DataService();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startvalue = 15;
int stopvalue = 22;


Console.WriteLine("Начало отрезка = " + startvalue);
Console.WriteLine("Конец отрезка = " + stopvalue);


Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.Write("Произведение ряда = " + ds.GetSumTheDivisors(startvalue, stopvalue));
Console.ReadKey();
