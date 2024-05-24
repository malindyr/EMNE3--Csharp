class Student(string name, int age, string studyprogram, int studentID, List<Subject> subjects) //. Each object created based on this blueprint "Student class" is called an instance of the class.
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public string StudyProgram { get; set; } = studyprogram;
    public int StudentID { get; set; } = studentID;
    public List<Subject> Subjects { get; set; } = subjects;

    public void PrintInfo() //You can access these properties directly because the method is inside the Student class.
                            //So, you use the property names directly without any extra prefix.

    //When you're inside a class (like Student), and you want to access its own properties,
    //you can simply refer to them by their names without any extra prefix.
    //This is because the class knows its own properties.
    {
        Console.WriteLine($"student name: {Name} \r\n student age: {Age}\r\n student study-program: {StudyProgram}\r\n student ID: {StudentID}\r\n");
        for (int i= 0; i < Subjects.Count; i++) 
        //foreach (Subject subject in Subjects)
        {
            Console.WriteLine($"subjects: {subjects[i].SubjectName}");
        }
    }


    public double GradeAverage(List<Grade> grades)
    {
        int totalGrades = 0;

        foreach (var grade in grades)
        {
            totalGrades += grade.GradeValue;
        }

        double averageGrade = (double)totalGrades / grades.Count;

        return averageGrade;
    }

    public int TotalStudyPoints()
    {
        int totalPoints = 0;
        foreach (var subject in subjects)
        {
            totalPoints += subject.StudyPoints;
        }
        return totalPoints;


    }
};/*Gjennomsnittskarakter:

Implementer en metode i Student-klassen som beregner gjennomsnittskarakteren for studenten basert på karakterene de har fått.'

    */
    
/*

Studiepoeng:

Implementer en metode i Student-klassen som beregner totalt antall studiepoeng basert på fagene studenten tar.
*/

