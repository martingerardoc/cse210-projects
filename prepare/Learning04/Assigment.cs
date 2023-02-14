namespace Learning04;
public class Assigment
{
    private string studentName;
    private string topic;

    public string StudentName { get => studentName; set => studentName = value; }
    public string Topic { get => topic; set => topic = value; }

    public void GetSummary(string _studentName, string _topic)
    {
        studentName= _studentName;
        topic = _topic;
    }
}
