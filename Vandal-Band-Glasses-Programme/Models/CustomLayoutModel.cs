public class CustomLayoutModel
{
    public List<LayoutDetail>? layoutDetails { get; init; }
}

public class LayoutDetail
{
    public string participant { get; init; } = "foo bar";
    public string color { get; init; } = "0Xrrggbb";
    public int xPos { get; init; } = 0;
    public int yPos { get; init; } = 0;
}