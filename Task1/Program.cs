using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }

        static public void Print()
        {
            DateTime dateTime = new DateTime();

            Console.WriteLine($"Attributes: {GetPropertyInfo(dateTime, "DayOfWeek").Attributes}");
            Console.WriteLine($"CanRead: {GetPropertyInfo(dateTime, "DayOfWeek").CanRead}");
            Console.WriteLine($"CanWrite: {GetPropertyInfo(dateTime, "DayOfWeek").CanWrite}");
            Console.WriteLine($"CustomAttributes: {GetPropertyInfo(dateTime, "DayOfWeek").CustomAttributes}");
            Console.WriteLine($"DeclaringType: {GetPropertyInfo(dateTime, "DayOfWeek").DeclaringType}");
            Console.WriteLine($"IsSpecialName: {GetPropertyInfo(dateTime, "DayOfWeek").IsSpecialName}");
            Console.WriteLine($"GetMethod: {GetPropertyInfo(dateTime, "DayOfWeek").GetMethod}");
            Console.WriteLine($"GetValue: {GetPropertyInfo(dateTime, "DayOfWeek").GetValue(dateTime, null)}");
            Console.WriteLine($"MemberType: {GetPropertyInfo(dateTime, "DayOfWeek").MemberType}");
            Console.WriteLine($"MetadataToken: {GetPropertyInfo(dateTime, "DayOfWeek").MetadataToken}");
            Console.WriteLine($"Module: {GetPropertyInfo(dateTime, "DayOfWeek").Module}");
            Console.WriteLine($"Name: {GetPropertyInfo(dateTime, "DayOfWeek").Name}");
            Console.WriteLine($"PropertyType: {GetPropertyInfo(dateTime, "DayOfWeek").PropertyType}");
            Console.WriteLine($"ReflectedType: {GetPropertyInfo(dateTime, "DayOfWeek").ReflectedType}");
            Console.WriteLine($"SetMethod: {GetPropertyInfo(dateTime, "DayOfWeek").SetMethod}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Это приложение выводит все свойства структуры DateTime.");
            Console.WriteLine("Вывод будет осужествлен с помощью рефлексии\n");
            Print();

            Console.ReadKey();
        }
    }
}
