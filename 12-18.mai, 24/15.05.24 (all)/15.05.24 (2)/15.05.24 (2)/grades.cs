/*Karakter:

Egenskaper: Student (referanse til en Student), Fag (referanse til et Fag), Karakterverdi.
Metode: SkrivUtInfo() som skriver ut informasjon om karakteren.
*/

class Grade(Student student, Subject subject, int gradeValue)
{
    public string StudentName { get; set; } = student.Name;
    Subject Subject { get; set; } = subject;
    public int GradeValue { get; set; } = gradeValue;

    
    public void PrintInfo()
    {
        Console.WriteLine($"student name: {StudentName} \r\n subject name: {Subject} \r\n grade value: {GradeValue}\r\n");
    }
}