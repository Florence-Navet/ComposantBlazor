using BlazorApp.WASM.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorApp.WASM.Pages;

public partial class Formulaire

{
    [SupplyParameterFromForm]// enrichi par les données envoyees par le formulaire
    public Personne? Model { get; set; }

    private string? _nomPersonne;
    //private bool _error; pouir gestion d'erreur simple    

    protected override void OnInitialized()
    {
        Model ??= new Personne(); //??= affecte dans model uniquement si model est null
    }

    private async Task OnSubmit()
    {
        //premier façon de gestion d'erreur avec le bool_error
        //_error = false;
        //if (string.IsNullOrEmpty(Model?.Nom))
        //{
        //    _error = true;
        //}
        //else
        //{
        //    _nomPersonne = Model?.Nom;

        //}
        _nomPersonne = Model?.Nom;
    }
}