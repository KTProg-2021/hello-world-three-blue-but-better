using System;
using System.Collections.Generic;
using System.Text;

namespace textBasedGame
{
    class Item
    {
        private string _storage;
        private bool _conditions;

        Item name = new Item("name", true);
        parentObject.addItem(name);

        Item Mop = new Item("mop", true);
                CleaningCloset.addItem(Mop);

        Item Rag = new Item(“Rag", true); 
        CleaningCloset.addItem(Rag);

                Item ToiletPaper = new Item("Toilet Paper", true);
                CleaningCloset.addItem(ToiletPaper);

        Item Bucket = new Item("Bucket", true);
                CleaningCloset.addItem(Bucket);

        Item Napkins = new Item("Napkins", true);
                FoodSupplies.addItem(Napkins);

            
        Item ToiletPaper = new Item("Toilet Paper", true);
                CleaningCloset.addItem(ToiletPaper);

        Item Bucket = new Item("Bucket", true);
                CleaningCloset.addItem(Bucket);

        Item Napkins = new Item("Napkins", true);
                FoodSupplies.addItem(Napkins);

        Item Condiments = new Item("Condiments", true);
        FoodSupplements.addItem(Condiments);


        public Item(string Storage) 
        {
            _storage = Storage;
        }

        

    }
}
