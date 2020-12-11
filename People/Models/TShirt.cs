using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace People.Models
{
    [Table("tshirt")]
    public class tshirt
    {

            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            [MaxLength(250), Unique]
            public string Names { get; set; }
            public string Genders { get; set; }
            public string TShirtSizes { get; set; }
            public string DateOfOrders { get; set; }
            public string TShirtColors { get; set; }
            public string Shipping_Addresses { get; set; }




    }
}
