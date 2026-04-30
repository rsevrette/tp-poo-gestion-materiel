namespace TpGestionMateriel.Tests;
 
[TestClass]
public class GestionMaterielTests
{
    [TestMethod]
    public void AjouterMateriel_RetourneTrue_QuandMaterielValide()
    {
        GestionMateriel gestion = new GestionMateriel();
        OrdinateurPortable pc = new OrdinateurPortable("PC-001", "Dell", "Latitude 5420", true, "Bon", 16, true);
        bool resultat = gestion.AjouterMateriel(pc);
        Assert.IsTrue(resultat);
    }
}
 