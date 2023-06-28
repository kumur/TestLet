using System;
using System.Collections.Generic;
using System.Linq;
using TestLetAssessment.Common;
using TestLetAssessment.Model;

namespace TestLetAssessment
{

    /// <summary>
    /// Represents a TestLet
    /// </summary>
    public class TestLet
    {
        /// <summary>
        /// Getting the Ordered Item
        /// </summary>
        /// <returns>Pretest items and operational items List</returns>
        public List<Item> GetOrderedItem()
        {
            List<Item> randomItems = Randomize();
            List<Item> pretestItems = randomItems.Where(item => item.Type == ItemType.Pretest).Take(2).ToList();
            List<int> testLetId = pretestItems.Select(x => x.ItemId).ToList();
            randomItems.RemoveAll(item => testLetId.Contains(item.ItemId));
            return pretestItems.Concat(randomItems).ToList();
        }

        /// <summary>
        /// Randomize the Items List
        /// </summary>
        /// <returns>Random List</returns>
        private List<Item> Randomize()
        {
            var lstItem = GetItems();
            var random = new Random();
            return lstItem.OrderBy(item => random.Next()).ToList();
        }

        /// <summary>
        /// Getting the 10 items combination 6 of Operational and 4 of Pretest
        /// </summary>
        /// <returns>Item List</returns>
        public List<Item> GetItems()
        {
            return new List<Item>
            {
                new Item {ItemId =1,Type = ItemType.Pretest },
                new Item {ItemId =2,Type = ItemType.Pretest },
                new Item {ItemId =3,Type = ItemType.Pretest },
                new Item {ItemId =4,Type = ItemType.Pretest },
                new Item {ItemId =5,Type = ItemType.Operational },
                new Item {ItemId =6,Type = ItemType.Operational },
                new Item {ItemId =7,Type = ItemType.Operational },
                new Item {ItemId =8,Type = ItemType.Operational },
                new Item {ItemId =9,Type = ItemType.Operational },
                new Item {ItemId =10,Type = ItemType.Operational }
            };
        }
    }
}
