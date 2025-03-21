namespace CopilotExamples;

public class NinetyNineBottlesOfJava
{
   public void BeerSong()    
   {
      int beerNum = 99;
      string word = "bottles";
     
      while (beerNum > 0)
      {
         Console.WriteLine($"{beerNum} {word} of beer on the wall");
         Console.WriteLine($"{beerNum} {word} of beer.");
         Console.WriteLine("Take one down.");
         Console.WriteLine("Pass it around.");
         beerNum = beerNum - 1;
                            
         if (beerNum == 1)
         {
            word = "bottle";  // singular, as in ONE bottle.
         }                        
     
         if (beerNum > 0)
         {
            Console.WriteLine($"{beerNum} {word} of beer on the wall");
         }
         else
         {
            Console.WriteLine("No more bottles of beer on the wall");
         }  // end else
      } // end while loop
   }  // end main method
}

/*
public class BeerSong {
   public static void main (String[] args) {
   int beerNum = 99;
   String word = "bottles";
     
   while (beerNum > 0) {
    
     
    
   System.out.println(beerNum + " " + word + " of beer on the wall");
   System.out.println(beerNum + " " + word + " of beer.");
   System.out.println("Take one down.");
   System.out.println("Pass it around.");
   beerNum = beerNum - 1;
                            
   if (beerNum == 1) {
   word = "bottle";  // singular, as in ONE bottle.
   }                        
     
   if (beerNum > 0) {
   System.out.println(beerNum + " " + word + " of beer on the wall");
   } else {
   System.out.println("No more bottles of beer on the wall");
   }  // end else
   } // end while loop
   }  // end main method
   }  // end class
*/