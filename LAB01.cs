//Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
/*
[tên], bạn[tuổi] tuổi!".
Console.WriteLine("Hello, ban hay nhap ho va ten: ");
string HoVaTen = Console.ReadLine();

Console.WriteLine("Ban bao nhieu tuoi: ");
Tuoi = int.Parse(Console.ReadLine());

Console.WriteLine($"Xin chao {HoVaTen}, ban nam nay {Tuoi} tuoi.");
*/

/*
//Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và chiều rộng.
int a, b;
Console.WriteLine("Moi ban nhap chieu dai a:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Moi ban nhap chieu rong b:");
b = int.Parse(Console.ReadLine());
double S = a * b;
Console.WriteLine($"Dien tich hinh chu nhat la: {S}");
*/

//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F  Công thức: F = (C * 9 / 5) + 32
/*
int C;
Console.Write("Moi ban nhap nhiet do muon chuyen : ");
C = int.Parse(Console.ReadLine());
double f = (C * 9.0 / 5) + 32;

Console.WriteLine($"Nhiet do sau khi doi la {f}F.");
*/

//Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn hay không.
/*
int SoNguyen;
Console.WriteLine("Moi ban nhap 1 so nguyen: ");
try
{
    SoNguyen = int.Parse(Console.ReadLine());
    if (SoNguyen % 2 ==0)
	{
		Console.WriteLine("La so chan ");
	}
	else {
		Console.WriteLine("La so le");
	}
}
catch (FormatException)
{

    Console.WriteLine("Moi ban nhap so nguyen ");
	
}
*/

//Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
/*
int a, b,c;
Console.WriteLine("Nhap2  so bat ki: ");
Console.Write("a=");
a = int.Parse(Console.ReadLine());
Console.Write("b=");
b = int.Parse(Console.ReadLine());

c = a + b;
Console.WriteLine($"Tong hai so {a} va {b} la: {c}");
*/

//Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.
/*
int a;
Console.WriteLine("Moi ban nhap 1 so: ");
try
{
    a = int.Parse(Console.ReadLine());
    if (a >0)
    {
        Console.WriteLine("La so duong ");
    }
    else if (a < 0)
    {
        Console.WriteLine("La so am.");
    }
    else
    {
        Console.WriteLine("La so am");
    }
}
catch (FormatException)
{

    Console.WriteLine("Moi ban nhap so!");

}
*/

//Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
//(Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho 400).
/*
void Nhap()
{
    int Nam;
    while (true)
    {
        Console.Write("Moi ban nhap nam: ");
        try
        {
            Nam = int.Parse(Console.ReadLine());
            if ((Nam % 4 == 0 && Nam % 100 != 0) || (Nam % 400 == 0))
            {
                Console.WriteLine("La nam nhuan.");
            }
            else
            {
                Console.WriteLine("Khong phai nam nhuan.");
            }
            break; 
        }
        catch (FormatException)
        {
            Console.WriteLine("Xin hay nhap lai, loi nhap lieu!");
        }
    }
}
Nhap();*/

//Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.
/*
 * Console.WriteLine("Bang cuu chuong tu 1 den 10 la: ");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"bang cuu chuong {1}");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i}x{j}={i * j}");
    }
}
*/

//Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.
/*
using LAB01;

void Nhap()
{
    int a;
    Console.Write("Moi ban nhap 1 so nguyen duong a = ");
    try
    {
        a = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine($"So nguyen duong vua nhap: {a}");

        if (a < 0)
            throw new SoAmException("Loi: a phai la so nguyen duong!");

        long giaiThua = TinhGiaiThua(a);
        Console.WriteLine($"Giai thua cua {a} la: {giaiThua}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Loi nhap lieu: {ex.Message}");
    }
    catch (SoAmException ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("KET THUC CHUONG TRINH");
    }

static long TinhGiaiThua(int n)
{
    long ketQua = 1;
    for (int i = 1; i <= n; i++)
    {
        ketQua *= i;
    }
    return ketQua;
}
}
Nhap();
*/

//Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.
/*
using LAB01;

void Nhap()
{
    int a;
    Console.Write("Moi ban nhap 1 so a = ");
    try
    {
        a = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine($"So vua nhap: {a}");

        if (a < 0)
            throw new SoAmException("Loi: a phai la so nguyen duong!");

        bool laNguyenTo = KiemTraNguyenTo(a);
        if (laNguyenTo)
            Console.WriteLine($"{a} la so nguyen to.");
        else
            Console.WriteLine($"{a} khong phai la so nguyen to.");
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Loi nhap lieu: {ex.Message}");
    }
    catch (SoAmException ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("KET THUC CHUONG TRINH");
    }
}

static bool KiemTraNguyenTo(int n)
{
    if (n < 2)
        return false;

    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
    }

Nhap();
/*
