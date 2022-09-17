using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Runtime.CompilerServices;

internal class Program
{
    static bool check(string Stroka)
    {
        foreach (char c in Stroka)
        {
            if (int.TryParse(c.ToString(), out var bar) || c == ' ' || c == '\\' || c == '.')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        Console.SetBufferSize(200, 30);
        Console.Write("Введите цифры от 0 до 9 включая пробел,точку,запятуя: ");
        var print = Console.ReadLine();
        if (!check(print))
        {
            Console.WriteLine("Неверный ввод");
        }
        else
        {
            var Razmer = print.Length;
            var SizeX = Razmer * 12;
            var SizeY = 8;
            var x = (Console.WindowWidth / 2) - (SizeX / 2);
            var y = (Console.WindowHeight / 2) - (SizeY / 2);
            foreach (char c in print)
            {
                switch (c)
                {
                    case ('0'):
                        Console.SetCursorPosition(x, y);
                        string[] number0 =
                              {" ████████   ",
                               "██      ██  ",
                               "██      ██  ",
                               "██      ██  ",
                               "██      ██  ",
                               "██      ██  ",
                               " ████████   "};
                        for (int i = 0; i < number0.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(number0[i]);
                        }
                        x += 12;
                        y = (Console.WindowHeight / 2) - (SizeY / 2);
                        break;
                    case ('1'):
                        Console.SetCursorPosition(x, y);
                        string[] number1 =
                              {"   ███      ",
                               "██████      ",
                               "█   ██      ",
                               "    ██      ",
                               "    ██      ",
                               "    ██      ",
                               "██████████  "};
                        for (int i = 0; i < number1.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(number1[i]);
                        }
                        x += 12;
                        y = (Console.WindowHeight / 2) - (SizeY / 2);
                        break;
                    case ('2'):
                        Console.SetCursorPosition(x, y);
                        string[] number2 =
                              {" ███████   ",
                               "██     ██  ",
                               "      ███  ",
                               "    ███    ",
                               "  ███      ",
                               "███        ",
                               "█████████  "};
                        for (int i = 0; i < number2.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(number2[i]);
                        }
                        x += 12;
                        y = (Console.WindowHeight / 2) - (SizeY / 2);
                        break;
                    case ('3'):
                        Console.SetCursorPosition(x, y);
                        string[] number3 =
                              {" ████████   ",
                               "██      ██  ",
                               "        ██  ",
                               "    ████    ",
                               "        ██  ",
                               "██      ██  ",
                               " ████████   "};
                        for (int i = 0; i < number3.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(number3[i]);
                        }
                        x += 12;
                        y = (Console.WindowHeight / 2) - (SizeY / 2);
                        break;
                    case ('4'):
                        Console.SetCursorPosition(x, y);
                        string[] number4 =
                              {"    ██████  ",
                               "   ███  ██  ",
                               "  ███   ██  ",
                               "████    ██  ",
                               "██████████  ",
                               "        ██  ",
                               "        ██  "};
                        for (int i = 0; i < number4.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(number4[i]);
                        }
                        x += 12;
                        y = (Console.WindowHeight / 2) - (SizeY / 2);
                        break;
                    case ('5'):
                        Console.SetCursorPosition(x, y);
                        string[] number5 =
                              {"██████████  ",
                               "██          ",
                               " ████████   ",
                               "        ██  ",
                               "        ██  ",
                               "██      ██  ",
                               " ████████   "};
                        for (int i = 0; i < number5.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(number5[i]);
                        }
                        x += 12;
                        y = (Console.WindowHeight / 2) - (SizeY / 2);
                        break;
                    case ('6'):
                        Console.SetCursorPosition(x, y);
                        string[] number6 =
                              {" ████████   ",
                               "██      ██  ",
                               "██          ",
                               "█████████   ",
                               "██      ██  ",
                               "██      ██  ",
                               " ████████   "};
                        for (int i = 0; i < number6.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(number6[i]);
                        }
                        x += 12;
                        y = (Console.WindowHeight / 2) - (SizeY / 2);
                        break;
                    case ('7'):
                        Console.SetCursorPosition(x, y);
                        string[] number7 =
                              {"█████████  ",
                               "       ██  ",
                               "     ███   ",
                               "    ███    ",
                               "   ███     ",
                               "  ███      ",
                               "  ███      "};
                        for (int i = 0; i < number7.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(number7[i]);
                        }
                        x += 12;
                        y = (Console.WindowHeight / 2) - (SizeY / 2);
                        break;
                    case ('8'):
                        Console.SetCursorPosition(x, y);
                        string[] number8 =
                              {" ████████   ",
                               "██      ██  ",
                               "██████████  ",
                               " ████████   ",
                               "██      ██  ",
                               "██      ██  ",
                               " ████████   "};
                        for (int i = 0; i < number8.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(number8[i]);
                        }
                        x += 12;
                        y = (Console.WindowHeight / 2) - (SizeY / 2);
                        break;
                    case ('9'):
                        Console.SetCursorPosition(x, y);
                        string[] number9 =
                              {" ████████   ",
                               "██      ██  ",
                               "██      ██  ",
                               "  ████████  ",
                               "        ██  ",
                               "██      ██  ",
                               " ████████   "};
                        for (int i = 0; i < number9.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(number9[i]);
                        }
                        x += 12;
                        y = (Console.WindowHeight / 2) - (SizeY / 2);
                        break;
                    case (' '):
                        Console.SetCursorPosition(x, y);
                        string[] probel =
                              {"            ",
                               "            ",
                               "            ",
                               "            ",
                               "            ",
                               "            ",
                               "            "};
                        for (int i = 0; i < probel.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(probel[i]);
                        }
                        x += 12;
                        y = (Console.WindowHeight / 2) - (SizeY / 2);
                        break;
                    case (','):
                        Console.SetCursorPosition(x, y);
                        string[] zapyataya =
                              {"            ",
                               "            ",
                               "            ",
                               "            ",
                               "            ",
                               "    ████    ",
                               "      ██    ",
                               "     ██    ",
                               "    ██      "};
                        for (int i = 0; i < zapyataya.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(zapyataya[i]);
                        }
                        x += 12;
                        y = (Console.WindowHeight / 2) - (SizeY / 2);
                        break;
                    case ('.'):
                        Console.SetCursorPosition(x, y);
                        string[] tochka =
                              {"            ",
                               "            ",
                               "            ",
                               "            ",
                               "            ",
                               "    ███     ",
                               "    ███     "};
                        for (int i = 0; i < tochka.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(tochka[i]);
                        }
                        x += 12;
                        y = (Console.WindowHeight / 2) - (SizeY / 2);
                        break;
                }
            }
            Console.ReadKey();
        }
        Console.WriteLine("\n\n\n\n\n\n\n\n");
    }
}