ImageProcessor Kertas = new ImageProcessor();

Kertas.Resize(-50);
Kertas.Resize(50);
Kertas.Resize(150);
Kertas.Resize(100);
Kertas.Resize(192, 108);
Kertas.Resize("A4");

class ImageProcessor
{
    public void Resize(int presentase)
    {
        if (presentase <= 0)
        {
            Console.WriteLine("Error! Presentase tidak bolah 0 atau negatif.");
        }
        else if (presentase < 100)
        {
            Console.WriteLine($"Gambar berhasil diperkecil sebesar {presentase}%");
        }
        else if (presentase > 100)
        {
            Console.WriteLine($"Gambar berhasil diperbesar sebesar {presentase}%.");
        }
        else
        {
            Console.WriteLine("Ukuran tetao 100%, tidak ada perubahan");
        }
    }

    public void Resize(int lebar, int tinggi)
    {
        Console.WriteLine($"Mengubah ukuran menjadi {lebar}mm x {tinggi}mm");
    }

    public void Resize(string kertas)
    {
        Console.WriteLine($"Mengubah ukuran menjadi format kertas {kertas}");
    }
}
