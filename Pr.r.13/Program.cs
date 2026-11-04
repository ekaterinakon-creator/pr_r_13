//***********************************************************************
//* Практическая работа № 13                                            *
//* Выполнила: Кондратюк Е.С., группа 2ИСП                              *
//* Задание: Высокоуровневые языки програмирования                      *
//***********************************************************************
using System;
namespace Pr.r._13
{
    internal class Program
    {
        static bool Palindrome(string word, int left, int right)
        {
            if (left >= right)
            {
                return true;
            }
            if (word[left] != word[right])
            {
                return false;
            }
            return Palindrome(word, left + 1, right - 1);
        }
        static void HandleError(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: " + ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
        static string Info()
        {
            Console.Title = "Практическая работа № 13";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            string word;
            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите слово: ");
            word = Convert.ToString(Console.ReadLine());
            return CheckWord(word);
        }
        static string CheckWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new Exception("вы ничего не ввели! Попробуйте еще раз.");
            }
            bool number = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsLetter(word[i]))
                {
                    number = false;
                    break;
                }
            }
            if (number == false)
            {
                throw new Exception("Это не слово!");
            }
            return word.ToLower();
        }
        static bool AskToRepeat()
        {
            while (true)
            {
                try 
                {
                    byte choice;
                    Console.Write("Вы хотите повторить программу? (Да - 1 / нет - 0): ");
                    choice = Convert.ToByte(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:

                            return false;
                        case 1:

                            return true;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели не то число! Попробуйте снова.");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
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
                    HandleError(ex);
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try 
                {
                    string word = Info();
                    int left = 0, right = word.Length - 1;
                    bool result = Palindrome(word, left, right);
                    if (result == true)
                    {
                        Console.WriteLine($"Слово {word} является палиндромом!");
                    }
                    else
                    {
                        Console.WriteLine($"Слово {word} НЕ является палиндромом!");
                    }
                    if (AskToRepeat() == false)
                    {
                        return; 
                    }
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
                    HandleError(ex);
                }
            }
        }
    }
}

