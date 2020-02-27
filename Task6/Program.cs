using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Класс с вспомогательными методами, которые могут пригодиться учебе.
namespace Lesson1
{
    //Печать текста в центре окна, с переносом курсора на следующую строку, для следующего текста. 
    public static class PrintCenter
    {
        static int nextStr = new int();
        public static void Print(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth / 2) - (text.Length / 2), (Console.WindowHeight + nextStr) / 2);
            Console.WriteLine(text);
            nextStr += 2;
        }

        //Для задержки окна
        public static void Pause()
        {
            Console.ReadKey();
        }

        //Проверка на ввод цифр в анкету
        public static bool ContainOnlyDigits(string input)
        {
            if (Regex.IsMatch(input, @"[0-9]"))
            {
                return true;
            }
            return false;
        }
        //Проверка на ввод символов в анкету
        public static bool ContainOnlyCharacter(string input)
        {
            if (Regex.IsMatch(input, @"[А-Яа-яA-Za-z]"))
            {
                return true;
            }
            return false;
        }


        static void Main() {}
    }
}