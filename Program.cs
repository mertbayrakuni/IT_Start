//using System.Collections;
//using System.Runtime.InteropServices;
//using System.Security.Cryptography;



//Console.WriteLine("Merhaba, Dunya!");

//// Yorum Satiri

// Yorum Blogu
//CTRL + K + C : Secili tum satiri yoruma donustur
//CTRL + K + U : Secili tum satiri yorumdan cikar

//CTRT + SHIFT + B : Projeyi build eder

//CTRL + S : İlgili dokumani kaydet
//CTRL + SHIFT + S : Acik olan tum dokumanları kaydet
// */

////Degiskenler - Variables
//// veri_tipi degisken_adi = deger;

//string adSoyad = "İpek Bayrak";
//int yas = 28;

//// byte - 1 byte
//// sbyte - 1 byte
//// short - 2 byte
//// int   - 4 byte
//// long  - 8 byte

//float ondalikF = 4.236f; // float degerler sonuna f veya F eklenir
//double ondalikD = 4.236; // double degerler sonuna d veya D eklenebilir, ancak zorunlu degildir
//decimal ondalikM = 4.236m; // decimal degerler sonuna m veya M eklenir

//char karakter = 'A'; // char degerler tek tirnak icinde tanimlanir
//char sembol = '\u4001';
//char sayiKarakteri = (char)65;

//string metin = "Hello, World!"; // string degerler cift tirnak icinde tanimlanir

//bool dogruMu = true; // bool degerler true veya false olabilir

//object nesne = "Bu bir nesnedir"; // object veri tipi tum veri tiplerinin temelidir

//// Value type ve Reference type
//// object ve string reference type iken, int, float, bool gibi veri tipleri value type'dir

//// Ornek :
//byte kucukPozitif = 255;
//sbyte kucukIsaretli = -100;
//short kisaSayi = -32000;
//ushort kisaPozitif = 60000;
//int tamSayi = -10;
//uint pozitifTam = 20u;
//long uzunSayi = -1234567890123L;
//ulong buyukPozitif = 12345678901234567890UL;
//float ondalikFloat = 4.236f;
//double ondalikDouble = 4.236;
//decimal ondalikDecimal = 4.236m;
//char karakterİ = 'İ';
//string isim = "İpek";
//bool dogru = true;
//bool yanlis = false;

//// Type conversion - Tip donusumu
//// Implicit conversion (Bilinçsiz donusum) - Kucuk veri tipinden buyuk veri tipine otomatik donusum
//// Explicit conversion (Bilincli donusum) - Buyuk veri tipinden kucuk veri tipine donusum, cast operatoru kullanilir, veri kaybi olabilir
//int sayi = 100;
//long buyukSayi = sayi; // implicit conversion
//sayi = (int)buyukSayi; // explicit conversion using cast operator

//string sayiStr = "123";
//int sayiInt = int.Parse(sayiStr); // string to int
//int sayiInt2 = Convert.ToInt32(sayiStr); // string to int using Convert

//string harfStr = "A";
//int harfInt = Convert.ToInt32(harfStr[0]); // string to char to int
//int harfInt2 = harfStr[0]; // string to char to int using cast operator
//int harfInt3 = char.Parse(harfStr); // string to char to int using char.Parse

//// short : Int16
//// int : Int32
//// long : Int64
//// float : Single

//string ondalikMetin = "3.14";
//double ondalikSayi = double.Parse(ondalikMetin); // string to double

//// Boxing ve Unboxing
//// Boxing : Value type bir degerin object tipine donusturulmesi
//int deger = 42;
//object kutu = deger; // Boxing
//                     // Unboxing : Object tipindeki bir degerin value type'a donusturulmesi
//int kutuIcindekiDeger = (int)kutu; // Unboxing using cast operator

////Aritmetik operatorler
//// +, -, *, /, %
//Console.WriteLine(5 + 6);
//Console.WriteLine("5" + "6");
//Console.WriteLine("4" + 5 + 6);
//Console.WriteLine(4 + 5 + "6");

//Console.Write("Lütfen doğum yılınızı giriniz: ");
//string girilenDeger = Console.ReadLine();
//int dogumYili = int.Parse(girilenDeger);
//int yasiniz = DateTime.Now.Year - dogumYili;
//Console.WriteLine("Yasiniz: " + yasiniz);

////Soru : Kullanıcıdan 3 adet pozitif tam sayı alarak bu sayıların ortalamasını hesaplayan bir program yazınız.
//Console.WriteLine("Lütfen 3 adet pozitif tam sayı giriniz:");
//Console.Write("1. Sayi : ");
//int sayi1 = int.Parse(Console.ReadLine());
//Console.Write("2. Sayi : ");
//int sayi2 = int.Parse(Console.ReadLine());
//Console.Write("3. Sayi : ");
//int sayi3 = int.Parse(Console.ReadLine());
//Console.WriteLine("Ortalama: " + (sayi1 + sayi2 + sayi3) / 3.0);
//string sonuc = $"Ortalama: {(sayi1 + sayi2 + sayi3) / 3.0}";
//Console.WriteLine(sonuc);

//// Atama operatorleri
//// =, +=, -=, *=, /=, %=
//sonuc = sonuc + sonuc; // sonuc = sonuc + sonuc
//sonuc += sonuc; // sonuc = sonuc + sonuc

//bool sonucBool = 5 > 9; // false

//// and , or, not operatorleri
//// && (and), || (or), ! (not)
//if (1 < 2 && 3 < 4)
//{
//    Console.WriteLine("Bu ifade true: 1 < 2 && 3 < 4");
//    if (1 < 2 || 3 > 4)
//    {
//        Console.WriteLine("Bu ifade true: 1 < 2 || 3 > 4");
//        if (!(1 > 2))
//        {
//            Console.WriteLine("Bu ifade true: !(1 > 2)");
//        }
//    }
//}
//else
//{
//    Console.WriteLine("Unreachable code");
//}

