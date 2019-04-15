using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 调用方法判断两个整数之间的最大值
            //int max = GetMax(222, 1111111);
            //Console.WriteLine(max);
            #endregion


            //#region 数组排序

            //int[] numbers = { 1, 2, 5, 6, 7, 8, 222, 33, 4, 5 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //#endregion



            //int max = GetMax1(121, 23131);
            //Console.WriteLine(max);

            //bool b = IsRun(2000);
            //Console.WriteLine(b);


            //while (true)
            //{
            //    Console.WriteLine("请输入一个数字");

            //    try
            //    {
            //        int a = int.Parse(Console.ReadLine());
            //        Console.WriteLine(a);
            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入有误");

            //    }
            //}
            //Console.ReadKey();



            ////写一个方法，判断用户是否输入的是正整数。
            //Console.WriteLine("请输入一个数字");
            //string s = Console.ReadLine();
            //int number = IsZhengShu(s);
            //Console.WriteLine(number);
            //Console.ReadKey();



            ////写一个方法，限定用户只能输入yes或者no。
            //Console.WriteLine("请输入yes或者no");
            //string str = Console.ReadLine();
            //string result = IsYesOrNo(str);
            //Console.WriteLine(result);
            //Console.ReadKey();


            ////写一个方法，求一个数组中值的合计。
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int sum = GetSum(nums);
            //Console.WriteLine(sum);
            //Console.ReadKey(); 



            ////写一个方法，求一个数组中的最大值、最小值、总和和平均值。
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] result = GetMaxMinSumAvg(nums);
            //Console.WriteLine("最大值为{0}", result[0]);
            //Console.WriteLine("最小值为{0}", result[1]);
            //Console.WriteLine("合计为{0}", result[2]);
            //Console.WriteLine("平均值为{0}", result[3]);

            ////用方法来实现：有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串。
            //string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string a = GetLongest(names);
            //Console.WriteLine(a);
            //Console.ReadKey();



            ////写一个方法，求一个数组中的最大值、最小值、总和和平均值。
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int max1;
            //int min1;
            //int sum1;
            //int avg1;
            //double d1;
            //string s1;
            //bool b1;
            //Test(nums, out max1, out min1, out sum1, out avg1,out d1,out s1,out b1);
            //Console.WriteLine(max1);
            //Console.WriteLine(min1);
            //Console.WriteLine(sum1);
            //Console.WriteLine(avg1);
            //Console.WriteLine(d1);
            //Console.WriteLine(s1);
            //Console.WriteLine(b1);

            ////写一个方法，判断用户输入的用户名和密码是否正确，并返回登录结果，登录信息。
            //Console.WriteLine("请输入用户名");
            //string user1 = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string pwd1 = Console.ReadLine();
            //bool b1;
            //string s1;
            //IsLogin(user1, pwd1, out b1, out s1);
            //Console.WriteLine("登录结果{0}",b1);
            //Console.WriteLine("登录信息{0}",s1);


            ////自己动手写一个tryparse函数
            //string a = "111";
            //int res;
            //bool b = int.TryParse(a, out res);
            //Console.WriteLine(b);
            //Console.WriteLine(res);

            //int res1;
            //bool b1 = MyTryParse(a, out res1);
            //Console.WriteLine(b1);
            //Console.WriteLine(res1);


            //用方法来实现：请计算出一个整型数组的平均值，保留两位小数。
            //int[] ashuzu = { 1, 2, 7 };
            //double avg = GetAvg(ashuzu);
            //Console.WriteLine(avg);

            //string s = avg.ToString("0.00");
            //Console.WriteLine(s);
            //Console.WriteLine("{0:0.00}", avg);
            //Console.WriteLine(avg);

            //double d = 3.148;
            //Console.WriteLine(d.ToString("0.00"));

            //Console.WriteLine("{0:0.00}", d);


            //Console.ReadKey();


            //写一个方法，用来判断用户输入的数字是不是质数  再写一个方法 要求用户只能输入数字 输入有误就一直让用户输入数字



            //95、接受输入后判断其等级并显示出来。判断依据如下：等级 ={优 （90~100分）；良 （80~89分）；中 （60~69分）；差 （0~59分）；}


            //Console.WriteLine("请输入数字");
            //int number = int.Parse(Console.ReadLine());
            //GetDengJi(number);

            //string dengji = GetLevel(number);
            //Console.WriteLine(dengji);


            ////97、请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转

            //string[] str = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            //string[] a = FanZhuan(str);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);

            //}



            //98、写一个方法 计算圆的面积和周长  面积是 pI*R*R  周长是 2*Pi*r

            //Console.WriteLine("请输入圆的半径");
            //try
            //{
            //    double r = double.Parse(Console.ReadLine());
            //    double[] result = MianJi_ZhouChang(r);
            //    for (int i = 0; i < result.Length; i++)
            //    {
            //        Console.WriteLine("面积是{0}，周长是{1}。", result[0].ToString("0.00"), result[1].ToString("0.00"));
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("输入有误，请重新输入");
            //}

            double r = 4;
            double perimeter;
            double area;
            GetPerimeterArea(r, out perimeter, out area);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);







            Console.ReadKey();
        }













        /// <summary>
        /// 返回两个整数之间的最大值
        /// </summary>
        /// <param name="第一个整数"></param>
        /// <param name="第二个整数"></param>
        /// <returns>返回的最大值</returns>
        public static int GetMax(int n1, int n2)
        {

            return n1 > n2 ? n1 : n2;
        }



        /// <summary>
        /// 判断给定的值是否为闰年
        /// </summary>
        /// <param name="输入的年份"></param>
        /// <returns>是否为闰年</returns>
        public static bool IsRun(int year)
        {
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return b;
        }



        /// <summary>
        /// 限定用户只能输入整数
        /// </summary>
        /// <param name="input">用户的输入</param>
        /// <returns>返回的整数</returns>
        public static int IsZhengShu(string input)
        {
            while (true)
            {
                try
                {
                    int a = int.Parse(input);
                    return a;
                }
                catch
                {
                    Console.WriteLine("输入有误");
                    input = Console.ReadLine();
                }
            }
        }


        /// <summary>
        /// 限定用户只能输入yes或者no
        /// </summary>
        /// <param name="input">用户的输入</param>
        /// <returns>返回yes 或者 no </returns>
        public static string IsYesOrNo(string input)
        {
            while (true)
            {
                if (input == "yes" || input == "no")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("只能输入yes或者no，请重新输入。。。");
                    input = Console.ReadLine();
                }
            }
        }


        /// <summary>
        /// 一个整数类型数组的总和
        /// </summary>
        /// <param name="nums">要求总和的数组</param>
        /// <returns>返回数组的总和</returns>
        public static int GetSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        /// <summary>
        /// 计算一个数组的最大值、最小值、总和、平均值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] GetMaxMinSumAvg(int[] nums)
        {

            int[] res = new int[4];
            res[0] = nums[0];
            res[1] = nums[0];
            res[2] = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > res[0]) //最大值
                {
                    res[0] = nums[i];
                }
                if (nums[i] < res[1])  //最小值
                {
                    res[1] = nums[i];
                }
                res[2] += nums[i];
            }
            res[3] = res[2] / nums.Length;
            return res;
        }

        /// <summary>
        /// 输出一个数组中最长字符串的值。
        /// </summary>
        /// <param name="input">输入的数组</param>
        /// <returns>返回数组中最长字符串的值</returns>
        public static string GetLongest(string[] input)
        {
            string clen = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > clen.Length)
                {
                    clen = input[i];
                }
            }
            return clen;
        }

        /// <summary>
        /// 计算一个整数数组的最大值、最小值、总合、平均值
        /// </summary>
        /// <param name="nums">要求值的数组</param>
        /// <param name="max">多余返回的最大值</param>
        /// <param name="min">多余返回的最小值</param>
        /// <param name="sum">多余返回的总合</param>
        /// <param name="avg">多余返回的平均值</param>
        public static void Test(int[] nums, out int max, out int min, out int sum, out int avg, out double d, out string s, out bool b)
        {
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;
            d = 3.14;
            s = "123";
            b = true;
        }

        /// <summary>
        /// 判断用户登陆信息是否正确，并且返回登陆信息及错误信息。
        /// </summary>
        /// <param name="user">用户输入的用户名</param>
        /// <param name="pwd">用户输入的密码</param>
        /// <param name="b">登陆信息</param>
        /// <param name="s">错误信息</param>
        public static void IsLogin(string user, string pwd, out bool b, out string s)
        {

            if (user == "admin" && pwd == "admin")
            {
                b = true;
                s = "登录成功";
            }
            else if (user == "admin")
            {
                b = false;
                s = "密码错误。。。";
            }
            else if (pwd == "admin")
            {
                b = false;
                s = "用户名错误。。。";
            }
            else
            {
                b = false;
                s = "未知错误。。。";
            }
        }


        /// <summary>
        /// 自己写一个tryparse函数
        /// </summary>
        /// <param name="要转换的值"></param>
        /// <param name="转换后的结果"></param>
        /// <returns>转换结果（失败还是成功）</returns>
        public static bool MyTryParse(string input, out int num)
        {
            num = 0;

            try
            {
                num = int.Parse(input);
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 计算一个数组的平均值
        /// </summary>
        /// <param name="numbers">要计算的数组</param>
        /// <returns>返回的平均值</returns>
        public static double GetAvg(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum / numbers.Length;
        }


        //public static bool IsZhiShu(int n)
        //{




        //}

        /// <summary>
        /// 根据输入的数字显示等级
        /// </summary>
        /// <param name="score">输入的数字</param>
        //95、接受输入后判断其等级并显示出来。判断依据如下：等级 ={优 （90~100分）；良 （80~89分）；中 （60~69分）；差 （0~59分）；}
        public static void GetDengJi(int score)
        {
            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("优");
            }
            else if (score >= 80 && score < 90)
            {
                Console.WriteLine("良");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("中");
            }
            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("差");
            }
            else
            {
                Console.WriteLine("不及格");
            }
        }


        public static string GetLevel(int score)
        {
            string level = "";
            switch (score / 10)
            {
                case 10:
                case 9: level = "优"; break;
                case 8: level = "良"; break;
                case 7: level = "中"; break;
                case 6: level = "差"; break;
                default:
                    level = "不及格";
                    break;
            }
            return level;

        }

        /// <summary>
        /// 反转数组中的值
        /// </summary>
        /// <param name="str">要反转的数组</param>
        /// <returns>反转后的数组</returns>
        public static string[] FanZhuan(string[] str)
        {
            string[] temp = new string[str.Length];

            for (int i = str.Length; i > 0; i--)
            {
                temp[str.Length - i] = str[i - 1];

            }
            return temp;

        }


        /// <summary>
        /// 计算圆的面积和周长
        /// </summary>
        /// <param name="r">圆的半径</param>
        /// <returns>返回圆的面积和周长</returns>
        //98写一个方法 计算圆的面积和周长  面积是 pI*R* R  周长是 2*Pi* r
        public static double[] MianJi_ZhouChang(double r)
        {

            double pi = 3.14;
            double[] jieguo = new double[2];
            jieguo[0] = pi * r * r; //面积
            jieguo[1] = 2 * pi * r; //周长
            return jieguo;
        }



        public static void GetPerimeterArea(double r, out double perimeter, out double area)
        {
            perimeter = 2 * 3.14 * r;
            area = 3.14 * r * r;

        }



    }
}

