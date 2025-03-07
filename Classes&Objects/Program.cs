using Classes_Objects;

internal class Program
{
    private static void Main(string[] args)
    {
        //MyClass myClass01 = new();

        Person person1 = new();
        person1.name = "Pedro";
        person1.age = 18;

        Person person2 = new()
        {
            name = "Lorena",
            age = 17
        };

    }
}

class MyClass
{

}