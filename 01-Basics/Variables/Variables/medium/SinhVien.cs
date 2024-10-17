//TODO Medium
// Bài 1: Viết chương trình quản lý thông tin sinh viên.
// Lưu trữ thông tin như tên, tuổi, điểm trung bình. In ra thông tin và phân loại sinh viên dựa trên điểm trung bình.


public class SinhVien
{
    public string Ten { get; set; }
    public int Tuoi { get; set; }
    public double DiemTrungBinh { get; set; }

    public string PhanLoai()
    {
        if (DiemTrungBinh >= 8.0)
            return "Giỏi";
        else if (DiemTrungBinh >= 6.5)
            return "Khá";
        else if (DiemTrungBinh >= 5.0)
            return "Trung bình";
        else
            return "Yếu";
    }

    public void InThongTin()
    {
        Console.WriteLine($"Tên: {Ten}, Tuổi: {Tuoi}, Điểm trung bình: {DiemTrungBinh}, Phân loại: {PhanLoai()}");
    }
}
