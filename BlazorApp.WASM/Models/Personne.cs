using System.ComponentModel.DataAnnotations;

namespace BlazorApp.WASM.Models;

public enum Sexe
{
    Masculin,
    Feminin
}

public class Personne
{
    //bien pour des validations basique 
    //[Required(AllowEmptyStrings =false, ErrorMessage ="Vous devez entrer votre nom !")]
    //[StringLength(256, MinimumLength = 3, ErrorMessage ="Nom entre 3 et 256 caractères")]
    public string? Nom { get; set; }

    public string Bio { get; set; }

    public int Age { get; set; }

    public bool VIP { get; set; }   

    public Sexe Sexe { get; set; }

    public DateTime DateNaissance { get; set; }

    public string Pays { get; set; }
}
