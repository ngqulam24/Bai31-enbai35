using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

class SinhVien
{
    public string MSSV { get; set; }
    public string HoTen { get; set; }
    public double DiemToan { get; set; }
    public double DiemLy { get; set; }
    public double DiemHoa { get; set; }

    public double DiemTrungBinh
    {
        get { return (DiemToan + DiemLy + DiemHoa) / 3; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        // a. Nhập số lượng sinh viên
        int soLuong = NhapSoLuongSinhVien();

        // b. Nhập thông tin sinh viên
        NhapThongTinSinhVien(danhSachSinhVien, soLuong);

        // c. Tính điểm trung bình
        TinhDiemTrungBinh(danhSachSinhVien);

        // d. Hiển thị thông tin sinh viên
        HienThiThongTinSinhVien(danhSachSinhVien);

        // e. Hiển thị sinh viên đầu tiên có điểm trung bình > 9.5
        HienThiSinhVienDiemCao(danhSachSinhVien);

        // g. Đếm số sinh viên có điểm trung bình lớn hơn 5.0
        DemSinhVienDiemTren5(danhSachSinhVien);

        // h. Sắp xếp danh sách sinh viên theo thứ tự điểm trung bình từ thấp đến cao
        SapXepTheoDiemTrungBinh(danhSachSinhVien);

        // i. Sắp xếp sinh viên theo thứ tự alphabet của Họ tên sinh viên
        SapXepTheoTen(danhSachSinhVien);

        // k. Ghi thông tin sinh viên vào file
        GhiThongTinSinhVienVaoFile(danhSachSinhVien);
    }

    // Hàm a. Nhập số lượng sinh viên
    static int NhapSoLuongSinhVien()
    {
        int soLuong = 0;
        while (true)
        {
            try
            {
                Console.Write("Nhập số lượng sinh viên: ");
                soLuong = int.Parse(Console.ReadLine());
                if (soLuong <= 0)
                {
                    throw new ArgumentException("Số lượng sinh viên phải là số nguyên dương.");
                }
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Bạn đã nhập sai định dạng số.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        return soLuong;
    }

    // Hàm b. Nhập thông tin sinh viên
    static void NhapThongTinSinhVien(List<SinhVien> danhSachSinhVien, int soLuong)
    {
        for (int i = 0; i < soLuong; i++)
        {
            SinhVien sv = new SinhVien();
            Console.WriteLine($"\nNhập thông tin sinh viên thứ {i + 1}:");
            Console.Write("Mã số sinh viên: ");
            sv.MSSV = Console.ReadLine();
            Console.Write("Họ tên: ");
            sv.HoTen = Console.ReadLine();
            Console.Write("Điểm Toán: ");
            sv.DiemToan = double.Parse(Console.ReadLine());
            Console.Write("Điểm Lý: ");
            sv.DiemLy = double.Parse(Console.ReadLine());
            Console.Write("Điểm Hóa: ");
            sv.DiemHoa = double.Parse(Console.ReadLine());

            danhSachSinhVien.Add(sv);
        }
    }

    // Hàm c. Tính điểm trung bình
    static void TinhDiemTrungBinh(List<SinhVien> danhSachSinhVien){}

    // Hàm d. Hiển thị thông tin sinh viên
    static void HienThiThongTinSinhVien(List<SinhVien> danhSachSinhVien)
    {
        Console.WriteLine("\nThông tin các sinh viên:");
        foreach (var sv in danhSachSinhVien)
        {
            Console.WriteLine($"MSSV: {sv.MSSV}, Họ tên: {sv.HoTen}, Điểm trung bình: {sv.DiemTrungBinh:F2}");
        }
    }

    // Hàm e. Hiển thị sinh viên đầu tiên có điểm trung bình > 9.5
    static void HienThiSinhVienDiemCao(List<SinhVien> danhSachSinhVien)
    {
        Console.WriteLine("\nSinh viên đầu tiên có điểm trung bình > 9.5:");
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTrungBinh > 9.5)
            {
                Console.WriteLine($"MSSV: {sv.MSSV}, Họ tên: {sv.HoTen}, Điểm trung bình: {sv.DiemTrungBinh:F2}");
                break;
            }
        }
    }

    // Hàm g. Đếm số sinh viên có điểm trung bình lớn hơn 5.0
    static void DemSinhVienDiemTren5(List<SinhVien> danhSachSinhVien)
    {
        int count = 0;
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTrungBinh > 5.0)
            {
                count++;
            }
        }
        Console.WriteLine($"\nSố sinh viên có điểm trung bình lớn hơn 5.0 là: {count}");
    }

    // Hàm h. Sắp xếp danh sách sinh viên theo thứ tự điểm trung bình từ thấp đến cao
    static void SapXepTheoDiemTrungBinh(List<SinhVien> danhSachSinhVien)
    {
        danhSachSinhVien.Sort((sv1, sv2) => sv1.DiemTrungBinh.CompareTo(sv2.DiemTrungBinh));
    }

    // Hàm i. Sắp xếp sinh viên theo thứ tự alphabet của Họ tên sinh viên
    static void SapXepTheoTen(List<SinhVien> danhSachSinhVien)
    {
        danhSachSinhVien.Sort((sv1, sv2) => string.Compare(sv1.HoTen, sv2.HoTen, StringComparison.Ordinal));
    }

    // Hàm k. Ghi thông tin sinh viên vào file
    static void GhiThongTinSinhVienVaoFile(List<SinhVien> danhSachSinhVien)
    {
        try
        {
            Console.Write("\nNhập tên file để lưu thông tin sinh viên (vd: sinhvien.txt): ");
            string tenFile = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(tenFile))
            {
                foreach (var sv in danhSachSinhVien)
                {
                    sw.WriteLine($"{sv.MSSV},{sv.HoTen},{sv.DiemToan},{sv.DiemLy},{sv.DiemHoa}");
                }
            }

            Console.WriteLine($"Đã ghi thông tin sinh viên vào file '{tenFile}' thành công.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi ghi file: {ex.Message}");
        }
    }
}