namespace DecoratorPattern.DataSource;

public class DataSourceDecorator : IDataSource
{
    public IDataSource DataSource { get; set; }

    public DataSourceDecorator(IDataSource dataSource)
    {
        DataSource = dataSource;
    }

    public virtual object ReadData() => DataSource.ReadData();

    public virtual void WriteData(object data) => DataSource.WriteData(data);
}
