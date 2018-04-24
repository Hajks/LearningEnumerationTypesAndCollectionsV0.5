using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEnumerationTypesAndCollectionsV0._5
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new List<Shoe>();

            shoeCloset.Add(new Shoe()
            {
                Style = Style.Sneakers,
                Color = "Czarny"});

            shoeCloset.Add(new Shoe()
            {
                Style = Style.Clogs,
                Color = "Brązowy"});

            shoeCloset.Add(new Shoe()
            {
                Style = Style.Wingtips,
                Color = "Czarny"});

            shoeCloset.Add(new Shoe()
            {
                Style = Style.Loafers,
                Color = "Biały"
            });

            shoeCloset.Add(new Shoe()
            {
                Style = Style.Loafers,
                Color = "Czerwony"
            });

            shoeCloset.Add(new Shoe()
            {
                Style = Style.Wingtips,
                Color = "Czarny"
            });

            int numberOfShoes = shoeCloset.Count; //It gonna contains six pair of shoes.
            foreach (Shoe shoe in shoeCloset) //foreach is loop which is executed(?) for same types (does it make sense?). Anyway i mean that foreach is doing method for all included in loop types. I guess im too sleepy.
            {
                shoe.Style = Style.Flipflops;
                shoe.Color = "Pomarańczowy";
            }

            shoeCloset.RemoveAt(4); //It removes the given index

            Shoe thirdShoe = shoeCloset[2]; // creating 2 references to our shoeCloset indexes.
            Shoe secondShoe = shoeCloset[1];
            shoeCloset.Clear(); // We clear our list totally.

            shoeCloset.Add(thirdShoe); // We just add thirdShoe to list.
            Console.WriteLine(numberOfShoes.ToString());
            if (shoeCloset.Contains(secondShoe))
                Console.WriteLine("Wow, cud się wydarzył!");

            List<Shoe> shoeCloset2 = new List<Shoe>(); //It's same list like above, but initialized in other way. Well it's a lot easier to read in this way.
            new Shoe() { Style = Style.Sneakers, Color = "Czarny" };
            new Shoe() { Style = Style.Clogs, Color = "Brązowy" };
            new Shoe() { Style = Style.Wingtips, Color = "Biały" };
            new Shoe() { Style = Style.Loafers, Color = "Czerwony" };
            new Shoe() { Style = Style.Loafers, Color = "Zielony" };
            new Shoe() { Style = Style.Sneakers, Color = "Niebieski" };


        }
    }
}
