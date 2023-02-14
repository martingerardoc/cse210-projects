namespace Learning04;
public class mathAssigment:Assigment
{
    private string textBookSection;
    private string problems;

    public string TextBookSection { get => textBookSection; set => textBookSection = value; }
    public string Problems { get => problems; set => problems = value; }

    public void getHomeworkList(string _textBookSection, string _problems)
    {
        textBookSection = _textBookSection;
        problems = _problems;

    }
}