 using System;
 
 class Fraction{

            private int _top;
            private int _bottom;

            public Fraction(){
               _top= 1;
               _bottom= 1;

            }
            public Fraction(int number){
               _top=number;
               _bottom=1;
               
            }
             public Fraction(int numberTop, int numberBottom){
               _top=numberTop;
               _bottom=numberBottom;
            }

            public string GetFractionString{
               get{

               return $"{_top}/{_bottom}";
               }         
               
            }

           public double GetDecimalValue()
           {
                  return (double)_top / (double)_bottom;
           }




 }