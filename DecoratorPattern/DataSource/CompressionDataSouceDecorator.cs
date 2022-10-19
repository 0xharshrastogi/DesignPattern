namespace DecoratorPattern.DataSource;

public class CompressionDataSouceDecorator : DataSourceDecorator
{
    public CompressionDataSouceDecorator(IDataSource dataSource) : base(dataSource)
    { }

    public override object ReadData()
    {
        var result = base.ReadData();
        Console.WriteLine("Data Decompressed");
        return result;

    }

    public override void WriteData(object data)
    {
        Console.WriteLine("Data Compressed");
        base.WriteData(data);
    }
}
