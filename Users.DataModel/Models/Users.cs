using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Users.DataModel.Models
{
    public class User
    {
        [BsonElement("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Date> ListOfDates { get; set; }
    }
}
