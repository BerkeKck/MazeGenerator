namespace _3_Enum
{

    #region Tanimlama
    //Enumlar, belirli bir veri tipindeki sabit değerleri temsil etmek için kullanılır.
    //Bu sabit değerler, sembolik adlarla temsil edilir ve belirli bir sıraya sahiptirler.
    //Örneğin, bir günün haftanın hangi gününü temsil ettiğini düşünün.
    //Bu sabit değerleri enum kullanarak tanımlayabilirsiniz.
    //Default veri tipi integer'dir
    //Eger veri tipi degistirlmek istenirse : operatoru ile byte,sbyte,short v.b  tanimlamalar yapilabilir
    // Enumlar, belirli bir veri kümesini temsil etmek için kullanılırlar. 
    public enum Gun : short
    {
        Pazartesi=1,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum Degerlerine Erişim
            Gun bugun = Gun.Carsamba;
            Console.WriteLine("Bugun :" + bugun);
            #endregion

            #region Enum icerisindeki degerlere ulasim

            foreach (var gun in Enum.GetValues(typeof(Gun)))
            {
                Console.WriteLine(gun);
            }
            #endregion


            Console.WriteLine("Hello, World!");
        }
    }
}
