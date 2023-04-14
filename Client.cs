namespace ConsoleApp1
{
    internal class Client
    {
        //les proprietes de la classe client 

        private string nom;
        private string prenom;
        private string courriel;
        private string carteCredit;
        private int numeroChambre;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Courriel
        {
            get { return courriel; }
            set { courriel = value; }
        }
        public string CarteCredit
        {
            get { return carteCredit; }
            set { carteCredit = value; }
        }
        public int NumeroChambre
        {
            get { return numeroChambre; }
            set { numeroChambre = value; }
        }

        public Client(string nom, string prenom, string courriel, string carteCredit, int numeroChambre)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Courriel = courriel;
            this.CarteCredit = carteCredit;
            this.NumeroChambre = numeroChambre;

        }

    }
}