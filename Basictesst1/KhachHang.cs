using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basictesst1
{
    public class KhachHang
    {
        private string hoTen;
        private string maKh;
        private int loaiSanPham;
        private double soLuongDaMua;

        //contructor ko tham so
         public KhachHang() 
        { 
        }

        //contructor co tham so
        public KhachHang(string hoTen, string maKh, int loaiSanPham, double soLuongDaMua)
        {
            this.hoTen = hoTen;
            this.maKh = maKh;
            this.loaiSanPham = loaiSanPham;
            this.soLuongDaMua = soLuongDaMua;
        }

        //getter setter
        public string HoTen { get => HoTen; set => HoTen = value; }
        public string MaKh { get => MaKh; set => MaKh = value; }
        public int LoaiSanPham { get => LoaiSanPham ; set => LoaiSanPham = value; }
        public double SoLuongDaMua { get => SoLuongDaMua; set => SoLuongDaMua = value; }
        public object MaKH { get; internal set; }

        //Phuong thuc in thong tin

        public void inThongTin()
        {
            double donGia = TinhDonGia();
            double tongChiPhi = TinhTongChiPhi();
            Console.WriteLine($"Ho ten: {hoTen} + Ma Khach Hang: {maKh} + Loai San Pham:{loaiSanPham} + $So luong da mua: {soLuongDaMua} + Don gia : {donGia}");
        }

        public double TinhTongChiPhi()
        {
            double donGia = TinhDonGia();
            return soLuongDaMua + donGia;
        }

        public double TinhDonGia()
        {
            double donGia;
            switch (loaiSanPham)
            {
                case 1:
                    donGia = 50000;
                    break;
                case 2:
                    donGia = 70000;
                    break;
                case 3:
                    donGia = 100000;
                    break;
                default:
                    donGia = 0;
                    break;
            }
            return donGia;
        }
    }
}
