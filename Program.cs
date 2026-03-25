class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("1. Giai thua");
         Console.WriteLine("2. So nguyen to");
         Console.WriteLine("3. UCLN");
         Console.WriteLine("4. BCNN");
         Console.Write("Chon: ");
         string chon = Console.ReadLine();

         switch (chon)
         {
             case "1": GiaiThua(); break;
             case "2": SoNguyenTo(); break;
             case "3": UCLN(); break;
             case "4": BCNN(); break;
             default: Console.WriteLine("Sai lua chon!"); break;
         }
     }

     static void GiaiThua()
     {
         Console.Write("Nhap n: ");
         int n = int.Parse(Console.ReadLine());
         double giaiThua = 1;
         for (int i = 1; i <= n; i++)
             giaiThua *= i;
         Console.WriteLine($"{n}! = {giaiThua}");
     }

     static void SoNguyenTo()
     {
         Console.Write("Nhap so: ");
         int s = int.Parse(Console.ReadLine());
         bool laNguyenTo = KiemTraSoNguyenTo(s);
         Console.WriteLine(laNguyenTo
             ? $"{s} LA so nguyen to."
             : $"{s} KHONG phai so nguyen to.");
     }

     static bool KiemTraSoNguyenTo(int s)
     {
         if (s < 2) return false;
         if (s == 2) return true;
         if (s % 2 == 0) return false;
         for (int i = 3; i <= Math.Sqrt(s); i += 2)
             if (s % i == 0) return false;
         return true;
     }

     static void UCLN()
     {
         Console.Write("Nhap a: ");
         int a = int.Parse(Console.ReadLine());
         Console.Write("Nhap b: ");
         int b = int.Parse(Console.ReadLine());

         int ucln = TinhUCLN(a, b);
         int bcnn = a / ucln * b;

         Console.WriteLine($"UCLN({a},{b}) = {ucln}");
     }

     static int TinhUCLN(int a, int b)
     {
         while (b != 0)
         {
             int du = a % b;
             a = b;
             b = du;
         }
         return a;
     }
     static void BCNN()
     {
         Console.Write("Nhap a: ");
         int a = int.Parse(Console.ReadLine());
         Console.Write("Nhap b: ");
         int b = int.Parse(Console.ReadLine());

         int ucln = TinhUCLN(a, b);
         int bcnn = a / ucln * b;

         Console.WriteLine($"BCNN({a},{b}) = {bcnn}");
     }*/
        //bai1
        Console.WriteLine("Rằm Tháng Giêng");
        Console.WriteLine("Rằm xuân lồng lộng trăng soi,");
        Console.WriteLine("Sông xuân nước lẫn màu trời thêm xuân.");
        Console.WriteLine("Giữa dòng bàn bạc việc quân");
        Console.WriteLine("Khuya về bát ngát trăng ngân đầy thuyền.");
        Console.WriteLine("Hồ Chí Minh.");

        Hinhtru();

        Console.Write("Nhap so: ");
        string input = Console.ReadLine();

        Console.Write("Cach doc: ");
        foreach (char c in input)
        {
            int digit = c - '0';
            Console.Write($"{dem_So(digit)} ");
        }
        Console.WriteLine();


        Console.WriteLine("nhap 1 de co tam giac vuong dac");
        Console.WriteLine("nhap 2 de co tam giac vuong rong");
        Console.WriteLine("nhap 3 de co hinh vuong rong");

        int chon= int.Parse(Console.ReadLine());
        Console.Write("Nhap chieu cao / canh: ");
        int n = int.Parse(Console.ReadLine());
        switch (chon)
        {
            case 1:
                Tam_Giac_Vuong_Dac(n);
                break;
            case 2:
                Tam_Giac_Vuong_Rong(n);
                break;
            case 3:
                Hinh_Vuong_Rong(n);
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                break;
        }

        //bai2
    }
    static void Hinhtru()
    {
        double PI = 3.14;
        Console.WriteLine("nhap chieu cao");
        double cao = double.Parse(Console.ReadLine());
        Console.WriteLine("nhap ban kinh");
        double ban_kinh = double.Parse(Console.ReadLine());

        double SXQ = 2 * PI * ban_kinh * cao;
        Console.WriteLine($"dien tich xung quanh la:{SXQ}");

        double the_Tich = PI * (ban_kinh * ban_kinh) * cao;
        Console.WriteLine($"the tich hinh tru la:{the_Tich}");


    }
    //bai3
    enum so
    {
        khong=0,
        mot=1,
        hai=2,
        ba=3,
        bon=4,
        nam=5,
        sau=6,
        bay=7,
        tam=8,
        chin=9,
    }
    static String dem_So( int digit)
    {
        so chuSo = (so)digit;
        switch (chuSo)
        {
            case so.khong: return "không";
            case so.mot: return "một";
            case so.hai: return "hai";
            case so.ba: return "ba";
            case so.bon: return "bốn";
            case so.nam: return "năm";
            case so.sau: return "sáu";
            case so.bay: return "bảy";
            case so.tam: return "tám";
            case so.chin: return "chín";
            default: return "";
        }
 
    }
    //bai4
    static void Tam_Giac_Vuong_Dac(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    static void Tam_Giac_Vuong_Rong(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i == 1 || i == n || j == 1 || j == i)
                    Console.Write("* ");
                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }
    }
    static void Hinh_Vuong_Rong(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == 1 || i == n || j == 1 || j == n)
                    Console.Write("* ");
                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }
    }

}