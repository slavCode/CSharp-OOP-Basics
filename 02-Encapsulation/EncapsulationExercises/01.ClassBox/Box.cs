public class Box
{
    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double Length { get; }
    public double Width { get; }
    public double Height { get; }

    public double GetSurfaceArea()
    {
        return (2 * (this.Length * this.Width)) + (2 * (this.Length * this.Height)) + (2 * (this.Width * this.Height));
    }

    public double GetLateralSurfaceArea()
    {
        return (2 * (this.Length * this.Height) + (2 * (this.Width * this.Height)));
    }

    public double GetVolume()
    {
        return this.Length * this.Width * this.Height;
    }
}
