using BlazorApp.Server.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Server.Components.Pages;

public partial class Formulaire

{
    [SupplyParameterFromForm]// enrichi par les données envoyees par le formulaire
    public Personne? Model { get; set; }

    private string? _nomPersonne;

    protected override void OnInitialized()
    {
        Model ??= new Personne(); //??= affecte dans model uniquement si model est null
    }

    private async Task OnSubmit()
    {
        _nomPersonne = Model?.Nom;
    }
}