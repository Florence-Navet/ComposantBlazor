using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared;

public class ElementsList : ComponentBase
{
    [Parameter, EditorRequired]
    public List<string> Items { get; set; }
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "ul"); //<ul>
        int sequence = 1;
        foreach (var item in Items)
        {
            builder.OpenElement(sequence, "li"); //<li>
            builder.AddContent(++sequence, item); // valeur de item
            builder.CloseElement(); //</li>
            sequence++;
        }
        builder.CloseElement(); //</ul>

    }
}
