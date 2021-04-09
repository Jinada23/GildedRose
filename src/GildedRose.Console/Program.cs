using GildedRose.Console.Factories;
using GildedRose.Console.Models.Items;
using System.Collections.Generic;

namespace GildedRose.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");
            ItemStore itemStore = new ItemStore();
            ItemFactory itemFactory = new ItemFactory();

            itemStore.Add(itemFactory.CreateCommonItem("+5 Dexterity Vest", 10, 20));
            itemStore.Add(itemFactory.CreateFoodItem("Aged Brie", 2, 0));
            itemStore.Add(itemFactory.CreateCommonItem("Elixir of the Mongoose", 5, 7));

            var itemList = new List<ExtendedItem>
            {
                itemFactory.CreateLegendaryItem("Sulfuras, Hand of Ragnaros", 0, 80),
                itemFactory.CreateBackstageItem("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                itemFactory.CreateConjuredItem("Conjured Mana Cake", 3, 6)
            };
            itemStore.Add(itemList);

            for(int i = 0; i < 20; i++)
            {
                System.Console.WriteLine($"============ DAY{i+1} ============");
                itemStore.UpdateStoreItemsQuality();
                System.Console.WriteLine(itemStore.ToString());

            }

            System.Console.ReadKey();

        }
    }

}
