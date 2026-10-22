/*Анализатор массива температур: Напишите программу, 
 * которая принимает массив температур за неделю, 
 * находит среднее значение, 
 * максимальную и минимальную температуру 
 * (используя циклы foreach и for).*/

int week = 7;
double maxTemp = 0;
double minTemp = 0;
double tempSum = 0;
double[]temperature = new double[week];

Console.WriteLine("Please enter the temperature for the week: ");
for (int i = 0; i < week; i++)
{
    temperature[i] = Convert.ToDouble(Console.ReadLine());
    tempSum += temperature[i];
    if(i == 0)
    {
        maxTemp = temperature[i];
        minTemp = temperature[i];
    }
    if(maxTemp < temperature[i])
    {
        maxTemp = temperature[i];
    }
    if (minTemp > temperature[i])
    {
        minTemp = temperature[i];
    }
}

double averageTemp = tempSum / week;
Console.WriteLine($"Max temperature: {maxTemp}, min temperature: {minTemp}, average temperature: {averageTemp}");

