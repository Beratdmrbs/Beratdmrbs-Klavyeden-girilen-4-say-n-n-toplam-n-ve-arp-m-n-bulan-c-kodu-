Console.WriteLine("Lütfen dört sayı girin:");

Console.Write("1. Sayı: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Sayı: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.Write("3. Sayı: ");
int sayi3 = Convert.ToInt32(Console.ReadLine());

Console.Write("4. Sayı: ");
int sayi4 = Convert.ToInt32(Console.ReadLine());

int toplam = sayi1 + sayi2 + sayi3 + sayi4;
int carpim = sayi1 * sayi2 * sayi3 * sayi4;

Console.WriteLine($"Toplam: {toplam}");
Console.WriteLine($"Çarpım: {carpim}");