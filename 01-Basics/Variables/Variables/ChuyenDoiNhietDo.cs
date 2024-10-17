using System;

public class ChuyenDoiNhietDo
{
    public void ChuyenDoi(double doC)
    {
        double doF = (doC * 9 / 5) + 32;
        Console.WriteLine($"Nhiệt độ {doC} độ C tương đương {doF} độ F");
    }
}