//// ++ , --
//int sayi4 = 10;
//sayi4++; // sayi4 = sayi4 + 1
//sayi4--; // sayi4 = sayi4 - 1

//for (int s = 0; s < int.Parse("10"); s++)
//{
//    Console.WriteLine(sayi4 + s);
//    Console.WriteLine(sayi4++);
//}

//if (true)
//{

//}
//else if (false)
//{

//}
//else
//{

//}

//// Soru: Kullanıcıdan 2 adet not bilgisi alalım, ortalaması 50 ve üzeri ise "Geçtiniz", altında ise "Kaldınız" yazdıralım.
//Console.WriteLine("Lütfen 2 adet not giriniz:");
//Console.Write("1. Not: ");
//double vize = double.Parse(Console.ReadLine());
//Console.Write("2. Not: ");
//double final = double.Parse(Console.ReadLine());
//double gecmeNotu = vize * 0.4 + final * 0.6;
//if (gecmeNotu >= 50)
//{
//    Console.WriteLine("Geçtiniz: " + gecmeNotu);
//}
//else
//{
//    Console.WriteLine("Kaldınız: " + gecmeNotu);
//}

//// Soru: Kullanıcıdan 0-100 arası not bilgisi alalım, 0-24: 0, 25-44: 1, 45-54: 2, 55-69: 3, 70-84: 4, 85-100: 5 yazdıralım.
//Console.Write("Lütfen 0-100 arası bir not giriniz: ");
//double not = double.Parse(Console.ReadLine());
//while (true)
//{
//    if (not >= 0 && not <= 100)
//    {
//        if (not <= 24)
//        {
//            Console.WriteLine("Notunuz: 0");
//            break;
//        }
//        else if (not <= 44)
//        {
//            Console.WriteLine("Notunuz: 1");
//            break;
//        }
//        else if (not <= 54)
//        {
//            Console.WriteLine("Notunuz: 2");
//            break;
//        }
//        else if (not <= 69)
//        {
//            Console.WriteLine("Notunuz: 3");
//            break;
//        }
//        else if (not <= 84)
//        {
//            Console.WriteLine("Notunuz: 4");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Notunuz: 5");
//            break;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Geçersiz not girdiniz.");
//    }
//}

////switch-case

//Console.Write("Lütfen bir gün numarası giriniz (1-7): ");
//int gun = int.Parse(Console.ReadLine());

//switch (gun)
//{
//    case 1:
//        Console.WriteLine("Pazartesi");
//        break;
//    case 2:
//        Console.WriteLine("Salı");
//        break;
//    case 3:
//        Console.WriteLine("Carsamba");
//        break;
//    case 4:
//        Console.WriteLine("Persembe");
//        break;
//    case 5:
//        Console.WriteLine("Cuma");
//        break;
//    case 6:
//        Console.WriteLine("Cumartesi");
//        break;
//    case 7:
//        Console.WriteLine("Pazar");
//        break;
//    default:
//        Console.WriteLine("Geçersiz gün");
//        break;
//}

//switch (gun)
//{
//    case 6:
//    case 7:
//        Console.WriteLine("Hafta sonu");
//        break;
//    default:
//        Console.WriteLine("Hafta içi");
//        break;
//}

//switch (gun)
//{
//    case 6 or 7:
//        Console.WriteLine("Hafta sonu");
//        break;
//    default:
//        Console.WriteLine("Hafta içi");
//        break;
//}

//int day = 3;
//string dayName = day switch
//{
//    1 => "Pazartesi",
//    2 => "Salı",
//    3 => "Çarşamba",
//    4 => "Perşembe",
//    5 => "Cuma",
//    6 => "Cumartesi",
//    7 => "Pazar",
//    _ => "Geçersiz gün"
//};

////Ternary operator
//int sayi5 = 10;
//string sonucTernary = sayi5 > 5 ? "Sayi 5'ten büyük" : "Sayi 5'ten küçük veya eşit";

////Loop - Dongu
//// for, while, do-while, foreach
//int i = 1;
//while (i <= 5)
//{
//    Console.WriteLine(i);
//    i++;
//}

//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i <= 5);

//for (int j = 1; j <= 5; j++)
//{
//    Console.WriteLine(j);
//}

//foreach (char c in "Hello")
//{
//    Console.WriteLine(c);
//}

//string passw = "";
//while (passw != "12345")
//{
//    Console.Write("Sifreyi giriniz:");
//    passw = Console.ReadLine();
//    if (passw != "12345")
//    {
//        Console.WriteLine("Hatalı Sifre Girdiniz. Tekrar deneyiniz.");
//    }
//}
//Console.WriteLine("Sifre Basarılı" + passw);


//do
//{
//    Console.WriteLine("Sifreyi giriniz:");
//    if (passw != "12345")
//    {
//        Console.WriteLine("Hatalı Sifre Girdiniz. Tekrar deneyiniz.");
//    }
//}
//while (passw != "12345");

////String interpolation
//Console.WriteLine($"Sifre Basarılı: {passw}");

////1 den 100 e kadar tek sayilarin ve cift sayilarin toplamini hesaplayan bir program yaziniz.
//int tekToplam = 0;
//int ciftToplam = 0;

//for (int k = 1; k <= 100; k++)
//{
//    if (k % 2 == 0)
//    {
//        ciftToplam += k; // ciftToplam = ciftToplam + k
//    }
//    else
//    {
//        tekToplam += k; // tekToplam = tekToplam + i
//    }
//}
//Console.WriteLine($"Tek Sayilarin Toplami: {tekToplam}");
//Console.WriteLine($"Cift Sayilarin Toplami: {ciftToplam}");

