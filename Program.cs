using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Smartphone Nokia = new Nokia("12222233", "N103", 22211222, 54);
        Smartphone Iphone = new Iphone("0988766653", "12 plus", 323234432, 76);

        Nokia.Ligar();
        Nokia.InstalarAplicativo("snake");
        //Nokia.MostrarNumero();
        Nokia.Numero = "123243435";
        //Nokia.MostrarNumro();


        Iphone.InstalarAplicativo("Instagram");
        Iphone.ReceberLigacao();
       
        
        Smartphone Nokia1 = new Nokia("23213344112","N32",485948504,89);
        Nokia.ReceberLigacao();
        Nokia.Ligar();
        Nokia.InstalarAplicativo("Sankes");

        Console.WriteLine("Nokia");

        //Console.WriteLine("------------------");

        Smartphone iphone1 = new Iphone("44334322","12 Pro",838384747,54);
        Iphone.Ligar();
        Iphone.ReceberLigacao();
        
    }
}