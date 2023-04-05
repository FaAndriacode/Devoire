using System.ComponentModel.DataAnnotations;

public class Utilisateur
{
    [Key]
    public int UtilisateurId { get; set; }
    public string Nom { get; set; } = string.Empty;
}