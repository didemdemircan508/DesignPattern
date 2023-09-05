
using System.Reflection;

Console.WriteLine("Hello, World!");


interface IBank
{

}
class GarantiBank : IBank
{
    string _userCode, _password;
    GarantiBank(string userCode, string password)
    {
        _userCode = userCode;
        _password = password;
    }

    static GarantiBank _garantiBank;
    static GarantiBank() => _garantiBank = new("asd", "123");

    public static GarantiBank GetInstance => _garantiBank;


    public void ConnectGaranti()
        => Console.WriteLine($"{nameof(GarantiBank)}-Connected");

    public void SendMoney(int amount)
        => Console.WriteLine($"{amount}-mpney send");

}

class HalkBank : IBank
{
    string _userCode, _password;
    HalkBank(string userCode)
    {
        _userCode = userCode;


    }

    static HalkBank _halkBank;
    static HalkBank() => _halkBank = new("asd");

    public static HalkBank GetInstance => _halkBank;

    public string Password { set => _password = value; }

    public void Send(int amount, string accountNumber)
        => Console.WriteLine($"{amount}-mpney send");
}

class CredentialVakifBank
{
    public string UserCode { get; set; }
    public string Mail { get; set; }


}

class VakifBank : IBank
{

    string _userCode, _password, _email;
    public bool isAuth { get; set; }
    VakifBank(CredentialVakifBank credential, string password)
    {
        _userCode = credential.UserCode;
        _email = credential.Mail;
        _password = password;



    }

    static VakifBank _vakifBank;
    static VakifBank() => _vakifBank = new(new() { Mail = "dd@gmail.com", UserCode = "dd" }, "123");

    public static VakifBank GetInstance => _vakifBank;

    public void ValidateCredential()
    {
        if (true)
            isAuth = true;


    }



    public void SendMoneyToAccountNumber(int amount, string receiptName, string accountNumber)
        => Console.WriteLine($"{amount}-mpney send");

}


interface IBankFactory
{
    IBank CreateInstance();

}

class GarantiFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        GarantiBank garanti = GarantiBank.GetInstance;
        garanti.ConnectGaranti();
        return garanti;
    }
}

class HalkBankFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        HalkBank halkBank = HalkBank.GetInstance;
        halkBank.Password = "123";
        return halkBank;
    }
}


class VakifBankFactory : IBankFactory
{
    public IBank CreateInstance()
    {
        VakifBank vakifBank = VakifBank.GetInstance;
        vakifBank.ValidateCredential();
        return vakifBank;
    }
}

enum BankType
{
    Garanti, Halkbank, VakifBank

}

class BankCreator
{

   public IBank Create(BankType bankType)
   {
       IBankFactory _bankFactory = bankType switch
        {
            BankType.VakifBank => new VakifBankFactory(),
            BankType.Halkbank => new HalkBankFactory(),
            BankType.Garanti => new GarantiFactory()

       };
        return _bankFactory.CreateInstance();

    }

}


//class BankCreator
//{

//    public IBank Create(BankType bankType)
//    {

//        string factory = $"{bankType.ToString()}Factory";
//        Type type = Assembly.GetExecutingAssembly().GetType(factory);
//        IBankFactory bankFactory = Activator.CreateInstance(type) as IBankFactory;
//        return bankFactory.CreateInstance();





//    }
//}

