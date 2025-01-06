using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using SkiaSharp;
using SkiaSharp.Views.Blazor;

namespace Modeler.Pages;

public class MyCanvas : ComponentBase
{
    SKCanvasView _skiaView = null!;

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        base.BuildRenderTree(builder);

        int sequence = 0;

        builder.OpenComponent<SKCanvasView>(sequence++);
        builder.AddAttribute(sequence++, "@ref", _skiaView);
        builder.AddAttribute(sequence++, "OnPaintSurface", OnPaintSurface);
        builder.AddAttribute(sequence++, "IgnorePixelScaling", true);
        builder.CloseComponent();

    }

    void OnPaintSurface(SKPaintSurfaceEventArgs e)
    {
        var canvas = e.Surface.Canvas;

        canvas.Clear(SKColors.BlueViolet);

        using var paint = new SKPaint
        {
            Color = SKColors.AliceBlue,
            Style = SKPaintStyle.Fill
        };

        canvas.DrawRect(new SKRect(10, 10, 50, 50), paint);
    }
}
