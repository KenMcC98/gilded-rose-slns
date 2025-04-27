using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class BaseItem : Item
    {
        protected Item item;

        public BaseItem(Item item)
        {
            this.item = item;
        }

        public virtual void UpdateItemValue()
        {
            item.SellIn -= 1;

            if (item.Quality > 0)
            {
                if (item.SellIn >= 0)
                {
                    item.Quality -= 1;
                } else
                {
                    item.Quality = (item.Quality - 2) > 0 ? (item.Quality - 2) : 0 ;
                }
            }
        }
    }
}
