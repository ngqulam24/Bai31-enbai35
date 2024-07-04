using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Thuộc tính:\r\nabstract: Khai báo một thuộc tính abstract có nghĩa là thuộc tính này không có được định nghĩa cụ thể trong lớp cha, các lớp con sẽ phải cung cấp định nghĩa cụ thể cho thuộc tính này.\r\nvirtual: Khai báo một thuộc tính virtual có nghĩa là thuộc tính sẽ có một định nghĩa mặc định trong lớp cha, nhưng các lớp con có thể ghi đè (override) định nghĩa này.\r\nPhương thức:\r\nabstract: Khai báo một phương thức abstract có nghĩa là phương thức này không có được định nghĩa cụ thể trong lớp cha, các lớp con sẽ phải cung cấp định nghĩa cụ thể cho phương thức này.\r\nvirtual: Khai báo một phương thức virtual có nghĩa là phương thức sẽ có một định nghĩa mặc định trong lớp cha, nhưng các lớp con có thể ghi đè (override) định nghĩa này.");
    }
}