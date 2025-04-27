using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    internal class ConjuredItem : BaseItem
    {
        public ConjuredItem(Item item) : base(item)
        {
        }

        public override void UpdateItemValue()
        {
            item.SellIn -= 1;

            if (item.Quality >= 2)
            {
                if (item.SellIn >= 0)
                {
                    item.Quality -= 2;
                }
                else
                {
                    item.Quality = (item.Quality - 4) > 0 ? (item.Quality - 4) : 0;
                }
            }
            else
            {
                item.Quality = 0;
            }
        }
    }
}
