namespace DecoratorPattern.DataSource;

public class EncryptionDataSouceDecorator : DataSourceDecorator
{
    public EncryptionDataSouceDecorator(IDataSource dataSource) : base(dataSource)
    { }

    public override object ReadData()
    {
        var encryptedData = base.ReadData();
        Console.WriteLine("Data Decrypted");
        return encryptedData;
    }

    public override void WriteData(object data)
    {
        Console.WriteLine("Encrypting Data");
        base.WriteData(data);
    }
}
