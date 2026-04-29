public class Videoprojecteur : Materiel
{
    private int luminositeNumens;
    private bool cableHDMIInclus;
 
    public Videoprojecteur(string reference, string marque, string modele,bool disponible, string etat, int luminositeNumens, bool cableHDMIInclus)
        : base(reference, marque, modele,disponible, etat)
    {
        this.luminositeNumens = luminositeNumens;
        this.cableHDMIInclus = cableHDMIInclus;
    }
    public override int CalculerDureeMaxEmprunt()
    {
        return 3;
    }
    public override void AfficherInformations()
    {
        Console.WriteLine("-- Vidéoprojecteur --");
        base.AfficherInformations();
        Console.WriteLine($"Luminosité: {luminositeNumens} lumens");
        Console.WriteLine($"Câble HDMI: {cableHDMIInclus}");
    }
    public int LuminositeNumens { get => luminositeNumens; set => luminositeNumens = value; }
    public bool CableHDMIInclus { get => cableHDMIInclus; set => cableHDMIInclus = value; }
}