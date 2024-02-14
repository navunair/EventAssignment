
using Delegates;


class Program
{
    
    public static int CompareStudent(Student s1, Student s2)
    {
        return s1.Score.CompareTo(s2.Score);
    }
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student()
            {
               Id = 100,
               Name = "Ram",
               Age = 15,
               Score = 99
            },
           new Student()
            {
               Id = 121,
               Name = "Arjun",
               Age = 19,
               Score = 89.8
            },
           new Student()
            {
               Id = 101,
               Name = "Rahul",
               Age = 15,
               Score = 99.9
            },
           new Student()
            {
               Id = 102,
               Name = "Riya",
               Age = 16,
               Score = 78.5
            },
        };
        Console.WriteLine("Unsorted List:");
        foreach (var student in students)
        {
            student.Display();
            Console.WriteLine();
        }
        CustomSort.ComparisonDelegate<Student> comparison = new CustomSort.ComparisonDelegate<Student>(CompareStudent);
        CustomSort.SortStudent(students,comparison);
        Console.WriteLine("Sorted List:");
        foreach (var student in students)
        {
            student.Display();
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

       

    



