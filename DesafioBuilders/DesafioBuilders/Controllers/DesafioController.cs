using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBuilders.Models.Business;
using DesafioBuilders.Models.Interface;
using DesafioBuilders.Models.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesafioBuilders.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DesafioController : ControllerBase
    {
        private Btree bTree;

        private readonly ILogger<DesafioController> _logger;

        public DesafioController(ILogger<DesafioController> logger)
        {
            _logger = logger;
            new Btree().insertInitial();
            bTree = new Btree().getAll();

        }

        [HttpGet]
        public void Get()
        {
        }

        [HttpPost]
        public void Post()
        {
        }

        /// <summary>
        /// 1° Question - Check Palindrome
        ///     character case should be ignored - YES  
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("IsPalindrome")]
        public bool IsPalindrome(string value)
        {
            return new Palindrome().CheckPalindrome(value);
        }

        /// <summary>
        /// 2° Question - Search a binary tree 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSearchBinaryTree")]
        public int GetSearchBinaryTree(int node, int value)
        {
            var retorno = 0;

            var NodeParam = new Node() { Value = value };
            var aux = new Btree().get(bTree, NodeParam);

            retorno = aux != null ? aux.node.Value : 0;

            return retorno;
        }

    }
}
