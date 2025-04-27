using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    static int QualityDegredationFactor = 1;
    
    static Dictionary<string, Func<Item, BaseItem>> ItemProcessorLookup = new()
    {
        { "Sulfuras, Hand of Ragnaros", (Item item) => new LegendaryItem(item) },
        { "Aged Brie", (Item item) => new AgedBrie(item) },
        { "Conjured Mana Cake", (Item item) => new ConjuredItem(item) },
        { "Backstage passes to a TAFKAL80ETC concert", (Item item) => new BackstagePass(item) },
        { "Default", (Item item) => new BaseItem(item) },
    };
    
    public static IList<BaseItem> CreateProcessorsForItems(IList<Item> Items)
    {
        var processorList = new List<BaseItem>();
        
        foreach (var item in Items)
        {
            processorList.Add(CreateItemProcessor(item));
        }

        return processorList;
    }

    public static BaseItem CreateItemProcessor(Item item)
    {
        string itemName = item.Name;

        if (ItemProcessorLookup.TryGetValue(itemName, out var processor))
        {
            return processor(item);
        } else
        {
            return ItemProcessorLookup["Default"](item);
        }
    }
    
    IList<Item> Items;
    IList<BaseItem> ItemProcessors;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
        this.ItemProcessors = CreateProcessorsForItems(Items);
    }

    public void UpdateQualityClean()
    {
        foreach (var processor in ItemProcessors)
        {
            processor.UpdateItemValue();
        }
    }
}