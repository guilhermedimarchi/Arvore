using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExercArvore;

namespace Testes
{
    [TestClass]
    public class TesteArvoreT22014
    {
        /// <summary>
        /// O método minimax é uma mistura de minimo e máximo dos nós das árvores.  
        /// Quando o nó é folha, seu valor minimax é seu próprio valor. 
        /// Um nó inexistente tem valor minimax de zero. 
        /// Se o nó não é folha, minimax pode ser:
        /// - o maior valor minimax dos filhos, se o nível do nó é par
        /// - o menor valor minimax dos filhos, se o nível do nó é impar
        /// </summary>
        [TestMethod]
        public void P1_MinimaxSimples()
        {
            BTree bt = new BTree();
            bt.Insert(30);
            Assert.AreEqual(30, bt.Minimax());
        }
        [TestMethod]
        public void P2_MinimaxManco()
        {
            BTree bt = new BTree();
            bt.Insert(20);
            bt.Insert(10);
            bt.Insert(30);
            bt.Insert(40);
            Assert.AreEqual(10, bt.Minimax());
        }
        [TestMethod]
        public void P3_MinimaxMultiNivel()
        {
            BTree bt = new BTree();
            bt.Insert(500);
            bt.Insert(250);
            bt.Insert(750);
            bt.Insert(125);
            bt.Insert(385);
            bt.Insert(625);
            bt.Insert(1000);
            bt.Insert(80);
            bt.Insert(200);
            bt.Insert(300);
            bt.Insert(400);
            bt.Insert(550);
            bt.Insert(700);
            bt.Insert(900);
            bt.Insert(1200);
            Assert.AreEqual(700, bt.Minimax());
        }
        /// <summary>
        /// Neste método você deve montar a árvore para minimax processar. 
        /// A árvore deve seguir ose seguintes parametros:
        /// - A altura é passada por parâmetro e a árvore é binária e completa. 
        /// - Cada um de seus nós folhas tem o valor de um contador, iniciando em 1, no 
        ///  nó folha mais a esquerda. 
        /// </summary>
        [TestMethod]
        public void P4_MinimaxArvoreGerada()
        {
         /*  BTree bt = new BTree();
            bt.GeraArvore(2);
            Assert.AreEqual(2, bt.Minimax());
            bt.GeraArvore(5);
            Assert.AreEqual(11, bt.Minimax());
            bt.GeraArvore(10);
            Assert.AreEqual(342, bt.Minimax());*/
        }


    }
}
