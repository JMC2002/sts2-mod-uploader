namespace ModUploader;

public static class Log
{
    private static StreamWriter streamWriter;

    static Log()
    {
        FileStream fileStream = new FileStream("mod-uploader.log", FileMode.OpenOrCreate);
        streamWriter = new StreamWriter(fileStream);
    }

    public static void Info(string log)
    {
        Console.WriteLine(log);
        streamWriter.WriteLine(log);
    }
}