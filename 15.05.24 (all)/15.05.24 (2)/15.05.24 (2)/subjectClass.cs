class Subject (string subjectCode, string subjectName, int studyPoints)
{
    public string SubjectCode { get; set; } = subjectCode;
    public string SubjectName { get; set; } = subjectName;
    public int StudyPoints { get; set; } = studyPoints;

    public void printInfo()
    {
        Console.WriteLine($"subject code: {SubjectCode} \r\n subject name: {SubjectName} \r\n {StudyPoints} \r\n");
    }

}
