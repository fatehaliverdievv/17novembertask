#region 1st task
//namespace _17novembertask
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] nums = { 1, 5, 6, 10, 8 };
//            Console.WriteLine(Min(nums));

//        }
//        static int Min(int[] nums)
//        {
//            int min = nums[0];
//            for (int i = 0; i < nums.Length; i++)
//            {
//                if(nums[i]<min)
//                {
//                    min = nums[i];
//                }
//            }
//            return min;
//        }
//    }
//}
#endregion

#region 2nd task
//namespace _17novembertask
//{

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hansi fiqurun sahesini tapmaq isteyirsiniz ?");
//            Console.WriteLine("1. Chevrenin sahesi");
//            Console.WriteLine("2. Duzbucaqlinin sahesi");
//            Console.WriteLine("3. Duzbucaqli paralelpipedin sahesi");
//            Console.WriteLine("4. Ucbucaqlinin daxiline chekilmis chevrenin sahesi.");
//            int Condition = Convert.ToInt32(Console.ReadLine());
//            switch (Condition)
//            {
//                case 1:
//                    Console.Write("radiusu:");
//                    int r = Convert.ToInt32(Console.ReadLine());
//                    if (r > 0)
//                    {
//                        Console.WriteLine("Sahe : " + Area(r));
//                    }
//                    else
//                    {
//                        Console.WriteLine("Ededleri yanlis daxil etdiniz!");
//                    }
//                    break;
//                case 2:
//                    Console.WriteLine("uzunluq:");
//                    int a = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("en:");
//                    int b = Convert.ToInt32(Console.ReadLine());
//                    if (a > 0 && b >0)
//                    {
//                        Console.WriteLine("Sahe : " + Area(a, b));
//                    }
//                    else
//                    {
//                        Console.WriteLine("Ededleri yanlis daxil etdiniz!");
//                    }
//                    break;
//                case 3:
//                    Console.WriteLine("uzunluq:");
//                    a = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("en:");
//                    b =Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("hundurluk:");
//                    int c = Convert.ToInt32(Console.ReadLine());
//                    if (a > 0 && b > 0 && c>0)
//                    {
//                        Console.WriteLine("Sahe : " + Area(a, b ,c));
//                    }
//                    else
//                    {
//                        Console.WriteLine("Ededleri yanlis daxil etdiniz!");
//                    }
//                    break;
//                case 4:
//                    Console.WriteLine("teref:");
//                    a = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("teref:");
//                    b = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("teref:");
//                    c = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("radius :");
//                    r = Convert.ToInt32(Console.ReadLine());
//                    if (a > 0 && b > 0 && c > 0 && r>0)
//                    {
//                        Console.WriteLine("Sahe : " + Area(a, b ,c,r));
//                    }
//                    else
//                    {
//                        Console.WriteLine("Ededleri yanlis daxil etdiniz!");
//                    }
//                    break;
//                default:
//                    Console.WriteLine("Ele bir shert movcud deyil");
//                    break;
//            }
//        }
//        static int Area(int r)
//        {
//            int p = 3;
//            int S = p * r * r;
//            return S;
//        }
//        static int Area(int a, int b)
//        {
//            int S = a * b;
//            return S;
//        }
//        static int Area(int a, int b, int c)
//        {
//            int S = 2 * (a * b + a * c + b * c);
//            return S;
//        }
//        static int Area(int a, int b, int c, int r)
//        {
//            int p = (a + b + c) / 2;
//            int S = p * r;
//            return S;
//        }
//    }
//}
#endregion

#region classwork A
//namespace _17novembertask
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(kalkulyator(4,3,'+'));
//        }
//        static int kalkulyator(int eded, int eded1, char emel)
//        {
//            switch (emel)
//            {
//                case '*':
//                    return eded * eded1;
//                    break;
//                case '/':
//                    return eded / eded1;
//                    break;
//                case '-':
//                    return eded - eded1;
//                    break;
//                case '+':
//                    return eded + eded1;
//                    break;
//                default:
//                    Console.WriteLine("xeta bash verdi");
//                    return 0;
//                    break;
//            }
//        }
//    }
//}
#endregion

#region classwork B
//namespace _17novembertask
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(pow(1,0));
//        }
//        static int pow(int num, int power =2)
//        {
//            int result = 1;
//            for (int i = 0; i < power; i++)
//            {
//                result*=num;
//            }
//            return result;
//        }
//    }
//}
#endregion

#region classwork C
//namespace _17novembertask
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            printconsole("Elon");
//            printconsole("Elon", "Musk");
//            printconsole("Elon","Musk","Errol");
//        }
//        static void printconsole(string ad)
//        {
//            Console.WriteLine(ad);
//        }
//        static void printconsole(string ad, string soyad)
//        {
//            Console.WriteLine(soyad+" "+ad);
//        }
//        static void printconsole(string ad, string soyad, string ata)
//        {
//            Console.WriteLine(ad[0] +"."+soyad+" "+ata);
//        }
//    }
//}
#endregion