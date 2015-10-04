using SQLite.Net.Attributes;

namespace HappyHour.Core
{
    public class Login
    {
        [PrimaryKey, AutoIncrement]
        public int id_usr { get; set; }
        public string nmusr { get; set; }
        public string nmsenha { get; set; }
        public int nrtelefone { get; set; }
        public string nmmail { get; set; }
        //public string token { get; set; }

    }
}