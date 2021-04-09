namespace GildedRose.Console.Models.Items
{
    public class ConjuredItem : ExtendedItem
    {
        public override void UpdateQuality()
        {
            if (SellIn < 0)
            {
                Quality -= 4;
            }
            else
            {
                Quality -= 2;
            }
            SellIn--;
            ValidateAttributes();
        }
    }
}
