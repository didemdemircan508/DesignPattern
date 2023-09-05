// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//MULTITON DESGIN PATTREN

var mssql = Database.GetInstance("Mssql");
var oracle = Database.GetInstance("Oracle");
var mangoDb = Database.GetInstance("mangoDb");


class Database
{
    private Database()
    {
        Console.WriteLine($"{nameof(Database)} nesnesi oluşturuldu");
    }

    static Dictionary<string, Database> _databases = new();

    public static Database GetInstance(string key)
    {
        if (!_databases.ContainsKey(key))
        {
            _databases[key] = new Database();

        }
        return _databases[key];

    }




}
