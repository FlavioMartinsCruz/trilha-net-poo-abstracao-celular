namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

      // TODO: Passar os parâmetros do construtor para as propriedades
    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

        public void Ligar()
        {
            Console.WriteLine("Ligando para Pai");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação de Mãe");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}