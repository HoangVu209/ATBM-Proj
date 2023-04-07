using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanvienDTO
    {

        // private data
        private string _maNV;
        private string _tenNV;
        private string _ngaySinh;
        private string _diaChi;
        private string _SDT;
        private double _Luong;
        private double _phuCap;
        private string _vaiTro;

        // constructor
        NhanvienDTO()
        {
            _maNV = string.Empty;
            _tenNV = string.Empty;
            _ngaySinh = string.Empty;
            _diaChi = string.Empty;
            _SDT = string.Empty;
            _Luong = double.NaN;
            _phuCap = double.NaN;
            _vaiTro = string.Empty;
        }
        NhanvienDTO(string maNV, string tenNV, string ngaySinh, string diaChi, string SDT, double Luong,
            double phuCap, string vaiTro)
        {
            _maNV = maNV;
            _tenNV = tenNV;
            _ngaySinh = ngaySinh;
            _diaChi = diaChi;
            _SDT = SDT;
            _Luong = Luong;
            _phuCap = phuCap;
            _vaiTro = vaiTro;
        }

        // get method
        public string maNV() { return _maNV; }
        public string tenNV() { return _tenNV; }
        public string ngaySinh() { return _ngaySinh; }
        public string diaChi() { return _diaChi; }
        public string SDT() { return _SDT; }
        public double Luong() { return _Luong; }
        public double phuCap() { return _phuCap; }
        public string vaiTro() { return _vaiTro; }
    }
    public class DBA_ROLESDTO
    {

    }

    public class ROLE_TAB_PRIVSDTO
    {

    }
    public class DBA_ROLE_PRIVSDTO
    {
        private string _grantee;
        public DBA_ROLE_PRIVSDTO(string grantee)
        {
            _grantee = grantee;
        }
        public string Grantee()
        {
            return _grantee;
        }
    }
    public class USER_TAB_PRIVSDTO
    {
        private string _grantee;
        public USER_TAB_PRIVSDTO(string grantee)
        {
            _grantee = grantee;
        }
        public string Grantee()
        {
            return _grantee;
        }

    }
}
