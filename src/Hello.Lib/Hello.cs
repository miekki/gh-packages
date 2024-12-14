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


}
