using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Threading.Channels;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace ConsoleApp2
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                // 1. Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
                #region Task1
                //Console.WriteLine("Ededleri daxil edin:"); 
                //int a = Convert.ToInt32(Console.ReadLine());
                //int b = Convert.ToInt32(Console.ReadLine());
                //int c = Convert.ToInt32(Console.ReadLine());
                //if (a > b && a > c)
                //{
                //    Console.WriteLine($"en boyuk eded {a}dir");
                //}
                //else if (b > a && b > c)
                //{
                //    Console.WriteLine($"en boyuk eded {b}dir");
                //}
                //else
                //{
                //    Console.WriteLine($"en boyuk eded {c}dir");
                //}
                #endregion


                #region Task1.1
                //Console.WriteLine("1. ededi daxil et:");
                //int a = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("2. ededi daxil et:");
                //int b = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("3. ededi daxil et:");
                //int c = Convert.ToInt32(Console.ReadLine());

                //if (a > b)
                //{
                //    if (b > c)
                //    {
                //        Console.WriteLine(a);
                //    }
                //    else
                //    {
                //        Console.WriteLine(c);
                //    }
                //}
                //else if (b > c)
                //{
                //    Console.WriteLine(b);
                //}
                //else
                //{
                //    Console.WriteLine(c);
                //}
                #endregion

                // 2. Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram
                #region Task2
                //Console.WriteLine("Metni daxil et: ");
                //string text = Console.ReadLine();

                //bool check = false;
                //for (int i = 0; i < text.Length; i++)
                //{
                //    if (text[i] == 'A')
                //    {
                //        check = true;
                //        break;
                //    }
                //}

                //if (check)
                //{
                //    Console.WriteLine(" A herfi var.");
                //}
                //else
                //{
                //    Console.WriteLine(" A herfi yoxdur.");
                //}
                #endregion

                #region Task2.1
                //Console.WriteLine("metni daxil et: ");
                //string text = Console.ReadLine();
                //Console.WriteLine("Axtarilan herfi daxil et: ");
                //char herf = Convert.ToChar(Console.ReadLine());

                //bool check = false;
                //for(int i = 0; i < text.Length;i++)
                //{
                //    if(text[i]==herf)
                //        check = true;
                //}
                //if (check)
                //{
                //    Console.WriteLine($"{herf} verilmis yazida var");
                //}
                //else
                //{
                //    Console.WriteLine($"{herf} verilmis yazida yoxdur");

                //}
                #endregion

                // 3. Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram

                #region Task3
                //Console.WriteLine("metni daxil et: ");
                //string text = Console.ReadLine();
                //int count = 0;
                //for (int i = 0; i < text.Length; i++)
                //{
                //    if (text[i] == 'A')
                //        count++;
                //}
                //Console.WriteLine(count);

                #endregion

                // 4. Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram.Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir
                #region Task4
                //int num;
                //do
                //{
                //    Console.WriteLine("eded daxil edin:");
                //    num = Convert.ToInt32(Console.ReadLine());
                //}
                //while (num <= 0 || num % 2 != 0);

                //int total = num * num;
                //Console.WriteLine(total);

                #endregion


                // 5. Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram

                #region Task5
                //int[] nums = new int[5];
                //int sum = 0;

                //for (int i = 0; i < 5; i++)
                //{
                //    Console.Write("Eded daxil edin: ");
                //    nums[i] = Convert.ToInt32(Console.ReadLine());
                //    sum += nums[i];
                //}

                //Console.WriteLine(sum);

                #endregion

                #region Task5.1

                //Console.WriteLine("ededlerin sayini daxil et:");
                //int nums = Convert.ToInt32(Console.ReadLine());
                //int[] numlist= new int[nums];
                //int sum = 0;
                //for (int i = 0; i < numlist.Length; i++) ;
                //{
                //    sum += numlist[i];
                //}
                //Console.WriteLine(sum);

                #endregion


                // 6. Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.Əgər verilmiş dəyər "programming"dirsə console-da 400 saat, "design"dırsa 250 saat, "system"dirsə 200 saat, heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.

                #region Task6

                //bool check1;
                //do
                //{
                //    Console.WriteLine("Tehsil novunu daxil edin:");
                //    string tehsilNovu = Console.ReadLine();
                //    check1 = true;

                //    switch (tehsilNovu)
                //    {
                //        case "programming":
                //            Console.WriteLine("400 saat");
                //            break;
                //        case "design":
                //            Console.WriteLine("250 saat");
                //            break;
                //        case "system";
                //            Console.WriteLine("200 saat");
                //            break;
                //        default:
                //            check1 = false;
                //            Console.WriteLine("tehsil novu yanlisdir");
                //            break;
                //    }
                //} while (check1 == false);

                #endregion
            }
        }
    }

        }
    }
}