//// Faktoriyel 1 den belirli bir n dogal sayisina kadar olan tum sayilarin carpimi
//Console.Write("Faktoriyel hesaplamak icin bir sayi giriniz: ");
//int n = int.Parse(Console.ReadLine());
//int temp = 1;
//for (int l = 1; l <= n; l++)
//{
//    if (n == 0 || n == 1)
//    {
//        Console.WriteLine("Faktoriyel: 1");
//        break;
//    }
//    else
//    {
//        temp *= l; // n = n * l
//    }
//}
//Console.WriteLine($"Faktoriyel: {temp}");

//for (int t = 0; t <= 6; t++)
//{
//    for (int j = 0; j < t; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//// Pyramid printing: leading spaces = rows - t - 1, stars = 2*t + 1
//int rows = 6; // change this value to increase/decrease pyramid height
//for (int t = 0; t < rows; t++)
//{
//    // print leading spaces
//    for (int s = 0; s < rows - t - 1; s++)
//    {
//        Console.Write(" ");
//    }

//    // print stars
//    for (int x = 0; x < 2 * t + 1; x++)
//    {
//        Console.Write("*");
//    }

//    Console.WriteLine();
//}

//// Multiplication table from 1 to 10
//for (int a = 1; a <= 10; a++)
//{
//    for (int v = 1; v <= 10; v++)
//    {
//        Console.WriteLine($"{a} x {v} = {a * v}");
//    }
//}

//// Arrays - Diziler
//// One dimensional array, multi-dimensional array, jagged array
//// Indexing starts from 0 to length-1
//// An array is a collection of items stored at contiguous memory locations. It allows you to store multiple values of the same type in a single variable, and access them using an index. Arrays can be one-dimensional (like a list), multi-dimensional (like a table), or jagged (an array of arrays).
//// An arrays length is fixed at the time of creation, and cannot be changed. To create an array, you specify the type of elements it will hold, and the number of elements it can store. You can then access individual elements using their index, which starts from 0 for the first element, up to length-1 for the last element. Arrays are useful for storing and manipulating collections of data in a structured way.
//// Array is a data structure that can hold a fixed number of values of the same type. It allows you to store multiple values in a single variable, and access them using an index. Arrays can be one-dimensional (like a list), multi-dimensional (like a table), or jagged (an array of arrays). The length of an array is determined at the time of creation and cannot be changed. You can access individual elements of an array using their index, which starts from 0 for the first element and goes up to length-1 for the last element. Arrays are useful for storing and manipulating collections of data in a structured way.


//int[] sayilar = new int[5]; // one-dimensional array of integers with 5 elements
//int[] sayilar2 = { 1, 2, 3, 4, 5 }; // one-dimensional array of integers initialized with values
//int[,] matris = new int[3, 4]; // Two dimensional array (matrix) of integers with 3 rows and 4 columns

//string[] isimler = new string[3]; // one-dimensional array of strings with 3 elements
//string[] isimler2 = { "Ali", "Veli", "Ayse" }; // one-dimensional array of strings initialized with values
//string[,] tablo = new string[2, 2]; // Two dimensional array (table) of strings with 2 rows and 2 columns

//Console.WriteLine(sayilar[4]); // This will print the value of the 5th element in the 'sayilar' array, which is 0 by default
//Console.WriteLine(isimler[1]); // This will print "Veli"

//// Array.Sort(diziAdi)
//// Array.Reverse(diziAdi)
//// Array.Clear(diziAdi, baslangicIndeksi, elemanSayisi)
//// Array.Clear(diziAdi, 0, diziAdi.Length) // This will clear the entire array
//// Array.BinarySearch(diziAdi, arananEleman) // This will return the index of the arananEleman in the diziAdi array if it exists, otherwise it will return a negative number
//// Array.IndexOf(diziAdi, arananEleman) // This will return the index of the first occurrence of the arananEleman in the dizi
//// Array.LastIndexOf(diziAdi, arananEleman) // This will return the index of the last occurrence of the arananEleman in the dizi
//// Array.Copy(sourceArray, destinationArray, length) // This will copy 'length' elements from sourceArray to destinationArray starting from index 0
//// dizi_adi.Length // This will return the number of elements in the array

//int[] sayilar3 = [627, 234, 127, 6, 17, 852, 473, 987, 22];

//int maxNum = 0;
//for (int m = 0; m < sayilar3.Length; m++)
//{
//    if (sayilar3[m] > maxNum)
//    {
//        maxNum = sayilar3[m];
//    }
//}
//Console.WriteLine("Dizideki en buyuk sayi: " + maxNum);

//Console.Write("Array boyutunu girin: ");
//int sayac = int.Parse(Console.ReadLine());
//int toplam = 0;
//int[] sayilar4 = new int[sayac];
//for (int z = 0; z < sayac; z++)
//{
//    Console.Write($"Dizinin {z + 1}. elemanini girin: ");
//    sayilar4[z] = int.Parse(Console.ReadLine());
//}
//for (int z = 0; z < sayac; z++)
//{
//    toplam += sayilar4[z]; // toplam = toplam + sayilar4[z]
//}
//Console.WriteLine($"Dizideki elemanlarin ortalamasi: {(double)toplam / sayac}");

//// Arraylist : Farkli veri tiplerini tek bir koleksiyonda tutabilen dinamik bir veri yapısıdır. Arraylist, System.Collections namespace

//ArrayList dinamikDizi = new ArrayList();
//dinamikDizi.Add(sayilar4); // Add methodu ile eleman eklenir

//ArrayList dinamikDizi2 = [];
//dinamikDizi2.Add(1);
//dinamikDizi2.Add("Hello");

//// HashTable : Key-Value (Anahtar-Değer) çiftlerini depolayan bir koleksiyon sınıfıdır. HashTable, System.Collections namespace

//Hashtable sehirler = [];
//sehirler.Add(34, "Istanbul");
//sehirler.Add(06, "Ankara");
//sehirler.Add(35, "İzmir");

//Console.WriteLine((string)sehirler[34]);

