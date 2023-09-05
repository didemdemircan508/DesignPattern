// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//singleton pattren
//Example ex = Example.Instance;
//Example ex1 = Example.Instance;
//Example ex2 = Example.Instance;
//ex.Id = 1;
//Console.WriteLine(ex.Id);
//Console.WriteLine(ex1.Id);
//Console.WriteLine(ex2.Id);
//class Example
//{
//    public int Id { get; set; }
//    private Example()
//    {

//        Console.WriteLine($"{nameof(Example)} nesnesi oluşturuldu");

//    }

//    static Example _example;

//    public static Example Instance
//    {
//        get
//        {
//            if (_example == null)
//                _example = new Example();
//            return _example;
//        }
//    }



//}

//Example example = Example.Instance;

var t1 = Task.Run(() =>
{
    Example example1 = Example.Instance();

});

var t2 = Task.Run(() =>
{
    Example example2 = Example.Instance();

});

await Task.WhenAll(t1, t2);
class Example
{
    private Example()
    {

        Console.WriteLine($"{nameof(Example)} nesnesi oluşturuldu");

    }

    static Example()
    {
        _example = new Example();
    }

    static Example _example;
  

    public static Example Instance()
    {
        return _example;

    }



}
