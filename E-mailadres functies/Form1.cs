namespace E_mailadres_functies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*=======Analyse Stap 1======
1. Welke functies heb je nodig? Noteer voor elke functie een naam. Zorg ervoor dat de naam onmiddellijke duidelijk is voor wat deze functie moet doen.
        functie "HaalGebruikerOp" 
        functie "HaalAdresOp"

=======Analyse Stap 2======
HERHAAL DEZE STAP VOOR ELKE FUNCTIE
1. Invoer: Welke invoer mag ik verwachten? Geef zowel een naam/beschrijving als een datatype.
        een email adres - string

2. Bewerking: Welke formules heb je nodig om de berekening te kunnen doen?
        een formule die alles voor de @ neemt en eentje die alles na de @ neemt

3. Uitvoer: Welk resultaat zal je bekomen? Geef zowel een naam/beschrijving als een datatype.
        een gebruiker - string
        een adres - string

==========Testdata=========

4. Testdata: Verzin en noteer testgegevens, en bereken met je rekenmachine de juiste oplossing. Zo weet je of je oefening klopt.
        ll-84907@broeders.be
        gebruiker: ll-84907
        server: broeders.be

=========================== */
        private void SelectButton_Click(object sender, EventArgs e)
        {
            string EmailAdres = Convert.ToString(InvoerTextBox.Text);
            string Gebruiker = HaalGebruikerOp(EmailAdres);
            string Server = HaalServerOp(EmailAdres);
            GebruikerLabel.Text = Gebruiker;
            ServerLabel.Text = Server;
        }


        private string HaalGebruikerOp(string EmailAdres)
        {
            int TekenPlaats = EmailAdres.IndexOf("@");
            return EmailAdres.Substring(0, TekenPlaats);
        }


        private string HaalServerOp(string EmailAdres)
        {
            int TekenPlaats = EmailAdres.IndexOf("@");
            return EmailAdres.Substring(TekenPlaats + 1);
        }
    }
}