//// List<T> : Generic bir koleksiyon sınıfıdır ve belirli bir türdeki nesneleri depolamak için kullanılır. List<T>, System.Collections.Generic namespace
//// Dizilerin aksine, List dinamik olarak boyutlandırılabilir ve eleman ekleme, çıkarma gibi işlemler daha kolaydır. List<T> kullanarak, belirli bir türdeki nesneleri depolayabilir ve bu nesneler üzerinde çeşitli işlemler gerçekleştirebilirsiniz. List<T>, performans açısından da avantajlıdır çünkü tür güvenliği sağlar ve gereksiz kutulama (boxing) işlemlerini önler.

//List<string> list = new List<string>();
//List<string> list2 = [];
//list.Add("Ali");
//list2.Add("Veli");
//list.Remove("Ali"); // Remove methodu ile eleman silinir
//list.Clear(); // ts.Clear(); // Clear methodu ile tüm elemanlar silinir

//Action<string> yazdir = (s) => Console.WriteLine(s);
//yazdir("Merhaba, Dunya!"); // Action delegate'i kullanarak bir string parametre alan ve void döndüren bir lambda ifadesi oluşturduk ve çağırdık.

//list.Add("Ali");
//list.Add("Veli");
//list.Add("Ayse");

//foreach (string listIsim in list)
//{
//    Console.WriteLine(listIsim);
//}

//list.ForEach(isim => Console.WriteLine(isim)); // List<T> sınıfının ForEach metodunu kullanarak, list içindeki her bir ismi yazdırmak için bir lambda ifadesi kullandık. Bu yöntem, foreach döngüsüne göre daha kısa ve okunabilir bir kod sağlar.

//// Dictionary<TKey, TValue> : Key-Value (Anahtar-Değer) çiftlerini depolayan bir koleksiyon sınıfıdır. Dictionary<TKey, TValue>, System.Collections.Generic namespace
//Dictionary<int, string> sehirler2 = new Dictionary<int, string>();
//sehirler2.Add(34, "Istanbul");
//sehirler2.Add(06, "Ankara");
//sehirler2.Add(35, "İzmir");
//Console.WriteLine(sehirler2[34]); // Dictionary'den bir değere erişmek için, ilgili anahtarı kullanarak köşeli parantezler içinde belirtilir. Bu örnekte, sehirler2[34] ifadesi, anahtarı 34 olan değeri döndürür, yani "Istanbul" yazdırılır.

//Dictionary<int, string> vatandaslar = [];
//vatandaslar.Add(1, "Ali");
//vatandaslar.Add(2, "Veli");
//vatandaslar.Add(3, "Ayse");

//bool anahtarVarMi = vatandaslar.ContainsKey(2); // Dictionary'de belirli bir anahtarın var olup olmadığını kontrol etmek için ContainsKey metodunu kullanabilirsiniz. Bu örnekte, vatandaslar.ContainsKey(2) ifadesi, anahtarı 2 olan bir öğenin var olup olmadığını kontrol eder ve sonucunu anahtarVarMi değişkenine atar. Eğer anahtar 2 varsa, anahtarVarMi true olur; aksi takdirde false olur.

//bool degerVarMi = vatandaslar.ContainsValue("Veli"); // Dictionary'de belirli bir değerin var olup olmadığını kontrol etmek için ContainsValue metodunu kullanabilirsiniz. Bu örnekte, vatandaslar.ContainsValue("Veli") ifadesi, değeri "Veli" olan bir öğenin var olup olmadığını kontrol eder ve sonucunu degerVarMi değişkenine atar. Eğer değer "Veli" varsa, degerVarMi true olur; aksi takdirde false olur.

//foreach (int anahtarlar in vatandaslar.Keys)
//{
//    Console.WriteLine($"Anahtar: {anahtarlar}");
//}

//foreach (string degerler in vatandaslar.Values)
//{
//    Console.WriteLine($"Değer: {degerler}");
//}

//// KeyValuePair<TKey, TValue> : Dictionary<TKey, TValue> koleksiyonunda kullanılan bir yapıdır ve her bir anahtar-değer çiftini temsil eder. KeyValuePair<TKey, TValue>, System.Collections.Generic namespace

//foreach (KeyValuePair<int, string> item in vatandaslar)
//{
//    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//}

//// TryGetValue : Dictionary<TKey, TValue> koleksiyonunda belirli bir anahtarın değerini güvenli bir şekilde almaya yarayan bir yöntemdir. TryGetValue, belirtilen anahtarın var olup olmadığını kontrol eder ve eğer varsa, ilgili değeri döndürür. Eğer anahtar yoksa, varsayılan değeri döndürür ve false döner. Bu yöntem, anahtarın var olup olmadığını kontrol etmek için ContainsKey metodunu kullanmaktan daha verimli olabilir çünkü tek bir işlemle hem kontrol hem de değer alma işlemi gerçekleştirilir.

//// TryGetValue(key, out TValue value)

//bool varMi = vatandaslar.TryGetValue(2, out string degerVeli); // TryGetValue yöntemi, belirtilen anahtarın var olup olmadığını kontrol eder ve eğer varsa, ilgili değeri degerVeli değişkenine atar. Eğer anahtar 2 varsa, degerVeli "Veli" olur ve yöntem true döner; aksi takdirde degerVeli varsayılan değere (null) atanır ve yöntem false döner.

//if (varMi)
//{
//    Console.WriteLine($"Anahtar 2'nin değeri: {degerVeli}");
//}
//else
//{
//    Console.WriteLine("Anahtar 2 bulunamadı.");
//}

//// SortedList<TKey, TValue> : Key-Value (Anahtar-Değer) çiftlerini depolayan ve anahtarlara göre sıralama yapan bir koleksiyon sınıfıdır. SortedList<TKey, TValue>, System.Collections.Generic namespace

