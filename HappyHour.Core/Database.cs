using Cirrious.CrossCore;
using MvvmCross.Plugins.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Async;

namespace HappyHour.Core
{
    public class Database
    {
        private SQLiteAsyncConnection _connection;

        public Database()
        {
            var connectionFactory = Mvx.Resolve<IMvxSqliteConnectionFactory>();
            _connection = connectionFactory.GetAsyncConnection("HappyHourDB");
        }

        internal async void InitDB()
        {
            await _connection.CreateTableAsync<Login>();
        }

        public async void InserirLogin(Login login)
        {
            await _connection.InsertAsync(login);
        }

        public async Task<Login> GetLogin(int id)
        {
            return await _connection.Table<Login>().FirstOrDefaultAsync(l => l.Id == id);
        }
    }
}
