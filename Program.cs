namespace My_First_Console_App //namespace: Mevcut Bulunduğumuz klasörün adıdır.
{
    internal class Program // class bir tanımlamadır,keyworddur. program isimdir. Program isimli değişkeni class tipinde olduğunu bildiriyosun.internal erişim belirleyicidir.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //OOP => Object Oriented Programming
            //Class:OOP, yapıları mutlaka class'a bağlar.
            // Değişken Tipleri:string, int, boolean, date, object => primitive tip => ilkel tip Genellikle tüm programlama dillerinde kullanılır.
            // string: Genellikle metinsel değerlere atanan bir tiptir.
            // int: Numaratik değerlere atanır.
            // boolean: True ya da False değerlerine atanır.
            // date: Kendine ait bir tiptir.
            //object: İçerisine birden fazla değişkenin alınabildiği bir kapsüllemedir.

            //string name = "Cagla Tunc"; //Değişken oluşturma
            //state
            //İsimlendirme KLuralları

            string name = "Çağla";
            int age = 21;
            decimal money = 100.10m;//18 haneye kadar küsürat kullanılabiliyor.Genellikle double yerine decimal kullanıyor.m kullanılmasının sebebi double ile decimal ayırt etmek için.
            double money2 = 100.10;// küsüratta belirli bir sayısı var. 
            decimal money3 = money;
            DateTime now= DateTime.Now;
            bool isTrue = true;
            object user = new { };

            Consol.WriteLine(name);//CW tab ile kısaca Consol.WriteLine();
            Console.WriteLine(age);//ctrl + d kodu aşağıya kopyalar
            Console.WriteLine(money);
            Console.WriteLine(money2);
            Console.WriteLine(money3);
            Console.WriteLine(now);  
            Console.WriteLine(isTrue);
           
           

            //memory'de tutulma
        }
    }
}