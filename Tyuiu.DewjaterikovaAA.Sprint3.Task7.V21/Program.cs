// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikovaAA.Sprint3.Task7.V21.Lib;

DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startvalue = -5;
int stopvalue = 5;


Console.WriteLine("Начало шага = " + startvalue);
Console.WriteLine("Конец шага = " + stopvalue);

int len = ds.GetMassFunction(startvalue, stopvalue).Length;
double[] valueArray;
valueArray = new double[len];

valueArray = ds.GetMassFunction(startvalue, stopvalue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("+-----------+----------+");
Console.WriteLine("|    X      |    F(X)  |");
Console.WriteLine("+-----------+----------+");
for (int i = 0; i < len; i++)
{
    Console.WriteLine("|{0,4:d}       |{1,7:f2}   |", startvalue, valueArray[i]);
    startvalue++;
}
Console.WriteLine("+-----------+----------+");
Console.ReadKey();

