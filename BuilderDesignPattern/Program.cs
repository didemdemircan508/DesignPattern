// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Mormal satrlarda
//Araba mercedes = new();
//mercedes.KM = 1;
//mercedes.Marka = "Mercedes";
//mercedes.Model = "MMOLDE-X";
//mercedes.Vites = true;

//ArabaDirector arabaDirector = new ArabaDirector();
//Araba mercedes =arabaDirector.Build(new MercedesBuilder());
//mercedes.ToString();

//Araba opel= arabaDirector.Build(new OpelBuilder());
//opel.ToString();
#region abstract ile tasaralnması 

//abstract class ArabaBuilder
//{

//    protected Araba araba;

//    public Araba Araba { get => araba; }

//    public ArabaBuilder()
//    {
//        araba = new Araba();
//    }

//    public abstract ArabaBuilder  setMarka();
//    public abstract ArabaBuilder setModel();

//    public abstract ArabaBuilder setKM();

//    public abstract ArabaBuilder setVites();




//}


//class OpelBuilder : ArabaBuilder
//{
   


//    public override ArabaBuilder setKM() 
//    {
//        araba.KM = 1; return this;

    
//    }


//    public override ArabaBuilder setMarka()
//    {
//        araba.Marka = "oPEL"; return this;


//    }



//    public override ArabaBuilder setModel()
//    {
//        araba.Model = "MODEL-RR"; return this;


//    }


//    public override ArabaBuilder setVites()
//    {
//        araba.Vites = true; return this;


//    }

//}

//class Araba
//{

//    public string Marka { get; set; }

//    public string Model { get; set; }

//    public double KM { get; set; }

//    public bool Vites { get; set; }


//    public override string ToString()
//    {
//        Console.WriteLine($"{Marka} marka araba {Model} modelinde {KM} kilometrede {Vites} vitesolarak üretilmiştir.");

//        return base.ToString();
//    }


//}


//#endregion



#region inreface ile tasaralanması 
//interface IArabaBuilder
//{
//    public Araba araba { get; }

//    void setMarka();
//    void setModel();

//    void setKM();

//    void setVites();




//}

////direcotor

//class ArabaDirector
//{
//    public Araba Build(IArabaBuilder arabaBuilder)
//    {
//        arabaBuilder.setMarka();
//        arabaBuilder.setModel();
//        arabaBuilder.setKM();
//        arabaBuilder.setVites();
//        return arabaBuilder.araba;



//    }

//}

//class MercedesBuilder : IArabaBuilder
//{
//    public Araba araba { get; }

//    public MercedesBuilder()
//    {
//        araba = new();

//    }

//    public void setKM() => araba.KM = 1;


//    public void setMarka() => araba.Marka = "Mercedes";



//    public void setModel() => araba.Model = "MMOLDE-X";


//    public void setVites() => araba.Vites = true;

//}

//class OpelBuilder : IArabaBuilder
//{
//    public Araba araba { get; }

//    public OpelBuilder()
//    {
//        araba = new();

//    }

//    public void setKM() => araba.KM = 1;


//    public void setMarka() => araba.Marka = "OPEL";



//    public void setModel() => araba.Model = "MMOLDE-y";


//    public void setVites() => araba.Vites = true;

//}


//class Araba
//{ 

//    public string Marka { get; set; }

//    public string Model { get;set; }

//    public double KM { get; set; }  

//    public bool Vites { get; set; }


//    public override string ToString()
//    {
//        Console.WriteLine($"{Marka} marka araba {Model} modelinde {KM} kilometrede {Vites} vitesolarak üretilmiştir.");

//        return base.ToString(); 
//    }


//}
#endregion