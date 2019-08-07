using System;
using System.Collections.Generic;


namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {

        // RandomArray();
        // TossCoin();
        Names();
        }

        public static void RandomArray(){
            Random rand = new Random();
            int[] numbers = new int[10];

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (rand.Next(5,26));
            }


            int max = numbers[0];
            int sum = numbers[0]; 
            int min = numbers[0]; 
            double avg = 0; 

            for (int i=0; i<numbers.Length; i++){
                if(numbers[i]>max)
                    max=numbers[i];
            }

            for (int i=0; i<numbers.Length; i++){
                if(numbers[i]<min)
                    min=numbers[i];
            }
        
            for (int i=0; i<numbers.Length; i++){
                sum += numbers[i];
            }

            avg = sum/numbers.Length;

            System.Console.WriteLine(min);
            System.Console.WriteLine(max);
            System.Console.WriteLine(avg);

            foreach(var item in numbers){
                System.Console.WriteLine(item);
            }

        }

        public static int TossCoin() {

            System.Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();

            int heads = 2;
            int tails = 1;

            if (rand.Next(1,3) == 1){
            System.Console.WriteLine("Tails");
            
            return tails;
            }

            else{
                System.Console.WriteLine("Heads");

            return heads;
            }
        }



        public static void Names() {
            Random rand = new Random();

            List<string> name = new List<string>();

            name.Add("Todd");
            name.Add("Tiffany");
            name.Add("Charlie");
            name.Add("Sydney");
            name.Add("Geneva");

            List<string> randname = new List<string>();

            for (int i=name.Count; i>0; i--){
                int num = rand.Next(0,name.Count);
                
                if (name[num].Length>5){
                    
                randname.Add(name[num]);
                }
                name.Remove(name[num]);
            }
                foreach(var item in randname){
                System.Console.WriteLine(item);
                }
        }





        
        

















    }
}
