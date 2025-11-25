using Microsoft.AspNetCore.Components;

namespace BlazorApp.WASM.Pages;

public partial class Home
{
    private string? _apiResponse;
    private List<string> _steps = new List<string>();
    protected override void OnInitialized()
    {
        _steps.Add(nameof(OnInitialized));
        Console.WriteLine("OnInitialed - DEBUT");
        base.OnInitialized();
        Console.WriteLine("OnInitialed - FIN");
    }

    protected override async Task OnInitializedAsync()
    {
        _steps.Add(nameof(OnInitializedAsync));
        Console.WriteLine("OnInitializedAsync - DEBUT");
        await base.OnInitializedAsync();

        await Task.Delay(2000);
        _apiResponse = "Response blabla de l'API";

        Console.WriteLine("OnInitializedAsync - FIN");
    }

    protected override void OnParametersSet()
    {
        _steps.Add(nameof(OnParametersSet));
        Console.WriteLine("OnParametersSet - DEBUT");
        base.OnParametersSet();
        Console.WriteLine("OnParametersSet - FIN");
    }
    protected override async Task OnParametersSetAsync()
    {
        _steps.Add(nameof(OnParametersSetAsync));
        Console.WriteLine("OnParametersSetAsync - DEBUT");
        await base.OnParametersSetAsync();
        Console.WriteLine("OnParametersSetAsync - FIN");
    }

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        _steps.Add(nameof(SetParametersAsync));
        Console.WriteLine("SetParametersAsync - DEBUT");
        await base.SetParametersAsync(parameters);
        Console.WriteLine("SetParametersAsync - FIN");
    }

    protected override void OnAfterRender(bool firstRender)
    {
            
        _steps.Add(nameof(OnAfterRender));
        Console.WriteLine($"OnAfterRender - DEBUT (First ? {firstRender})");
        base.OnAfterRender(firstRender);
        Console.WriteLine($"OnAfterRender - FIN (First ? {firstRender}");
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        _steps.Add(nameof(OnAfterRenderAsync));
        Console.WriteLine($"OnAfterRenderAsync - DEBUT (First ? {firstRender})");
        await base.OnAfterRenderAsync(firstRender);
        Console.WriteLine($"OnAfterRenderAsync - DEBUT (First ? {firstRender})");
    }

    protected override bool ShouldRender()
    {
        _steps.Add(nameof(ShouldRender));
        Console.WriteLine("ShouldRender - DEBUT");
        var result = base.ShouldRender();
        Console.WriteLine("ShouldRender - FIN");
        return result;
    }

}