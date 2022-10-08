Service service = new Service()
{
    Logger = new Logger(),
    Deleter = new Deleter()
};
service.Add();

class Service
{
    public ILogger Logger { get; set; }
    public IDelete Deleter { get; set;  }
    public void Add()
    {
        Console.WriteLine("Added");
        Logger.Log();
        Deleter.Delete();
    }
}
interface ILogger
{
    void Log();
}
class Logger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged");
    }
}
interface IDelete
{
    void Delete();
}
class Deleter : IDelete
{
    public void Delete()
    {
        Console.WriteLine("Deleted");
    }
}