using System;
using System.Collections.Generic;
using System.Text;
using SkiaSharp;
using SkiaSharp.Views.UWP;

namespace UnoAnimator.Shared.Views
{
    public class DrawCanvas : SKXamlCanvas
    {
        public DrawCanvas() : base()
        {

        }

        protected override void OnPaintSurface(SKPaintSurfaceEventArgs e)
        {
            // call the base method
            base.OnPaintSurface(e);

            var surface = e.Surface;
            var surfaceWidth = e.Info.Width;
            var surfaceHeight = e.Info.Height;

            var canvas = surface.Canvas;

            using (SKPaint paint = new SKPaint { Color = SKColors.Red })
            {
                canvas.DrawText("treeeeeeee", new SKPoint(100, 100), paint);
            }
            canvas.Flush();
        }
    }
}