//// Rastgele sayı üretmek icin Random class'ini kullanabiliriz. Random class'i, System namespace'inde bulunur ve rastgele sayılar üretmek için çeşitli yöntemler sağlar. Örneğin, Random.Next() yöntemi, belirli bir aralıkta rastgele bir tam sayı döndürürken, Random.NextDouble() yöntemi 0.0 ile 1.0 arasında rastgele bir ondalık sayı döndürür. Rastgele sayı üretmek için önce bir Random nesnesi oluşturmanız gerekir ve ardından istediğiniz yöntemi kullanarak rastgele sayılar üretebilirsiniz.

//Random random = new Random();
//int rastgeleSayi = random.Next(1, 101); // 1 ile 100 arasında rastgele bir tam sayı üretir
//Console.WriteLine($"Rastgele sayı: {rastgeleSayi}");
//int yeniRastgeleSayi = random.Next();

//// 0.0 ile 1.0 arasında rastgele bir ondalık sayı üretir
//double rastgeleOndalik = random.NextDouble();

//// Soru : Sayısal lotoda 6 adet benzersiz sayı üretmek istiyoruz. Bu sayılar 1 ile 49 arasında olmalıdır. Aşağıdaki kod, bu gereksinimleri karşılamak için Random sınıfını kullanarak benzersiz sayılar üreten bir örnektir:

//Random lotoRandom = new Random();
//List<int> lotoSayilari = new List<int>();
//int randoSayi = 0;
//for (int x = 0; x < 6; x++)
//{
//    randoSayi = lotoRandom.Next(1, 50); // 1 ile 49 arasında rastgele bir tam sayı üretir
//    if (!lotoSayilari.Contains(randoSayi))
//    {
//        lotoSayilari.Add(randoSayi); // Benzersiz sayı eklenir
//    }
//    else
//    {
//        x--; // Eğer sayı zaten listede varsa, döngü sayacını azaltarak tekrar denemeyi sağlar
//    }
//}

//lotoSayilari.Sort(); // Sayıları küçükten büyüğe sıralar
//Console.Write("Loto Sayıları: ");
//foreach (int lotoSayi in lotoSayilari)
//{
//    Console.Write(lotoSayi + " ");
//}
//Console.WriteLine();

//// Soru : Asal sayılar yalnızca 1 ve kendisine bölünebilen pozitif tam sayılardır. 1'den 100'e kadar olan asal sayıları bulan bir program yazınız.

//Console.WriteLine("1'den 100 e kadar asal sayılar: ");
//int tamBolenSayi = 0;
//for (int i33 = 2; i33 <= 100; i33++)
//{
//    tamBolenSayi = 0; // Her i sayısı için tamBolenSayi sıfırlanır
//    for (int j = 1; j <= i33; j++)
//    {
//        if (i33 % j == 0)
//        {
//            tamBolenSayi++;
//        }
//    }
//    if (tamBolenSayi == 2)
//    {
//        Console.WriteLine($"{i33} sayısı asaldır"); // i, kendisinden küçük hiçbir sayıya tam bölünmüyorsa, i asaldır ve yazdırılır
//    }
//}
//Console.WriteLine();


//// Mükemmel sayılar, kendisi hariç pozitif bölenlerinin toplamı kendisine eşit olan sayılardır. 1'den 100'e kadar olan mükemmel sayıları bulan bir program yazınız.

//Console.WriteLine("1'den 1000 e kadar mükemmel sayılar: ");
//int temp2 = 0;
//for (int i2 = 1; i2 < 100; i2++)
//{
//    temp = 0;
//    for (int j = 1; j < i2; j++)
//    {
//        if (i2 % j == 0)
//        {
//            temp += j; // i sayısının tam bölenlerini toplar
//        }
//    }
//    if (temp == i2) // Mükemmel sayı kontrolü: tam bölenlerin toplamı i sayısına eşit olmalıdır, ancak i sayısı kendisi dahil edilmemelidir
//    {
//        Console.WriteLine($"{i2} sayısı mükemmel sayıdır");
//    }
//}

//// Soru : Fibonacci dizisi, her sayının kendisinden önceki iki sayının toplamı olduğu bir sayı dizisidir. 1'den 40'a kadar olan Fibonacci sayılarını bulan bir program yazınız.

//Console.WriteLine("1'den 40 e kadar Fibonacci sayıları: ");
//int first = 0, second = 0, next = 0;
//for (int counter = 0; counter < 40; counter++)
//{
//    if (counter == 0)
//    {
//        first = 0;
//        Console.WriteLine($"{counter}. fibonacci sayısı {first}");
//    }
//    else if (counter == 1)
//    {
//        first = 1;
//        second = 1;
//        Console.WriteLine($"{counter}. fibonacci sayısı {first}");
//        Console.WriteLine($"{counter + 1}. fibonacci sayısı {second}");
//    }
//    else
//    {
//        next = first + second;
//        first = second;
//        second = next;
//        Console.WriteLine($"{counter}. fibonacci sayısı {next}");
//    }
//}

//// Soru : Kullanıcının girmiş olduğu iki sayıyı carpma işlemi kullanmadan çarpalım.
//Console.Write("Birinci sayıyı giriniz: ");
//int ilkSayı = int.Parse(Console.ReadLine());
//Console.Write("İkinci sayıyı giriniz: ");
//int ikinciSayı = int.Parse(Console.ReadLine());
//int carpimSonuc = 0;
//for (int t = ikinciSayı; t > 0; t--)
//{
//    carpimSonuc += ilkSayı;
//}

//Console.WriteLine($"Çarpım sonucu: {carpimSonuc}");

