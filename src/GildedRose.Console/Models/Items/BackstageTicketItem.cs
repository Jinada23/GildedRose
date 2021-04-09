namespace GildedRose.Console.Models.Items
{
    public class BackstageTicketItem : ExtendedItem
    {
        public override void UpdateQuality()
        {
            Quality++;
            if (SellIn < 11)
            {
                Quality++;
                if (SellIn < 6)
                {
                    Quality++;
                    if (SellIn == 0)
                    {
                        Quality = 0;
                    }
                }
            }
            SellIn--;
            ValidateAttributes();
        }
    }
}
