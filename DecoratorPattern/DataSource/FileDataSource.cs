namespace DecoratorPattern.DataSource;

public class FileDataSource : IDataSource
{
    private readonly string _filename;

    public FileDataSource(string filename)
    {
        _filename = filename;
    }

    public object ReadData() => File.ReadAllBytes(_filename);

    public void WriteData(object data) => File.WriteAllText(_filename, data.ToString());
}
