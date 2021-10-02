using DesafioBuilders.Models.Persistence;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBuilders.Models.Business
{
    public class ManipularBTree
    {
        public static void insertInitial()
        {
            Btree root = null;
            Node n = new Node() { Value = 2, Name = "Node2" };
            ManipularBTree.insert(ref root, n);
            n = new Node() { Value = 1, Name = "Node1" };
            ManipularBTree.insert(ref root, n);
            n = new Node() { Value = 3, Name = "Node3" };
            ManipularBTree.insert(ref root, n);

            MongoDbContext dbContext = new MongoDbContext();

            dbContext.Btree.InsertOne(root);
        }
        public static void insert(ref Btree root, Node node)
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
                insert(ref root.left, node);
            }
            else
            {
                insert(ref root.right, node);
            }
        }
        public static Btree getAll()
        {
            MongoDbContext dbContext = new MongoDbContext();
            Btree BTree = dbContext.Btree.Find(x => true).FirstOrDefault();
            return BTree;
        }
        public static Btree get(Btree root, Node node)
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
