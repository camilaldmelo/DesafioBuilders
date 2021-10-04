using DesafioBuilders.Models.Interface;
using DesafioBuilders.Models.Persistence;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBuilders.Models.Business
{
    [BsonIgnoreExtraElements]
    public class Btree : IBtree
    {
        public Node node { get; set; }
        public Btree left { get; set; }
        public Btree right { get; set; }

        public void insertInitial()
        {
            Btree root = null;
            Node n = new Node() { Value = 2, Name = "Node2" };
            insert(ref root, n);
            n = new Node() { Value = 1, Name = "Node1" };
            insert(ref root, n);
            n = new Node() { Value = 3, Name = "Node3" };
            insert(ref root, n);

            MongoDbContext dbContext = new MongoDbContext();

            dbContext.Btree.InsertOne(root);
        }
        public void insert(ref Btree root, Node node)
        {
            if (root == null)
            {
                root = new Btree();
                root.node = node;
                root.left = null;
                root.right = null;

            }
            else if (node.Value < root.node.Value)
            {
                Btree left = root.left;
                insert(ref left, node);
            }
            else
            {
                Btree right = root.left;
                insert(ref right, node);
            }
        }
        public Btree getAll()
        {
            MongoDbContext dbContext = new MongoDbContext();
            Btree BTree = dbContext.Btree.Find(x => true).FirstOrDefault();
            return BTree;
        }
        public Btree get(Btree root, Node node)
        {

            if (root == null)
            {
                return null;
            }
            else if (root.node.Value == node.Value)
            {
                return root;
            }
            else if (node.Value < root.node.Value)
            {
                return get(root.left, node);
            }
            else
            {
                return get(root.right, node);
            }

        }
    }

}
