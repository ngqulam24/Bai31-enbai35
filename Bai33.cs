using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Thì sẽ xảy ra những thay đổi sau:\r\n\r\nTính trừu tượng: Khi bạn loại bỏ get và set, bạn đã loại bỏ tính trừu tượng của thuộc tính Name. Điều này có nghĩa là bạn không thể kiểm soát cách truy cập và thay đổi giá trị của Name nữa. Bất kỳ ai cũng có thể trực tiếp truy cập và sửa đổi giá trị của Name.\r\nTính đóng gói: Khi bạn loại bỏ get và set, bạn đã loại bỏ tính đóng gói của thuộc tính Name. Điều này có nghĩa là bạn không thể kiểm soát cách các đối tượng bên ngoài truy cập và sửa đổi giá trị của Name.\r\nTính kế thừa: Trong trường hợp này, không có thay đổi đáng kể về tính kế thừa. Lớp Student vẫn có thể truy cập và sửa đổi giá trị của Name từ lớp Person.\r\nTính đa hình: Không có thay đổi đáng kể về tính đa hình. Lớp Student vẫn có thể ghi đè phương thức Name từ lớp Person.\r\nTóm lại, khi bạn loại bỏ get và set, bạn đã loại bỏ tính trừu tượng và tính đóng gói của thuộc tính Name. Điều này có thể dẫn đến các vấn đề về bảo mật và tính ổn định của chương trình, vì các đối tượng bên ngoài có thể trực tiếp truy cập và sửa đổi giá trị của Name. Vì vậy, việc sử dụng get và set là rất quan trọng để đảm bảo tính đóng gói và bảo mật của dữ liệu trong chương trình.");
    }
}