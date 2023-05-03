namespace project.Models
{
    public class Pizza
    {
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Img { get; set; }
        public double Prezzo { get; set; }

        public Pizza(string nome, string descrizione, string img, double prezzo)
        {
            Nome = nome;
            Descrizione = descrizione;
            Img = img;
            Prezzo = prezzo;
        }
    }
}
