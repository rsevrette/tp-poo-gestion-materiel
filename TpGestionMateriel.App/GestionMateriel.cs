public class GestionMateriel
{
    private List<Materiel> materiels;
 
    public GestionMateriel()
    {
        materiels = new List<Materiel>();
    }
 
    public List<Materiel> Materiels { get => materiels; set => materiels = value; }
 
    public bool AjouterMateriel(Materiel materiel)
    {
        if (materiel == null)
            return false;
 
        if (RechercherMateriel(materiel.Reference) != null)
            return false;
 
        materiels.Add(materiel);
        return true;
    }

    public Materiel? RechercherMateriel(string reference)
    {
        foreach (Materiel m in materiels)
        {
            if (m.Reference == reference)
                return m;
        }
        return null;
    }
 
    public bool EmprunterMateriel(string reference)
    {
        Materiel? m = RechercherMateriel(reference);
 
        if (m == null)
            return false;
 
        if (!m.Disponible)
            return false;
 
        if (m.Etat == "Hors service")
            return false;

        if (m is OrdinateurPortable pc && !pc.PossedeChargeur)
            return false;
 
        if (m is Videoprojecteur vp && !vp.CableHDMIInclus)
            return false;
 
        m.Disponible = false;
        return true;
    }
 
    public bool RetournerMateriel(string reference, string nouvelEtat)
    {
        Materiel? m = RechercherMateriel(reference);
 
        if (m == null)
            return false;
 
        if (m.Disponible)
            return false;
 
        m.Disponible = true;
        m.Etat = nouvelEtat;
        return true;
    }
 
    public void AfficherMaterielsDisponibles()
    {
        Console.WriteLine("=== Matériels disponibles ===");
        bool aucun = true;
        foreach (Materiel m in materiels)
        {
            if (m.Disponible && m.Etat != "Hors service")
            {
                m.AfficherInformations();
                Console.WriteLine();
                aucun = false;
            }
        }
        if (aucun)
            Console.WriteLine("Aucun matériel disponible.");
    }
 
    public void AfficherTousLesMateriels()
    {
        Console.WriteLine("=== Tous les matériels ===");
        foreach (Materiel m in materiels)
        {
            m.AfficherInformations();
            Console.WriteLine();
        }
    }
 
    public int CalculerDureeMaxTotale()
    {
        int total = 0;
        foreach (Materiel m in materiels)
        {
            total += m.CalculerDureeMaxEmprunt();
        }
        return total;
    }
}
 