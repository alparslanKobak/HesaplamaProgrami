namespace HesaplamaProgrami
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hesaplama();

        }

        public static void Hesaplama()
        {
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("----- Hesaplama Programı -----");
                Console.WriteLine("------------------------------");

                Console.WriteLine("----- Hesaplama Seçiniz ------");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Basit Hesap Makinesi          (1)");
                Console.WriteLine("Dairenin Alanını Hesaplama    (2)");
                Console.WriteLine("Dairenin Çevre Hesaplaması    (3)");
                Console.WriteLine("Dikdörtgen Çevre Hesaplaması  (4)");
                Console.WriteLine("Dikdörtgen Alan Hesaplaması   (5)");
                Console.WriteLine("Çıkış Yap                     (0)");
                Console.WriteLine("*********************************");
                Console.Write("\nSeçiminiz : ");


                string? secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("----- Basit Hesap Makinesi -----");
                        BasitHesapMakinesi();
                        break;
                    case "2":
                        Console.WriteLine("----- Dairenin Alanını Hesaplama -----");
                        DaireninAlaniniHesapla();
                        break;
                    case "3":
                        Console.WriteLine("----- Dairenin Çevre Hesaplaması -----");
                        DaireninCevresiniHesapla();
                        break;
                    case "4":
                        Console.WriteLine("----- Dikdörtgen Çevre Hesaplaması -----");
                        DikdortgenCevresiniHesapla();
                        break;
                    case "5":
                        Console.WriteLine("----- Dikdörtgen Alan Hesaplaması -----");
                        DikdortgenAlanHesapla();
                        break;
                    case "0":
                        Console.WriteLine("Çıkış Yapılıyor!..");
                        Console.Beep();
                        Thread.Sleep(1000);
                        durum = false;
                        break;
                    default:
                        Console.WriteLine("\nHata : Tanımlanmamış Karakter ! Tanımlı olan karakterler üzerinden seçiminizi yeniden yapınız... \n\n");
                        break;
                }

                Thread.Sleep(2000);
                Console.Clear();
            }

        }

        public static void BasitHesapMakinesi()
        {

            bool durum = true;

            while (durum)
            {
                Console.WriteLine("---- Basit Hesap Makinesi ----");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Toplama İşlemi                (1)");
                Console.WriteLine("Çıkarma İşlemi                (2)");
                Console.WriteLine("Çarpma İşlemi                 (3)");
                Console.WriteLine("Bölme İşlemi                  (4)");
                Console.WriteLine("Çıkış Yap                     (0)");
                Console.WriteLine("*********************************");
                Console.Write("\nSeçiminiz : ");

                string? secim = Console.ReadLine();

                Console.Write("\n1. Sayıyı Giriniz : ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\n2. Sayıyı Giriniz : ");

                double sayi2 = Convert.ToDouble(Console.ReadLine());



                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Toplama İşlemi Sonucu : " + (sayi1 + sayi2));
                        break;
                    case "2":
                        Console.WriteLine("Çıkarma İşlemi Sonucu : " + (sayi1 - sayi2));
                        break;
                    case "3":
                        Console.WriteLine("Çarpma İşlemi Sonucu : " + (sayi1 * sayi2));
                        break;
                    case "4":
                        Console.WriteLine("Bölme İşlemi Sonucu : " + (sayi1 / sayi2));
                        break;
                    case "0":
                        Console.WriteLine("Üst Menuye Geçiş Yapılıyor....");
                        Console.Beep();
                        Thread.Sleep(1000);
                        durum = false;
                        break;
                    default:
                        Console.WriteLine("\nHata : Tanımlanmamış Karakter ! Tanımlı olan karakterler üzerinden seçiminizi yeniden yapınız... \n\n");
                        break;
                }


            }

        }

        public static void DaireninAlaniniHesapla()
        {

            Console.WriteLine("----- Dairenin Alanını Hesaplama -----");
            Console.WriteLine("--------------------------------------");
            Console.Write("\nDairenin Alanını Hesaplamak için Lütfen Dairenin Yarıçapını Giriniz : ");

            double yaricap = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDairenin Alanı : " + (Math.PI * yaricap * yaricap));

            Thread.Sleep(2000);
            Console.Clear();


        }

        public static void DaireninCevresiniHesapla()
        {

            Console.WriteLine(
                "----- Dairenin Çevre Hesaplaması -----");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(
                "\nDairenin Çevresini Hesaplamak için Lütfen Dairenin Yarıçapını Giriniz : ");
            Console.WriteLine(
                "\nDairenin Çevresi : " + (2 * Math.PI * Convert.ToDouble(Console.ReadLine())));
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void DikdortgenCevresiniHesapla()
        {
            Console.WriteLine(
                               "----- Dikdörtgen Çevre Hesaplaması -----");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(
                               "\nDikdörtgenin Çevresini Hesaplamak için Lütfen Dikdörtgenin Uzun Kenarını Giriniz : ");
            double uzunkenar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(
                               "\nDikdörtgenin Çevresini Hesaplamak için Lütfen Dikdörtgenin Kısa Kenarını Giriniz : ");
            double kisakenar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(
                               "\nDikdörtgenin Çevresi : " + (2 * (uzunkenar + kisakenar)));
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void DikdortgenAlanHesapla()
        {
            Console.WriteLine("----- Dikdörtgen Alan Hesaplaması -----");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\nDikdörtgenin Alanını Hesaplamak için Lütfen Dikdörtgenin Uzun Kenarını Giriniz : ");
            double uzunkenar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDikdörtgenin Alanını Hesaplamak için Lütfen Dikdörtgenin Kısa Kenarını Giriniz : ");
            double kisakenar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDikdörtgenin Alanı : " + (uzunkenar * kisakenar));
        }
    }
}