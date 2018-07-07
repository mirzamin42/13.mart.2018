using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_03_2018_oop_crud_console_app
{
    class Student
    {
        public static string Login = "admin";
        public static string Parol = "admin";
        public static List<Student> db = new List<Student>();
        public static int Count = 1;
        public int ID;
        public string Name;
        public string Surname;
        public int Age;
        public Student(string _name, string _surname, int _age)
        {
            Name = _name;
            Surname = _surname;
            Age = _age;
            db.Add(this);


        }

        public static void Instructions()
        {
            Console.WriteLine("1. Yeni telebe elave et");
            Console.WriteLine("2. Telebeleri gor");
            Console.WriteLine("3. Telebe melumatlarini deyis");
            Console.WriteLine("4. Telebeni sil");
            Console.WriteLine("5. Telebe ile bagli xususiyyetleri gor");
            Console.WriteLine("6. Proqramdan cix");
            Console.WriteLine("***********************");
            Console.WriteLine("Emri sec qadam");
            var emr = Convert.ToInt32(Console.ReadLine());
            if (emr == 1)
            {
                Create();
            }
            else if (emr == 2)
            {
                Read();
            }
            else if (emr == 3)
            {
                Update();
            }
            else if (emr == 4)
            {
                Delete();
            }
            else if (emr == 5)
            {
                Details();
            }
            else if (emr == 6)
            {
                Exit();
            }
            else
            {
                Console.WriteLine("Emr nomresi duzgun deyil");
            }
        }
        public static void Create()
        {

            Console.Write("Telebe adini daxil edin: ");
            var name = Console.ReadLine();

            Console.Write("Telebe soyadini daxil edin: ");
            var surname = Console.ReadLine();

            Console.Write("Telebe yasini daxil edin: ");
            var age = Convert.ToInt32(Console.ReadLine());


            Student telebe = new Student(name, surname, age);
            telebe.ID = Count;
            //db.Add(telebe);
            Count++;
            Instructions();


        }

        public static void Read()
        {
            foreach (var item in Student.db)
            {
                Console.WriteLine(item.ID + "-" + item.Name + "-" + item.Surname + "-" + item.Age);
            }
            Console.WriteLine("Admin paneline kecmek isteyirsinizse login ve parolu daxil edin :");
            var login = Console.ReadLine();
            var parol = Console.ReadLine();
            if (login == Student.Login && parol == Student.Parol)
            {
                Instructions();
            }
            else
            {
                Console.WriteLine("Teesuf edirik, siz sadece bu emeliyyati icra ede bilersiniz");
            }

            //Instructions();
        }

        public static void Update()
        {
            Console.WriteLine("Deyiwmek istediyiniz Elementin  ID - sini Yazin");

            foreach (var item in Student.db)
            {
                Console.WriteLine(item.ID + "-" + item.Name + "-" + item.Surname + "-" + item.Age);
            }

            var chooseId = Convert.ToInt32(Console.ReadLine());

            foreach (var item in db)
            {
                if (item.ID == chooseId)
                {
                    Console.WriteLine("Yeni Adi Daxil Edin");
                    var ad = Console.ReadLine();
                    Console.WriteLine("Yeni soyadi Daxil Edin");
                    var soyad = Console.ReadLine();
                    Console.WriteLine("Yeni Yawi Daxil Edin");
                    var yaw = Convert.ToInt32(Console.ReadLine());

                    item.Name = ad;
                    item.Surname = soyad;
                    item.Age = yaw;

                    Read();

                }
            }
        }

        public static void Delete()
        {
            Console.WriteLine("Silmek istediyiniz telebenin id deyerini daxil edin : ");
            var _id = Convert.ToInt32(Console.ReadLine());
            foreach (var item in db)
            {
                if (item.ID == _id)
                {
                    db.Remove(item);
                    break;
                }
            }
            Instructions();
        }

        public static void Details()
        {
            Console.WriteLine("Detalli melumatini gormek istediyiniz telebenin id deyerini daxil edin : ");
            var _id = Convert.ToInt32(Console.ReadLine());

            foreach (var item in db)
            {
                if (item.ID == _id)
                {
                    Console.WriteLine(" Telebe adi : {0} ", item.Name);
                    Console.WriteLine(" Telebe soyadi : {0} ", item.Surname);
                    Console.WriteLine(" Telebe yasi : {0} ", item.Age);
                }
            }
            Console.WriteLine("Admin paneline kecmek isteyirsinizse login ve parolu daxil edin :");
            Console.WriteLine("Zehmet olmasa 'login'i daxil edin : ");
            var login = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Zehmet olmasa 'parol'u daxil edin : ");
            var parol = Console.ReadLine();
            if (login == Student.Login && parol == Student.Parol)
            {
                Instructions();
            }
            else
            {
                Console.WriteLine("Teesuf edirik, siz sadece bu emeliyyati icra ede bilersiniz");
            }
            //Instructions();
        }

        public static void Exit()
        {
            Console.WriteLine("Cixmaq ucun 4 yazin");
            Environment.Exit(4);
        }
    }
}
