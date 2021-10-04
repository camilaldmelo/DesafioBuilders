using DesafioBuilders.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBuilders.Models.Interface
{
    public interface IBtree
    {
        void insertInitial();
        void insert(ref Btree root, Node node);
        Btree getAll();
        Btree get(Btree root, Node node);
    }
}
