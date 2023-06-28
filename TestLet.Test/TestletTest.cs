using System.Collections.Generic;
using System.Linq;
using TestLetAssessment.Common;
using TestLetAssessment.Model;
using Xunit;

namespace TestLet.Test
{
    public class TestLetTest
    {
        [Fact]
        public void RandomizeItems_ShouldRandomizeOrder()
        {
            TestLetAssessment.TestLet testlet = new TestLetAssessment.TestLet();

            List<Item> orderedItems = testlet.GetOrderedItem();         
       
            Assert.Equal(10, orderedItems.Count);
            Assert.Equal(4, orderedItems.Where(x => x.Type == ItemType.Pretest).ToList().Count);
            Assert.Equal(6, orderedItems.Where(x => x.Type == ItemType.Operational).ToList().Count);
            Assert.Equal(2, orderedItems.Take(2).Count(i => i.Type == ItemType.Pretest));
            Assert.Equal(8, orderedItems.Skip(2).Count(i => i.Type == ItemType.Pretest || i.Type == ItemType.Operational));
            Assert.NotEqual(testlet.GetItems(), orderedItems);
        }
    }
}
