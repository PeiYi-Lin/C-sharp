using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8_3
{
    class student
    {
        public string id;
        public string sname;
        private int _chi;
        public int chi  //存取範圍為1到100
        {
            get
            {
                return _chi;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    _chi = value;
                }
                else
                {
                    Console.WriteLine("輸入錯誤，分數應介於1到100之間");
                    Console.WriteLine("3.國文:{0}", _chi);
                    _chi = value;
                }
            }
        }
        private int _eng;
        public int eng   //存取範圍為1到100
        {
            get
            {
                return _eng;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    _eng = value;
                }
                else
                {
                    Console.WriteLine("輸入錯誤，分數應介於1到100之間");
                    Console.WriteLine("4.英文:{0}", _eng);
                    _eng = value;
                }
            }
        }
        private int _bcc;
        public int bcc   //存取範圍為1到100
        {
            get
            {
                return _bcc;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    _bcc = value;
                }
                else
                {
                    Console.WriteLine("輸入錯誤，分數應介於1到100之間");
                    Console.WriteLine("5.計概:{0}", _bcc);
                    _bcc = value;
                }
            }
        }

        public double GetAvg(int chi, int eng, int bcc)   //取得平均分數
        {
            return (chi + eng + bcc) / 3; 
        }
        
        public static int Num { get; set; }  //Num靜態屬性，紀錄建立的學生人數
       
       
        
        public void GetStudentNum(string sname, string id, int _chi, int _eng, int _bcc, double GetAvg) //static方法
        {
            Console.WriteLine("1.學生姓名:{0}", sname);
            Console.WriteLine("2.學號:{0}", id);
            Console.WriteLine("3.國文:{0}", _chi);
            Console.WriteLine("4.英文:{0}", _eng);
            Console.WriteLine("5.計概:{0}", _bcc);
            Console.WriteLine("6.平均成績:{0}\n", GetAvg);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.Write("請輸入要建立的學生人數:");
            student.Num= int.Parse(Console.ReadLine());
            student[] stu = new student[student.Num];
            for(int i = 0; i < student.Num; i++)
            {
                stu[i] = new student(); //建立物件陣列實體
                Console.WriteLine();
                Console.Write("目前建立 第{0}位 學生", i + 1);
                Console.WriteLine();
                Console.Write("1.學號:");
                stu[i].id = Console.ReadLine();
                Console.Write("2.姓名:");
                stu[i].sname = Console.ReadLine();
                Console.Write("3.國文:");
                stu[i].chi = int.Parse(Console.ReadLine());
                Console.Write("4.英文:");
                stu[i].eng = int.Parse(Console.ReadLine());
                Console.Write("5.計概:");
                stu[i].bcc = int.Parse(Console.ReadLine());
                Console.WriteLine();
              
            }
            Console.WriteLine("---------------------------------------------------");
            Console.Write("請問要尋找哪位學生(以姓名尋找):");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("尋找資料如下:");
            Console.WriteLine();

            int a = 0;
            for (a = 0; a < student.Num; a++)  //以建立的學生人數為上限去查詢
            {
                if (name == stu[a].sname)
                {
                    stu[a].GetStudentNum(stu[a].sname, stu[a].id,stu[a].chi,stu[a].eng,stu[a].bcc,stu[a].GetAvg(stu[a].chi,stu[a].eng,stu[a].bcc));
                    break;
                }            
            }
            if (a== student.Num) {
                Console.WriteLine("找不到 {0} 學生的資料......", name);   //若已全部搜尋完畢，依然沒有則顯示找不到
            }
            Console.WriteLine("目前共建立 {0}位 學生的資料 !!", student.Num);
            Console.Read();
        }
    }
}
