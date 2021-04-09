using GildedRose.Console.Models.Items;

namespace GildedRose.Console.Factories
{
    public class ItemFactory
    {
        public ExtendedItem CreateCommonItem(string name, int selldays, int quality)
        {
            return new CommonItem
            {
                Name = name,
                SellIn = selldays,
                Quality = quality
            };
        }
        public ExtendedItem CreateFoodItem(string name, int selldays, int quality)
        {
            return new FoodItem
            {
                Name = name,
                SellIn = selldays,
                Quality = quality
            };
        }
        public ExtendedItem CreateConjuredItem(string name, int selldays, int quality)
        {
            return new ConjuredItem
            {
                Name = name,
                SellIn = selldays,
                Quality = quality
            };
        }
        public ExtendedItem CreateLegendaryItem(string name, int selldays, int quality)
        {
            return new LegendaryItem
            {
                Name = name,
                SellIn = selldays,
                Quality = quality
            };
        }
        public ExtendedItem CreateBackstageItem(string name, int selldays, int quality)
        {
            return new BackstageTicketItem
            {
                Name = name,
                SellIn = selldays,
                Quality = quality
            };
        }
    }
}
