using System;

namespace Basictesst1
{
    public class KhachHang
    {
        private string hoTen;
        private string maKh;
        private int loaiSanPham;
        private double soLuongDaMua;

        // Constructor không tham số
        public KhachHang()
        {
        }

        // Constructor có tham số
        public KhachHang(string hoTen, string maKh, int loaiSanPham, double soLuongDaMua)
        {
            this.hoTen = hoTen;
            this.maKh = maKh;
            this.loaiSanPham = loaiSanPham;
            this.soLuongDaMua = soLuongDaMua;
        }

        // Getter và Setter
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string MaKh { get => maKh; set => maKh = value; }
        public int LoaiSanPham { get => loaiSanPham; set => loaiSanPham = value; }
        public double SoLuongDaMua { get => soLuongDaMua; set => soLuongDaMua = value; }
        public object MaKH { get; internal set; }

        // Phương thức in thông tin
        public void InThongTin()
        {
            double donGia = TinhDonGia();
            double tongChiPhi = TinhTongChiPhi();
            Console.WriteLine($"Ho ten: {hoTen} + Ma Khach Hang: {maKh} + Loai San Pham: {loaiSanPham} + So luong da mua: {soLuongDaMua} + Don gia: {donGia}");
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
                    Console.WriteLine("Loại sản phẩm ko hợp lệ")
                    break;
            }
            return donGia;
        }
    }
}
