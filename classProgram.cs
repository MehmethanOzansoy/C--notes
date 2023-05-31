using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        // Program(){
        // default
        // }
        static void Main(string[] args)
        {

            Calısan calısan = new Calısan();

            calısan.Ad = "Can";
            calısan.Soyad = "Yaman";
            calısan.No = 545;
            calısan.Departman = "Bilgi işlem";
            calısan.CalisanBilgileri();

            System.Console.WriteLine("************** Calışan **************");

            Student student = new Student("Ali", "Yılmaz", 33);

            student.getInfo();
        }
    }

    class Calısan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public void CalisanBilgileri()
        {
            System.Console.WriteLine("Çalışan adı:{0}", Ad);
            System.Console.WriteLine("Çalışan soyadı:{0}", Soyad);
            System.Console.WriteLine("Çalışan id:{0}", No);
            System.Console.WriteLine("Çalışan departman:", Departman);
        }
    }

    class Student
    {
        // public Student()
        // {
        //     // without parametre
        // }

        public string name;
        public string surname;
        public int age;

        public Student(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public Student()
        {

        }

        public void getInfo()
        {
            System.Console.WriteLine("Name: {0} ",name);
            System.Console.WriteLine("Surname: {0} ",surname);
        }

        
    }
}