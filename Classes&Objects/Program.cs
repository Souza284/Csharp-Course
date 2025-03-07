using Classes_Objects;

internal class Program
{
    private static void Main(string[] args)
    {
        //MyClass myClass01 = new();

        #region Person objects
        Person person1 = new();
        person1.name = "Pedro";
        person1.age = 18;

        Person person2 = new()
        {
            name = "Lorena",
            age = 17
        };

        //person1.Greet();
        //person2.Greet();
        #endregion

        Methods methods1 = new();
        methods1.Sum(3, 5);

    }
}

class MyClass
{

}