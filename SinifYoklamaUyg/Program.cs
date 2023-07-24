using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace SinifYoklamaUyg
{
    class Program
    {
        static object student;

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("H.Serhan Kunt", 1, true));
            students.Add(new Student("Betül Kunt", 2, false));
            students.Add(new Student("Özge Toksöz", 3, true));
            students.Add(new Student("Berk Karakurt ", 4, false));
            students.Add(new Student("Ahmet Şenyüz", 5, true));
            students.Add(new Student("Oğuzhan Atik", 6, true));
            students.Add(new Student("Melike Tanrıkulu", 7, false));
            int tercih = 0;

            while (tercih!=5)
            {

                Console.WriteLine("Sınıf Yoklama Uygulmasına Hoşgeldiniz.");
                Console.WriteLine("1.Öğrenci Listesi");
                Console.WriteLine("2.Gelen Öğrenci Listesi");
                Console.WriteLine("3-Gelmeyen Öğrenci Listesi:");
                Console.WriteLine("4-Öğrenci Seçme");
                Console.WriteLine("5-Çıkış");
            b:
                Console.WriteLine("Lütfen tercihinizi yapınız:");
                string tercih1 = Console.ReadLine();
                //int tercih = 0;
                if (int.TryParse(tercih1, out tercih) && (tercih < 6 && tercih > 0)) { goto a; }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer girin!!");
                    goto b;
                }
            a:

                switch (tercih)
                {
                    case 1:
                        students.ForEach(delegate (Student student)
                        {
                            Console.WriteLine(student.name + " " + student.studentNumber);
                        }); break;

                    case 2:
                        students.ForEach(delegate (Student student)
                        {
                            if (student.isHere == true)
                            {
                                Console.WriteLine(student.name);
                            }
                        }); break;
                    case 3:
                        students.ForEach(delegate (Student student)
                        {
                            if (student.isHere == false)
                            {
                                Console.WriteLine(student.name);
                            }
                        }); break;
                    case 4:
                        Console.WriteLine("Öğrenci numarasını giriniz:");
                        string controlnumber = Console.ReadLine();
                        int number = 0;
                        bool isFound = false;
                        if (int.TryParse(controlnumber, out number))
                        {
                            students.ForEach(delegate (Student student)
                            {
                                if (student.studentNumber == number)
                                {
                                    Console.WriteLine(student.name + " isimli " + student.studentNumber + " numaralı öğrenciyi seçtiniz.");
                                    isFound = true;
                                }
                                
                            });
                            if (!isFound)
                            {
                                Console.WriteLine($"Girilen {number} numaralı bir öğrenci bulunmamaktadır. ");
                            }
                        }
                        break;

                        case 5:
                            break;


                }
            }
        }
    }
    public class Student
    {
        public string name;
        public int studentNumber;
        public bool isHere;

        public Student(string name, int studentNumber, bool isHere)
        {
            this.name = name;
            this.studentNumber = studentNumber;
            this.isHere = isHere;
        }
    }
}