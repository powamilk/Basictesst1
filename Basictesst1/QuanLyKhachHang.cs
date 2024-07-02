namespace Basictesst1
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
                 else
                {
                    var sortedDanhSach = danhSachKhachHang
                        .OrderBy(kh => kh.MaKh)
                        .ThenByDescending(kh => kh.SoLuongDaMua)
                        .ToList();

                    foreach (var khachHang in sortedDanhSach)
                    {
                        khachHang.InThongTin();
                    }
                }
            }
        }

        public void Xoa(string maKh)
        {
            KhachHang khachHang = danhSachKhachHang.FirstOrDefault(kh => kh.MaKh == maKh);
            if (khachHang == null)
            {
                Console.WriteLine("Không thể tìm thấy khách hàng cần xóa");
                return;
            }
            danhSachKhachHang.Remove(khachHang);
            Console.WriteLine("Đã xóa khách hàng thành công");
        }

        public void XuatTheoTongChiPhi(double tuChiPhi, double denChiPhi)
        {
            var danhSachTheoChiPhi = danhSachKhachHang
                .Where(kh => kh.TinhTongChiPhi() >= tuChiPhi && kh.TinhTongChiPhi() <= denChiPhi)
                .OrderBy(kh => kh.TinhTongChiPhi())
                .ToList();

            if (!danhSachTheoChiPhi.Any())
            {
                Console.WriteLine($"Không thể tìm thấy khách hàng trong khoảng [{tuChiPhi} ; {denChiPhi}]");
            }
            else
            {
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
