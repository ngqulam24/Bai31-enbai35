using System;
using System.Text;

// Lớp trừu tượng Shape
public abstract class Shape
{
    private int _soDinh;

    public int so_dinh
    {
        get { return _soDinh; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Số đỉnh phải lớn hơn 0.");
            _soDinh = value;
        }
    }

    public abstract double TinhDienTich();
}

// Lớp kế thừa Tam_Giac
public class Tam_Giac : Shape
{
    private double _canhA;
    private double _canhB;
    private double _canhC;

    public Tam_Giac(double canhA, double canhB, double canhC)
    {
        _canhA = canhA;
        _canhB = canhB;
        _canhC = canhC;
        so_dinh = 3; // Số đỉnh của tam giác luôn là 3
    }

    public override double TinhDienTich()
    {
        double p = (_canhA + _canhB + _canhC) / 2;
        return Math.Sqrt(p * (p - _canhA) * (p - _canhB) * (p - _canhC));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo tam giác
        Tam_Giac tamGiac = new Tam_Giac(3, 4, 5);
        Console.WriteLine($"Số đỉnh của tam giác: {tamGiac.so_dinh}");
        Console.WriteLine($"Diện tích tam giác: {tamGiac.TinhDienTich()}");

        // Lỗi khi gán giá trị không hợp lệ cho số đỉnh của Shape
        try
        {
            tamGiac.so_dinh = 0;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}