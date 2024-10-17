public class TinhLuongNhanVien
{
    public void TinhLuong(double gioLam, double luongMoiGio)
    {
        double luongTong;

        if (gioLam > 40)
        {
            double gioThem = gioLam - 40;
            luongTong = (40 * luongMoiGio) + (gioThem * luongMoiGio * 1.5);
        }
        else
        {
            luongTong = gioLam * luongMoiGio;
        }

        Console.WriteLine($"Lương tổng cộng: {luongTong}");
    }
}
