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
        // PK1 to FK1, Fk2 ...
        
        // form the relationship within our comment
        // Comments is a list of Comment Object. This create a One to Many relationship between Stock object and multiple Comment Objects
        // The Comments property is intitalized with a new instance of 'List<Comment>' to avoid null values.
        public List<Comment> Comments { get; set; } = new List<Comment>();

         

    }

}

