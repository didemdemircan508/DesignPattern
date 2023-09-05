// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//factory methodkullnkksak

//Computer computer = new Computer();

//CPU cPU = new CPU();
//computer.CPU = cPU;
//RAM rAM = new RAM();    
//computer.RAM = rAM;
//VideoCard videoCard = new VideoCard();
//computer.VideoCard = videoCard;

//factory methodkullnkksak

ComputerCreator computerCretor  = new ();
Computer asus = computerCretor.CreateComputer(new LenovaFactory());


class Computer
{
    public Computer()
    {
        
    }

    public Computer(CPU cpu,RAM ram,VideoCard videoCard)
    {
        CPU = cpu;
        RAM = ram;
        VideoCard = videoCard;
        
    }
    public CPU CPU { get; set; }
    public RAM RAM { get; set; }
    public VideoCard VideoCard { get; set; }


}

interface ICPU
{ 

}

interface IRAM
{

}

interface IVideoCard
{

}


class CPU:ICPU {
    public CPU(string text)=>Console.WriteLine(text);
    
}

class RAM:IRAM{
    public RAM(string text)=>Console.WriteLine(text);
   
}

class VideoCard:IVideoCard{
    public VideoCard(string text)=>Console.WriteLine(text);
   
}

interface IComputerFatory
{ 
    ICPU CreateCpu();
    IRAM CreateRAM();

    IVideoCard CreateVideoCard();

}

class AsusFactory : IComputerFatory
{
    public ICPU CreateCpu()=>new CPU($"Asus CPU Üretildi.");


    public IRAM CreateRAM() => new RAM($" asus Ram Üretildi");


    public IVideoCard CreateVideoCard() => new VideoCard($" AsusVideoCard Üretildi");
   
}

class LenovaFactory : IComputerFatory
{
    public ICPU CreateCpu() => new CPU($"Lenova CPU Üretildi.");



    public IRAM CreateRAM() => new RAM($"Lenova ram Üretildi");


    public IVideoCard CreateVideoCard() => new VideoCard($"Lenova videocard Üretildi");

}

class ComputerCreator
{
    ICPU _cpu;
    IRAM _ram;
    IVideoCard _videoCard;

    public Computer  CreateComputer(IComputerFatory computerFatory)
    {
        _cpu=computerFatory.CreateCpu();
        _ram=computerFatory.CreateRAM();
        _videoCard=computerFatory.CreateVideoCard();

        return new (_cpu as CPU, _ram as RAM, _videoCard as VideoCard);

    }

}


