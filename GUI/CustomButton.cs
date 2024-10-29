using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CustomButton : Button
{
    private Color _borderColor = Color.PaleVioletRed;
    private int _borderSize = 2;
    private int _borderRadius = 20;

    public Color BorderColor
    {
        get { return _borderColor; }
        set { _borderColor = value; Invalidate(); }
    }

    public int BorderSize
    {
        get { return _borderSize; }
        set { _borderSize = value; Invalidate(); }
    }

    public int BorderRadius
    {
        get { return _borderRadius; }
        set { _borderRadius = value; Invalidate(); }
    }

    public CustomButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        BackColor = Color.MediumSlateBlue;
        ForeColor = Color.White;
        Resize += (s, e) => Invalidate();
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        var rectSurface = this.ClientRectangle;
        var rectBorder = Rectangle.Inflate(rectSurface, -_borderSize, -_borderSize);
        int smoothSize = 2;

        if (_borderRadius > 2)
        {
            var pathSurface = GetFigurePath(rectSurface, _borderRadius);
            var pathBorder = GetFigurePath(rectBorder, _borderRadius - _borderSize);
            var penSurface = new Pen(this.Parent.BackColor, smoothSize);
            var penBorder = new Pen(_borderColor, _borderSize);

            this.Region = new Region(pathSurface);

            pevent.Graphics.DrawPath(penSurface, pathSurface);

            if (_borderSize >= 1)
                pevent.Graphics.DrawPath(penBorder, pathBorder);
        }
        else
        {
            this.Region = new Region(rectSurface);
            if (_borderSize >= 1)
            {
                var penBorder = new Pen(_borderColor, _borderSize);
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }

    private GraphicsPath GetFigurePath(Rectangle rect, int radius)
    {
        var path = new GraphicsPath();
        float curveSize = radius * 2F;
        path.StartFigure();
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
        path.CloseFigure();
        return path;
    }
}
