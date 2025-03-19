using System.IO;
class Program
{
    public string currentDirectory;
    public int[255] file1;
    public int[255] file2;
    public int[255] file3;
    public int[2047] file4;
    public int[2047] file5;
    public int[2047] file6;
    public int[6][] allFiles = new int[][] {file1, file2, file3, file4, file5, file6};
    private int counter = 0;
    public Program()
    {
        currentDirectory = GetCurrentDirectory();
    }

    public openFile()
    {
        while (counter < 6)
        {
            if (counter < 3)
            {
                int internalCounter = 0;
                int tempValue = 0;
                string fullFilePath = Path.Combine(currentDirectory, $"share_{counter+1}_256");
                StreamReader sr = new StreamReader(fullFilePath);
                line = sr.ReadLine();
                while (internalCounter <256)
                {
                    tempValue = int.Parse(line);
                    allFiles[counter][internalCounter] = tempValue
                    internalCounter++
                }
            }
            else if (counter < 6)
            {
                int internalCounter = 0;
                int tempValue = 0;
                string fullFilePath = Path.Combine(currentDirectory, $"share_{counter+1}_2048");
                StreamReader sr = new StreamReader(fullFilePath);
                line = sr.ReadLine();
                while (internalCounter <2048)
                {
                    tempValue = int.Parse(line);
                    allFiles[counter][internalCounter] = tempValue
                    internalCounter++
                }
            }
            counter++
        }
    }
}