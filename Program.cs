using System;

class Program
{
    static void Main()
    {
        // Nhập điểm các môn từ người dùng và chuyển sang kiểu số thực
        float diemToan = ReadScore("Toan");
        float diemVan = ReadScore("Van");
        float diemAnh = ReadScore("Anh");

        // Kiểm tra điểm hợp lệ và tính toán, đánh giá học sinh
        if (AreValidScores(diemToan, diemVan, diemAnh))
        {
            string hocLuc = EvaluateStudent(diemToan, diemVan, diemAnh);
            Console.WriteLine(hocLuc);
        }
        else
        {
            Console.WriteLine("Diem khong hop le, hay nhap diem trong khoảng từ 0 đến 10");
        }
    }

    static float ReadScore(string monHoc)
    {
        Console.Write($"Nhap diem {monHoc}: ");
        return float.Parse(Console.ReadLine());
    }

    static bool AreValidScores(params float[] scores)
    {
        foreach (float score in scores)
        {
            if (score < 0 || score > 10)
                return false;
        }
        return true;
    }

    static string EvaluateStudent(float diemToan, float diemVan, float diemAnh)
    {
        float diemTB = (diemToan + diemVan + diemAnh) / 3;

        if (diemTB >= 8 && diemToan >= 8 && diemVan >= 8 && diemAnh >= 8)
            return "Hoc sinh gioi";
        else if (diemTB >= 6.5 && diemToan >= 6.5 && diemVan >= 6.5 && diemAnh >= 6.5)
            return "Hoc sinh kha";
        else if (diemTB >= 5 && diemToan >= 5 && diemVan >= 5 && diemAnh >= 5)
            return "Hoc sinh trung binh";
        else if (diemTB >= 3.5 && diemToan >= 3.5 && diemVan >= 3.5 && diemAnh >= 3.5)
            return "Hoc sinh yeu";
        else
            return "Hoc sinh kem";
    }
}
