using System;
using System.Collections.Generic;

class Product
{
    public string TenSanPham { get; set; }
    public int SoLuong { get; set; }
    public double Gia { get; set; }

    public Product(string tenSanPham, int soLuong, double gia)
    {
        TenSanPham = tenSanPham;
        SoLuong = soLuong;
        Gia = gia;
    }
}

class QuanLyKhoHang
{
    static void Main(string[] args)
    {
        List<Product> danhSachSanPham = new List<Product>
        {
            new Product("San Pham 1", 10, 10000),
            new Product("San Pham 2", 5, 20000),
            new Product("San Pham 3", 7, 15000)
        };

        double tongGiaTriHangTonKho = 0;

        foreach (var sanPham in danhSachSanPham)
        {
            tongGiaTriHangTonKho += sanPham.SoLuong * sanPham.Gia;
        }

        Console.WriteLine($"Tổng giá trị hàng tồn kho: {tongGiaTriHangTonKho} đồng.");
    }
}
