using Books.Domain.Interfaces;

namespace Books.Infra.Settings
{
  public class DatabaseSettings : IDatabaseSettings
  {
    public string BooksCollectionName { get; set; }
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
  }

}