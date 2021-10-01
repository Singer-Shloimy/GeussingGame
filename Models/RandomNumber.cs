using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace GeussingGame.Models
{
    
    public  class RandomNumbers
    {
        public int guess { get; set; }
        public static int Timers;
        int randomNumber = new Random().Next(1, 5);
        private static int AmountGuessed = 0;

        public static string Timer()
        {
            DateTime DataTimes = new DateTime();
         
          while(Timers < 100)
            {
                
                DataTimes = DateTime.Now;
                Timers++;
            }
            return DataTimes.ToLongTimeString();
        }
       
        //public string DateTimeNow()
        //{
        //    //var dateTime =  DateTime.Now.Second < 10 ? "0" + DateTime.Now.ToString() : DateTime.Now.ToString();
        //    //min.InnerHtml = DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString();
        //    //sec.InnerHtml = DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString();
        //    //var dateTime = DateTime.UtcNow.ToShortDateString();
          
        //    string currenttime = DateTime.Now.ToLongTimeString();
        //    var dateTime =  currenttime;
        //    return dateTime.ToString();
        //}
        public int Rand()
        {
            int CurrentNumber = randomNumber;
            return CurrentNumber;
        }
        public  string Random()
        {
            //int randomNumber = new Random().Next(1, 100);
            int GGuess = guess;
          
           
            string WowYouGuessedIt = "You Won!";
            string YouDidntGuessIt = "Oy vay!";
            if (randomNumber == GGuess)
            {
                if (AmountGuessed == 5)
                {
                    AmountGuessed = 0;
                    return WowYouGuessedIt;
                }
                else
                {
                    return Convert.ToString(AmountGuessed += 1);
                }
               
            }
            else
            {

                return AmountGuessed.ToString();
            }
        }
     


    }
     
}
