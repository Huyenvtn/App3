using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    public class LoaiHoa
    {
        [PrimaryKey, AutoIncrement]
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
    }
}
