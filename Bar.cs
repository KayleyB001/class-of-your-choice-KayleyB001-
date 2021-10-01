using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Class
{

    public class Bar
    {
        public List<Drink> DrinkList;
        
        
        public Bar()
        {
            DrinkList = new List<Drink>();
            
        }

        public Bar(List<Drink> _drinkList)
        {
            DrinkList = _drinkList;
        }

        public void AddDrink(Drink drink)
        {

            DrinkList.Add(drink);


        }



        public Drink DrinkMenu()
        {   
            Console.Clear();
            int index = 1;
            Console.WriteLine("Enter 1 to go back to Main Menu");
            foreach (var Drink in DrinkList)
            {
 
                
                Console.WriteLine($"\n{index}.Drink: {Drink._DrinkName} \nFirst mix: {Drink._firstDrink} \nSecond mix: {Drink._secondDrink } \nThird mix: {Drink._thirdDrink} \nGarnish: {Drink._garnish}");
                index++;

                
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return DrinkList[choice - 1];
            

        }



    }










}
