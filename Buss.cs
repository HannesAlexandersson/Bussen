using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bussen
{
    internal class Buss
    {
        // ett antal variabler som behövs i uträkningar 
        public int sumOfAge;
        public double avareageAge;
        public double sumOfAllTarfis;
        public int passThatGotOff;
        public int antal_passagerare;
        // variabler som behövs i olika metoder och som håller koll på olika statusegenskaper hos bussen.
        int pokeCount = 0;
        string defaultColour = "Röd";
        int defaultHP = 300;
        bool defaultTint = false;
        string defaultHorn = "Tut tut";
        Passager[] Seats = new Passager[25]; // array som representerar sätena (tillgängliga sittplatser) i bussen


        public void Run()
        {
            {
                //huvudmenyn
                string[] menuOptions = new string[] { "1.Hantera passagerare", "2.'Skriv ut' funktioner", "3.Beräkningar", "4.Sortera passagerare", "5.Peta på passagerare", "6.Garage", "7.Avsluta" };
                int menuSelect = 0;

                while (true)
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    if (menuSelect == 0)
                    {
                        Console.WriteLine("BUSS-SIMULATORN 1000");
                        Console.WriteLine("*********************");
                        Console.WriteLine("* " + menuOptions[0] + " *");
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[1]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[2]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[3]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[4]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[5]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[6]);
                        Console.WriteLine("- - - - - - - - - - -");



                    }
                    else if (menuSelect == 1)
                    {
                        Console.WriteLine("BUSS-SIMULATORN 1000");
                        Console.WriteLine("*********************");
                        Console.WriteLine(menuOptions[0]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine("* " + menuOptions[1] + " *");
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[2]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[3]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[4]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[5]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[6]);
                        Console.WriteLine("- - - - - - - - - - -");



                    }
                    else if (menuSelect == 2)
                    {
                        Console.WriteLine("BUSS-SIMULATORN 1000");
                        Console.WriteLine("*********************");
                        Console.WriteLine(menuOptions[0]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[1]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine("* " + menuOptions[2] + " *");
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[3]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[4]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[5]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[6]);
                        Console.WriteLine("- - - - - - - - - - -");



                    }
                    else if (menuSelect == 3)
                    {
                        Console.WriteLine("BUSS-SIMULATORN 1000");
                        Console.WriteLine("*********************");
                        Console.WriteLine(menuOptions[0]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[1]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[2]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine("* " + menuOptions[3] + " *");
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[4]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[5]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[6]);
                        Console.WriteLine("- - - - - - - - - - -");



                    }
                    else if (menuSelect == 4)
                    {
                        Console.WriteLine("BUSS-SIMULATORN 1000");
                        Console.WriteLine("*********************");
                        Console.WriteLine(menuOptions[0]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[1]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[2]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[3]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine("* " + menuOptions[4] + " *");
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[5]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[6]);
                        Console.WriteLine("- - - - - - - - - - -");



                    }
                    else if (menuSelect == 5)
                    {
                        Console.WriteLine("BUSS-SIMULATORN 1000");
                        Console.WriteLine("*********************");
                        Console.WriteLine(menuOptions[0]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[1]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[2]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[3]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[4]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine("* " + menuOptions[5] + " *");
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[6]);
                        Console.WriteLine("- - - - - - - - - - -");


                    }
                    else if (menuSelect == 6)
                    {
                        Console.WriteLine("BUSS-SIMULATORN 1000");
                        Console.WriteLine("*********************");
                        Console.WriteLine(menuOptions[0]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[1]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[2]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[3]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[4]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[5]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine("* " + menuOptions[6] + " *");
                        Console.WriteLine("- - - - - - - - - - -");


                    }
                    else if (menuSelect == 7)
                    {
                        Console.WriteLine("BUSS-SIMULATORN 1000");
                        Console.WriteLine("*********************");
                        Console.WriteLine(menuOptions[0]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[1]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[2]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[3]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[4]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[5]);
                        Console.WriteLine("- - - - - - - - - - -");
                        Console.WriteLine(menuOptions[6]);
                        Console.WriteLine("- - - - - - - - - - -");


                    }


                    var keyPressed = Console.ReadKey();
                    if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1)
                    {
                        menuSelect++;
                    }
                    else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1)
                    {
                        menuSelect--;
                    }
                    else if (keyPressed.Key == ConsoleKey.Enter)
                    {
                        switch (menuSelect)
                        {
                            case 0:
                                handle_Passagers();
                                break;
                            case 1:
                                Print();
                                break;
                            case 2:
                                Calculations();
                                break;
                            case 3:
                                sortingMenu();
                                break;
                            case 4:
                                poke();
                                break;
                            case 5:
                                Garage();
                                break;
                            case 6:
                                Terminate();
                                break;

                        }
                    }
                }
            }
        }

        public void handle_Passagers()//undermeny för allt som rör all hantering av passagerare
        {
            string[] printMenuOptions = new string[] { "Lägg till passagerare", "Släpp av passagerare", "Ta betalt av passagerare", "Återgå till mainmeny" };
            int printMenuSelect = 0;

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                if (printMenuSelect == 0)
                {
                    Console.WriteLine("Skriv ut funktioner");
                    Console.WriteLine("*********************");
                    Console.WriteLine("* " + printMenuOptions[0] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");

                }
                else if (printMenuSelect == 1)
                {
                    Console.WriteLine("Skriv ut funktioner");
                    Console.WriteLine("*********************");
                    Console.WriteLine(printMenuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + printMenuOptions[1] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");


                }
                else if (printMenuSelect == 2)
                {
                    Console.WriteLine("Skriv ut funktioner");
                    Console.WriteLine("*********************");
                    Console.WriteLine(printMenuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + printMenuOptions[2] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (printMenuSelect == 3)
                {
                    Console.WriteLine("Skriv ut funktioner");
                    Console.WriteLine("*********************");
                    Console.WriteLine(printMenuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + printMenuOptions[3] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                }


                var keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.DownArrow && printMenuSelect != printMenuOptions.Length - 1)
                {
                    printMenuSelect++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && printMenuSelect >= 1)
                {
                    printMenuSelect--;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    switch (printMenuSelect)
                    {
                        case 0:
                            add_passenger();
                            break;
                        case 1:
                            getting_off();
                            break;
                        case 2:
                            Console.WriteLine("Nu tar vi betalt av passagerarna som inte betalat ännu!");
                            sumOfAllTarfis = sumOfAllTarfis + chargeAllPassagers();
                            Console.WriteLine("Totalt intjänade pengar: " + sumOfAllTarfis);
                            Console.WriteLine("Tryck ENTER för att fortsätta...");
                            Console.ReadLine();
                            break;
                        case 3:
                            Run();
                            break;
                    }
                }
            }
        }
        public void add_passenger()//metod som lägger till passagerare till bussen
        {
            int numOfSeatsFree = 25 - antal_passagerare;
            // texten berör bussens egenskaper som går att modifiera i garaget
            Console.WriteLine("Din buss närmar sig en hållplats!\nDu tutar på passagerarna på hållplatsen, din tuta låter som "+defaultHorn+"\nBussen är skinande "+defaultColour+" och motorn låter :");
            if ( defaultHP < 500)
            {
                Console.WriteLine("Inte så värst mycket\n");
                if (defaultTint)
                {
                    Console.WriteLine("Ingen ser in genom glasen, Men du kan som tur e se ut!\n");
                }
            }
            else if (defaultHP > 500 && defaultHP < 1000) 
            {
                Console.WriteLine(" Så högt så att vissa av passagerarna håller för öronen!\n");
                if (defaultTint)
                {
                    Console.WriteLine("Ingen ser in genom glasen, Men du kan som tur e se ut!\n");
                }
            }
            else
            {
                Console.WriteLine("JÄTTEMYCKET OCH JÄTTEHÖGT!!! HELA STADEN SKAKAR!! MUTTRARNA LOSSNAR NÄSTAN PÅ HJULEN!!!\n");
                if (defaultTint)
                {
                    Console.WriteLine("Ingen ser in genom glasen, Men du kan som tur e se ut!\n");
                }
            }
            Console.WriteLine("Välj mellan: ");             //en sorts undermeny med ett alternativ som underlättar påstigning av flera passagerare samtidigt
            Console.WriteLine("1. Lägg till passagerare manuellt");
            Console.WriteLine("2. Fyll upp bussen med passagerare");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)//manuell inläggning av en enskild passagerare
                {
                    bool s = false;
                    while (s == false)
                    {
                        Console.Clear();
                        Console.WriteLine("På bussen finns det 25 platser. Det finns för närvarande " + antal_passagerare + " passagerare på bussen!");// för att visa för användaren hur många platser det finns tillgängliga så att man inte råkar släppa på för många passagerare ( inte för att det är möjligt)
                        Console.WriteLine("Det betyder att det finns " + numOfSeatsFree + " lediga platser!");

                        if (numOfSeatsFree >= 1)// för att man inte ska kunna ta emot passagerare ifall det inte finns lediga platser
                        {
                            try
                            {
                                Console.WriteLine("Lägg till en passagerare genom att ange ålder och kön!");
                                Console.WriteLine("Skriv in ålder: ");
                                int pAge = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Skriv Kön: (Kvinna/Man/Annan)");
                                string pSex = Console.ReadLine();
                                bool pIsCharged = false;

                                for (int i = 0; i < Seats.Length - 1; i++)
                                {
                                    if (Seats[i] == null)// om platsen i 'Seats' är ledig
                                    {
                                        Seats[i] = new Passager(pAge, pSex, pAge, pIsCharged);// den andra "pAge" är bara en platshållare, biljetpriset bestäms inom klassen passagerare utifrån åldern men constuctorn kräver att vi "skickar med" nånting
                                        antal_passagerare++;
                                        passThatGotOff--;// en variabel som behövs i flera metoder för att arrayn 'Seats' ska behålla rätt antal platser. Är inte alltid logisk men det är OK för funktionalitetens skull
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Felaktig inmatning! Försök igen!");
                                Console.ReadLine();
                            }
                            Console.WriteLine("Finns det fler passagerare på hållplatsen?: J/N");// om användaren anger 'ja' så startar loopen om igen och användaren kan lägga till ytterligare passagerare
                            try
                            {
                                string a = Console.ReadLine();
                                if (a == "J" || a == "j")
                                {
                                    s = false;
                                }
                                else
                                {
                                    s = true;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Felaktig inmatning! Försök igen!");
                                Console.ReadLine();
                            }
                        }

                        else
                        {
                            // om användaren matat in ett värde som överstiger antalet lediga platser på bussen
                            Console.WriteLine("Bussen är full! Du måste släppa av passagerare först innan du kan låta nya passagerare stiga på!");
                            break;
                        }
                    }
                }

                if (choice == 2)// underlättar för användaren när man ska lägga till flera passagerare, automatiserar processen och slumpar fram objekt i klassen passager
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("På bussen finns det 25 platser. Det finns för närvarande " + antal_passagerare + " passagerare på bussen!");
                        Console.WriteLine("Det betyder att det finns " + numOfSeatsFree + " lediga platser!");//för att visa användaren hur många som max kan stiga på
                        Console.WriteLine("Hur många passagerare står det vid hållplatsen och vill stiga på?: ");
                        try
                        {
                            int incomingP = Convert.ToInt32(Console.ReadLine());// användaren anger här antalet passagerare som stiger på bussen. variabeln nedanför ser till att användaren inte råkar ange ett antal som inte kommer få plats på bussen
                            int stressLimit = antal_passagerare + incomingP;                           
                            if (antal_passagerare > 25 || incomingP > 25 || stressLimit > 25)//olika kontrollstrukturer som ser till att bussen inte blir överfylld
                            {
                                Console.WriteLine("Det finns inte plats för alla!! Du kan bara ta ombord 25 passagerare totalt! tryck på ENTER...");
                                Console.ReadLine();
                                break;//har användaren tagit emot för många passagerare avbryts processen och användaren får börja om
                            }                            
                            else
                            {
                                if (passThatGotOff > 0)
                                {
                                    passThatGotOff = passThatGotOff - incomingP;// en variabel som används i flera metoder för att hålla reda på hur stor arrayn ska vara, mha av denna förblir arrayn alltid 25 platser
                                }

                                for (int i = 0; i < incomingP; i++)//loop som loopar samma antal iterationer som antalet passagerare som användaren angett stiger på bussen
                                {
                                    antal_passagerare += incomingP;
                                    Random rnd = new Random();
                                    int pAge = rnd.Next(1, 100);        //slumpar fram ålder och
                                    string[] sexes = new string[3];     //slumpa fram kön   på de framslumpade passagerarna
                                    sexes[0] = "Man";                  //
                                    sexes[1] = "Kvinna";                //
                                    sexes[2] = "Annan";                 //
                                    string pSex = sexes[rnd.Next(0, 3)];//
                                    bool pIsCharged = false;
                                    for (int j = 0; j < Seats.Length; j++)// ger dessa passagerare platser på bussen (Seats arrayn)
                                    {
                                        if (Seats[j] == null)
                                        {
                                            Seats[j] = new Passager(pAge, pSex, pAge, pIsCharged);
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }


                            }
                        }
                        catch
                        {
                            Console.WriteLine("Felaktig inmatning!");
                        }
                        break;
                    }

                }
            }
            catch
            {
                Console.WriteLine("Felaktig inmatning! Försök igen! Välj mellan [1] och [2]...");
                Console.WriteLine("Tryck ENTER för att komma tillbaka till menyval...");
                Console.ReadLine();
            }
        }
        public void getting_off()// släpper av passagerare
        {
            Console.Clear();
            Console.WriteLine("Välj mellan att släppa av en enskild passagerare och att släppa av alla passagerare!");// undermeny där användaren får tillgång till ett alternativ som tömmer bussen på passagerare för att underlätta den processen om man så vill
            Console.WriteLine("1. Släpp av en enskild passagerare");
            Console.WriteLine("2. Släpp av alla passagerarna");
            try
            {
                int purgeBusChoice = Convert.ToInt32(Console.ReadLine());
                if (purgeBusChoice == 1)
                {
                    try
                    {
                        Console.WriteLine("Vilken passagerare är det som stiger av bussen? Ange vilken plats passageraren satt på: ");
                        int seatNum = Convert.ToInt32(Console.ReadLine());
                        var pos = seatNum - 1;// minus 1 eftersom arrayn börjar på plats 0

                        while (true)
                        {
                            if (Seats[pos] == null)//för att förhindra felaktig inmatning
                            {
                                Console.WriteLine("Du kan inte välja en plats som redan är tom! välj en annan!");
                            }
                            else if (pos < 0 || pos >= Seats.Length)//för att förhindra felaktig inmatning
                            {
                                Console.WriteLine("Du måste välja en sittplats på bussen, välj mellan plats 1 och " + Seats.Length);
                            }
                            else
                            {
                                Console.WriteLine("Passageraren på " + seatNum + " har nu gått av bussen. Sittplatsen är nu tom!");
                                Seats[pos] = null;
                                antal_passagerare--;
                                passThatGotOff++;
                                Console.WriteLine("tryck enter för att fortsätta");
                                Console.ReadKey();
                                break;
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Felaktig inmatning! Försök igen!");
                        Console.WriteLine("Tryck ENTER för att komma åter till meny!");
                        Console.ReadLine();
                    }
                }
                else if (purgeBusChoice == 2)//låter användaren rensa bussen helt på passagerare, för att underlätta processen
                {
                    try
                    {
                        Console.WriteLine("Alla passagerarna stiger nu av! Bussen är snart helt tom!");                        
                        for (int i = 0; i < Seats.Length; i++)
                        {
                            if (Seats[i] == null)
                            {                                
                                continue;
                            }
                            else
                            {
                                passThatGotOff++; 
                            }
                        }
                        Array.Clear(Seats, 0, Seats.Length);
                        antal_passagerare = 0;

                    }
                    catch
                    {
                        Console.WriteLine("Felaktig inmatning! Tryck ENTER för att fortsätta...");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Okänd inmatning försök igen! tryck ENTER för att fortsätta");
            }
            
            
           
        }

        public double chargeAllPassagers()// tar betalt av passagerarna
        {
            List<Passager> chargePassagerList = TransformArray();//omvandlar arrayn till en lista mha av min metod för att göra just detta
            int occupiedSeats = SeatsTaken();//tar fram de platser som är tagna
            double sumOfTarifs = 0.0;
            for (int i = 0; i < occupiedSeats; i++)
            {
                if (chargePassagerList[i].isCharged == false)
                {
                    sumOfTarifs = sumOfTarifs + chargePassagerList[i].TicketPrice;
                    chargePassagerList[i].isCharged = true; // ändrar bool värdet så att vi inte tar betalt av samma passagerare fler än 1 gång
                }
            }
            TransformList(chargePassagerList);//lägger in listans värden i min ursprungliga 'Seats' array så att programmet har koll på vilka passagerare som har betalat och vilka som inte har betalat
            return sumOfTarifs;
        }

        public void Print()// undermeny för alla olika osrters utskrifter
        {
            string[] printMenuOptions = new string[] { "Skriv ut alla passagerare", "Skriv ut kön på passagerare", "Återgå till mainmeny" };
            int printMenuSelect = 0;

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                if (printMenuSelect == 0)
                {
                    Console.WriteLine("'Skriv ut' funktioner");
                    Console.WriteLine("*********************");
                    Console.WriteLine("* " + printMenuOptions[0] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");

                }
                else if (printMenuSelect == 1)
                {
                    Console.WriteLine("'Skriv ut' funktioner");
                    Console.WriteLine("*********************");
                    Console.WriteLine(printMenuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + printMenuOptions[1] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");


                }
                else if (printMenuSelect == 2)
                {
                    Console.WriteLine("'Skriv ut' funktioner");
                    Console.WriteLine("*********************");
                    Console.WriteLine(printMenuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + printMenuOptions[2] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                }



                var keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.DownArrow && printMenuSelect != printMenuOptions.Length - 1)
                {
                    printMenuSelect++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && printMenuSelect >= 1)
                {
                    printMenuSelect--;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    switch (printMenuSelect)
                    {
                        case 0:
                            print_buss();
                            break;
                        case 1:
                            print_sex();
                            break;
                        case 2:
                            Run();
                            break;
                    }
                }
            }
        }
        public void print_buss()// metod som skriver ut vilken passagerare som sitter på vilken plats.
        {
            Console.Clear();
            Console.WriteLine("Sittplatser i bussen:");
            Console.WriteLine("---------------------");
            int seatNumber = 0;
            foreach (Passager passager in Seats)
            {
                seatNumber++;
                if (passager == null)// för tomma platser
                {
                    Console.WriteLine("Plats " + seatNumber + ": Är tom!");
                }
                else// för platser som är "tagna" av passagerare, skriver ut objektet "passager" alla olika attribut dvs ålder, kön, och biljettpris
                {
                    Console.WriteLine("Plats " + seatNumber + ": " + passager.Sex + ",  " + passager.Age + " år gammal, Biljettpris :" + passager.TicketPrice + " kr.  Betalningsstatus: ");
                    if (passager.isCharged)
                    {
                        Console.WriteLine("Har betalat!\n--------");
                    }
                    else
                    {
                        Console.WriteLine("Har inte betalat!\n-------");
                    }

                }
            }

            Console.WriteLine("Tryck ENTER för att fortsätta!");
            Console.ReadLine();
        }

        public void print_sex()// metod för att skriva ut passagerarnas kön
        {
            int actualSeatNumber = 0;
            foreach (Passager passager in Seats)
            {
                actualSeatNumber++;
                if (passager != null)
                {
                    // en variabel för alla olika sorters kön.
                    string fSex = "Kvinna";
                    string mSex = "Man";
                    string oSex = "Annan";
                    Console.WriteLine("På sittplats " + actualSeatNumber + " så sitter det: ");
                    if (passager.Sex == mSex)
                    {
                        Console.WriteLine(">>> en man");
                    }
                    else if (passager.Sex == fSex)
                    {
                        Console.WriteLine(">>> en kvinna");
                    }
                    else if (passager.Sex == oSex)
                    {
                        Console.WriteLine(">>> en icke binär");
                    }
                }
                else
                {
                    Console.WriteLine("På sittplats " + actualSeatNumber + " så är sätet tomt");
                }
            }
            Console.WriteLine("tryck på ENTER för att fortsätta");
            Console.ReadLine();
        }

        public void Calculations()// undermeny för alla olika sorters beräkningar.
        {
            string[] subMenuOptions = new string[] { "Beräkna sammanlagd ålder", "Beräkna medelålder", "Hitta äldsta passagerare", "Sök passagerare efter ålder", "Sök efter passagerare mellan åldrar", "Återgå till main menu" };
            int subMenuSelect = 0;

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                if (subMenuSelect == 0)
                {
                    Console.WriteLine("Beräkningar:");
                    Console.WriteLine("*********************");
                    Console.WriteLine("* " + subMenuOptions[0] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[4]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[5]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (subMenuSelect == 1)
                {
                    Console.WriteLine("Beräkningar:");
                    Console.WriteLine("*********************");
                    Console.WriteLine(subMenuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + subMenuOptions[1] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[4]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[5]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (subMenuSelect == 2)
                {
                    Console.WriteLine("Beräkningar:");
                    Console.WriteLine("*********************");
                    Console.WriteLine(subMenuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + subMenuOptions[2] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[4]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[5]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (subMenuSelect == 3)
                {
                    Console.WriteLine("Beräkningar:");
                    Console.WriteLine("*********************");
                    Console.WriteLine(subMenuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + subMenuOptions[3] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[4]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[5]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (subMenuSelect == 4)
                {
                    Console.WriteLine("Beräkningar:");
                    Console.WriteLine("*********************");
                    Console.WriteLine(subMenuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + subMenuOptions[4] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[5]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (subMenuSelect == 5)
                {
                    Console.WriteLine("Beräkningar:");
                    Console.WriteLine("*********************");
                    Console.WriteLine(subMenuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(subMenuOptions[4]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + subMenuOptions[5] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                }
                var keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.DownArrow && subMenuSelect != subMenuOptions.Length - 1)
                {
                    subMenuSelect++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && subMenuSelect >= 1)
                {
                    subMenuSelect--;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    switch (subMenuSelect)
                    {
                        case 0:
                            int sumOfAge = calc_total_age();//metoden räknar ut och skickar tillbaka summan av allas åldrar
                            Console.WriteLine("Den totala åldern för alla på bussen är för närvarande: " + sumOfAge + " år!!");
                            Console.WriteLine("Tryck ENTER för att fortsätta!");
                            Console.ReadLine();
                            break;
                        case 1:                            
                            double avareageAge = calc_average_age();//metoden räknar ut och skickar tillbaka medelåldern i decimalform
                            Console.WriteLine("Den aktuella medelåldern av alla passagerare är: " + avareageAge + "!");
                            Console.WriteLine("Tryck ENTER för att fortsätta!");
                            Console.ReadLine();
                            break;
                        case 2:
                            max_age();//metoden tar fram passageraren/passagerarna med äldsta ålder
                            break;
                        case 3:
                            Console.WriteLine("Vilken ålder söker du efter?: ");
                            try
                            {
                                int findAge = Convert.ToInt32(Console.ReadLine());
                                find_age(findAge);//metoden tar fram passageraren med den ålder som efterfrågades
                            }
                            catch
                            {
                                Console.WriteLine("Felaktig inmatning! Försök igen!");
                            }

                            break;
                        case 4:
                            try
                            {
                                Console.WriteLine("Från vilken ålder vill du söka?");
                                int ageFrom = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Till vilken ålder vill du söka?");
                                int ageTo = Convert.ToInt32(Console.ReadLine());
                                findAgeSpan(ageFrom, ageTo);//metoden tar fram alla passagerare inom det åldersspann som användaren har angett
                            }
                            catch
                            {
                                Console.WriteLine("Felaktig inmatning! Försök igen!");
                            }
                            break;
                        case 5:
                            Run();
                            break;
                    }
                }
            }
        }
        public int calc_total_age()// metod för att lägga ihop alla åldrar till en sammanlagd summa år. 
        {

            int occupiedSeats = SeatsTaken();//tar fram de platser som är tagna
            List<Passager> totalAgeList = TransformArray();//omvandlar arrayn till lista
            sumOfAge = 0;
            for (int i = 0; i < occupiedSeats; i++)
            {
                sumOfAge += totalAgeList[i].Age;
            }
            return sumOfAge;
        }
        public double calc_average_age() //metod för att få fram medelålder som decimaltal
        {            
            double totalAge = calc_total_age();
            double numsOfPassagers = SeatsTaken();
            double avareageAge = totalAge / numsOfPassagers;

            return avareageAge;
        }

        public void max_age()   //hittar de passagerare som innehar högst ålder av alla passagerare   
        {
            List<Passager> maxAgeList = TransformArray();
            var maxVal = maxAgeList.Max(x => x.Age); // Tar reda på vilken ålder som är högst                   
            Console.WriteLine("Den äldsta passageraren är " + maxVal + " År gammal och \n");
            find_age(maxVal);//använder min find_age metod för att ta reda på vilken sittplats den äldsta passagearen sitter på
            Console.ReadKey();
        }

        public void find_age(int findAge)// plockar fram passagerare med den ålder användaren matar in som sökterm. Används i flera metoder
        {
            int keyAge = findAge;
            List<Passager> findAgeList = TransformArray();

            for (int i = 0; i < findAgeList.Count; i++)
            {
                if (findAgeList[i].Age == keyAge)
                {
                    int actualSeatnum = i + 1;
                    Console.WriteLine("Passagerare med åldern du söker efter finns på plats: " + actualSeatnum);
                }

            }
            Console.WriteLine("Hoppas att vi hittade den passageraren du sökte efter. Om inte så testa att söka på en annan ålder!");
            Console.WriteLine("Tryck ENTER för att fortsätta...");
            Console.ReadKey();
        }
        public void findAgeSpan(int ageFrom, int ageTo)//plockar fram passagerare med ålder mellan ett användar inmatat ålderspann.
        {
            List<Passager> findAgeList = TransformArray();
            Console.WriteLine("Passagerare mellan åldrarna " + ageFrom + " till " + ageTo + " sitter på platserna: ");
            for (int i = 0; i < findAgeList.Count; i++)
            {
                if (findAgeList[i].Age < ageTo && findAgeList[i].Age > ageFrom)
                {
                    int actualSeatnum = i + 1;
                    Console.WriteLine("Passagerarna med åldern du söker sitter på plats: " + actualSeatnum + " och är " + findAgeList[i].Age + " år gammal");

                }
            }
            Console.WriteLine("Tryck ENTER för att fortsätta...");
            Console.ReadKey();
        }
        public void sortingMenu()//undermeny för alla olika sorters sorteringsalternativ
        {
            string[] printMenuOptions = new string[] { "Sortera passagerare efter ålder", "Sortera passagerare efter kön", "Återgå till mainmeny" };
            int printMenuSelect = 0;

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                if (printMenuSelect == 0)
                {
                    Console.WriteLine("Sorterings funktioner");
                    Console.WriteLine("*********************");
                    Console.WriteLine("* " + printMenuOptions[0] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");


                }
                else if (printMenuSelect == 1)
                {
                    Console.WriteLine("Sorterings funktioner");
                    Console.WriteLine("*********************");
                    Console.WriteLine(printMenuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + printMenuOptions[1] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");



                }
                else if (printMenuSelect == 2)
                {
                    Console.WriteLine("Sorterings funktioner");
                    Console.WriteLine("*********************");
                    Console.WriteLine(printMenuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(printMenuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + printMenuOptions[2] + " *");
                    Console.WriteLine("- - - - - - - - - - -");

                }



                var keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.DownArrow && printMenuSelect != printMenuOptions.Length - 1)
                {
                    printMenuSelect++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && printMenuSelect >= 1)
                {
                    printMenuSelect--;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    switch (printMenuSelect)
                    {
                        case 0:
                            sort_buss();//metoden sorterar bussen efter ålder
                            break;
                        case 1:
                            Sorting();//metoden sorterar bussen efter kön
                            break;
                        case 2:
                            Run();
                            break;
                    }
                }
            }
        }
        public void sort_buss()//sorterar passagerarna på bussen efter ålder mha bubblesort algoritm
        {
            List<Passager> myListAge = new List<Passager>(25); // en temporär lista, för att lista är enklare att hantera när det kommer till att tex sortera

            foreach (Passager passager in Seats)
            {
                if (passager == null)//hoppar över de tomma platserna
                {
                    continue;
                }
                else
                {
                    myListAge.Add(passager);//lägger in alla element från arrayn till listan

                }
            }
            Console.WriteLine("Passagerarnas åldrar sorterade från yngst till äldst!\n");
            //enligt bubblesort exempel i läroboken sid 166
            int max = myListAge.Count - 1;
            for (int i = 0; i < max; i++)
            {
                int nrLeft = max - i;
                for (int j = 0; j < nrLeft; j++)
                {
                    if (myListAge[j].Age > myListAge[j + 1].Age)
                    {
                        var temp = myListAge[j].Age;
                        myListAge[j].Age = myListAge[j + 1].Age;
                        myListAge[j + 1].Age = temp;
                    }
                    else if (myListAge[j].Age == null)
                    {
                        Console.WriteLine("Tom plats");

                    }
                }
            }
            for (int i = 0; i < myListAge.Count; i++)// skriver ut passagerarnas åldrar sorterat
            {
                int placeHolder = i + 1;
                Console.WriteLine("nr " + placeHolder + " har ålder: " + myListAge[i].Age);
            }
            Console.ReadKey();
            TransformList(myListAge);//metoden tar listan och gör om den tillbaka till 'Seats' arrayn
        }

        public void Sorting()//sorterar passagerarna efter kön
        {

            List<Passager> myList = new List<Passager>(25); // en temporär lista, för att lista är enklare att hantera när det kommer till att tex sortera

            foreach (Passager passager in Seats)
            {
                if (passager == null)//hoppar över de tomma platserna
                {
                    continue;
                }
                else
                {
                    myList.Add(passager);//lägger in alla element från arrayn till listan

                }
            }

            myList.Sort((x, y) => x.Sex.CompareTo(y.Sex));//sorterar listan

            Array.Clear(Seats, 0, Seats.Length);//rensar arrayn, behövs för att kunna lägga in den sorterade listan

            for (int i = 0; i < myList.Count; i++)
            {
                int placeHolder = i + 1;
                Console.WriteLine("nr " + placeHolder + " har ålder: " + myList[i].Sex);
            }
            Console.ReadLine();
            TransformList(myList);//metoden tar listan som skapats och gör om den tillbaka till 'Seats' arrayn
        }

        public void sortBussSex()// sorterar efter kön enligt en LINQ metod jag hittade online på https://www.tutorialsteacher.com/ fungerar dock bara när bussen är full
        {                       //FUNGERAR EJ TA BORT!!
            

            int max = Seats.Length - 1;
            for (int i = 0; i < max; i++)
            {
                int nrLeft = max - i;
                for (int j = 0; j < nrLeft; j++)
                {
                    if (Seats[j].Age > Seats[j + 1].Age)
                    {
                        var temp = Seats[j].Age;
                        Seats[j].Age = Seats[j + 1].Age;
                        Seats[j + 1].Age = temp;
                    }
                    else if (Seats[j].Age == null)
                    {
                        Console.WriteLine("Tom plats");

                    }
                }
            }
            for (int i = 0; i < Seats.Length; i++)// skriver ut passagerarnas åldrar sorterat
            {
                int placeHolder = i + 1;
                Console.WriteLine("nr " + placeHolder + " har ålder: " + Seats[i].Age);
            }


            Console.WriteLine("Tryck på ENTER för att fortsätta");
            Console.ReadKey();

        }
        public void poke()
        {
            while (true)
            {
                Console.WriteLine("Här kan vi skoja lite med passagerarna! Välj mellan: \n");//undermeny för val som rör att peta på passagerarna
                Console.WriteLine("[S]e en lista över bussen");// för att lättare påminna användaren vilka passagerare som sitter var
                Console.WriteLine("[P]eta på en av passagerarna");
                Console.WriteLine("[Å]tergå till main meny");
                string initialChoice = Console.ReadLine();
                try
                {
                    if (initialChoice == "S" || initialChoice == "s")
                    {
                        print_buss();//skriver ut hela bussen
                    }
                    else if (initialChoice == "P" || initialChoice == "p")
                    {
                        Console.WriteLine("Välj en passagerare att peta på och se vad som händer!!");
                        Console.WriteLine("Välj en sittplats där det sitter en passagerare, välj mellan 1-25");
                        try
                        {
                            int pokeChoice = Convert.ToInt32(Console.ReadLine());// den plats som användaren anger här, den passagerarn som finns på den platsen hämtas och dess kön och ålder används för att hitta rätt reaktioner
                            if (pokeChoice > 0 && pokeChoice <= 25)
                            {
                                switch (pokeChoice)
                                {

                                    case 1:
                                        ReactionWhenPokedAt(Seats[0]);
                                        break;
                                    case 2:
                                        ReactionWhenPokedAt(Seats[1]);
                                        break;
                                    case 3:
                                        ReactionWhenPokedAt(Seats[2]);
                                        break;
                                    case 4:
                                        ReactionWhenPokedAt(Seats[3]);
                                        break;
                                    case 5:
                                        ReactionWhenPokedAt(Seats[4]);
                                        break;
                                    case 6:
                                        ReactionWhenPokedAt(Seats[5]);
                                        break;
                                    case 7:
                                        ReactionWhenPokedAt(Seats[6]);
                                        break;
                                    case 8:
                                        ReactionWhenPokedAt(Seats[7]);
                                        break;
                                    case 9:
                                        ReactionWhenPokedAt(Seats[8]);
                                        break;
                                    case 10:
                                        ReactionWhenPokedAt(Seats[9]);
                                        break;
                                    case 11:
                                        ReactionWhenPokedAt(Seats[10]);
                                        break;
                                    case 12:
                                        ReactionWhenPokedAt(Seats[11]);
                                        break;
                                    case 13:
                                        ReactionWhenPokedAt(Seats[12]);
                                        break;
                                    case 14:
                                        ReactionWhenPokedAt(Seats[13]);
                                        break;
                                    case 15:
                                        ReactionWhenPokedAt(Seats[14]);
                                        break;
                                    case 16:
                                        ReactionWhenPokedAt(Seats[15]);
                                        break;
                                    case 17:
                                        ReactionWhenPokedAt(Seats[16]);
                                        break;
                                    case 18:
                                        ReactionWhenPokedAt(Seats[17]);
                                        break;
                                    case 19:
                                        ReactionWhenPokedAt(Seats[18]);
                                        break;
                                    case 20:
                                        ReactionWhenPokedAt(Seats[19]);
                                        break;
                                    case 21:
                                        ReactionWhenPokedAt(Seats[20]);
                                        break;
                                    case 22:
                                        ReactionWhenPokedAt(Seats[21]);
                                        break;
                                    case 23:
                                        ReactionWhenPokedAt(Seats[22]);
                                        break;
                                    case 24:
                                        ReactionWhenPokedAt(Seats[23]);
                                        break;
                                    case 25:
                                        ReactionWhenPokedAt(Seats[24]);
                                        break;                                   
                                }
                            }
                            else
                            {
                                Console.WriteLine("Felaktig inmatning! Försök igen! Ange nummer 1-25! Eller se listan över tillgängliga passagerare!");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Felaktig inmatning! Var så snäll och ange en plats på bussen där det sitter en passagerare!");
                        }
                    }
                    else if (initialChoice == "Å" || initialChoice == "å")// för att bryta loopen och återkomma till main menyn
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Felaktig inmatning! Försök igen!");
                    }
                }
                catch
                {
                    Console.WriteLine("Felaktig inmatning, Försök igen! Ange S för lista och P för att peta!");
                }                
            }
        }

        public void ReactionWhenPokedAt(Passager passager)//Metod för rektionerna när passagerarna blir petade på. 
        {

            if (passager.Age > 50 && passager.Sex == "Man")
            {
                Console.WriteLine("Passageraren ställer sig upp och sjunger en kärleksballad!");

                if (passager.isCharged == false)
                {
                    Console.WriteLine("Betalar sedan sin biljett!");
                    passager.isCharged = true;
                }
                pokeCount++;
            }
            else if (passager.Age > 20 && passager.Age < 50 && passager.Sex == "Man")
            {
                Console.WriteLine("Passageraren petar tillbaka ganska hårt och tittar sedan ut genom fönstret medans en tår sakta rinner längs kinden");
                if (passager.isCharged == false)
                {
                    Console.WriteLine("Betalar sedan sin biljett!");
                    passager.isCharged = true;
                }
                pokeCount++;
            }
            else if (passager.Age > 50 && passager.Sex == "Kvinna")
            {
                Console.WriteLine("Passageraren tar fram plånboken och ger dig en tjugo och ber dig att köpa dig ett liv");
                if (passager.isCharged == false)
                {
                    Console.WriteLine("Betalar sedan sin biljett!");
                    passager.isCharged = true;
                }
                pokeCount++;
            }
            else if (passager.Age > 20 && passager.Age < 50 && passager.Sex == "Kvinna")
            {
                Console.WriteLine("Passageraren börjar gråta och ropa efter hjälp från de andra passagerarna som dock gör sitt bästa för att titta åt ett annat håll");
                if (passager.isCharged == false)
                {
                    Console.WriteLine("Betalar sedan sin biljett!");
                    passager.isCharged = true;
                }
                pokeCount++;
            }
            else if (passager.Age > 50 && passager.Sex == "Annan")
            {
                Console.WriteLine("Passageraren tar av sig sina skor och låter dig lukta på dem");
                if (passager.isCharged == false)
                {
                    Console.WriteLine("Betalar sedan sin biljett!");
                    passager.isCharged = true;
                }
                pokeCount++;
            }
            else if (passager.Age > 20 && passager.Age < 50 && passager.Sex == "annan")
            {
                Console.WriteLine("En svärm av arga bin flyger in genom ett öppet fönster och attackerar dina fotsulor");
                if (passager.isCharged == false)
                {
                    Console.WriteLine("Betalar sedan sin biljett!");
                    passager.isCharged = true;
                }
                pokeCount++;
            }
            else if (pokeCount >= 3)// passagerarna har en gräns för hur många gånger de låter användaren peta på dem
            {
                Console.Clear();
                Console.WriteLine("Passageraren ringer polisen som anländer väldigt snabbt och för bort dig till fängelset där du ruttnar bort tills du dör!");
                Console.ReadLine();
                Environment.Exit(3);
            }
            else
            {
                Console.WriteLine("Ingenting händer");
                if (passager.isCharged == false)
                {
                    Console.WriteLine("Betalar sedan sin biljett!");
                    passager.isCharged = true;
                }
                pokeCount++;

            }
        }

        public static void Terminate()
        {
            Console.WriteLine("Programmet avslutas! Hejdå!");
            Console.ReadKey();
            Environment.Exit(1);
        }




        public int SeatsTaken()// metod för att plocka fram de platser som är tagna
        {
            List<Passager> seatList = TransformArray();
            int seatNumber = 0;
            int seatTaken = 0;
            foreach (Passager passager in seatList)
            {

                if (passager == null)
                {
                    continue;
                }
                else
                {
                    seatNumber++;
                    seatTaken++;
                }
            }
            return seatTaken;
        }




        public List<Passager> TransformArray()// för att omvandla array till lista
        {
            List<Passager> myList = new List<Passager>(25);
            foreach (Passager passager in Seats)
            {
                if (passager == null)//hoppar över de tomma platserna
                {
                    continue;
                }
                else
                {
                    myList.Add(passager);//lägger in alla element från arrayn till listan

                }
            }

            return myList;
        }
        public Array TransformList(List<Passager> list)//en metod för att omvandla tillbaka lista till array för de tillfällen i koden som jag har behövt omvandla arrayn till en lista
        {
            Array.Clear(Seats, 0, Seats.Length);
            Seats = list.ToArray();//omvandlar listan tillbaka till arrayn
            Array.Resize(ref Seats, Seats.Length + passThatGotOff);

            return Seats;
        }

        public void Garage()//metod som håller undermeny för garaget
        {
            Console.Clear();
            Console.WriteLine("******Garaget******");
            Console.WriteLine("Du har nu svängt in till garaget! Här kan du modifiera bussen!");
            Console.WriteLine("Välj mellan: ");
            Console.WriteLine("-[B]yt färg på bussen -- 500kr");
            Console.WriteLine("-[T]rimma bussen      -- 500 - 1700kr");            
            Console.WriteLine("-[M]intade rutor      -- 600kr");
            Console.WriteLine("-[C]ustom tuta        -- 800kr\n");
            Console.WriteLine("Du har i kassan: " + sumOfAllTarfis + " kr");
            try
            {
                string garageChoice = Console.ReadLine();
                if (garageChoice == "B" || garageChoice == "b")//byter färg på bussen
                {
                    Console.Clear();
                    Console.WriteLine("Bussen är nu " + defaultColour + " ! Vilken färg vill du byta till?\n Välj mellan [B]lå, [V]it, [O]range, [S]vart ");
                    try
                    {
                        string colourChoice = Console.ReadLine();
                        if (colourChoice == "B" || colourChoice == "b")
                        {
                            Console.WriteLine("SCCHHHHMMNNNNOOO ORRP ORRP ORRP!! Bussen är nu skinande blå!");
                            sumOfAllTarfis -= 500;
                            colourChoice = "Blå";
                            defaultColour = colourChoice;
                            Console.ReadLine();
                        }
                        else if (colourChoice == "V" || colourChoice == "v")
                        {
                            Console.WriteLine("SCCHHHHMMNNNNOOO ORRP ORRP ORRP!! Bussen är nu skinande vit!");
                            sumOfAllTarfis -= 500;
                            colourChoice = "Vit";
                            defaultColour = colourChoice;
                            Console.ReadLine();
                        }
                        else if (colourChoice == "O" || colourChoice == "o")
                        {
                            Console.WriteLine("SCCHHHHMMNNNNOOO ORRP ORRP ORRP!! Bussen är nu skinande orange!");
                            sumOfAllTarfis -= 500;
                            colourChoice = "Orange";
                            defaultColour = colourChoice;
                            Console.ReadLine();
                        }
                        else if (colourChoice == "S" || colourChoice == "s")
                        {
                            Console.WriteLine("SCCHHHHMMNNNNOOO ORRP ORRP ORRP!! Bussen är nu skinande svart!");
                            sumOfAllTarfis -= 500;
                            colourChoice = "Svart";
                            defaultColour = colourChoice;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Okänd inmatning! Försök igen!");
                            Console.ReadLine();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Felaktig inmating! Tryck ENTER för att åter komma till meny...");
                        Console.ReadLine();
                    }

                }
                if (garageChoice == "T" || garageChoice == "t")//trimmar bussen
                {
                    Console.WriteLine("Välj hur många HP du vill trimma bussen med. Den har för närvarande " + defaultHP + " HP!");
                    Console.WriteLine("Välj mellan: ");
                    Console.WriteLine("1. 500HP  -- 500kr");
                    Console.WriteLine("2. 1000HP  -- 1700kr");
                    try
                    {
                        int hpChoice = Convert.ToInt32(Console.ReadLine());
                        if (hpChoice == 1)
                        {
                            Console.WriteLine("SCCHHHHMMNNNNOOO ORRP ORRP ORRP PLINK PLINK PLINK TCHOGA TCHOGGA CHYYYP CHYYYP!!!!");
                            defaultHP += 500;
                            Console.WriteLine("Sådär, då har vi lagt till 500 HP till motorn! Den har nu totalt " + defaultHP + " HP!");
                            sumOfAllTarfis -= 500;
                            Console.ReadLine();
                        }
                        else if (hpChoice == 2)
                        {
                            Console.WriteLine("SCCHHHHMMNNNNOOO ORRP ORRP ORRP PLINK PLINK PLINK TCHOGA TCHOGGA CHYYYP CHYYYP!!!!");
                            defaultHP += 1000;
                            Console.WriteLine("Sådär, då har vi lagt till 500 HP till motorn! Den har nu totalt " + defaultHP + " HP!");
                            sumOfAllTarfis -= 1700;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Felaktig inmatning!");
                            Console.ReadLine();
                        }

                    } catch
                    {
                        Console.WriteLine("Felaktig inmatning! Tryck på ENTER!");
                        Console.ReadLine();
                    }
                }
                if (garageChoice == "M" || garageChoice == "m")//mörkar fönstren på bussen
                {
                    try
                    {
                        Console.WriteLine("SCCHHHHMMNNNNOOO ORRP ORRP ORRP PLINK PLINK");
                        defaultTint = true;
                        Console.WriteLine("Du har nu tintade fönster! Ingen kan nu se dig genom fönstrena!");
                        sumOfAllTarfis -= 600;
                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("Felaktig inmatning! Tryck på ENTER!");
                        Console.ReadLine();
                    }
                }
                if (garageChoice == "C" || garageChoice == "c")//ändrar tutan på bussen
                {
                    try
                    {
                        Console.WriteLine("Vilken tuta vill du ha?");
                        Console.WriteLine("1. Rockabilly rebell");
                        Console.WriteLine("2. Du gamla du fria");
                        Console.WriteLine("3. Popcorn låten");
                        int hornCoiche = Convert.ToInt32(Console.ReadLine());
                        if (hornCoiche == 1)
                        {
                            Console.WriteLine("SCCHHHHMMNNNNOOO ORRP ORRP ORRP PLINK PLINK");
                            Console.WriteLine(" Din tuta spelar nu 'Rockabilly rebell'");
                            sumOfAllTarfis -= 600;
                            defaultHorn = "'Rockabilly rebell'";
                            Console.ReadLine();
                        }
                        else if (hornCoiche == 2) 
                        {
                            Console.WriteLine("SCCHHHHMMNNNNOOO ORRP ORRP ORRP PLINK PLINK");
                            Console.WriteLine(" Din tuta spelar nu 'Du gamla du fria'");
                            sumOfAllTarfis -= 600;
                            defaultHorn = "'Du gamla du fria'";
                            Console.ReadLine();
                        }
                        else if (hornCoiche == 3)
                        {
                            Console.WriteLine("SCCHHHHMMNNNNOOO ORRP ORRP ORRP PLINK PLINK");
                            Console.WriteLine(" Din tuta spelar nu 'Popcorn låten'");
                            sumOfAllTarfis -= 600;
                            defaultHorn = "'Popcorn låten'";
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Felaktig inmatning! tryck enter för att försöka igen!");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Felaktig inmatning! Tryck enter pls...");
                    }
                }

            }
            catch
            {
                Console.WriteLine("Felaktig inmatning! Tryck ENTER för att fortsätta...!");
                Console.ReadLine();
            }
           

        }

    }
}
 
