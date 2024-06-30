namespace Basictesst1
{
    public class KhachHangVIP : KhachHang
    {
        private float phanTramGiamGia;

        // Constructor không tham số
        public KhachHangVIP() : base()
        {
        }

        // Constructor có tham số
        public KhachHangVIP(string hoTen, string maKh, int loaiSanPham, double soLuongDaMua, float phanTramGiamGia)
            : base(hoTen, maKh, loaiSanPham, soLuongDaMua)
        {
            this.phanTramGiamGia = phanTramGiamGia;
        }

        // Getter và Setter
        public float PhanTramGiamGia { get => phanTramGiamGia; set => phanTramGiamGia = value; }

        // Override phương thức in thông tin
        public override void InThongTin()
        {
            double donGia = TinhDonGia();
            double tongChiPhi = TinhTongChiPhi();
            Console.WriteLine($"Ho ten: {HoTen} + Ma Khach Hang: {MaKh} + Loai San Pham: {LoaiSanPham} + So luong da mua: {SoLuongDaMua} + Don gia: {donGia} + Phan tram giam gia: {phanTramGiamGia}% + Tong chi phi: {tongChiPhi}");
        }

        // Override phương thức tính tổng chi phí
        public override double TinhTongChiPhi()
        {
            double donGia = TinhDonGia();
            return (SoLuongDaMua * donGia) * (1 - phanTramGiamGia / 100);
        }
    }
}
