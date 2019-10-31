using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    public class Hoa
    {
        [PrimaryKey, AutoIncrement]
        public int MaHoa { get; set; }
        public int MaLoai { get; set; }
        public string TenHoa { get; set; }
        public string Hinh { get; set; }
        public string MoTa { get; set; }
        public string DonGia { get; set; }

    }
}
