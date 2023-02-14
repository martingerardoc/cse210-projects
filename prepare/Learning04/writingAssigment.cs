namespace Learning04;
public class writingAssigment:Assigment
{
    private string title;

    public string Title { get => title; set => title = value; }

    public void getWritingInformation(string _title)
    {
        title= _title;
    }
}