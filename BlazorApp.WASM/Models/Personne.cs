using System.ComponentModel.DataAnnotations;

namespace BlazorApp.WASM.Models;

public class Personne
{
    //bien pour des validations basique 
    //[Required(AllowEmptyStrings =false, ErrorMessage ="Vous devez entrer votre nom !")]
    //[StringLength(256, MinimumLength = 3, ErrorMessage ="Nom entre 3 et 256 caractères")]
    public string? Nom { get; set; }
}
