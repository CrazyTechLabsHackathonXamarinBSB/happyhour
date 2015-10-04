using SQLite.Net.Attributes;

namespace HappyHour.Core
{
    public class TempConfirm
    {
        [PrimaryKey, AutoIncrement]
        public int id_temp_conf { get; set; }
        public int id_usr { get; set; }
        public int id_usr2 { get; set; }
        public byte status { get; set; }

    }
}
