public abstract class Materiel
{
    protected string reference;
    protected string marque;
    protected string modele;
    protected bool disponible;
    protected string etat;
    public Materiel(string reference, string marque, string modele, bool disponible, string etat)
    {
        this.reference = reference;
        this.marque = marque;
        this.modele = modele;
        this.disponible = true;
        this.etat = etat;
    }
    public abstract int CalculerDureeMaxEmprunt();
    public virtual void AfficherInformations()
    {
        Console.WriteLine($"Référence : {reference}");
        Console.WriteLine($"Marque    : {marque}");
        Console.WriteLine($"Modèle    : {modele}");
        Console.WriteLine($"État      : {etat}");
        Console.WriteLine($"Disponible: {disponible}");
        Console.WriteLine($"Durée max : {CalculerDureeMaxEmprunt()} jours");
    }

    public string Reference { get => reference; set => reference = value; }
    public string Marque { get => marque; set => marque = value; }
    public string Modele { get => modele; set => modele = value; }
    public bool Disponible { get => disponible; set => disponible = value; }
    public string Etat { get => etat; set => etat = value; }
}