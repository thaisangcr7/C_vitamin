using System;

namespace api.Models
{
    public class Comment
    {
        public int ID { get; set; }

        // Initialize to avoid null
        public string Title { get; set; } = string.Empty;

        // Initialize to avoid null
        public string Content { get; set; } = string.Empty;

        // Set default value for DateTime
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        // Foreign key is nullable to handle cases where there’s no related stock initially
        public int? StockId { get; set; } 

        // Navigation property is nullable since there might not always be a related Stock
        public Stocks? Stocks { get; set; } 
    }
}
