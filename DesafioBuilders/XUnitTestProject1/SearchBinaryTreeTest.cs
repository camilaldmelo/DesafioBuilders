using DesafioBuilders.Models.Business;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesafioBuilders.Tests
{
    public class SearchBinaryTreeTest
    {
        private readonly Btree bTree = new Btree();

        [Fact]
        public void SearchBinaryTree_Sucess()
        {
            string valueNode = "1";
            int valueValue = 2;

            var bTree = new Btree();
            bTree.getAll();
            var NodeParam = new Node() { Value = valueValue };
            Btree returnSucess = bTree.get(bTree, NodeParam);
            Assert.Equal(2, returnSucess.node.Value);
        }

        //[Fact]
        //public void SearchBinaryTree_False()
        //{
        //    string valueSucess = "teste";
        //    bool returnSucess = bTree.get(valueSucess);
        //    Assert.False(returnSucess);
        //}
    }
}
