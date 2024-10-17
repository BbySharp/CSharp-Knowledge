public class PhamViBien
{
    static int bienToanCuc = 10;  // Biến toàn cục

    public void ThayDoiBien()
    {
        int bienCucBo = 5;  // Biến cục bộ
        Console.WriteLine($"Biến toàn cục trước khi thay đổi: {bienToanCuc}");
        Console.WriteLine($"Biến cục bộ: {bienCucBo}");

        bienToanCuc = 20;  // Thay đổi giá trị biến toàn cục
        Console.WriteLine($"Biến toàn cục sau khi thay đổi: {bienToanCuc}");
    }
}
