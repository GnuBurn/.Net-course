using System.ComponentModel.DataAnnotations;
using System.Dynamic;

class Program
{
  record struct Course
  {
    public required string name {get; set;}
    public required int credit {get; set;}
  }
  record struct Student
  {
    public required string firstName {get; set;}
    public required string lastName {get; set;}
    public required (Course course, int grade)[] Courses {get; set;}
  };
  static void calculateGPA(Student student)
  {
    Console.WriteLine($"Student: {student.firstName} {student.lastName}\n");
    Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
    decimal gpa = 0;
    decimal totalCredit = 0;
    foreach(var (course, grade) in student.Courses)
    {
      if (course.name.Length > 12)
      {
        Console.WriteLine($"{course.name}\t{grade}\t{course.credit}");
      }
      else
      {
        Console.WriteLine($"{course.name}\t\t{grade}\t{course.credit}");
      }
      totalCredit += course.credit;
      gpa += grade*course.credit;
    }
    Console.WriteLine($"\nFinal GPA:\t\t{(gpa/totalCredit):F2}");
  }

  static void Main()
  {
    Course Eng101 = new Course
    {
      name = "English 101",
      credit = 3
    };
    Course Alg101 = new Course
    {
      name = "Algebra 101",
      credit = 3
    };
    Course Bio101 = new Course
    {
      name = "Biology 101",
      credit = 4
    };
    Course CsI = new Course
    {
      name = "Computer Science I",
      credit = 4
    };
    Course Psy101 = new Course
    {
      name = "Psycology",
      credit = 3
    };
    Student sophia = new Student
    {
      firstName = "Sophia",
      lastName = "Johnson",
      Courses = [(Eng101, 4), (Alg101, 3), (Bio101, 3), (CsI, 3), (Psy101, 4)]
    };
    
    Console.WriteLine("Student\t\tGrade\n");
    calculateGPA(sophia);
  }
}