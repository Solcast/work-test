// See https://aka.ms/new-console-template for more information

/// Calculate the linear distance between a point and a target t
static float distance(float x, float y, float xt, float yt)
{
    var dx = x-xt; //delta between point and target
    var dy = y-yt;
    return (float)Math.Sqrt(dx*dx + dy*dy);
}


Console.WriteLine("Hello, World!");