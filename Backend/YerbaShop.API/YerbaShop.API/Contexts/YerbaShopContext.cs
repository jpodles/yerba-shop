using Microsoft.EntityFrameworkCore;
using YerbaShop.API.Entities;

namespace YerbaShop.API.Contexts
{
    public class YerbaShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderHistory> OrderHistory { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        public YerbaShopContext(DbContextOptions<YerbaShopContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

                //Argentyna
                new Product()
                {
                    Id = 1,
                    ProductName = "Amanda Despelada Sin Palo",
                    ProductBrand = "Amanda",
                    ProductImage = "https://www.poyerbani.pl/pol_pl_Amanda-Despalada-Sin-Palo-0-5kg-894_1.png",
                    Country = "Argentyna",
                    ProductPrice = 24.99M,
                    ProductWeight = 0.5,
                    ShortDescription = "Yerba Mate Amanda Despalada Sin Palo 0,5 kg to klasyk z Argentyny. Yerba mate bez dodatków, bez patyczków – wyłącznie listki ostrokrzewu paragwajskiego.",
                    LongDescription = "Yerba mate Amanda Despalada produkowana w argentyńskiej prowincji Missiones. Opakowanie zawiera dosyć grubo pocięte listki yerba mate bez gałązek. Despalada służy szybkiemu pobudzeniu, które wynika z proporcji suszu. Despalada jest zdecydowanie klasyczną mate. A to oznacza, że prócz lekko ziemistego aromatu jest w niej wyczuwalna goryczka.",
                },
                new Product()
                {
                    Id = 2,
                    ProductName = "Amanda Despelada Sin Palo",
                    ProductBrand = "Amanda",
                    ProductImage = "https://www.poyerbani.pl/pol_pl_Amanda-Despalada-Sin-Palo-0-5kg-894_1.png",
                    Country = "Argentyna",
                    ProductPrice = 41.99M,
                    ProductWeight = 1.0,
                    ShortDescription = "Yerba Mate Amanda Despalada Sin Palo 1 kg to klasyk z Argentyny. Yerba mate bez dodatków, bez patyczków – wyłącznie listki ostrokrzewu paragwajskiego.",
                    LongDescription = "Yerba mate Amanda Despalada produkowana w argentyńskiej prowincji Missiones. Opakowanie zawiera dosyć grubo pocięte listki yerba mate bez gałązek. Despalada służy szybkiemu pobudzeniu, które wynika z proporcji suszu. Despalada jest zdecydowanie klasyczną mate. A to oznacza, że prócz lekko ziemistego aromatu jest w niej wyczuwalna goryczka.",
                },
                new Product()
                {
                    Id = 3,
                    ProductName = "CBSe Energia Guarana",
                    ProductBrand = "CBSe",
                    ProductImage = "https://www.poyerbani.pl/pol_pl_CBSe-Energia-Guarana-0-5-kg-1016_1.png",
                    Country = "Argentyna",
                    ProductPrice = 21.99M,
                    ProductWeight = 0.5,
                    ShortDescription = "Yerba Mate CBSe Energía Guarana to pobudzająca argentyńska yerba z guaraną. Ma łagodny owocowy smak i aromat. Zawiera mnóstwo kofeiny. Prawdziwy bestseller!",
                    LongDescription = "Popijając yerba mate CBSé Energía Guarana, na długo zapomnisz o kawie. Jeśli poszukujesz podwójnego pobudzenia — to właśnie znalazłeś. Atrakcyjne opakowanie kryje susz o słodkawym, lekko korzennym aromacie, który uwodzi nasze zmysły. Delikatny, przyjemny smak niwelujący wyczuwalną goryczkę ukontentuje nie jedno podniebienie. Przemyślane i zaskakujące połączenie yerba mate z naturalnym ekstraktem z owoców guarany. Całość równoważona przez tradycyjne dodatki ziołowe stanowi połączenie idealne.",
                },
                new Product()
                {
                    Id = 4,
                    ProductName = "CBSe Energia Guarana",
                    ProductBrand = "CBSe",
                    ProductImage = "https://www.poyerbani.pl/pol_pl_CBSe-Energia-Guarana-0-5-kg-1016_1.png",
                    Country = "Argentyna",
                    ProductPrice = 39.99M,
                    ProductWeight = 1.0,
                    ShortDescription = "Yerba Mate CBSe Energía Guarana to pobudzająca argentyńska yerba z guaraną. Ma łagodny owocowy smak i aromat. Zawiera mnóstwo kofeiny. Prawdziwy bestseller!",
                    LongDescription = "Popijając yerba mate CBSé Energía Guarana, na długo zapomnisz o kawie. Jeśli poszukujesz podwójnego pobudzenia — to właśnie znalazłeś. Atrakcyjne opakowanie kryje susz o słodkawym, lekko korzennym aromacie, który uwodzi nasze zmysły. Delikatny, przyjemny smak niwelujący wyczuwalną goryczkę ukontentuje nie jedno podniebienie. Przemyślane i zaskakujące połączenie yerba mate z naturalnym ekstraktem z owoców guarany. Całość równoważona przez tradycyjne dodatki ziołowe stanowi połączenie idealne.",
                },
                new Product()
                {
                    Id = 5,
                    ProductName = "CBSe Pomelo(grejpfrut)",
                    ProductBrand = "CBSe",
                    ProductImage = "https://www.poyerbani.pl/pol_pl_CBSe-Pomelo-0-5kg-grejpfrut-1039_1.png",
                    Country = "Argentyna",
                    ProductPrice = 21.99M,
                    ProductWeight = 0.5,
                    ShortDescription = "Grejfrutowa Yerba Mate znanej marki CBSe",
                    LongDescription = "CBSé Pomelo to owocowa yerba mate o smaku grejpfruta. W sam raz do tereré. Klasyczna i delikatna elaborada w argentyńskim stylu została uzupełniona cytrusową dominantą, która przenosi w świat egzotyki. Ciekawa propozycja dla miłośników owocowych smaków. Także dla rozpoczynających swoją yerbacianą odyseję.",
                },
                new Product()
                {
                    Id = 6,
                    ProductName = "Kraus Organica",
                    ProductBrand = "Kraus",
                    ProductImage = "https://www.poyerbani.pl/pol_pl_Kraus-Organica-0-5kg-organiczna-1218_2.png",
                    Country = "Argentyna",
                    ProductPrice = 25.99M,
                    ProductWeight = 0.5,
                    ShortDescription = "Kraus to argentyńska marka specjalizująca się w produkcji Yerba Mate bez użycia dymu. Liście suszone są gorącym powietrzem, dzięki czemu zachowują żywy kolor. ",
                    LongDescription = "Kraus Orgánica to yerba mate absolutnie naturalna. Jej krzewy wzrastają na ekologicznej plantacji w zgodzie ze środowiskiem. Zbiory są limitowane ze względu na charakter uprawy, wolnej od środków ochrony i stymulacji chemicznej. Także innowacyjna metoda suszenia surowca czyni Krausa wyjątkowym.. Zazwyczaj yerba mate jest suszona (wędzona) w dymie ogniska, tutaj zastosowano innowacyjną technologię suszenia za pomocą gorącego powietrza. Taka metoda uwalnia napar od dymnego i ostrzejszego posmaku. Kraus Orgánica jest nadal gorzką yerbą, ale o nieco trawiastym (świeżym) posmaku. Łagodny smak pobudzenia. Polecamy.",
                },
                new Product()
                {
                    Id = 7,
                    ProductName = "Cruz de Malta Elaborada Con Paloa",
                    ProductBrand = "Molinos",
                    ProductImage = "https://www.poyerbani.pl/pol_pl_Cruz-de-Malta-Elaborada-Con-Palo-1kg-1067_1.png",
                    Country = "Argentyna",
                    ProductPrice = 39.99M,
                    ProductWeight = 1.0,
                    ShortDescription = "Cruz de Malta to argentyńska marka Yerba Mate produkowana od 1874 roku na plantacjach należących do Molinos Rio de la Plata.",
                    LongDescription = "Cruz de Malta Elaborada Con Palo to tradycyjna yerba mate z patyczkami pozbawiona dodatków smakowych. Należy do najbardziej znanych argentyńskich marek o dużej renomie i długich tradycjach. Cruz De Malta od zawsze utożsamiano z wysokimi standardami produkcji i wyśmienitym smakiem. Jest świetnym źródłem mateiny gwarantującej długotrwały efekt",
                },
                new Product()
                {
                    Id = 8,
                    ProductName = "Cruz de Malta Elaborada Con Paloa",
                    ProductBrand = "Molinos",
                    ProductImage = "https://www.poyerbani.pl/pol_pl_Cruz-de-Malta-Elaborada-Con-Palo-1kg-1067_1.png",
                    Country = "Argentyna",
                    ProductPrice = 19.99M,
                    ProductWeight = 0.5,
                    ShortDescription = "Cruz de Malta to argentyńska marka Yerba Mate produkowana od 1874 roku na plantacjach należących do Molinos Rio de la Plata.",
                    LongDescription = "Cruz de Malta Elaborada Con Palo to tradycyjna yerba mate z patyczkami pozbawiona dodatków smakowych. Należy do najbardziej znanych argentyńskich marek o dużej renomie i długich tradycjach. Cruz De Malta od zawsze utożsamiano z wysokimi standardami produkcji i wyśmienitym smakiem. Jest świetnym źródłem mateiny gwarantującej długotrwały efekt",
                },

                 //PARAGWAJ
                 new Product()
                 {
                     Id = 9,
                     ProductName = "Kurupi Clasica",
                     ProductBrand = "Kurupi",
                     ProductImage = "https://www.poyerbani.pl/pol_pl_Kurupi-Clasica-0-5kg-1228_1.png",
                     Country = "Paragwaj",
                     ProductPrice = 21.99M,
                     ProductWeight = 0.5,
                     ShortDescription = "Kurupi Clásica 500 g 0,5 kg to paragwajska yerba mate w klasycznym stylu. Cechuje się wspaniałym, szlachetnie goryczkowym aromatem i świetnie pobudza.",
                     LongDescription = "Kurupi Clasica - klasyczna paragwajska elaborada, przechodząca specjalny proces obróbki, w którym uzyskuje swój unikalny i niepowtarzalny smak. Jest jedną z mocniejszych yerba mate, której walory docenią szczególnie doświadczeni mateiści. Szczególnie poszukujący wyrazistego smaku oraz dobrego pobudzenia znajdą w Kurupi Clásica źródło naturalnej przyjemności. Posiada wspaniały goryczkowaty smak i dymny aromat. Ze względu na długi czas sezonowania jest nieco łagodniejsza od bliźniaczej Kurupi Tradicional. Pięknie pieniący susz jest głównym atutem tej popularnej mate.",
                 },
                new Product()
                {
                    Id = 10,
                    ProductName = "Kurupi Katuava",
                    ProductBrand = "Kurupi",
                    ProductImage = "https://www.poyerbani.pl/pol_pl_Kurupi-Katuava-Especial-0-5kg-1234_1.png",
                    Country = "Paragwaj",
                    ProductPrice = 21.99M,
                    ProductWeight = 0.5,
                    ShortDescription = "Kurupi Katuava Especial 500 g to paragwajska yerba mate z dodatkiem kory catuaby oraz zioła burrito. Ziołowy aromat równoważy goryczkę. Doskonale pobudza.",
                    LongDescription = "Yerba mate Kurupi Katuava Especial to najwyższej jakości paragwajska yerba mate z dodatkiej ciętej katuavy, prawdziwego skarbu południowoamerykańskiej ziemi. Najcenniejszym elementem rośliny jest jej kora cechująca się wspaniałym eterycznym aromatem. Tradycyjna medycyna ludowa przypisuje jej właściwości przeciwzapalne i oczyszczające i powszechnie uznaje za afrodyzjak. W niektórych regionach Brazylii mawia się ponoć, że po 60 roku życia, każdy mężczyzna \"należy\" do katuavy. Jak sproszkowana kora tej tajemniczej rośliny wypada w połączeniu z yerba mate? Naprawdę znakomicie! Szlachetna goryczka dymionej paragwajskiej yerba mate jest zręcznie harmonizowana przez ziołowe akcenty. Nie mamy wątpliwości, że całość doskonale odnajdzie się jako baza dla orzeźwiającego tereré w upalne dni, jak również w formie ciepłego naparu na rozgrzanie. Warto zaznaczyć, że podobnie jak inne produkty marki, Kurupi Katuava Especial cechuje się dużą zawartością naturalnej kofeiny. Będzie doskonałym źródłem naturalnej enegii. Polecamy ją przede wszystkim miłośnikom ziołowych yerba mate i doświadczonym mateistom zainteresowanym rasowymi paragwajskimi yerba mate.",
                },
                new Product()
                {
                    Id = 11,
                    ProductName = "Kurupi Katuava",
                    ProductBrand = "Kurupi",
                    ProductImage = "https://www.poyerbani.pl/pol_pl_Kurupi-Katuava-Especial-0-5kg-1234_1.png",
                    Country = "Paragwaj",
                    ProductPrice = 40.99M,
                    ProductWeight = 1.0,
                    ShortDescription = "Kurupi Katuava Especial 1kg to paragwajska yerba mate z dodatkiem kory catuaby oraz zioła burrito. Ziołowy aromat równoważy goryczkę. Doskonale pobudza.",
                    LongDescription = "Yerba mate Kurupi Katuava Especial to najwyższej jakości paragwajska yerba mate z dodatkiej ciętej katuavy, prawdziwego skarbu południowoamerykańskiej ziemi. Najcenniejszym elementem rośliny jest jej kora cechująca się wspaniałym eterycznym aromatem. Tradycyjna medycyna ludowa przypisuje jej właściwości przeciwzapalne i oczyszczające i powszechnie uznaje za afrodyzjak. W niektórych regionach Brazylii mawia się ponoć, że po 60 roku życia, każdy mężczyzna \"należy\" do katuavy. Jak sproszkowana kora tej tajemniczej rośliny wypada w połączeniu z yerba mate? Naprawdę znakomicie! Szlachetna goryczka dymionej paragwajskiej yerba mate jest zręcznie harmonizowana przez ziołowe akcenty. Nie mamy wątpliwości, że całość doskonale odnajdzie się jako baza dla orzeźwiającego tereré w upalne dni, jak również w formie ciepłego naparu na rozgrzanie. Warto zaznaczyć, że podobnie jak inne produkty marki, Kurupi Katuava Especial cechuje się dużą zawartością naturalnej kofeiny. Będzie doskonałym źródłem naturalnej enegii. Polecamy ją przede wszystkim miłośnikom ziołowych yerba mate i doświadczonym mateistom zainteresowanym rasowymi paragwajskimi yerba mate.",
                },
                new Product()
                {
                    Id = 12,
                    ProductName = "Pajarito Elaborada Con Palo",
                    ProductBrand = "Pajarito",
                    ProductImage = "https://www.poyerbani.pl/pol_pl_Pajarito-Elaborada-Con-Palo-Tradicional-1kg-1327_1.png",
                    Country = "Paragwaj",
                    ProductPrice = 29.99M,
                    ProductWeight = 1.0,
                    ShortDescription = "Pajarito Elaborada Con Palo Tradicional 1 kg to tradycyjna yerba mate z Paragwaju. Ma mocny dymny aromat i wyrazisty smak. Dobrze pobudza.",
                    LongDescription = "Yerba mate Pajarito Elaborada to klasyka z Paragwaju. Pajarito oznacza po hiszpańsku „ptaszek” i na nazwie kończy się delikatności. Mocna w działaniu i wyraźna w smaku. Tu nie ma miejsca na subtelności - to jest mate w stylu macho. Wielu mateistów mówiąc yerba, myśli właśnie Elaborada od Pajarito. Być może dlatego, że kto jej spróbował, ten długo pamięta wyjątkowo przyjemny smak. Jedna z tych odmian, które dostarczają energii na długo. Tajemnicą firmy jest sposób yerba mate. Wiemy o nim tyle, że zbiera się tylko najlepsze listki i gałązki. W późniejszym etapie specjalne receptury przygotowania i palenia czynią z niej jedną z najlepszych mate na świecie. Pozostawia wyrazisty smak i przyjemne wspomnienia.",
                },
                new Product()
                {
                    Id = 13,
                    ProductName = "Pajarito Compuesta con Hierbas",
                    ProductBrand = "Pajarito",
                    ProductImage = "https://www.poyerbani.pl/pol_pl_Pajarito-Elaborada-Con-Palo-Tradicional-1kg-1327_1.png",
                    Country = "Paragwaj",
                    ProductPrice = 21.99M,
                    ProductWeight = 0.5,
                    ShortDescription = "Pajarito Compuesta con Hierbas 0,5 kg 500 g to ziołowa yerba mate z Paragwaju. Ma goryczkowy aromat połączony z rześkim dodatkiem mięty. Dobrze pobudza. Hit naszego sklepu yerba mate!",
                    LongDescription = "Pajarito Hierbas to idealna propozycja dla osób gustujących w ziołowych mieszankach. Kompozycja składa się w 90% z yerba mate oraz w 10% z aromatycznych ziół. Między innymi: mięty pieprzowej, cedronu oraz burito. Orzeźwiający smak przyjemnie pobudza.",
                },
                  new Product()
                  {
                      Id = 14,
                      ProductName = "La Rubia Elaborada Con Palo",
                      ProductBrand = "La Rubia",
                      ProductImage = "https://www.poyerbani.pl/pol_pl_La-Rubia-Elaborada-Con-Palo-Tradicional-0-5kg-1254_2.png",
                      Country = "Paragwaj",
                      ProductPrice = 21.99M,
                      ProductWeight = 0.5,
                      ShortDescription = "La Rubia 0,5 kg 500 g to paragwajska yerba mate z organicznym certyfikatem. Nie zawiera dodatków. Cechuje się klasycznym goryczkowym smakiem i świetnie pobudza.",
                      LongDescription = "Pochodząca z ekologicznej uprawy jest specjalnie selekcjonowana dla osiągnięcia wyrazistszego smaku, a przez to doskonałego pobudzenia. Rodzinna plantacja uczestniczy w programie odbudowy lasów tropikalnych. Sięgając zatem po tę mocną mate, pomagasz ocalić unikalne środowisko. Część surowca leżakuje niemal cały rok dla wydobycia intensywności smaku i aromatu. La Rubia dosłownie znaczy po hiszpańsku „blondynka”. Ta dama należy do grona wielbicielek wytrawnych smaków w najlepszym wydaniu.",
                  },
                    new Product()
                    {
                        Id = 15,
                        ProductName = "La Rubia Elaborada Con Palo",
                        ProductBrand = "La Rubia",
                        ProductImage = "https://www.poyerbani.pl/pol_pl_La-Rubia-Elaborada-Con-Palo-Tradicional-0-5kg-1254_2.png",
                        Country = "Paragwaj",
                        ProductPrice = 40.99M,
                        ProductWeight = 1,
                        ShortDescription = "La Rubia 1kg to paragwajska yerba mate z organicznym certyfikatem. Nie zawiera dodatków. Cechuje się klasycznym goryczkowym smakiem i świetnie pobudza.",
                        LongDescription = "Pochodząca z ekologicznej uprawy jest specjalnie selekcjonowana dla osiągnięcia wyrazistszego smaku, a przez to doskonałego pobudzenia. Rodzinna plantacja uczestniczy w programie odbudowy lasów tropikalnych. Sięgając zatem po tę mocną mate, pomagasz ocalić unikalne środowisko. Część surowca leżakuje niemal cały rok dla wydobycia intensywności smaku i aromatu. La Rubia dosłownie znaczy po hiszpańsku „blondynka”. Ta dama należy do grona wielbicielek wytrawnych smaków w najlepszym wydaniu.",
                    },

                    //Argentyna
                    new Product()
                    {
                        Id = 16,
                        ProductName = "Taragui Energia",
                        ProductBrand = "Las Marias",
                        ProductImage = "https://www.poyerbani.pl/pol_pl_Taragui-Energia-0-5kg-1671_1.png",
                        Country = "Argentyna",
                        ProductPrice = 22.99M,
                        ProductWeight = 0.5,
                        ShortDescription = "Yerba Mate Taragüi Energia to klasyczna yerba o zwiększonej zawartości kofeiny, dzięki czemu daje mocny efekt pobudzenia.",
                        LongDescription = "Yerba Mate Taragüi Energia to produkt Establecimiento Las Marias, jednego z największych producentów yerba mate w Argentynie. Należy do najpopularniejszych mate oferowanych przez to przedsiębiorstwo. Wszystko ze względu na dużą zawartość naturalnej kofeiny. Według producenta jest jej nawet 30% więcej niż w tradycyjnych yerba mate. Co ciekawe, w przeciwieństwie do innych produktów znancych z silnego efektu pobudzajacego, Taragüi Energia nie zawiera żadnych dodatków. Co sprawia więc, że tak dobrze energetyzuje? Kluczem okazuje się odpowiednia technika przetwarzania suszu. Taragui Energia to silnie energetyzująca yerba mate w klasycznej otoczce smakowej. Koniecznie sprawdźcie jej działanie!",
                    },
                     new Product()
                     {
                         Id = 17,
                         ProductName = "Taragui Energia",
                         ProductBrand = "Las Marias",
                         ProductImage = "https://www.poyerbani.pl/pol_pl_Taragui-Energia-0-5kg-1671_1.png",
                         Country = "Argentyna",
                         ProductPrice = 32.99M,
                         ProductWeight = 1.0,
                         ShortDescription = "Yerba Mate Taragüi Energia to klasyczna yerba o zwiększonej zawartości kofeiny, dzięki czemu daje mocny efekt pobudzenia.",
                         LongDescription = "Yerba Mate Taragüi Energia to produkt Establecimiento Las Marias, jednego z największych producentów yerba mate w Argentynie. Należy do najpopularniejszych mate oferowanych przez to przedsiębiorstwo. Wszystko ze względu na dużą zawartość naturalnej kofeiny. Według producenta jest jej nawet 30% więcej niż w tradycyjnych yerba mate. Co ciekawe, w przeciwieństwie do innych produktów znancych z silnego efektu pobudzajacego, Taragüi Energia nie zawiera żadnych dodatków. Co sprawia więc, że tak dobrze energetyzuje? Kluczem okazuje się odpowiednia technika przetwarzania suszu. Taragui Energia to silnie energetyzująca yerba mate w klasycznej otoczce smakowej. Koniecznie sprawdźcie jej działanie!",
                     },

                    new Product()
                    {
                        Id = 18,
                        ProductName = "Taragui Maracuya Tropical",
                        ProductBrand = "Las Marias",
                        ProductImage = "https://www.poyerbani.pl/pol_pl_Taragui-Maracuya-Tropical-marakuja-0-5kg-1509_1.png",
                        Country = "Argentyna",
                        ProductPrice = 22.99M,
                        ProductWeight = 0.5,
                        ShortDescription = "Taragüi Maracuya Tropical 0,5 kg 500 g to argentyńska yerba mate o smaku owocu marakui. Doskonale pobudza, jest świetna na zimno i na ciepło.",
                        LongDescription = "Taragüi Maracuya Tropical - delikatna yerba o złagodzonej goryczce. Łagodny smak i aromat zdecydowanie występują w naturalnych odmianach klasyki. Polecana szczególnie wszystkim początkującym mateistom. Sprawdzona jako doskonały poczęstunek dla zainteresowanych niezwykłymi właściwościami yerba mate. Ciekawym dodatkiem jest świetnie wkomponowana nuta marakui. ",
                    },

                    //Brazylia
                    new Product()
                    {
                        Id = 19,
                        ProductName = "Verde Mate Green Detox",
                        ProductBrand = "Verde Mate",
                        ProductImage = "https://www.poyerbani.pl/pol_pl_Verde-Mate-Green-Detox-0-5kg-4425_1.png",
                        Country = "Brazylia",
                        ProductPrice = 24.99M,
                        ProductWeight = 0.5,
                        ShortDescription = "Verde Mate Green Detox to idealna propozycja dla każdego, kto poszukuje wytrawnego i dobrze wyważonego smaku yerba mate.",
                        LongDescription = "Zanieczyszczenie powietrza, niezdrowe jedzenie, stres i nieustanny pośpiech to codzienność człowieka XXI wieku. Istnieje jednak naturalne remedium na bolączki życia w betonowej dżungli. To Verde Mate Detox! Spróbuj koniecznie! ",
                    },
                    new Product()
                    {
                        Id = 20,
                        ProductName = "Verde Mate Green Frutos del Bosque",
                        ProductBrand = "Verde Mate",
                        ProductImage = "https://www.poyerbani.pl/pol_pl_Verde-Mate-Green-Frutos-del-Bosque-0-5kg-4480_1.png",
                        Country = "Brazylia",
                        ProductPrice = 22.99M,
                        ProductWeight = 0.5,
                        ShortDescription = "Verde Mate Frutos del Bosque to połączenie aromatycznej yerba mate ze słodkawymi i kwaskowatymi owocami z europejskich lasów.",
                        LongDescription = "Dawno nie spotkaliśmy nic lepszego od Verde Mate Frutos del Bosque. Nasze europejskie owoce leśne to idealny materiał do produkcji soków, dżemów, win i nalewek. A gdyby tak połączyć je ze świeżą brazylijską yerba mate, która dorasta w dzikim tropikalnym lesie w cieniu drzew araukarii chilijskiej? Idealna harmonia! Kompozycja jest urozmaicona wizualnie. Poza yerba mate w składzie mamy starannie wyselekcjonowane owoce dzikiej róży, jeżyny i czerwonej porzeczki oraz malinowe liście. Gwarancja pobudzenia w świeżym stylu! ",
                    },
                    new Product()
                    {
                        Id = 21,
                        ProductName = "Verde Mate Green Mas IQ",
                        ProductBrand = "Verde Mate",
                        ProductImage = "https://www.poyerbani.pl/pol_pl_Verde-Mate-Green-Mas-IQ-0-5kg-4240_1.png",
                        Country = "Brazylia",
                        ProductPrice = 27.99M,
                        ProductWeight = 0.5,
                        ShortDescription = "Verde Mate Más IQ to kompozycja ostrokrzewu paragwajskiego i składników nadających jej delikatnie owocowy smak. Nie brakuje w niej także pożytecznych dodatków!",
                        LongDescription = "Odkryj moc naturalnej kofeiny i cennych dla zdrowia składników w prawdziwie zmysłowej odsłonie! Verde Mate Más IQ to doskonale dopracowana kompozycja ziół, owoców i yerba mate. Oprócz listków ostrokrzewu z leśnej uprawy w brazylijskim stanie Parana, Mas IQ zawiera wyciąg z ginkgo biloba oraz żeń-szeń. Ziołową bazę uzupełniają owocowe dodatki w postaci skórki pomarańczy i kawałków ananasa. Kompozycję zamyka znany z dużej zawartości kofeiny ekstrakt z guarany. Po Verde Mate Mas IQ najchętniej sięgają uczniowie, studenci, informatycy i inne osoby pracujące umysłowo.",
                    }
            );

