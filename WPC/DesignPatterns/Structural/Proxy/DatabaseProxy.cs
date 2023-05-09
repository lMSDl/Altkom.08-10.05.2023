using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Proxy
{
    internal class DatabaseProxy : IDatabase
    {
        private IDatabase _database;
        Func<IDatabase> _openDatabase;

        public DatabaseProxy(IDatabase database, Func<IDatabase> openDatabase)
        {
            _database = database;
            _openDatabase = openDatabase;
        }

        private const int InitialCount = 4;
        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(InitialCount);

        public async Task<int?> RequestAsync(int parameter)
        {
            if (_database == null && _openDatabase != null)
            {
                await Console.Out.WriteLineAsync("Otwieranie połączenia z bazą");
                _database = _openDatabase();
            }

            await semaphore.WaitAsync();

            var result = await _database.RequestAsync(parameter);

            semaphore.Release();

            if(_openDatabase != null && semaphore.CurrentCount == InitialCount)
            {
                Console.WriteLine("Zamykanie bazy danych");
                _database = null;
            }

            return result;
        }
    }
}
