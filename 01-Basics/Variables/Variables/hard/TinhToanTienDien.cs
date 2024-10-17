using System;

class TinhToanTienDien
{
    static void Main(string[] args)
    {
        Console.Write("Nhập số điện tiêu thụ (kWh): ");
        double soDien;
        if (double.TryParse(Console.ReadLine(), out soDien))
        {
            double tienDien = 0;
            if (soDien <= 50)
            {
                tienDien = soDien * 1500;
            }
            else if (soDien <= 100)
            {
                tienDien = (50 * 1500) + ((soDien - 50) * 2000);
            }
            else
            {
                tienDien = (50 * 1500) + (50 * 2000) + ((soDien - 100) * 2500);
            }

            Console.WriteLine($"Tổng tiền điện phải trả: {tienDien} đồng.");
        }
        else
        {
            Console.WriteLine("Số điện không hợp lệ.");
        }
    }
}
