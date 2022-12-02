public class DefaultLayoutModel
{
    public string customLayoutDirectory { get; set; } = "/Custom_Layouts/";
    public int numRows { get; set; } = 0;
    public int numColumns { get; set; } = 0;
    public List<ParticipantModel> participantList { get; set; } = new();
}

public class ParticipantModel
{
    public string name { get; set; } = "John Smith";
    public int glassesNumber { get; set; } = 0;
}