//// Vücut Kitle Indeksi (BMI) hesaplamayan bir program yazınız. BMI, kişinin kilosunun boyunun karesine bölünmesiyle hesaplanır. Kullanıcıdan boyunu metre cinsinden ve kilosunu kilogram cinsinden girmesini isteyerek BMI değerini hesaplayıp ekrana yazdıralım. 
//static double BMICalc()
//{
//    Console.Write("Boyunuzu metre cinsinden giriniz: ");
//    double boy = double.Parse(Console.ReadLine());
//    Console.Write("Kilonuzu kilogram cinsinden giriniz: ");
//    double kilo = double.Parse(Console.ReadLine());
//    double bmi = kilo / (boy * boy);
//    Console.WriteLine($"Vücut Kitle Indeksiniz (BMI): {bmi}");
//    return bmi;
//}

//static void BMIResult(double bmi)
//{
//    if (bmi <= 18.5)
//    {
//        Console.WriteLine("BMI kategorisi: Zayıf");
//    }
//    else if (bmi <= 24.9)
//    {
//        Console.WriteLine("BMI kategorisi: Sağlıklı");
//    }
//    else if (bmi <= 29.9)
//    {
//        Console.WriteLine("BMI kategorisi: Fazla kilolu");
//    }
//    else
//    {
//        Console.WriteLine("BMI kategorisi: Obez");
//    }
//}

//double bmi = BMICalc();

//BMIResult(bmi);

//// Metotlar - Methods
//// Metotlar, belirli bir görevi yerine getirmek için bir araya getirilmiş kod bloklarıdır. Metotlar, programın daha düzenli, okunabilir ve yeniden kullanılabilir olmasını sağlar. Bir metot, genellikle bir isim, parametreler (giriş değerleri) ve bir dönüş tipi (çıktı değeri) içerir. Metotlar, programın farklı bölümlerinde çağrılarak kullanılabilir ve bu sayede kod tekrarını azaltır. C# dilinde metotlar, genellikle sınıflar içinde tanımlanır ve çeşitli erişim belirleyicileri (public, private, protected) ile kontrol edilir.
//// DRY : Don't Repeat Yourself - Kendini Tekrarlama

//// [Erişim Belirleyici] [Geri Dönüş Tipi] [Metot Adı] ([Parametreler])
//// {
////     // Metot gövdesi - Metotun yapacağı işlemler burada tanımlanır
//// }

//int Topla()
//{
//    return 5;
//}

//int Topla2(int a, int b)
//{
//    return a + b;
//}

//void Yazdir()
//{
//    Console.WriteLine("Parametresiz");
//}

//string yazdirPar(string mesaj)
//{
//    return mesaj;
//}


//int bes = Topla();
//int toplamMethod = Topla2(3, 4);
//Yazdir();
//string mesaj = yazdirPar("Merhaba Dünya");

// Tckn 11 karakter olmak zorunda, ilk karakter 0 olamaz, tüm karakterler rakam olmak zorunda, 1,3,5,7,9 basamaklarının toplamının 7 katından; 2,4,6,8 basamaklarının toplamını colartıgımızda elde ettigimiz sonucun 10'a bolumunded kalan sayı 10. basamaktakı rakamı vermektedir.
// İlk 10 hanenin toplamından elde edilen sonucun 10'a bölümünden kalan sayı 11. basamaktaki rakamı vermektedir.,
// 4 8 9 7 9 8 9 5 8 5 2

using System.Xml.Serialization;

///*
Console.Write("11 Haneli TCKN giriniz: ");
string tckn = Console.ReadLine();

static bool tcknKontrol(string tckn)
{
    double tcknInt = double.Parse(tckn);
    int oddNum = 0;
    int evenNum = 0;
    if (tcknInt < 0) { return false; }
    else if (tcknInt > 99999999999) { return false; }
    else if (tckn.Length != 11) { return false; }
    if (tckn[0] == '0') { return false; }
    for (int i = 1; i < tckn.Length; i++)
    {
        if (!char.IsDigit(tckn[i])) { return false; }
    }

    for (int i = 0; i < tckn.Length - 2; i++)
    {
        if (i % 2 == 0)
        {
            oddNum += int.Parse(tckn[i].ToString());
        }
        else
        {
            evenNum += int.Parse(tckn[i].ToString());
        }
    }

    if (((oddNum * 7) - evenNum) % 10 != int.Parse(tckn[9].ToString())) { return false; }

    if ((((oddNum + evenNum) + int.Parse(tckn[9].ToString())) % 10 != int.Parse(tckn[10].ToString()))) { return false; }
    return true;
}

if (tcknKontrol(tckn))
{
    Console.WriteLine("TCKN geçerli.");
}
else
{
    Console.WriteLine("TCKN geçersiz.");
}

// String Methods
// Length, ToUpper, ToLower, Trim, Substring, Replace, Contains, StartsWith, EndsWith, IndexOf, LastIndexOf, Split, Join

string metin = "  Merhaba Dünya!  ";
Console.WriteLine($"Orijinal metin: '{metin}'");
Console.WriteLine($"Metin uzunluğu: {metin.Length}");
Console.WriteLine($"Metin büyük harflerle: {metin.ToUpper()}");
Console.WriteLine($"Metin küçük harflerle: {metin.ToLower()}");
Console.WriteLine($"Metin kırpılmış hali: '{metin.Trim()}'");
Console.WriteLine($"Metin kelimelere ayrılmış hali: '{string.Join(", ", metin.Trim().Split())}'");

if (metin.Contains("Dünya"))
{
    Console.WriteLine("Metin 'Dünya' kelimesini içeriyor.");
}
else
{
    Console.WriteLine("Metin 'Dünya' kelimesini içermiyor.");
}


metin.ToLower(new System.Globalization.CultureInfo("tr-TR")); // Türkçe karakterler için özel bir kültür bilgisi kullanarak metni küçük harfe dönüştürür. Bu, özellikle 'i' harfi gibi Türkçe karakterlerin doğru şekilde işlenmesini sağlar.
metin.ToLowerInvariant(); // Kültüre duyarlı olmayan bir şekilde metni küçük harfe dönüştürür. Bu, kültüre özgü karakterlerin farklı şekillerde işlenebileceği durumlarda tutarlı sonuçlar sağlar.

