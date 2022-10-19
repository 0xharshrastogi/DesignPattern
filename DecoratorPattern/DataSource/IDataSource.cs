namespace DecoratorPattern.DataSource;

public interface IDataSource
{
    void WriteData(object data);

    object ReadData();
}
