using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw9_2
{
    class Program
    {
        class Course
        {
            public string Name { get; set; }     // 姓名屬性          
            public bool Status { get; set; }       // 本系生屬性
            public int Score { get; set; }          // 計概成績屬性           
        }

        static void Main(string[] args)
        {
            Dictionary<string, Course> bb = new Dictionary<string, Course>();  //宣告泛型堆疊

            int num;
            int aa;
            string sname;
            int i;
            Console.Write("請輸入學生人數:");
            num = int.Parse(Console.ReadLine());

            Course[] a = new Course[num];

            for (i = 0; i < num; i++)
            {
                a[i] = new Course();  //陣列實體化
                Console.Write("第{0}位學生姓名:", i + 1);
                a[i].Name = Console.ReadLine();
                Console.Write("是否為本系生(1)是(2)否:");
                aa = int.Parse(Console.ReadLine());
                if (aa == 1)
                {
                    a[i].Status = true;
                }
                else if (aa == 2)
                {
                    a[i].Status = false;
                }
                while (aa < 1 || aa > 2)
                {
                    Console.Write("輸入錯誤重新輸入\n");
                    aa = int.Parse(Console.ReadLine());
                }
                Console.Write("計概成績為:");
                a[i].Score = int.Parse(Console.ReadLine());
                Console.WriteLine();
                bb.Add(a[i].Name, new Course() { Name = a[i].Name, Status = a[i].Status, Score = a[i].Score });



            }
            //泛型陣列操作

            foreach (KeyValuePair<string, Course> item in bb)
            {
                Console.WriteLine("  姓名 : {0} \t 本系生 : {1}  \t  計概成績 : {2}  \n", item.Key, item.Value.Status ? "是" : "非", item.Value.Score);
                Console.WriteLine();

            }

            Console.Write("請輸入想查詢的學生姓名:");
            sname = Console.ReadLine();
            if (bb.ContainsKey(sname))
                Console.WriteLine("  學生姓名 : {0} \t 本系生 : {1}  \t  計概成績 : {2}  \n", bb[sname].Name, bb[sname].Status ? "是" : "非", bb[sname].Score);
            else
                Console.WriteLine("{0}不存在!!", sname);




            Console.Read();
        }
        }
}
