using System;

namespace ExercArvore
{
	// Classe com o nó
	public class Node
	{
		private int info;
		private Node esq, dir, pai;

		// Construtor
		public Node (int x, Node p)
		{
			info = x;
			pai = p;
			esq = null;
			dir = null;
		}

		// Properties
		public int Info
		{
			get
			{
				return info;
			}
			set
			{
				info = value;
			}
		}
		public Node Esq
		{
			get
			{
				return esq;
			}
			set
			{
				esq = value;
			}
		}
		public Node Dir
		{
			get
			{
				return dir;
			}
			set
			{
				dir = value;
			}
		}
		public Node Pai
		{
			get
			{
				return pai;
			}
			set
			{
				pai = value;
			}
		}
	}
	
	// Classe com a árvore
	public class BTree
	{
		// Nó raiz
		private Node raiz;
		public Node Raiz
		{
			get
			{
				return raiz;
			}
			set
			{
				raiz = value;
			}
		}

		// Construtor
		public BTree()
		{
			raiz = null;
		}

		// Inserindo na árvore
		public void Insert(int x)
		{
            if (raiz == null)
                raiz = new Node(x, null);
            else
            {
                Insert(raiz, x);
            }
		}

        private void Insert(Node n, int x)
        {
            if (x < n.Info)
            {
                if (n.Esq == null)
                    n.Esq = new Node(x, n);
                else
                    Insert(n.Esq, x);
            }
            else
            {
                if (n.Dir == null)
                    n.Dir = new Node(x, n);
                else
                    Insert(n.Dir, x);
            }
        }
        private int Minimax(Node n)
        {
            int minimax = 0;
            if (n == null)
                minimax = 0;
            else if (n.Dir == null && n.Esq == null)
                minimax = n.Info;
            else
            {
                if ((calcularNivelNodo(n.Info) % 2) == 0)
                {

                    minimax = Minimax(n.Dir);
                }
                else
                {
                    minimax = Minimax(n.Esq);
                }
            }
            return minimax;
        }

        public int Minimax()
        {

            int minimax = 0;
            minimax = Minimax(raiz);

            return minimax;
        }


        public int calcularNivelNodo(int k)
        {
            Node aux = raiz;
            int nivel = 0;
            while (aux != null && aux.Info != k)
            {
                if (k < aux.Info)
                {
                    aux = aux.Esq;
                }
                else
                {
                    aux = aux.Dir;
                }
                nivel++;
            }
            return nivel;
        } 


		// Pesquisa na árvore
		public Node Find(int x)
		{
            if ((raiz == null) || (raiz.Info == x))
                return raiz;
            if (x < raiz.Info)
                return Find(raiz.Esq, x);
            else
                return Find(raiz.Dir, x);
         
		}
        private Node Find(Node n, int x)
        {
            if ((n == null) || (n.Info == x))
                return n;
            if (x < n.Info)
                return Find(n.Esq, x);
            else
                return Find(n.Dir, x);
        }
		// Função para excluir nó
		public void Remove(int x)
		{
            if (raiz == null)
                return;
            else
                Remove(raiz, x);
		}
        private void Remove(Node n,int x)
        {
        }
		
		
	}
}
