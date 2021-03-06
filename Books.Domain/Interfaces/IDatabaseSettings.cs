namespace Books.Domain.Interfaces
{
  public interface IDatabaseSettings
  {
    string BooksCollectionName { get; set; }
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
  }
}