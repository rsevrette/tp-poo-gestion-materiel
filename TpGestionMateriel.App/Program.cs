namespace TpGestionMateriel.App;

class Program
{
    static void Main(string[] args)
    {
        // --- Création des objets ---
        OrdinateurPortable pc1 = new OrdinateurPortable("PC-001", "Dell", "Latitude 5420", true, "Bon", 16, true);
        OrdinateurPortable pc2 = new OrdinateurPortable("PC-002", "HP", "ProBook 450", true, "Bon", 8, false);
        Tablette tab1 = new Tablette("TAB-001", "Samsung", "Galaxy Tab A8", true, "Bon", 10.5, true);
        Videoprojecteur vid1 = new Videoprojecteur("VID-001", "Epson", "EB-X49", true, "Bon", 3600, true);
        Videoprojecteur vid2 = new Videoprojecteur("VID-002", "BenQ", "MS560", true, "Bon", 4000, false);

        GestionMateriel gestion = new GestionMateriel();

        // 1. Ajout d'un matériel
        Console.WriteLine("=== 1. Ajout d'un matériel ===");
        bool ajout1 = gestion.AjouterMateriel(pc1);
        Console.WriteLine($"Ajout PC-001 : {ajout1}"); 
        gestion.AjouterMateriel(pc2);
        gestion.AjouterMateriel(tab1);
        gestion.AjouterMateriel(vid1);
        gestion.AjouterMateriel(vid2);
        Console.WriteLine();

        // 2. Ajout d'un doublon
        Console.WriteLine("=== 2. Ajout d'un doublon ===");
        bool ajoutDoublon = gestion.AjouterMateriel(pc1);
        Console.WriteLine($"Ajout doublon PC-001 : {ajoutDoublon}"); 
        Console.WriteLine();

        // 3. Recherche d'un matériel existant
        Console.WriteLine("=== 3. Recherche d'un matériel existant ===");
        Materiel? trouve = gestion.RechercherMateriel("TAB-001");
        Console.WriteLine($"Recherche TAB-001 : {(trouve != null ? "Trouvé → " + trouve.Marque + " " + trouve.Modele : "Non trouvé")}");
        Console.WriteLine();

        // 4. Recherche d'un matériel inexistant
        Console.WriteLine("=== 4. Recherche d'un matériel inexistant ===");
        Materiel? introuvable = gestion.RechercherMateriel("XXX-999");
        Console.WriteLine($"Recherche XXX-999 : {(introuvable != null ? "Trouvé" : "Non trouvé (null)")}");
        Console.WriteLine();

        // 5. Emprunt d'un matériel disponible
        Console.WriteLine("=== 5. Emprunt d'un matériel disponible ===");
        bool emprunt1 = gestion.EmprunterMateriel("PC-001");
        Console.WriteLine($"Emprunt PC-001 : {emprunt1}");
        Console.WriteLine($"Disponible après emprunt : {pc1.Disponible}");
        Console.WriteLine();

        // 6. Emprunt d'un matériel déjà emprunté
        Console.WriteLine("=== 6. Emprunt d'un matériel déjà emprunté ===");
        bool emprunt2 = gestion.EmprunterMateriel("PC-001");
        Console.WriteLine($"Emprunt PC-001 (déjà emprunté) : {emprunt2}"); 
        Console.WriteLine();

        // 7. Emprunt d'un ordinateur sans chargeur
        Console.WriteLine("=== 7. Emprunt d'un ordinateur sans chargeur ===");
        bool empruntSansChargeur = gestion.EmprunterMateriel("PC-002");
        Console.WriteLine($"Emprunt PC-002 (sans chargeur) : {empruntSansChargeur}"); 
        Console.WriteLine();

        // 8. Emprunt d'un vidéoprojecteur sans câble HDMI
        Console.WriteLine("=== 8. Emprunt d'un vidéoprojecteur sans câble HDMI ===");
        bool empruntSansHDMI = gestion.EmprunterMateriel("VID-002");
        Console.WriteLine($"Emprunt VID-002 (sans câble HDMI) : {empruntSansHDMI}"); 
        Console.WriteLine();

        // 9. Retour d'un matériel emprunté
        Console.WriteLine("=== 9. Retour d'un matériel emprunté ===");
        bool retour1 = gestion.RetournerMateriel("PC-001", "À vérifier");
        Console.WriteLine($"Retour PC-001 : {retour1}"); 
        Console.WriteLine($"Disponible après retour : {pc1.Disponible}"); 
        Console.WriteLine($"Nouvel état : {pc1.Etat}"); 
        Console.WriteLine();

        // 10. Retour d'un matériel déjà disponible
        Console.WriteLine("=== 10. Retour d'un matériel déjà disponible ===");
        bool retour2 = gestion.RetournerMateriel("PC-001", "Bon");
        Console.WriteLine($"Retour PC-001 (déjà disponible) : {retour2}"); 
        Console.WriteLine();

        // 11. Affichage des matériels disponibles
        Console.WriteLine("=== 11. Affichage des matériels disponibles ===");
        gestion.AfficherMaterielsDisponibles();
        Console.WriteLine();

        // 12. Affichage de tous les matériels
        Console.WriteLine("=== 12. Affichage de tous les matériels ===");
        gestion.AfficherTousLesMateriels();

        // 13. Calcul de la durée maximale totale
        Console.WriteLine("=== 13. Durée maximale totale ===");
        int dureeTotal = gestion.CalculerDureeMaxTotale();
        Console.WriteLine($"Durée maximale totale : {dureeTotal} jours"); 
    }
}
    
