class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _problems = problems;
        _textbookSection = textbookSection;
    }

    public List<string> GetHomeworkList()
    {
        List<string> homeworkList = new List<string>();
        homeworkList.Add(_textbookSection);
        homeworkList.Add(_problems);
        return homeworkList;
    }
}
