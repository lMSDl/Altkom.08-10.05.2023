namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseService : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Closing DB connection.");
        }

        public void Insert(object @string)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + @string);
        }
    }
}