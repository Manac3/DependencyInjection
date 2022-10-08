Service service = new Service();
service.GetList(new SqlDatabase()); // constructer injection üzerinden tek bir obje enjekte edilip enjekte edilen class'ta kullanılabilir method ve property injection'da farklı objeler enjekte edilebilir.

class Service
{
    private readonly IDatabase _database;

    public void GetList(IDatabase database)
    {
        database.List();
    }//method injection
    
}
interface IDatabase
{
    void List();
}
class SqlDatabase : IDatabase
{
    public void List()
    {
        Console.WriteLine("Listed by Sql");
    }
}