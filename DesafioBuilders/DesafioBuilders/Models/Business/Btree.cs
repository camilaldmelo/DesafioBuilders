using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBuilders.Models.Business
{
    [BsonIgnoreExtraElements]
    public class Btree
    {
        public Node node;
        public Btree left;
        public Btree right;
    }
}
