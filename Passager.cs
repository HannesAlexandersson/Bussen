using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussen

{
    public class Passager
    {
        private int age;
        private string sex;
        private double ticketPrice;
        public bool isCharged;

        public Passager(int aAge, string aSex, double aTicketPrice, bool aIsCharged)//Constructor för objekten 'passagers'
        {
            Age = aAge;
            Sex = aSex;
            TicketPrice = GetPrice(aAge);//för att anskaffa rätt biljetpris behöver vi skicka med det inmatade värdet för ålder
            isCharged= aIsCharged;//ändras i bussklassen om användaren väljer att ta betalt av passagerarna
        }
        public string Sex
        {
            get { return sex; }
            set//settern för sex attributet bestämmer vad som är godtagbar inmatning för parametern kön
            {
                if (value == "Man" || value == "man" || value == "Kvinna" || value == "kvinna" || value == "Annan" || value == "annan")
                {
                    sex = value;
                }
                else
                {
                    sex = "Ingen korrekt inmatning identifierad!";
                }
            }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }//settern för åldern är vad användaren anger, jag kan inte gärna sätta begränsingar för vilken ålder man får lov att ha
        }
        public double TicketPrice
        {
            get { return ticketPrice; }
            set { GetPrice(age); }//settern för biljetprisparametern bestäms i metoden för att anskaffa rättbiljetpris, den bestäms utifrån åldern
        }
        public double GetPrice(int age)//metod för att beräkna biljettpris för passagerare utifrån ålder
        {
            if (age > 60 || age < 20)//Rabattpris för äldre och ungdomar
            {
                ticketPrice = 20.0;
            }
            else
            {
                ticketPrice = 35.5;//Fullpris för alla andra
            }
            return ticketPrice;
        }
        

    }
}
