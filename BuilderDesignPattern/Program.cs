// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Mormal satrlarda
//Araba mercedes = new();
//mercedes.KM = 1;
//mercedes.Marka = "Mercedes";
//mercedes.Model = "MMOLDE-X";
//mercedes.Vites = true;

interface IArabaBuilder
{
    public Araba araba { get; }

    void setMarka();
    void setModel();

    void setKM();

    void setVites();




}

class MercedesBuilder : IArabaBuilder
{
    public Araba araba { get; }

    public MercedesBuilder()
    {
        araba = new();

    }

    public void setKM() => araba.KM = 1;


    public void setMarka() => araba.Marka = "Mercedes";



    public void setModel() => araba.Model = "MMOLDE-X";


    public void setVites() => araba.Vites = true;
   
}

class OpelBuilder : IArabaBuilder
{
    public Araba araba { get; }

    public OpelBuilder()
    {
        araba = new();

    }

    public void setKM() => araba.KM = 1;


    public void setMarka() => araba.Marka = "OPEL";



    public void setModel() => araba.Model = "MMOLDE-y";


    public void setVites() => araba.Vites = true;

}


class Araba
{ 

    public string Marka { get; set; }

    public string Model { get;set; }

    public double KM { get; set; }  

    public bool Vites { get; set; }


    public override string ToString()
    {
        Console.WriteLine($"{Marka} marka araba {Model} modelinde {KM} kilometrede {Vites} vitesolarak üretilmiştir.");

        return base.ToString(); 
    }


}
