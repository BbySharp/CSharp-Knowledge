# 📝 Tổng hợp kiến thức và câu hỏi phỏng vấn về Variables trong C#

## 📚 Mục lục:

1. [Những kiến thức cần ghi nhớ về Variables](#những-kiến-thức-cần-ghi-nhớ-về-variables)
2. [Câu hỏi phỏng vấn từ cơ bản đến nâng cao](#câu-hỏi-phỏng-vấn-từ-cơ-bản-đến-nâng-cao)
3. [Câu hỏi tình huống và giải quyết vấn đề](#câu-hỏi-tình-huống-và-giải-quyết-vấn-đề)
4. [Tài liệu tham khảo](#tài-liệu-tham-khảo)

## Những kiến thức cần ghi nhớ về Variables

### 1. Variable là gì trong C#?

- Biến (Variable) là một vùng bộ nhớ dùng để lưu trữ dữ liệu và có thể thay đổi trong quá trình thực thi chương trình.
- Trong C#, biến được khai báo với cú pháp: `type variableName = value;`.

### 2. Các kiểu dữ liệu cơ bản của Variable:

- **int**: Lưu trữ số nguyên.
- **double**: Lưu trữ số thực với độ chính xác cao.
- **char**: Lưu trữ một ký tự duy nhất.
- **string**: Lưu trữ chuỗi ký tự.
- **bool**: Lưu trữ giá trị đúng hoặc sai.

### 3. Sự khác nhau giữa biến cục bộ và biến toàn cục:

- **Biến cục bộ**: Chỉ tồn tại trong phạm vi của một phương thức hoặc một khối lệnh.
- **Biến toàn cục**: Biến được khai báo ở ngoài phương thức và có thể được sử dụng ở nhiều nơi trong chương trình (C# không hỗ trợ biến toàn cục, nhưng các biến static hoặc các biến trong class có thể hoạt động tương tự).

### 4. Nullable Variable:

- **Nullable**: Biến có thể chứa giá trị `null`. Được sử dụng với các kiểu dữ liệu như `int`, `double`.

### 5. Hằng số (const) và biến chỉ đọc (readonly):

- **`const`**: Giá trị phải được gán ngay khi khai báo và không thể thay đổi.
- **`readonly`**: Chỉ có thể được gán một lần khi khai báo hoặc trong constructor của class.

### 6. Type inference với `var`:

- **`var`** cho phép compiler tự suy luận kiểu dữ liệu của biến dựa trên giá trị được gán.

### 7. Quản lý phạm vi (scope) của biến:

- **Phạm vi biến** xác định nơi biến có thể truy cập được trong chương trình. Điều này giúp tránh xung đột tên biến và tối ưu bộ nhớ.

---

## Câu hỏi phỏng vấn từ cơ bản đến nâng cao

### 🔰 **Cơ bản**:

1. Variable là gì và làm thế nào để khai báo một biến trong C#?
2. Nullable variable là gì?
3. Làm sao để chuyển đổi kiểu dữ liệu từ string sang int?
4. Sự khác biệt giữa kiểu giá trị (value type) và kiểu tham chiếu (reference type)?
5. Kiểu dữ liệu bool lưu trữ giá trị gì?
6. Làm sao để khai báo một hằng số trong C#?

### ⚙️ **Trung bình**:

1. Sự khác nhau giữa `const` và `readonly` là gì?
2. Type inference trong C# hoạt động như thế nào?
3. Có thể khai báo một biến toàn cục trong C# không?
4. Biến static là gì và khi nào nên sử dụng nó?
5. Làm sao để kiểm tra kiểu dữ liệu của một biến tại runtime?

### 🚀 **Nâng cao**:

1. Giải thích sự khác nhau giữa Boxing và Unboxing trong C#?
2. Làm sao để truyền tham số vào phương thức theo kiểu `ref` và `out`? Sự khác biệt là gì?
3. So sánh kiểu dữ liệu `string` và `StringBuilder`. Khi nào nên sử dụng `StringBuilder`?
4. Trình bày cách C# quản lý bộ nhớ với kiểu giá trị và kiểu tham chiếu?
5. Giải thích về từ khóa `volatile` trong C#. Khi nào nên sử dụng?
6. Sử dụng `Span<T>` trong C# để cải thiện hiệu năng quản lý bộ nhớ như thế nào?

---

## Câu hỏi tình huống và giải quyết vấn đề

### 1. **Xử lý dữ liệu nhập vào**:

Bạn được yêu cầu viết chương trình xử lý đầu vào của người dùng. Người dùng có thể nhập tên, tuổi và mức lương. Tuy nhiên, chương trình cần phải kiểm tra và xử lý khi người dùng nhập dữ liệu không hợp lệ (chẳng hạn như nhập chuỗi vào chỗ cần nhập số).

**Gợi ý**: Sử dụng `TryParse` để kiểm tra và xử lý đầu vào cho số nguyên (`int`), số thực (`double`), và chuỗi (`string`).

### 2. **Quản lý biến trong phương thức dài**:

Một phương thức của bạn có rất nhiều biến cục bộ và khiến cho chương trình trở nên khó kiểm soát. Làm thế nào bạn có thể tối ưu hóa phạm vi và sự rõ ràng của các biến mà vẫn giữ hiệu suất tốt?

**Gợi ý**: Phân chia phương thức lớn thành các phương thức nhỏ hơn để quản lý biến dễ dàng hơn, hoặc sử dụng các class/struct để nhóm các thuộc tính liên quan.

### 3. **Tối ưu hiệu năng với Boxing/Unboxing**:

Bạn phát hiện rằng việc sử dụng biến kiểu giá trị trong chương trình của mình gây ra nhiều hiện tượng **Boxing/Unboxing** không cần thiết, làm giảm hiệu năng. Bạn sẽ làm thế nào để tối ưu hóa?

**Gợi ý**: Tránh chuyển đổi kiểu dữ liệu giữa kiểu giá trị và kiểu tham chiếu quá nhiều. Sử dụng generic để hạn chế Boxing/Unboxing.

### 4. **Xử lý dữ liệu null an toàn**:

Trong dự án của bạn, có rất nhiều nơi biến kiểu `int`, `double` có thể nhận giá trị `null`. Làm sao bạn có thể xử lý an toàn các trường hợp biến bị `null` để không gây ra lỗi trong quá trình chạy?

**Gợi ý**: Sử dụng nullable type (`int?`, `double?`) và kiểm tra `null` trước khi sử dụng giá trị.

---

## Tài liệu tham khảo

- [Microsoft Documentation on Variables](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/variables/)
- [Nullable Types in C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types)
- [Boxing and Unboxing in C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing)
- [Memory Management in C#](https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/)
