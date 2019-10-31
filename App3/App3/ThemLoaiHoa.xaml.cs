using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThemLoaiHoa : ContentPage
	{
		public ThemLoaiHoa ()
		{
			InitializeComponent ();
		}
        private void cmdThem_clicked(object sender, EventArgs e)
        {
            Database db = new Database();
            LoaiHoa lh = new LoaiHoa { TenLoai = txtTenLoai.Text };
            if (db.themLoaiHoa(lh) == true)
            {
                DisplayAlert("Thông báo", "Thêm loại hoa mới thành công !", "OK");
            }
            else
            {
                DisplayAlert("Thông báo", "Lỗi khi thêm loại hoa này", "OK");
            }
        }
	}
}