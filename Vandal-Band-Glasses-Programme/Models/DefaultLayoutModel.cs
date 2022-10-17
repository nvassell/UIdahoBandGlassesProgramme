using System;

public class DefaultLayoutModel
{
    public List<string> participantNames { get; set; } = new List<string>();
    public int numRows { get; set; } = 0;
    public int numColumns { get; set; } = 0;
    public string customLayoutDirectory { get; set; } = "./Custom_Layouts/";

    //public DefaultLayoutModel(List<string> names, int rows, int columns, string layoutDirectory)
    //{
    //    participantNames = names;
    //    numRows = rows;
    //    numColumns = columns;
    //    customLayoutDirectory = layoutDirectory;
    //}
}

