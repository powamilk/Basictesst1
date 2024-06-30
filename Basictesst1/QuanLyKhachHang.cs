﻿namespace Basictesst1
{
    public class QuanLyKhachHang
    {
        List<KhachHang> danhSachKhachHang;

        public QuanLyKhachHang()
        {
            danhSachKhachHang = new List<KhachHang>();
        }

        public void Them()
        {
            bool tiepTuc = true;
            while (tiepTuc)
            {
                Console.WriteLine("Nhap ho ten khach hang");
                string hoTen = Console.ReadLine();
                Console.WriteLine("Nhap Ma Khach Hang");
                string maKh = Console.ReadLine();
                Console.WriteLine("Nhap Loai San Pham ");
                int loaiSanPham = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so luong da mua");
                double soLuongDaMua = double.Parse(Console.ReadLine());

                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(maKh) ||
                    loaiSanPham < 1 || loaiSanPham > 3 || soLuongDaMua < 0)
                {
                    Console.WriteLine("Du lieu ko hop le, vui long nhap lai");
                    continue;
                }
                KhachHang khachHang = new KhachHang(hoTen, maKh, loaiSanPham, soLuongDaMua);
                danhSachKhachHang.Add(khachHang);

                Console.WriteLine("Ban co muon in tiep ko (y/n) ");
                string input = Console.ReadLine();
                tiepTuc = input.ToLower() == "y";
            }
        }

        public void XuatDanhSach()
        {
            if (danhSachKhachHang.Count == 0)
            {
                Console.WriteLine("Ko co khach hang nao");
                return;
            }
            else
            {
                danhSachKhachHang.Sort((x, y) => x.MaKh.CompareTo(y.MaKh));
                danhSachKhachHang.Sort((x, y) => x.SoLuongDaMua.CompareTo(y.SoLuongDaMua));

                foreach (var khachHang in danhSachKhachHang)
                {
                    khachHang.InThongTin();
                }
            }
        }

        public void Xoa(string maKh)
        {
            KhachHang khachHang = danhSachKhachHang.Find(kh => kh.MaKh == maKh);
            if (khachHang == null)
            {
                Console.WriteLine("khong the tim thay khach hang can xoa");
                return;
            }
            danhSachKhachHang.Remove(khachHang);
            Console.WriteLine("da xoa khach hang thanh cong");
        }

        public void XuatTheoTongChiPhi(double tuChiPhi, double denChiPhi)
        {
            List<KhachHang> danhSachTheoChiPhi = danhSachKhachHang.FindAll(kh => kh.TinhTongChiPhi()
            >= tuChiPhi && kh.TinhTongChiPhi() <= denChiPhi);

            if (danhSachTheoChiPhi.Count == 0)
            {
                Console.WriteLine($"Khong the tim thay khach hang trong khoan [{tuChiPhi} ; {denChiPhi}] ");
            }
            else
            {
                danhSachTheoChiPhi.Sort((x, y) => x.TinhTongChiPhi().CompareTo(y.TinhTongChiPhi()));
                foreach (var khachHang in danhSachTheoChiPhi)
                {
                    khachHang.InThongTin();
                }
            }
        }

        public void XuatkhachHangChiPhiCaoNhat()
        {
            KhachHang khachHangChiPhiCaoNhat = null;
            foreach (var khachHang in danhSachKhachHang)
            {
                if (khachHang.LoaiSanPham == 1)
                {
                    if (khachHangChiPhiCaoNhat == null || khachHang.TinhTongChiPhi() > khachHangChiPhiCaoNhat.TinhTongChiPhi())
                    {
                        khachHangChiPhiCaoNhat = khachHang;
                    }
                }
            }

            if (khachHangChiPhiCaoNhat == null)
            {
                Console.WriteLine("Hiện chưa có khách hàng nào");
            }
            else
            {
                khachHangChiPhiCaoNhat.InThongTin();
            }
        }

        public void ThemKhachHangVIP()
        {
            Console.WriteLine("Nhap ho ten khach hang");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Nhap Ma Khach Hang");
            string maKh = Console.ReadLine();
            Console.WriteLine("Nhap Loai San Pham ");
            int loaiSanPham = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so luong da mua");
            double soLuongDaMua = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phan tram giam gia");
            float phanTramGiamGia = float.Parse(Console.ReadLine());

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(maKh) ||
                loaiSanPham < 1 || loaiSanPham > 3 || soLuongDaMua < 0 || phanTramGiamGia < 0 || phanTramGiamGia > 100)
            {
                Console.WriteLine("Du lieu ko hop le, vui long nhap lai");
                return;
            }
            KhachHangVIP khachHangVIP = new KhachHangVIP(hoTen, maKh, loaiSanPham, soLuongDaMua, phanTramGiamGia);
            danhSachKhachHang.Add(khachHangVIP);

            khachHangVIP.InThongTin();
        }
    }
}
