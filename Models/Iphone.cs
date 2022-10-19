using DesafioPOO.Models;
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero,string modelo,int imei,int memoria) : base(numero, modelo, imei, memoria){

        }
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine("Instalando aplicativo" + nomeApp + "no Phone");
        }
    }
}