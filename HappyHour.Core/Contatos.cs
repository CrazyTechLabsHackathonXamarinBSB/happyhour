using Cirrious.MvvmCross.ViewModels;
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHour.Core
{
    public class Contatos : MvxNotifyPropertyChanged
    {
        private string _id_usr;
        private int _nrtelefone;
        private byte _status;

        [PrimaryKey, AutoIncrement]
        public int Id_contato { get; set; }
        public string Id_usr { get { return _id_usr; } set { _id_usr = value; RaisePropertyChanged(() => Id_usr); } }
        public int Nrtelefone { get { return _nrtelefone; } set { _nrtelefone = value; RaisePropertyChanged(() => Nrtelefone); } }
        public byte Status { get { return _status; } set { _status = value; RaisePropertyChanged(() => Status); } }
        //public string token { get; set; }
    }
}
