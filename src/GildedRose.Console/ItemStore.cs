using GildedRose.Console.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class ItemStore
    {
        List<ExtendedItem> _items;

        public ItemStore()
        {
            _items = new List<ExtendedItem>();
        }

        public void Add(List<ExtendedItem> items)
        {
            _items.AddRange(items);
        }
        public void Add(ExtendedItem item)
        {
            _items.Add(item);
        }

        public void UpdateStoreItemsQuality()
        {
            foreach (var item in _items)
            {
                item.UpdateQuality();
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach(var item in _items)
            {
                result += $"Name: {item.Name}, SellDays: {item.SellIn}, Quality: {item.Quality}\n";
            }
            return result;
        }
    }
}
