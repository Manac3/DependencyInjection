Service service = new Service();
service.Logger = new Logger();
service.Add();

class Service
{
    public ILogger Logger { get; set; }
    public void Add()
    {
        Console.WriteLine("Added");
        Logger.Log();
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