if (metin.Contains(" "))
{
    metin.Replace(" ", ""); // Metindeki tüm boşluk karakterlerini kaldırır. Bu, metni tek bir kelime haline getirir ve boşlukları tamamen ortadan kaldırır.
}

string.IsNullOrEmpty(metin); // Metnin null veya boş olup olmadığını kontrol eder. Eğer metin null veya boş ise true döner, aksi takdirde false döner.
string.IsNullOrWhiteSpace(metin); // Metnin null, boş veya sadece beyaz boşluk karakterlerinden oluşup olmadığını kontrol eder. Eğer metin null, boş veya sadece beyaz boşluk karakterlerinden oluşuyorsa true döner, aksi takdirde false döner. Bu yöntem, metnin sadece boşluklardan oluştuğu durumları da kapsar.

// Substring(startIndex, length) : Metnin belirli bir bölümünü almak için kullanılır. startIndex, alt dize başlangıç indeksini belirtirken, length ise alınacak karakter sayısını belirtir. Örneğin, metin.Substring(0, 5) ifadesi, metnin ilk 5 karakterini döndürür.

string altMetin = metin.Substring(0, ((metin.Length / 2) - 1));

// String metodları immutable (değişmez) olduğu için, metin üzerinde yapılan değişiklikler yeni bir string oluşturur ve orijinal metin değişmeden kalır. Bu nedenle, metin üzerinde yapılan işlemler sonucunda yeni bir string elde edilir ve orijinal metin korunur.

// Insert(index, value) : Metnin belirli bir konumuna yeni bir metin eklemek için kullanılır. index, ekleme yapılacak konumu belirtirken, value ise eklenecek metni belirtir. Örneğin, metin.Insert(5, "Dünya") ifadesi, metnin 5. indeksine "Dünya" kelimesini ekler ve yeni bir string döndürür.

// IndexOf(value) : Metnin içinde belirli bir değerin ilk geçtiği konumun indeksini döndürür. Eğer değer bulunamazsa -1 döner. Örneğin, metin.IndexOf("Dünya") ifadesi, metnin içinde "Dünya" kelimesinin ilk geçtiği konumun indeksini verir.

// LastIndexOf(value) : Metnin içinde belirli bir değerin son geçtiği konumun indeksini döndürür. Eğer değer bulunamazsa -1 döner. Örneğin, metin.LastIndexOf("a") ifadesi, metnin içinde "a" harfinin son geçtiği konumun indeksini verir.

if (metin.IndexOf("Dünya") == metin.LastIndexOf("Dünya"))
{
    Console.WriteLine("Tek Dünya kelimesi var.");
}

// StartsWith(value) : Metnin belirli bir değerle başlayıp başlamadığını kontrol eder. Eğer metin belirtilen değerle başlıyorsa true, aksi takdirde false döner. Örneğin, metin.StartsWith("Merhaba") ifadesi, metnin "Merhaba" kelimesiyle başlayıp başlamadığını kontrol eder.
// EndsWith(value) : Metnin belirli bir değerle bitip bitmediğini kontrol eder. Eğer metin belirtilen değerle bitiyorsa true, aksi takdirde false döner. Örneğin, metin.EndsWith("Dünya!") ifadesi, metnin "Dünya!" kelimesiyle bitip bitmediğini kontrol eder.

string isimler = "Ali, Veli, Ayse, Fatma";
string[] isimDizisi = isimler.Split(", "); // Split metodu, belirtilen ayırıcıya göre bir stringi parçalara böler ve bir dizi (array) döndürür. Bu örnekte, isimler stringi ", " ayırıcısına göre bölünerek isimDizisi adlı bir string dizisi oluşturulur. Sonuç olarak, isimDizisi dizisi ["Ali", "Veli", "Ayse", "Fatma"] şeklinde olacaktır.
foreach (string isim in isimDizisi)
{
    Console.WriteLine(isim.Trim());
}

// DateTime : Tarih ve saat bilgilerini tutmak ve işlemek için kullanılan bir yapıdır. DateTime, System namespace'inde bulunur ve tarih-saat işlemleri için birçok yöntem ve özellik sağlar. DateTime nesneleri, belirli bir tarih ve saati temsil eder ve bu bilgiyi kullanarak tarih-saat hesaplamaları yapabilir, formatlayabilir ve karşılaştırmalar gerçekleştirebilirsiniz. Örneğin, DateTime.Now ifadesi, geçerli tarih ve saati döndürürken, DateTime.Parse("2024-01-01") ifadesi, belirtilen tarih stringini bir DateTime nesnesine dönüştürür.

// 1 Ocak 0001 ile 31 Aralık 9999 tarihleri arasında bir tarih ve saat bilgisini temsil eder. DateTime yapısı, tarih ve saat işlemleri için birçok yöntem ve özellik sağlar, ancak tarih aralığı bu sınırlar içinde kalır. Bu nedenle, DateTime nesneleri yalnızca bu tarih aralığında geçerli olan tarih ve saat bilgilerini temsil edebilir. Eğer bu sınırların dışında bir tarih veya saat bilgisi kullanmaya çalışırsanız, bir hata alabilirsiniz.

// DateTime.UtcNow : Geçerli tarih ve saati UTC (Coordinated Universal Time) formatında döndürür. UTC, dünya genelinde kullanılan standart bir zaman dilimidir ve saat dilimi farklarından etkilenmez. DateTime.UtcNow ifadesi, geçerli tarih ve saati UTC formatında verirken, DateTime.Now ifadesi ise geçerli tarih ve saati yerel saat dilimine göre döndürür. Bu nedenle, DateTime.UtcNow kullanarak elde edilen tarih ve saat bilgisi, farklı saat dilimlerinde aynı değeri temsil ederken, DateTime.Now kullanarak elde edilen tarih ve saat bilgisi, bulunduğunuz saat dilimine göre değişebilir.

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.UtcNow);

