// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");


// See https://aka.ms/new-console-template for more information

Console.WriteLine();



 

//FACTORY DESIGN PATTERN 

//A? a=ProductCreator.GetInstance(ProductType.A) as A;
//a.Run();
//B? b = ProductCreator.GetInstance(ProductType.B) as B;
//b.Run();
//interface IProduct
//{
//    void Run();
//}

//class A : IProduct
//{
//    public A()
//    {
//        Console.WriteLine($"{nameof(A)} nesnesi üretildi");
//    }
//    public void Run()
 
//    {
//        throw new NotImplementedException();
//    }
//}

//class B : IProduct
//{
//    public B()
//    {
//        Console.WriteLine($"{nameof(B)} nesnesi üretildi");
//    }
//    public void Run()
//    {
//        throw new NotImplementedException();
//    }
//}

//class C : IProduct
//{
//    public C()
//    {
//        Console.WriteLine($"{nameof(C)} nesnesi üretildi");
//    }
//    public void Run()
//    {
//        throw new NotImplementedException();
//    }
//}
//enum ProductType
//{
//    A,
//    B,
//    C
//}


//class ProductCreator
//{
//  static  public IProduct GetInstance(ProductType productType)
//    {
//        IProduct _product = null;
//        switch (productType)
//        {
//            case ProductType.A:
//                _product= new A();
//                break;
//            case ProductType.B:
//                _product= new B();
//                break;
//            case ProductType.C:
//                _product= new C();
//                break;

//        }

//        return _product;

//    }

//}


//Factory METHOD DESIGN



//interface IFactory
//{
//    IProduct CreateProduct();

//}
//class AFactory : IFactory
//{
//    public IProduct CreateProduct()
//    {
//        A a = new A();
//        return a;
//    }
//}

//class BFactory : IFactory
//{
//    public IProduct CreateProduct()
//    {
//        B b = new B();
//        return b;
//    }
//}

//class CFactory : IFactory
//{
//    public IProduct CreateProduct()
//    {
//       C c = new C();
//        return c;
//    }
//}

//class ProductCreatorFC
//{
//    static public IProduct GetInstance(ProductType productType)
//    {

//        IFactory _factory = productType switch
//        {
//            ProductType.A => new AFactory(),
//            ProductType.B => new BFactory(),
//            ProductType.C => new CFactory(),
//        };
//        return _factory.CreateProduct();

//    }

//}

// factory method devam 



//BankCreator bankCreator = new();

//GarantiBank? garantiBank=bankCreator.Create(BankType.Garanti) as GarantiBank;

//HalkBank? halkBank= bankCreator.Create(BankType.Halkbank) as HalkBank;



//interface IBank
//{ 

//}
//class GarantiBank:IBank
//{ 
//    string _userCode, _password;
//    public GarantiBank(string userCode,string password)
//    {
//        _userCode = userCode;
//        _password = password;
//    }

//    public void ConnectGaranti()
//        => Console.WriteLine($"{nameof(GarantiBank)}-Connected");

//    public void SendMoney(int amount)
//        => Console.WriteLine($"{amount}-mpney send");

//}

//class HalkBank:IBank
//{
//    string _userCode, _password;
//    public HalkBank(string userCode)
//    {
//        _userCode = userCode;
        

//    }

//    public string Password { set => _password = value; }

//    public void Send(int amount,string accountNumber)
//        => Console.WriteLine($"{amount}-mpney send");
//}

//class CredentialVakifBank
//{ 
//    public string UserCode { get; set; }
//    public string Mail { get; set; }


//}

//class VakifBank:IBank
//{

//    string _userCode, _password,_email ;
//    public bool isAuth { get; set; }
//    public VakifBank(CredentialVakifBank credential,string password)
//    {
//        _userCode = credential.UserCode;
//        _email = credential.Mail;
//        _password= password;



//    }

//    public void  ValidateCredential()
//    { 
//        if(true)
//            isAuth=true;


//    }

  

//    public void SendMoneyToAccountNumber(int amount, string receiptName,string accountNumber)
//        => Console.WriteLine($"{amount}-mpney send");

//}


//interface IBankFactory
//{
//    IBank CreateInstance();

//}

//class GarantiFactory : IBankFactory
//{
//    public IBank CreateInstance()
//    {
//        GarantiBank garanti = new("asd", "123");
//        garanti.ConnectGaranti();
//        return garanti;
//    }
//}

//class HalkBankFactory : IBankFactory
//{
//    public IBank CreateInstance()
//    {
//        HalkBank halkBank = new("asd");
//        halkBank.Password = "123";
//        return halkBank;
//    }
//}


//class VakifBankFactory : IBankFactory
//{
//    public IBank CreateInstance()
//    {
//        VakifBank vakifBank = new(new() { Mail = "dd@gmail.com", UserCode = "dd" }, "123");
//        vakifBank.ValidateCredential();
//        return vakifBank;
//    }
//}

//enum BankType
//{ 
//    Garanti,Halkbank,VakifBank

//}

//class BankCreator
//{

//    public IBank Create(BankType bankType)
//    {
//        IBankFactory _bankFactory = bankType switch
//        {
//            BankType.VakifBank => new VakifBankFactory(),
//            BankType.Halkbank=> new HalkBankFactory(),
//            BankType.Garanti=> new GarantiFactory()

//        };
//        return _bankFactory.CreateInstance();
    
//    }

//}

//factory methıd ve singleton birleşimi  

