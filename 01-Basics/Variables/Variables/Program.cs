//TODO Easy
// Bài 1: Khai báo và khởi tạo các biến kiểu int, double, char, bool, và string.
// In ra giá trị của các biến sau khi khởi tạo.

Console.Write("Nhập số nguyên (Int): ");
string? inputInt = Console.ReadLine();
int variableInt;
if (int.TryParse(inputInt, out variableInt))
{
    Console.WriteLine($"Giá trị của số nguyên là: {variableInt}");
}
else
{
    Console.WriteLine("Input không phải kiểu Int, vui lòng nhập lại!");
}

Console.Write("Nhập số thực (double): ");
string? inputDouble = Console.ReadLine();
double variableDouble;
if (double.TryParse(inputDouble, out variableDouble))
{
    Console.WriteLine($"Giá trị số thực là: {variableDouble}");
}
else
{
    Console.WriteLine("Input không phải kiểu Double, vui lòng nhập lại!");

}

Console.Write("Nhập một kí tự (char): ");
string? inputChar = Console.ReadLine();
if (!string.IsNullOrEmpty(inputChar) && inputChar.Length == 1)
{
    char variableChar = Convert.ToChar(inputChar);
    Console.WriteLine($"Giá trị ký tự: {variableChar}");
}
else
{
    Console.WriteLine("Input không phải kiểu Char, vui lòng nhập lại!");
}

Console.Write("Nhập giá trị boolean (true/false): ");
string? inputBool = Console.ReadLine();
bool variableBool;
if (bool.TryParse(inputBool, out variableBool))
{
    Console.WriteLine($"Giá trị boolean: {variableBool}");
}
else
{
    Console.WriteLine("Đầu vào không hợp lệ cho kiểu bool.");
}

Console.Write("Nhập chuỗi (string): ");
string? variableString = Console.ReadLine();
Console.WriteLine($"Giá trị chuỗi: {variableString}");


// Bài 2: Viết chương trình tính tổng, hiệu, tích, thương của hai số nguyên.
// Người dùng nhập vào hai số từ bàn phím và in ra các kết quả tính toán.

Console.Write("Nhập vào số nguyên thứ nhất: ");
string? inputA = Console.ReadLine();
int numA;

if (!int.TryParse(inputA, out numA))
{
    Console.WriteLine("Vui lòng nhập số nguyên thứ nhất hợp lệ!");
    return;
}

Console.Write("Nhập vào số nguyên thứ hai: ");
string? inputB = Console.ReadLine();
int numB;

if (!int.TryParse(inputB, out numB))
{
    Console.WriteLine("Vui lòng nhập số nguyên thứ nhất hợp lệ!");
    return;
}

int tong = numA + numB ;
int hieu = numA - numB ;
int tich = numA * numB ;
int? thuong = null;

if (numB != 0)
{
    thuong = numA / numB;
}

Console.WriteLine($"Tổng = {tong}");
Console.WriteLine($"Hiệu = {hieu}");
Console.WriteLine($"Tích = {tich}");

if (thuong.HasValue)
{
    Console.WriteLine($"Thương = {thuong.Value}");
}
else
{
    Console.WriteLine("Không thể chia cho 0.");
}

// Bài 3: Kiểm tra kiểu dữ liệu của biến.
// Khai báo một biến kiểu object, kiểm tra xem nó là kiểu số nguyên hay chuỗi.
object variable = "123";  

if (variable is int)
{
    Console.WriteLine("Biến này là kiểu số nguyên (int).");
}
else if (variable is string)
{
    Console.WriteLine("Biến này là kiểu chuỗi (string).");
}
else
{
    Console.WriteLine("Biến này không phải là số nguyên hay chuỗi.");
}


// Bài 4: Chuyển đổi kiểu dữ liệu từ string sang int.
// Yêu cầu người dùng nhập một chuỗi, sau đó chuyển chuỗi đó thành số nguyên và in ra kết quả.
Console.Write("Nhập một chuỗi để chuyển đổi thành số nguyên: ");
string? input = Console.ReadLine();

int number;
bool isConversionSuccessful = int.TryParse(input, out number);

if (isConversionSuccessful)
{
    Console.WriteLine($"Chuyển đổi thành công! Số nguyên là: {number}");
}
else
{
    Console.WriteLine("Chuyển đổi thất bại. Chuỗi không thể chuyển thành số nguyên.");
}


// Bài 5: Sử dụng hằng số (`const`) để tính diện tích hình tròn.
// Khai báo hằng số Pi và tính diện tích hình tròn với bán kính do người dùng nhập vào.
// Khai báo hằng số Pi
const double Pi = 3.14159;

