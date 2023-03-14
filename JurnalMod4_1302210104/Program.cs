public class KodeBuah
{
    public enum namaBuah{ 
        Apel, 
        Aprikot,
        Alpukat,
        Pisang,
        Paprika,
        Blackberry,
        Ceri,
        Kelapa,
        Jagung,
        Kurma,
        Durian,
        Anggur,
        Melon,
        Semangka
    }

    public static string getKodeBuah(namaBuah Buah)
    {
        string[] KodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};

        return KodeBuah[(int)Buah];
    }
}

public class PosisiKarakterGame
{
    public enum State
    {
        Tengkurap,
        Jongkok,
        Berdiri,
        Terbang
    }

    public static void Main()
    {
        //KodeBuah buah = new KodeBuah();
        Console.WriteLine("Nama Buah " + KodeBuah.namaBuah.Blackberry + " Kode Buah " + KodeBuah.getKodeBuah(KodeBuah.namaBuah.Blackberry));

        
        State Kondisi = State.Tengkurap;
        Console.WriteLine("kondisi saat ini sedang : " + Kondisi);
        string Perintah;
        while (Kondisi == State.Tengkurap) { 
            Perintah = Console.ReadLine();
            if(Perintah == "TombolW")
            {
                Kondisi = State.Jongkok;
                Console.WriteLine("kondisi saat ini sedang : " + Kondisi);
                while (Kondisi == State.Jongkok) {
                    Perintah = Console.ReadLine();
                    if (Perintah == "TombolW")
                    {
                        Kondisi= State.Berdiri;
                        Console.WriteLine("kondisi saat ini sedang : " + Kondisi);
                        while (Kondisi == State.Berdiri) { 
                            Perintah = Console.ReadLine();
                            if(Perintah == "TombolW")
                            {                               
                                Kondisi= State.Terbang;
                                Console.WriteLine("kondisi saat ini sedang : " + Kondisi);
                                Console.WriteLine("posisi take off");
                                while (Kondisi == State.Terbang)
                                {
                                    Perintah = Console.ReadLine();
                                    if(Perintah == "TombolS")
                                    {                                     
                                        Kondisi = State.Berdiri;
                                        Console.WriteLine("kondisi saat ini sedang : " + Kondisi);
                                    }
                                    else if(Perintah == "TombolX")
                                    {                                        
                                        Kondisi = State.Jongkok;
                                        Console.WriteLine("kondisi saat ini sedang : " + Kondisi);
                                        Console.WriteLine("posisi landing");
                                    }
                                }
                            }
                            else if (Perintah == "TombolS"){
                                Kondisi = State.Jongkok;
                                Console.WriteLine("kondisi saat ini sedang : " + Kondisi);
                            }
                        }
                    }
                    else if (Perintah == "TombolS")
                    {
                        Kondisi= State.Tengkurap;
                        Console.WriteLine("kondisi saat ini sedang : " + Kondisi);
                    }
                    
                }
            }
            else
            {
                break;
            }
        }
    }
}


