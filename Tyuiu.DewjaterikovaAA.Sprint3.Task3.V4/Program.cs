// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikovaAA.Sprint3.Task3.V4.Lib;

DataService ds = new DataService();
string str = "plkjjdw cvjkl";
char chr = 'j';


Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


Console.WriteLine("Строка =  " + str);
Console.WriteLine("Удаляемый символ = " + chr);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Конечная строка : " + ds.DeleteCharInString(str, chr));
Console.ReadKey();