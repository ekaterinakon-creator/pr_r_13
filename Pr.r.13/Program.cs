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
        static void Main(string[] args)
        {
            while (true)
            {
                try // поиск ошибок
                {
                    string word;
                    Console.Title = "Практическая работа № 13";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Clear();
                    Console.WriteLine("Здравствуйте!");
                    Console.Write("Введите слово: ");
                    word = Convert.ToString(Console.ReadLine());
                    if (string.IsNullOrWhiteSpace(word))
                    {
                        throw new Exception("вы ничего не ввели! Попробуйте еще раз.");
                    }
                    bool number = false;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (char.IsLetter(word[i]))
                        {
                            number = true;
                        }
                    }
                    if (number == false)
                    {
                        throw new Exception("Это не слово!");
                    }
                    word = word.ToLower();
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
                    bool rightChoice = false;
                    while (rightChoice == false)
                    {
                        byte choice;
                        Console.Write("Вы хотите повторить программу? (Да - 1 / нет - 0): ");
                        choice = Convert.ToByte(Console.ReadLine());
                        switch (choice)
                        {
                            case 0:
                                return;
                            case 1:
                                rightChoice = true;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Вы ввели не то число! Попробуйте снова.");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
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
