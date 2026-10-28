//***********************************************************************
//* Практическая работа № 13                                            *
//* Выполнила: Кондратюк Е.С., группа 2ИСП                              *
//* Задание: Высокоуровневые языки програмирования                      *
//***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr.r._13
{
    internal class Program
    {
        static bool Palindrome(string palindrome)
        {
            if (palindrome.Length <= 1)
            {  return true; }
            if (palindrome.Length > 1)
            {

            }

            return Palindrome(palindrome );
        }
        static void HandleError(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: " + ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main(string[] args)
        {


            while (true)
            {
                try // поиск ошибок
                {
                    string word;
                    Console.Title = "Практическая работа № 10";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Clear();
                    Console.WriteLine("Здравствуйте!");
                    Console.Write("Введите слово: ");
                    word = Convert.ToString(Console.ReadLine());

                }
                catch (FormatException fex)
                {
                    HandleError(fex);
                }
                catch (OverflowException oex)
                {
                    HandleError(oex);
                }
                catch (Exception ex)
                {
                    HandleError (ex);
                }
            }
        }


    }
}
