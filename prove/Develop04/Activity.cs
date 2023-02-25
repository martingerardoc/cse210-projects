namespace cse210_projects;
public class Activity
{
    private string name;
    private int age;
    private string gender;
    private int time;

    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }
    public string Gender { get => gender; set => gender = value; }
    public int Time { get => time; set => time = value; }

    public void getActivity(string _name, int _age, string _gender, int _time){
        name = _name;
        this.age=_age;
        gender=_gender;
        time=_time;

    }
}
