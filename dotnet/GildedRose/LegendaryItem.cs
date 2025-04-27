using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class LegendaryItem : BaseItem
    {
        public LegendaryItem(Item item) : base(item)
        {
        }

        public override void UpdateItemValue()
        {
            item.Quality = item.Quality;
            item.SellIn = item.SellIn;
        }
    }
}
