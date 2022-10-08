KamyonSurucu surucu1 = new KamyonSurucu()

{
    Adi = "Mehmet",
    Soyadi = "Anaç",
    EhliyetNo = "123456"
};
Araba araba = new Araba(surucu1);
araba.Sur();

ArabaSurucu surucu2 = new ArabaSurucu()

{
    Adi = "Mehmet2",
    Soyadi = "Anaç2",
    EhliyetNo = "123457"
};
araba = new Araba(surucu2);
araba.Sur();

class Araba
{
    private readonly SurucuBase _surucu;
    public Araba(SurucuBase surucu)
    {
        _surucu = surucu;
    }
    public void Sur()
    {
        Console.WriteLine("Mehmet arabayı sürüyor");
    }
}
abstract class SurucuBase
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public string EhliyetNo { get; set; }
}
class ArabaSurucu : SurucuBase
{

}
class KamyonSurucu : SurucuBase
{

}