using System.Text;

using DecoratorPattern.DataSource;

//var filepath = Path.Combine(Directory.GetCurrentDirectory(), "");

var fileDataSource = new EncryptionDataSouceDecorator(new CompressionDataSouceDecorator(new FileDataSource("DesignPattern.sln")));

var data = Encoding.UTF8.GetString((byte[])fileDataSource.ReadData());

Console.WriteLine(data);