            modelBuilder.Entity<User>()
                .HasOne(o => o.Address)
                .WithOne(a => a.User)
                .HasForeignKey<Address>(o => o.UserId);

            modelBuilder.Entity<Address>().HasData(
                new Address()
                {
                    Id = 1,
                    Street = "Łazowska 4",
                    PostCode = "42-450",
                    City = "Łazy",
                    UserId = 1
                },
                new Address()
                {
                    Id = 2,
                    Street = "Michałowksa 5",
                    PostCode = "42-450",
                    City = "Łazy",
                    UserId = 2
                }
                );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Tomasz",
                    LastName = "Kowalski",
                    Email = "tomus@gmail.com",
                    Password = "qwerty",
                    AddressId = 1,

                },
                new User
                {
                    Id = 2,
                    FirstName = "Michał",
                    LastName = "Nogalski",
                    Email = "michalek@gmail.com",
                    Password = "qwerty",
                    AddressId = 2,
                }

                );

            modelBuilder.Entity<Review>()
             .Property(p => p.TypeOfReview)
             .HasConversion<string>();

            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    Id = 1,
                    ReviewText = "Smaczna Yerba polecam!",
                    TypeOfReview = TypeOfReview.Like,
                    ProductId = 1,
                    UserId = 1,
                },
                  new Review()
                  {
                      Id = 2,
                      ReviewText = "Bardzo dobra klasyczna Yerba!",
                      TypeOfReview = TypeOfReview.Like,
                      ProductId = 1,
                      UserId = 2,
                  }

                );

            base.OnModelCreating(modelBuilder);
        }
    }
}