// Yêu cầu người dùng nhập bán kính
Console.Write("Nhập bán kính của hình tròn: ");
string? radiusInput = Console.ReadLine();

// Cố gắng chuyển đổi chuỗi bán kính thành số thực (double)
double radius;
bool isValidRadius = double.TryParse(radiusInput, out radius);

// Tính diện tích nếu bán kính hợp lệ
if (isValidRadius && radius > 0)
{
    double area = Pi * radius * radius;
    Console.WriteLine($"Diện tích hình tròn là: {area}");
}
else
{
    Console.WriteLine("Bán kính không hợp lệ. Vui lòng nhập một số thực dương.");
}

//TODO Medium
// Bài 1: Viết chương trình quản lý thông tin sinh viên.
// Lưu trữ thông tin như tên, tuổi, điểm trung bình. In ra thông tin và phân loại sinh viên dựa trên điểm trung bình.


// Bài 2: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F.
// Công thức: F = (C * 9/5) + 32. Yêu cầu người dùng nhập nhiệt độ C, tính toán và in ra nhiệt độ F.


// Bài 3: Chuyển đổi kiểu dữ liệu giữa các kiểu số.
// Khai báo biến kiểu double và int, sau đó thực hiện chuyển đổi giữa hai kiểu và in ra kết quả.


// Bài 4: Kiểm tra phạm vi của biến cục bộ và biến toàn cục.
// Khai báo biến toàn cục và biến cục bộ trong một hàm, sau đó thay đổi giá trị của chúng và in ra kết quả.


// Bài 5: Viết chương trình tính lương nhân viên.
// Yêu cầu nhập giờ làm việc và lương mỗi giờ. Nếu giờ làm việc trên 40 giờ thì tính thêm 1.5 lần cho giờ làm thêm.

//TODO Hard
// Bài 1: Viết chương trình tính toán tiền điện.
// Yêu cầu người dùng nhập số điện đã tiêu thụ. Sử dụng các điều kiện:
// - Dưới 50kWh: giá 1.500 đồng/kWh
// - Từ 51-100kWh: giá 2.000 đồng/kWh
// - Trên 100kWh: giá 2.500 đồng/kWh
// In ra tổng số tiền điện phải trả.


// Bài 2: Viết chương trình quản lý kho hàng.
// Khai báo một lớp "Product" với các thuộc tính tên sản phẩm, số lượng, và giá. Tạo danh sách sản phẩm và tính tổng giá trị hàng tồn kho.


// Bài 3: Viết chương trình tính toán thời gian hoàn vốn của một khoản đầu tư.
// Yêu cầu nhập số tiền đầu tư, lãi suất hàng năm và tính toán số năm cần để số tiền đầu tư ban đầu tăng gấp đôi.


// Bài 4: Viết chương trình chuyển đổi tiền tệ.
// Người dùng nhập số tiền và chọn đơn vị tiền tệ cần chuyển đổi (ví dụ: USD sang EUR, JPY, hoặc VND). Chương trình sẽ tính và in ra kết quả sau khi chuyển đổi.


// Bài 5: Viết chương trình quản lý điểm học sinh.
// Khai báo một lớp "Student" với các thuộc tính tên, điểm toán, điểm văn, điểm lý. Tính điểm trung bình và phân loại học sinh theo mức giỏi, khá, trung bình, yếu.

//TODO Bài tập thực hành ứng dụng trong phỏng vấn
// Bài 1: Viết chương trình tìm số lớn nhất và nhỏ nhất trong một mảng số nguyên.
// Yêu cầu người dùng nhập vào mảng và tìm ra giá trị lớn nhất, nhỏ nhất.


// Bài 2: Viết chương trình đảo ngược một chuỗi ký tự.
// Người dùng nhập vào một chuỗi và chương trình sẽ in ra chuỗi đã đảo ngược.


// Bài 3: Viết chương trình tính tổng các số nguyên tố trong một khoảng.
// Người dùng nhập vào hai số nguyên để xác định khoảng và chương trình sẽ tính tổng tất cả các số nguyên tố trong khoảng đó.


// Bài 4: Viết chương trình đếm số lần xuất hiện của mỗi ký tự trong một chuỗi.
// Yêu cầu người dùng nhập vào một chuỗi và đếm số lần xuất hiện của mỗi ký tự trong chuỗi đó.


// Bài 5: Viết chương trình tìm phần tử xuất hiện nhiều nhất trong một mảng.
// Yêu cầu người dùng nhập vào một mảng số nguyên và tìm phần tử xuất hiện nhiều nhất.
