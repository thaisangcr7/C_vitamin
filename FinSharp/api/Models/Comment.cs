using System;

namespace api.Models
{

    public class Comment
    {
        // link the comment with stock with Convention 
        // to form the relationship
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty; // title for comments
        public string Content { get; set; } = string.Empty;

        public DateTime  CreateOn { get; set; } = DateTime.Now;

        public int? StockId { get; set; } // key
        // Navigation
        // Navigate within our model and relationship
        public Stocks? Stocks { get; set;} // this is the navigation property allow us to access the properties
 

    }


}
