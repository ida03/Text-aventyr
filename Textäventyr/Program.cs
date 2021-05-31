using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textäventyr
{
    class Program
    {
        static void GameOver()
        {
            Console.WriteLine("Du har förlorat alla dina liv");
            Console.WriteLine("GAME OVER");
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            int liv = 3;
            int låskod = 0;
            int uppgift = 0;
            int matteuppgift = 0;
            int svar1 = 0;
            int svar2 = 0;
            int svar3 = 0;

            Console.WriteLine("Hej och välkommen!");
            Console.WriteLine("Om du vill starta spelet, tryck Enter");
            Console.WriteLine("Om du vill stänga ner spelet, tryck Escape");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("Tryck på Enter för att fortsätta ");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    Environment.Exit(0);
            }
            Console.WriteLine("Lycka till!");

            //Vaknar i cellen
            Console.WriteLine("Något känns konstigt. Din mjuka madrass är utbytt mot något hårt som skaver in i din rygg.");
            Console.WriteLine("Ljudet av droppande vatten hörs runt dig.");
            Console.WriteLine("När du öppnar dina ögon ser du att du inte är i din säng hemma, utan i vad som ser ut som en mörk fängelsecell.");
            Console.WriteLine(" - Ah, jag ser att du äntligen har vaknat.");
            Console.WriteLine("Rösten kommer från din högra sida och där, i cellen bredvid, sitter en mycket gammal man");
            Console.WriteLine(" -Jag hoppades att du skulle vakna snart. När vakterna bar in dig var du medvetslös och jag visste inte hur mycket sömnmedel de hade gett dig.");
            Console.WriteLine("Du undrar säkert var du är och det ska jag berätta för dig, men först vill jag veta ditt namn.");
            string strnamn = Console.ReadLine();
            Console.WriteLine("Ahh, " + strnamn + ", välkommen hit. Nu ska du få koden till låset");
            Console.WriteLine("Den gamla mannen räcker över en sliten och fuktig pappersbit. På den står det:");
            Console.WriteLine("Här är koden till det nya låset, låt inte fångarna få tag på den");
            Console.WriteLine("1. Roten ur 4, multiplicerat med 6");
            Console.WriteLine("2. 4 plus 4, dividerat med 2");
            Console.WriteLine("3. 5 multiplicerat med 0");
            Console.WriteLine("Du kryper fram mot låset som hänger på andra sidan om din celldörr");
            Console.WriteLine("Skriv in lösningen här:");
            
            while (låskod != 1240)
            {
                Console.WriteLine("Skriv in koden till låset här:");
                string strkod = Console.ReadLine();
                låskod = Convert.ToInt32(strkod);
                if (låskod != 1240)
                    liv--;
                if (liv == 0)
                    GameOver();
            }
            Console.WriteLine("Låset slår i stengolvet och dörren går upp. Du sticker ut huvudet för att se så att ingen av vakterna hörde");
            Console.WriteLine(" -Bra gjort! Gå nu innan någon kommer för att kolla till dig.");
            Console.WriteLine("Tänk inte på mig, jag är bara en gammal man, om de hade velat skada mig hade de gjort det för länge sedan");
            Console.WriteLine("Du går ut i korridoren mellan cellerna. Längst bort syns en dörr, du skyndar mot den");
            Console.WriteLine("Dörren glider upp på knarrande gångjärn och du hoppas innerligt att ingen hörde. Korridoren utanför är tyst och övergiven, det enda som hörs är dina fotsteg");
            
            Console.WriteLine("Plötsligt hör du fotsteg som kommer mot dig. Innan du hinner gömma dig rundar en man hörnet och får syn på dig.");
            Console.WriteLine(" -Hej?! Är du inte " + strnamn + ", den där fången som vakterna spärrade in tidigare idag? Hur tog du dig ut?");
            Console.WriteLine("Jag borde egentligen kalla på vakterna, men om du löser en klurig uppgift låter jag dig gå.");
            Console.WriteLine("Vad blir roten ur fyra, plus 10?");
            while (uppgift != 12)
            {
                string struppgift = Console.ReadLine();
                uppgift = Convert.ToInt32(struppgift);

                if (uppgift != 12)
                    liv--;
                if (liv == 0)
                    GameOver();
            }
            Console.WriteLine("Okej, du får passera. Men om jag ser dig igen kommer jag inte tveka innan jag kallar på vakterna.");
            Console.WriteLine("Du rundar hörnet som mannen kom ifrån. Där ser du två dörrar en röd och en blå. Båda verkar vara olåsta.");
            Console.WriteLine("Vilken dörr väljer du?");

            string strdörr = Console.ReadLine();
            strdörr = strdörr.ToLower();
            if (strdörr == "röd")
                Console.WriteLine("Du öppnar den röda dörren. Bakom den finns en lång korridor. Du går i vad som känns som flera timmar.");
                Console.WriteLine("Men det är egentligen bara några minuter. Plötsligt dyker en liten flicka upp från ingenstans. Du tvärstannar och tittar på henne. Hon ser inte ut att vara mer än 6 år gammal.");
                Console.WriteLine(" -Ursäkta. Skulle du kunna hjälpa mig med en uppgift på min matteläxa? Jag kan inte hitta min pappa och han brukar alltid hjälpa mig.");
                Console.WriteLine("Flickan sträcker fram ett häfte med uppgifter och pekar på den längst ner på sidan.");
                Console.WriteLine("Tom har 3 äpplen och Angelica har 5 äpplen.De bestämmer sig för att dela lika på äpplena.Hur många äpplen får de var ?");

            while (matteuppgift != 4)
            {
                string strmatteuppgift = Console.ReadLine();
                matteuppgift = Convert.ToInt32(strmatteuppgift);

                if (matteuppgift != 4)
                    liv--;
                if (liv == 0)
                    GameOver();
            }
                Console.WriteLine(" -Tack så mycket!");
                Console.WriteLine("Flickan försvinner genom en dörr som du inte hade sett innan. Du fortsätter gå genom korridoren. Tillslut kommer du fram till en dörr i och öppnar den.");
                Console.WriteLine("Bakom finns det en korridor och i slutet av den sitter en helt svart katt. Du går långsamt fram mot den och tänker precis passera när den börjar prata.");
                Console.WriteLine(" -Hallå där! Du är väl "+strnamn+", fången som vakterna tog in i förmiddags?");
                Console.WriteLine("Du är på rätt väg för att ta dig ut härifrån, men runt hörnet där borta står det flera vakter som ska se till att ingen flyr härifrån.");
                Console.WriteLine("Om jag hjälper dig förbi dem måste du lova att inte berätta om mig ifall du blir påkommen. Bra, följ mig.");
                Console.WriteLine("Istället för att fortsätta genom korridoren leder katten dig tillbaka där du kom ifrån. Ni går i total tystnad och ibland stannar katten för att lyssna.");
                Console.WriteLine("Efter en stund stannar katten framför en staty som ser ut att föreställa en katt.");
                Console.WriteLine(" -Om du trycker på statyns högra framtass kommer en lönndörr att öppnas. Följ korridoren tills den tar slut och tryck på väggen där.");
                Console.WriteLine("Du kommer att hamna i en korridor där du ska gå vänster. Om du gör detta borde du komma närmare utgången.");
                Console.WriteLine("Innan du hinner tacka katten för hjälpen har den försvunnit");

            if (strdörr == "blå")
                Console.WriteLine("Du öppnar den blåa dörren. Bakom finns det en korridor och i slutet av den sitter en helt svart katt.");
                Console.WriteLine("Du går långsamt fram mot den och tänker precis passera när den börjar prata.");
                Console.WriteLine(" -Hallå där! Du är väl "+strnamn+", fången som vakterna tog in i förmiddags?");
                Console.WriteLine("Du är på rätt väg för att ta dig ut härifrån, men runt hörnet där borta står det flera vakter som ska se till att ingen flyr härifrån.");
                Console.WriteLine("Om jag hjälper dig förbi dem måste du lova att inte berätta om mig ifall du blir påkommen. Bra, följ mig.");
                Console.WriteLine("Istället för att fortsätta genom korridoren leder katten dig tillbaka där du kom ifrån. Ni går i total tystnad och ibland stannar katten för att lyssna.");
                Console.WriteLine("Efter en stund stannar katten framför en staty som ser ut att föreställa en katt.");
                Console.WriteLine(" -Om du trycker på statyns högra framtass kommer en lönndörr att öppnas. Följ korridoren tills den tar slut och tryck på väggen där.");
                Console.WriteLine("Du kommer att hamna i en korridor där du ska gå vänster. Om du gör detta borde du komma närmare utgången.");
                Console.WriteLine("Innan du hinner tacka katten för hjälpen har den försvunnit");

            Console.WriteLine("Du trycker på statyns högra framtass och dörren öppnas.");
            Console.WriteLine("Du följer korridoren åt vänster och när du rundar ett hörn ser du den, utgången, och du börjar gå fortare.");
            Console.WriteLine("När du bara är några meter från dörren kommer en man ut från en korridor precis jämte dörren.");
            Console.WriteLine(" -Hallå! Vad gör du utanför din cell? Hur tog du dig förbi alla vakter som jag har ställt ut?");
            Console.WriteLine("Det spelar ingen roll nu, du kommer aldrig ta dig ut härifrån, inte om jag får bestämma!");
            Console.WriteLine("För att ta dig ut härifrån måste du svara på 3 frågor. Om du svarar rätt låter jag dig gå, men om du svarar fel måste du stanna här i all evighet.");
            Console.WriteLine("Här kommer den första frågan: Vad blir 2 plus 2, dividerat med 2?"); 
            
            while (svar1 != 4)
            {
                string strsvar1 = Console.ReadLine();
                svar1 = Convert.ToInt32(strsvar1);
                if (svar1 != 4)
                    liv--;
                if (liv == 0)
                    GameOver();
            }

            Console.WriteLine("Ah, du verkar vara ganska så smart ändå. Okej, då så. Här har du nästa fråga:");
            Console.WriteLine("Vad blir 2 upphöjt med 3?");
            while (svar2 != 8)
            {
                string strsvar2 = Console.ReadLine();
                svar2 = Convert.ToInt32(strsvar2);
                if (svar2 != 8)
                    liv--;
                if (liv == 0)
                    GameOver();
            }

            Console.WriteLine("Hmmm...här kommer den sista frågan. Jag garanterar att du inte kommer kunna svara på denna.");
            Console.WriteLine("Vad blir 2 multiplicerat med 5, plus 4, minus 2, dividerat med 2?");
            while (svar3 != 6)
            {
                string strsvar3 = Console.ReadLine();
                svar3 = Convert.ToInt32(strsvar3);
                if (svar3 != 6)
                    liv--;
                if (liv == 0)
                    GameOver();
            }

            Console.WriteLine("Hur lyckades du? Detta är ju riktigt svåra mattefrågor. Jaja, jag får väl hålla mitt löfte och låta dig gå.");
            Console.WriteLine("Du trycker upp den tunga ekdörren och lämnar mannen bakom dig. Husets trädgård är mycket vacker, med massor av blommor och träd");
            Console.WriteLine("Du följer vägen mot den stora järngrinden. Men när du försöker trycka upp grinden rör den sig inte och du känner paniken växa.");
            Console.WriteLine("Plötsligt börjar det svartna framför dina ögon och du faller till marken.");
            Console.WriteLine("När du öppnar ögonen igen ligger du i din egna säng. Den hemska resan till herrgården hänger kvar i ditt minne, men det verkar bara varit en dröm.");
        }
    }
}
