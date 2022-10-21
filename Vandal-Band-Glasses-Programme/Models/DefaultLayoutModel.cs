using System;

public class DefaultLayoutModel
{
    public List<string> participantNames { get; init; } = new List<string>();
    public int numRows { get; init; } = 0;
    public int numColumns { get; init; } = 0;
    public string customLayoutDirectory { get; init; } = "/Custom_Layouts/";

    //public DefaultLayoutModel(List<string> names, int rows, int columns, string layoutDirectory)
    //{
    //    participantNames = names;
    //    numRows = rows;
    //    numColumns = columns;
    //    customLayoutDirectory = layoutDirectory;
    //}
}

