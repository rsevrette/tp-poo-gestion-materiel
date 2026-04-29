public class OrdinateurPortable : Materiel
{
    private int ramGo;
    private bool possedeChargeur;
 
    public OrdinateurPortable(string reference, string marque, string modele, bool disponible, string etat, int ramGo, bool possedeChargeur)
        : base(reference, marque, modele, disponible, etat)
    {
        this.ramGo = ramGo;
        this.possedeChargeur = possedeChargeur;
    }
    public override int CalculerDureeMaxEmprunt()
    {
        return 14;
    }
 
    public override void AfficherInformations()
    {
        Console.WriteLine("-- Ordinateur portable --");
        base.AfficherInformations();
        Console.WriteLine($"RAM       : {ramGo} Go");
        Console.WriteLine($"Chargeur  : {possedeChargeur}");
    }
    public int RamGo { get => ramGo; set => ramGo = value; }
    public bool PossedeChargeur { get => possedeChargeur; set => possedeChargeur = value; }
}