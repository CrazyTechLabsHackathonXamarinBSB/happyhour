using Cirrious.MvvmCross.ViewModels;
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHour.Core
{
    public class Cadastro_Bar : MvxViewModel
    {
        //private string _id_local;
        private string _nm_latitude;
        private string _nm_longitude;
        private string _descricao;

        [PrimaryKey, AutoIncrement]
        public int Id_local { get; set; }
        public string Nm_latitude { get { return _nm_latitude; } set { _nm_latitude = value; RaisePropertyChanged(() => Nm_latitude); } }
        public string Nm_longitude { get { return _nm_longitude; } set { _nm_longitude = value; RaisePropertyChanged(() => Nm_longitude); } }
        public string Descricao { get { return _descricao; } set { _descricao = value; RaisePropertyChanged(() => Descricao); } }
        //public string token { get; set; }
    }
}
