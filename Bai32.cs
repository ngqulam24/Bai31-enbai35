using System;
public abstract class Person
{
    public string Name { get; set; }
}
public interface KPI
{
    void kpi();
}
public class Student : Person, KPI
{
    public string Major { get; set; }

    public void kpi()
    {
        Console.WriteLine("Implementing KPI method");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Khai báo 1 obs kiểu Person, cấp phát obs là một Student với tên "Nguyễn Văn Nam" và khoa "ICT"
        Person obs = new Student { Name = "Nguyễn Văn Nam", Major = "ICT" };

        // Kiểm tra obs là Student hay không?
        if (obs is Student)
        {
            // Nếu đúng gọi phương thức kpi()
            ((Student)obs).kpi();
        }
        else
        {
            Console.WriteLine("obs is not a Student");
        }

        // Nếu Name và Major không hỗ trợ get, set thì điều gì xảy ra?
        // Nếu Name và Major không hỗ trợ get, set, thì sẽ gặp lỗi biên dịch vì các thuộc tính này được sử dụng ở các lớp khác.
        // Ví dụ:
        // public class Person
        // {
        //     public string Name; // Lỗi biên dịch vì không có get, set
        // }
        // public class Student : Person
        // {
        //     public string Major; // Lỗi biên dịch vì không có get, set
        // }
    }
}