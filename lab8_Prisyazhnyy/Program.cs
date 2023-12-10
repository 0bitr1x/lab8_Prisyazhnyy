//сборник задач/тема 8/средний уровень/вариант 13
using System;
using System.Threading.Channels;

try
{
    Console.Write("Введите количество каналов: ");
    int n = int.Parse(Console.ReadLine());
    Studios[] studList = new Studios[n];
    for(int i = 0; i < n; i++)
    {
        if (n > 1) Console.WriteLine($"канал {i + 1})");
        Console.Write("название канала: ");
        studList[i].name = Console.ReadLine();
        Console.Write("планируемая дата проведения профилактики DD.MM.YYYY : ");
        studList[i].datePlan = DateOnly.Parse(Console.ReadLine());
        Console.Write("время начала профилактических работ HH:MM : ");
        studList[i].startTime = TimeOnly.Parse(Console.ReadLine());
        Console.Write("время окончания профилактики HH:MM : ");
        studList[i].endTime = TimeOnly.Parse(Console.ReadLine());
    }
    Console.WriteLine();
    for (int i = 0;i < studList.Length; i++)
    {
        if (n > 1) Console.WriteLine($"канал {i+1})");
        Console.WriteLine($"название канала: {studList[i].name}");
        Console.WriteLine($"длительность профилактических работ в минутах: {(studList[i].endTime - studList[i].startTime).TotalMinutes}");
    }
    Console.WriteLine();
    Console.WriteLine("каналы время профилактики которых (с 22:00 до 6:00)");
    for (int i = 0;i < n ; i++)
    {
        TimeOnly minTime = new TimeOnly(22,00);
        TimeOnly maxTime = new TimeOnly(6, 00);
        if (studList[i].startTime >= minTime && studList[i].endTime <= maxTime)
        {
            if (n > 1) Console.WriteLine($"канал {i + 1})");
            Console.WriteLine($"канал: {studList[i].name}");
            Console.WriteLine($"дата профилактики: {studList[i].datePlan}");
            Console.WriteLine($"начало профилактики: {studList[i].startTime}");
            Console.WriteLine($"конец профилактики: {studList[i].endTime}");
        }
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
struct Studios
{
    public string name;
    public DateOnly datePlan;
    public TimeOnly startTime;
    public TimeOnly endTime;
}