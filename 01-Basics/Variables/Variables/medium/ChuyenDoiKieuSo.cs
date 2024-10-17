public class ChuyenDoiKieuSo
{
    public void ChuyenDoi()
    {
        double soDouble = 12.34;
        int soInt = (int)soDouble;  // Ép kiểu từ double sang int
        Console.WriteLine($"Double: {soDouble}, sau khi chuyển sang int: {soInt}");

        int soNguyen = 10;
        double soThuc = soNguyen;  // Chuyển đổi từ int sang double
        Console.WriteLine($"Int: {soNguyen}, sau khi chuyển sang double: {soThuc}");
    }
}
