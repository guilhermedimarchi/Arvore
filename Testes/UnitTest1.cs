using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExercArvore;

namespace Testes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteRaiz()
        {
            BTree bt = new BTree();
            bt.Insert(20);
            Assert.AreEqual(20, bt.Raiz.Info);
        }
        
        [TestMethod]
        public void TesteMedio()
        {
            BTree bt = new BTree();
            bt.Insert(20);
            bt.Insert(10);
            bt.Insert(30);
            Assert.AreEqual(20, bt.Raiz.Info);
            Assert.AreEqual(10, bt.Raiz.Esq.Info);
            Assert.AreEqual(30, bt.Raiz.Dir.Info);
        }

        [TestMethod]
        public void TesteDificilMasNaoMuito()
        {
            BTree bt = new BTree();
            bt.Insert(20);
            bt.Insert(10);
            bt.Insert(30);
            bt.Insert(15);
            bt.Insert(50);
            Assert.AreEqual(null, bt.Find(40));
            Assert.AreEqual(30, bt.Find(30).Info);
        }


    }
}
