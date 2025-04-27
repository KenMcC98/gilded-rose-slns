using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    internal class AgedBrie : BaseItem
    {
        public AgedBrie(Item item) : base(item)
        {
        }

        public override void UpdateItemValue()
        {
            item.SellIn -= 1;

            if (item.Quality < 50)
            {
                item.Quality += (item.SellIn < 0) ? 2 : 1;
            }
        }
    }
}
