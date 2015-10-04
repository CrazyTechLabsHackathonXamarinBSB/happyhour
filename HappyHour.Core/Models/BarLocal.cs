
using SQLite.Net.Attributes;

namespace HappyHour.Core
{
    public class BarLocal
    {
        [PrimaryKey, AutoIncrement]
        public int id_local { get; set; }
        public string nmLatitude { get; set; }
        public string nmLongitude { get; set; }
    }
}
