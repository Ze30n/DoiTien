internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so tien Do-la My");
        float Dola = Convert.ToSingle(Console.ReadLine());
        float VND = Dola * 23000;
        if (Dola >= 0)
        {
            Console.WriteLine("So tien chuyen doi la" + VND);
        } else 
        {
            Console.WriteLine("Nhap vao so tien chinh xac");
        }    
    }
}