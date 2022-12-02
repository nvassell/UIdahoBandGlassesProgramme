public class CustomLayoutModel
{
    public List<LayoutDetail>? layoutDetails { get; init; }
}

public class LayoutDetail
{
    public string participant { get; init; } = "John Smith";
    public int glassesNumber { get; init; } = 0;
    public string color { get; init; } = "#rrggbb";
    // These are for the custum layout creator.
    public int xPos { get; init; } = 0;
    public int yPos { get; init; } = 0;
}