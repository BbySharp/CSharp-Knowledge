using System;

class TinhToanHoanVon
{
    static void Main(string[] args)
    {
        Console.Write("Nhập số tiền đầu tư ban đầu: ");
        double soTienDauTu = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập lãi suất hàng năm (%): ");
        double laiSuat = Convert.ToDouble(Console.ReadLine()) / 100;

        int nam = 0;
        double giaTriDauTu = soTienDauTu;

        while (giaTriDauTu < soTienDauTu * 2)
        {
            giaTriDauTu += giaTriDauTu * laiSuat;
            nam++;
        }

        Console.WriteLine($"Số năm cần để số tiền đầu tư tăng gấp đôi: {nam} năm.");
    }
}
