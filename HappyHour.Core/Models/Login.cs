using Cirrious.MvvmCross.ViewModels;
using SQLite.Net.Attributes;

namespace HappyHour.Core
{
    public class Login : MvxNotifyPropertyChanged
    {
        private string _nmusr;
        private string _nmsenha;
        private int _nrtelefone;
        private string _nmmail;

        [PrimaryKey, AutoIncrement]
        public int Id_usr { get; set; }
        public string Nmusr { get { return _nmusr; } set { _nmusr = value; RaisePropertyChanged(() => Nmusr); } }
        public string Nmsenha { get { return _nmsenha; } set { _nmsenha = value; RaisePropertyChanged(() => Nmsenha); } }
        public int Nrtelefone  { get { return _nrtelefone; } set { _nrtelefone = value; RaisePropertyChanged(() => Nrtelefone); } }
        public string Nmemail { get { return _nmmail; } set { _nmmail = value; RaisePropertyChanged(() => Nmemail); } }
        //public string token { get; set; }

    }
}