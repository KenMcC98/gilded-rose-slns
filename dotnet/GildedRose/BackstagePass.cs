using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    internal class BackstagePass : BaseItem
    {
        public BackstagePass(Item item) : base(item)
        {
        }

        public override void UpdateItemValue()
        { 
            switch (item.SellIn)
            {
                case int n when (n > 10):
                    item.Quality += (item.Quality < 50) ? 1 : 0;
                    break;

                case int n when (n <= 10 && n > 5):
                    item.Quality += (item.Quality <= 50) ? 2 : 0;
                    break;

                case int n when (n <= 5 && n > 0):
                    item.Quality += (item.Quality <= 50) ? 3 : 0;
                    break;

                case int n when (n <= 0):
                    item.Quality = 0;
                    break;
            }

            if (item.Quality > 50 && item.SellIn >= 0)
            {
                item.Quality = 50;
            }

            item.SellIn -= 1;
        }
    }
}
