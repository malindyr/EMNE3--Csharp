Main();
void Main()
{

    List<Subject> subjects = new List<Subject> {
new Subject("H104", "Programming", 5),
new Subject("V204", "windmill technician", 6),
new Subject("G293", "Csharp", 4),
};

    foreach(var subject in subjects)
    {
        subject.printInfo();
    }

    List<Subject> malinSubjects = new List<Subject> { subjects[0], subjects[1] };
    List<Subject> bjørnarSubjects = new List<Subject> { subjects[1], subjects[2] };

    Console.WriteLine("--------------------------------------------------------------------------------");

    List<Student> students = new List<Student> {

new Student("malin", 22, "Programming101", 1, malinSubjects),
new Student("bjørnar", 20, "windmills101", 2, bjørnarSubjects),

};
    foreach (var student in students)
    {
        student.PrintInfo();
    }


    Console.WriteLine("--------------------------------------------------------------------------------");

    List<Grade> grades = new List<Grade> {
 new Grade(students[0], subjects[0], 5),
 new Grade(students[1], subjects[1], 6),
};

    foreach (var grade in grades)
    {
        grade.PrintInfo();
    }


    Console.WriteLine("--------------------------------------------------------------------------------");

    foreach (var student in students)
    {
        double averageGrade = student.GradeAverage(grades);
        Console.WriteLine($"Student: {student.Name} \r\n Average Grade: {averageGrade}");
    }

};