// Belirli Bir Tarih Oluşturma : new DateTime(year, month, day) : Belirli bir tarih oluşturmak için kullanılır. Örneğin, new DateTime(2024, 1, 1) ifadesi, 1 Ocak 2024 tarihini temsil eden bir DateTime nesnesi oluşturur.

DateTime dogumTarihi = new DateTime(1998, 10, 23);
Console.WriteLine($"Doğum Tarihi: {dogumTarihi.ToShortDateString()}");
DateTime tamZaman = new DateTime(2026, 3, 27, 11, 23, 0, 0);
Console.WriteLine($"Tam Zaman: {tamZaman}");

// Zaman Ekleme / Çıkarma : DateTime.AddDays(days), DateTime.AddMonths(months), DateTime.AddYears(years) : Tarihe belirli bir süre eklemek veya çıkarmak için kullanılır. Örneğin, dogumTarihi.AddYears(1) ifadesi, doğum tarihine 1 yıl ekleyerek yeni bir DateTime nesnesi oluşturur.

// Zaman Farkı : DateTime.Subtract(otherDateTime) : İki tarih arasındaki farkı hesaplamak için kullanılır. Bu yöntem, bir DateTime nesnesinden diğerini çıkararak TimeSpan türünde bir sonuç döndürür. Örneğin, DateTime.Now.Subtract(dogumTarihi) ifadesi, geçerli tarih ile doğum tarihi arasındaki farkı hesaplar ve bu farkı TimeSpan türünde döndürür.

DateTime dogumGunu = new DateTime(1998, 10, 23, 18, 30, 00);
DateTime bugun = DateTime.Now;

TimeSpan zamanFarkı = bugun - dogumGunu;
TimeSpan timeDifference = bugun.Subtract(dogumGunu);


// TotalDays, TotalHours, TotalMinutes, TotalSeconds : TimeSpan nesnesinin toplam gün, saat, dakika veya saniye cinsinden değerini döndürür. Örneğin, zamanFarkı.TotalDays ifadesi, iki tarih arasındaki toplam gün sayısını verirken, zamanFarkı.TotalHours ifadesi toplam saat sayısını verir.
double yearDif = zamanFarkı.TotalDays; // İki tarih arasındaki toplam yıl sayısını verir.

// Biçimlendirme : DateTime.ToString(format) : Tarih ve saat bilgisini belirli bir formatta string olarak döndürür. Örneğin, dogumTarihi.ToString("dd/MM/yyyy") ifadesi, doğum tarihini "23/10/1998" formatında döndürür.

Console.WriteLine(bugun.ToShortDateString());
Console.WriteLine(bugun.ToLongDateString());
Console.WriteLine(bugun.ToShortTimeString());
Console.WriteLine(bugun.ToLongTimeString());

// Kullanıcının doğum tarihini girmesini isteyerek, kullanıcının yaşını gün ay yıl formatında hesaplayan bir program yazınız.

Console.Write("Lütfen doğum tarihinizi girin (dd/mm/yyyy) : ");
string dogumTarihiInput = Console.ReadLine();
DateTime today = DateTime.Now;
string todayString = today.ToString("dd/MM/yyyy");

dogumTarihiInput = dogumTarihiInput.Replace("/", "");
todayString = todayString.Replace("/", "");
int bDay = int.Parse(dogumTarihiInput.Substring(0, 2));
int bMonth = int.Parse(dogumTarihiInput.Substring(2, 2));
int bYear = int.Parse(dogumTarihiInput.Substring(4, 4));

int tDay = int.Parse(todayString.Substring(0, 2));
int tMonth = int.Parse(todayString.Substring(2, 2));
int tYear = int.Parse(todayString.Substring(4, 4));

if (tDay < bDay)
{
    tMonth--;
    tDay += 30;
}

if (tMonth < bMonth)
{
    tYear--;
    tMonth += 12;
}

Console.WriteLine($"Bu dünyada {tDay - bDay} gün {tMonth - bMonth} ay {tYear - bYear} yıl hayatta kaldınız.");

// Gecerli parantez kontrolu yapan bir program yaziniz. Parantezler (), {}, [] olabilir ve her açılan parantezin kapanması gerekir. Örneğin, "({[]})" gecerli bir parantez dizisidir, ancak "({[})" gecerli değildir.

Console.WriteLine("Parantez dizisini girin(({[]})): ");
string parantezDizisi = Console.ReadLine();
int temp = 0;
string tempString = "";
bool ParantezKontrol(string s)
{
    if (string.IsNullOrEmpty(s)) return true;
    var st = new Stack<char>();
    foreach (char c in s)
    {
        if (c == '(' || c == '{' || c == '[')
            st.Push(c);
        else if (c == ')' || c == '}' || c == ']')
        {
            if (st.Count == 0) return false;
            char open = st.Pop();
            if ((c == ')' && open != '(') ||
                (c == '}' && open != '{') ||
                (c == ']' && open != '['))
                return false;
        }
        // ignore other characters or return false if you want strict input
    }
    return st.Count == 0;
}

Console.WriteLine("Parantez dizisi geçerli mi? " + ParantezKontrol(parantezDizisi));
if (ParantezKontrol(parantezDizisi))
{
    Console.WriteLine("Parantez dizisi geçerli.");
}
else
{
    Console.WriteLine("Parantez dizisi geçersiz.");
}

string soru = "[{()}]";

bool gecerliMi(string s)
{
    int n = -1;
    while(s.Length != n)
    {
        n = s.Length;
        s = s.Replace("()", "").Replace("{}", "").Replace("[]", "");
    }
    return s.Length == 0;
}

bool yanit = gecerliMi(soru);
Console.WriteLine(yanit);

