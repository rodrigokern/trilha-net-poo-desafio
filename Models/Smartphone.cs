namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando pelo número: [{Numero}]");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação pelo número: [{Numero}]");
        }

        public void DebugInfo()
        {
            string className = this.GetType().Name;
            Console.WriteLine($"DebugInfo for [{className}]");
            Console.WriteLine($"Numero: [{Numero}]");
            Console.WriteLine($"Modelo: [{Modelo}]");
            Console.WriteLine($"IMEI: [{IMEI}]");
            Console.WriteLine($"Memoria: [{Memoria}]");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
