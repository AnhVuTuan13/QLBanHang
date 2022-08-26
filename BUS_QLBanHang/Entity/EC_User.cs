using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.Entity
{
    public class EC_User
    {
        private string _UserName;
        private string _Password;
        private string _PhanQuyen;
        private string _MaNV;
        DAL_QL dal = new DAL_QL();

        public void loadUser(string UName)
        {
            string sqltk =string.Format("select*from tb_User where UserName='{0}'", UName);
            this.UserName = UName;
            this.Password = dal.getString(sqltk, "Password");
            this.PhanQuyen = dal.getString(sqltk, "PhanQuyen");
            this.MaNV = dal.getString(sqltk, "MaNhanVien");
        }
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
                if (_UserName == "")
                {
                    throw new Exception("Tên Đăng Nhập Không Được Để Trống!");
                }
            }
        }
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
                if (_Password == "")
                {
                    throw new Exception("Mật Khẩu Không Được Để Trống!");
                }
            }
        }

        public string PhanQuyen
        {
            get
            {
                return _PhanQuyen;
            }
            set
            {
                _PhanQuyen = value;
                if (_PhanQuyen == "")
                {
                    throw new Exception("Quyền Truy Cập Không Được Để Trống!");
                }
            }
        }

        public string MaNV
        {
            get
            {
                return _MaNV;
            }
            set
            {
                _MaNV = value;                
            }
        }
    }
}
