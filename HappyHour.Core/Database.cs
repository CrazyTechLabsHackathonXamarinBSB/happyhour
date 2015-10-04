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
            _connection = connectionFactory.GetAsyncConnection("bd_happyhour");
        }

        internal async void InitDB()
        {
            await _connection.CreateTableAsync<Login>();
            await _connection.CreateTableAsync<BarLocal>();
            await _connection.CreateTableAsync<TempConfirm>();
        }

        public async void InserirLogin(Login login)
        {
            
            WS_HappyHour.Service1Client _srv = new WS_HappyHour.Service1Client();
            if(_srv != null)
            {
                _srv.CadastrarUsrAsync(login.Nmusr, login.Nmsenha, login.Nrtelefone, login.Nmemail);
                await _connection.InsertAsync(login);
            }
            

        }

        public async Task<Login> GetLogin(int id)
        {
           return await _connection.Table<Login>().Where(l => l.Id_usr == id).FirstOrDefaultAsync();
        }

        public async Task<int> GetLogin()
        {
            return await _connection.Table<Login>().CountAsync();
        }

        public async void InserirBarLocal(BarLocal local)
        {
            await _connection.InsertAsync(local);
        }

        public async void InserirTempConfirm(TempConfirm temp)
        {
            await _connection.InsertAsync(temp);
        }

        public async void ExcluirDados()
        {
            await _connection.ExecuteAsync("DELETE FROM Login");
        }

    }
}
