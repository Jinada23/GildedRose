namespace GildedRose.Console.Models.Items
{
    public abstract class ExtendedItem : Item
    {
        public abstract void UpdateQuality();
        public void ValidateAttributes()
        {
            if (SellIn < 0)
            {
                SellIn = 0;
            }
            if (Quality > 50)
            {
                Quality = 50;
            }
            if (Quality < 0)
            {
                Quality = 0;
            }
        }
    }
}
