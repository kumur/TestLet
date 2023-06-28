using TestLetAssessment.Common;

namespace TestLetAssessment.Model
{
    /// <summary>
    /// This is a class representing a Item
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the ItemId of Item
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// Gets or sets the Type of Item
        /// </summary>
        public ItemType Type { get; set; }
    }
}
