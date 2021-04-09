namespace GildedRose.Console.Models.Items
{
    public class CommonItem : ExtendedItem
    {
        public override void UpdateQuality()
        {
            if (SellIn < 0)
            {
                Quality -= 2;
            }
            else
            {
                Quality--;
            }
            SellIn--;
            ValidateAttributes();
        }
    }
}
