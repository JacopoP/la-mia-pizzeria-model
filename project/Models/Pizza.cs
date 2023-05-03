using System.Diagnostics.Metrics;

namespace project.Models
{
    public class Pizza
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Img { get; set; }
        public double Prezzo { get; set; }

        private static int counter = 1; 

        public Pizza(string nome, string descrizione, string img, double prezzo)
        {
            Nome = nome;
            Descrizione = descrizione;
            Img = img;
            Prezzo = prezzo;
            Id = counter;
            counter ++;
        }
    }
}
