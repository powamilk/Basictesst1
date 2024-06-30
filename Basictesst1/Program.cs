using Basictesst1;
using System;

class Program
{
    static void Main(string[] args)
    {
        QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
        bool thoat = false;
        while (!thoat)
        {
            Console.WriteLine("Quan Ly Khach Hang");
            Console.WriteLine("1. Nhap khach Hang");
            Console.WriteLine("2. Xuat danh sach");
            Console.WriteLine("3. Xoa Khach Hang");
            Console.WriteLine("4. xuat theo tong chi phi");
            Console.WriteLine("5. Xuat Theo chi phi cao nhat");
            Console.WriteLine("6. Them Khach Hang VIP");
            Console.WriteLine("7. Thoat");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    quanLyKhachHang.Them();
                    break;
                case 2:
                    quanLyKhachHang.XuatDanhSach();
                    break;
                case 3:
                    Console.WriteLine("Nhap Ma Khach Hang can xoa");
                    string maKh = Console.ReadLine();
                    quanLyKhachHang.Xoa(maKh);
                    break;
                case 4:
                    Console.WriteLine("Nhap khoang chi phi tu:");
                    double tuChiPhi = double.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap khoang chi phi den:");
                    double denChiPhi = double.Parse(Console.ReadLine());
                    quanLyKhachHang.XuatTheoTongChiPhi(tuChiPhi, denChiPhi);
                    break;
                case 5:
                    quanLyKhachHang.XuatkhachHangChiPhiCaoNhat();
                    break;
                case 6:
                    quanLyKhachHang.ThemKhachHangVIP();
                    break;
                case 7:
                    thoat = true;
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le, vui long chon lai");
                    break;
            }
        }
    }
}
