using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyHour.Droid.Views
{
    class Database
    {
        //objeto para manipula��o do banco de dados SQLiteDatabase 
        private SQLiteDatabase sqldb; //String para manipula��o da consulta 
        private string sqldb_query; //String para manipula��o Mensagem 
        private string sqldb_mensagem; //Bool para verificar a disponibilidade do banco de dados 
        private bool sqldb_Instance; //Inicializa uma nova inst�ncia de classe de banco de dados 
        public Database()
        {
            sqldb_mensagem = "";
            sqldb_Instance = false;
        }

        //Construtor
        public Database(string sqldb_nome)
        {
            try
            {
                sqldb_nome = "bd_happyhour";
                sqldb_Instance = false;

            }
            catch (SQLiteException e)
            {
                sqldb_mensagem = e.Message;
            }
        }
   
    }
}