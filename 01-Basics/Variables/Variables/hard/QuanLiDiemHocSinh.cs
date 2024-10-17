using System;

class Student
{
    public string Ten { get; set; }
    public double DiemToan { get; set; }
    public double DiemVan { get; set; }
    public double DiemLy { get; set; }

    public Student(string ten, double diemToan, double diemVan, double diemLy)
    {
        Ten = ten;
        DiemToan = diemToan;
        DiemVan = diemVan;
        DiemLy = diemLy;
    }

    public double TinhDiemTrungBinh()
    {
        return (DiemToan + DiemVan + DiemLy) / 3;
    }

    public void PhanLoai()
    {
        double diemTB = TinhDiemTrungBinh();
        string loaiHocSinh;

        if (diemTB >= 8)
            loaiHocSinh = "Giỏi";
        else if (diemTB >= 6.5)
            loaiHocSinh = "Khá";
        else if (diemTB >= 5)
            loaiHocSinh = "Trung bình";
        else
            loaiHocSinh = "Yếu";

        Console.WriteLine($"Học sinh {Ten} có điểm trung bình là {diemTB}, được xếp loại: {loaiHocSinh}.");
    }
}

class QuanLyDiemHocSinh
{
    static void Main(string[] args)
    {
        var hocSinh = new Student("Nguyen Van A", 7.5, 8.0, 6.0);
        hocSinh.PhanLoai();
    }
}
