namespace GildedRose.Console.Models.Items
{
    public class FoodItem : ExtendedItem
    {
        public override void UpdateQuality()
        {
            if (SellIn > 0)
            {
                Quality++;
            }
            SellIn--;
            ValidateAttributes();
        }
    }
}
