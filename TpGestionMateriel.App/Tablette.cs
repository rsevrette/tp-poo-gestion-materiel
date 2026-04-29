public class Tablette : Materiel
{
    private double tailleEcran;
    private bool styletInclus;
 
    public Tablette(string reference, string marque, string modele,bool disponible, string etat, double tailleEcran, bool styletInclus)
        : base(reference, marque, modele,disponible, etat)
    {
        this.tailleEcran = tailleEcran;
        this.styletInclus = styletInclus;
    }
    public override int CalculerDureeMaxEmprunt()
    {
        return 7;
    }
 
    public override void AfficherInformations()
    {
        Console.WriteLine("-- Tablette --");
        base.AfficherInformations();
        Console.WriteLine($"Écran     : {tailleEcran} pouces");
        Console.WriteLine($"Stylet    : {(styletInclus ? "Oui" : "Non")}");
    }
    public double TailleEcran { get => tailleEcran; set => tailleEcran = value; }
    public bool StyletInclus { get => styletInclus; set => styletInclus = value; }
}