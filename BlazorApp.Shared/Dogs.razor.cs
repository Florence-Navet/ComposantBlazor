using BlazorApp.Shared.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Shared;


public partial class Dogs
{

    [Inject] private IDogService DogService { get; set; } 

    private string? picture; 

    protected override async Task OnInitializedAsync()
    {
        picture = await DogService.GetDogImage();
    }
}