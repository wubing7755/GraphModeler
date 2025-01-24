using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Modeler.Pages;

public class MainPage : ComponentBase
{
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        base.BuildRenderTree(builder);

        int sequence = 0;

        builder.OpenElement(sequence++, "h3");
        builder.AddContent(sequence++, "main page");
        builder.CloseElement();
        
        builder.OpenComponent<StarshipPlainForm>(sequence);
        builder.CloseComponent();
    }
}
