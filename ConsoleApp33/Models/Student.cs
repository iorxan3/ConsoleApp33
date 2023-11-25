using System.Threading.Channels;

namespace ConsoleApp33.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }    
        public int Point{ get; set; }

        private static int Idp = 1;

        public Student(string fullname,int point) 
        { 
            Id = Idp++;
            Fullname = fullname;
            Point = point;          
        }
        public void StudentInfo() 
        {
            Console.WriteLine($"Id:{Id}");
            Console.WriteLine($"Fullname:{Fullname}");
            Console.WriteLine($"Point:{Point}");
        }

    }

}
