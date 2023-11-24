namespace ConsoleApp20.Models
{
    public class Student
    {
        public static int MaxId=1;
        public int Id;
        public string FullName;
        public double Point;

        public Student(string fullname, double point)
        {
            Id = MaxId++;
            FullName = fullname;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"User ID: {Id}");
            Console.WriteLine($"Fullname: {FullName}");
            Console.WriteLine($"Point: {Point}");
        }
    }
}
    
