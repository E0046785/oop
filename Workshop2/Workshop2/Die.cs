using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.RV.LIB;

namespace Workshop2
{
    class Die
    {
        private int faceUp;


        public void Throw()
        {
            faceUp = ISSMath.RNDInt(6) + 1;
        }
        public  Die()
        {
            Throw();
        }
        public int GetFaceUp()
        {
            return faceUp;
        }
        
        public string StrFaceUp
        {

         get{
             string sideValue = "";
            if(GetFaceUp() == 1)
               sideValue = "Side1";
             else if(GetFaceUp() == 2)
                sideValue = "Side2";
            else if (GetFaceUp() ==3)
                sideValue = "Side3";
            else if(GetFaceUp() ==4)
                sideValue = "Side4";
            else if(GetFaceUp() ==5)
                sideValue = "Side5";
             else if(GetFaceUp() ==6)
                sideValue = "Side6";
            return sideValue;
            
          }
        }


    }
    public class DieApp
    {
        public static void Main(string[] args)
        {
           
           
           
                Die die1 = new Die();
                die1.Throw();
                Console.WriteLine("Die1::{0}",die1.StrFaceUp);

                Die die2 = new Die();
                die2.Throw();
                Console.WriteLine("Die1::{0}", die2.StrFaceUp);
           
        }
    }
}
