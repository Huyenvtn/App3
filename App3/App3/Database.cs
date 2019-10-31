using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool createDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.CreateTable<LoaiHoa>();
                    connection.CreateTable<Hoa>();
                    return true;
                }
            }
            catch(SQLiteException e)
            {
                return false;
            }
        }
        public bool themLoaiHoa (LoaiHoa loai)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(loai);
                    return true;
                }
            }
            catch(SQLiteException e)
            {
                return false;
            }
        }
        public List<LoaiHoa> chonLoaiHoa()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<LoaiHoa>().ToList();
                }
            }
            catch (SQLiteException e)
            {
                return null;
            }
        }
        public bool themHoa (Hoa hoa)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(hoa);
                    return true;
                }
            }
            catch(SQLiteException e)
            {
                return false;
            }
        }
        public List<Hoa> chonHoa ()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<Hoa>().ToList();
                }
            }
            catch (SQLiteException e)
            {
                return null;
            }

        }
    }
}
