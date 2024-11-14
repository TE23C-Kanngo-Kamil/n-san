Random random = new Random();
int i = 0;

while (i < 20) {
    int ran = random.Next(1, 8);

    switch (ran) {
        case 1:
        Console.WriteLine("Hfayed Alexander Ben Zekri, Hasselgatan 11 194 37 Upplands Väsby, Hammarby, Upplands Väsby, Stockholm");
        break;
        case 2:
        Console.WriteLine("Edward Alfred Adilbish Vilén, Westerbergs väg 5 139 73 Djurhamn, Djurö, Värmdö, Stockholm");
        break;
        case 3:
        Console.WriteLine("Kamil Kanngo, Hjulsta backar 16 163 65 Spånga, Spånga, Stockholm, Stockholm");
        break;
        case 4:
        Console.WriteLine("Ares Jilani, Kavlevägen 93 141 59 Huddinge, Flemingsberg, Huddinge, Stockholm");
        break;
        case 5:
        Console.WriteLine("Gia Nguyen Le, Nybrogatan 74 114 41 Stockholm, Stockholms Hedvig Eleonora, Stockholm, Stockholm");
        break;
        case 6:
        Console.WriteLine("Dac Thai Bao Nguyen, Stångholmsbacken 44 127 40 Skärholmen, Skärholmen, Stockholm, Stockholm");
        break;
        case 7:
        Console.WriteLine("Erik Elias Fredrik Strindberg, Sidvallsgränd 12 163 43 Spånga, Spånga, Stockholm, Stockholm");
        break;
    }

    i++;
    Console.ReadLine();
}