using Cirrious.MvvmCross.ViewModels;
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHour.Core.ViewModels
{
    class TemConfirm : MvxNotifyPropertyChanged
    {
        private int _id_usr;
        private int _id_contato;
        private byte _status;

        [PrimaryKey, AutoIncrement]
        public int Id_temp_conf { get; set; }
        public int Id_usr { get { return _id_usr; } set { _id_usr = value; RaisePropertyChanged(() => Id_usr); } }
        public int Id_contato { get { return _id_contato; } set { _id_contato = value; RaisePropertyChanged(() => Id_contato); } }
        public byte Status { get { return _status; } set { _status = value; RaisePropertyChanged(() => Status); } }
        //public string token { get; set; }
    }
}
