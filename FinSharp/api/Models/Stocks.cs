using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

// model folder is like a drawer
// stocks and comments are like files 

namespace api.Models

{
    public class Stocks
    {
        //public int MyProperty { get; set; } // prop + tab to get the implemented property 
        // Define public properties
        public int ID { get; set; }
        public string Symbol { get; set; } =  string.Empty; // to avoid Null
        public string CompanyName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]

        public decimal Purchase { get; set;} // to store money
        [Column(TypeName = "decimal(18,2)")]
        
        public decimal LastDiv { get; set;}
        [Column(TypeName = "decimal(18,2)")]

        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }

        // one to many relationship (the connection between the primary key and the foregin key)

        
    }

}

