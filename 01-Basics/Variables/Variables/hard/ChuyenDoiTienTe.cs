using System;

class ChuyenDoiTienTe
{
    static void Main(string[] args)
    {
        Console.Write("Nhập số tiền cần chuyển đổi: ");
        double soTien = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Chọn đơn vị tiền tệ cần chuyển đổi (1: USD -> EUR, 2: USD -> JPY, 3: USD -> VND): ");
        int luaChon = Convert.ToInt32(Console.ReadLine());

        double tiGia = 0;

        switch (luaChon)
        {
            case 1:
                tiGia = 0.85;  // 1 USD = 0.85 EUR
                break;
            case 2:
                tiGia = 110.53;  // 1 USD = 110.53 JPY
                break;
            case 3:
                tiGia = 23000;  // 1 USD = 23,000 VND
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                return;
        }

        double ketQua = soTien * tiGia;
        Console.WriteLine($"Số tiền sau khi chuyển đổi: {ketQua}");
    }
}
