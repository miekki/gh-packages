namespace Hello.Lib;

public class Hello
{
    public string Greetings(string name)
    {
        var morning = true;
        if (morning)
        {
            return $"Good morning, {name}";
        }

        return $"Good afternoon, {name}";

    }

    public string SayMyName(string name)
    {
        return $"Your name is {name}";
    }

    public string FormatedGreetings(string name)
    {
        return $"Good morning, {name}. How do you do today?";
    }
}
