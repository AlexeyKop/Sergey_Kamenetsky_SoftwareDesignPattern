using System.Collections;
using System.Collections.Generic;


namespace GraphBinaryTreeIterator
{
    class BinaryTree<T> : IEnumerable<Node<T>>
    {
        readonly Node<T> root;
        public Traversal Mode { get; set; }
        public BinaryTree(Node<T> root)
        {
            this.root = root;
            Mode = Traversal.PreOrder;
        }

        // Прямой обход
        private IEnumerable<Node<T>> PreOrderTraversal(Node<T> r)
        {
            if (r != null)
            {
                yield return r;
                if (r.Left != null) foreach (var item in PreOrderTraversal(r.Left)) yield return item;
                if (r.Right != null) foreach (var item in PreOrderTraversal(r.Right)) yield return item;
            }
        }

        // Центрированный обход
        private IEnumerable<Node<T>> InOrderTraversal(Node<T> r)
        {
            if (r != null)
            {
                if (r.Left != null) foreach (var item in InOrderTraversal(r.Left)) yield return item;
                yield return r;
                if (r.Right != null) foreach (var item in InOrderTraversal(r.Right)) yield return item;
            }
        }

        // Обратный обход
        private IEnumerable<Node<T>> PostOrderTraversal(Node<T> r)
        {
            if (r != null)
            {
                if (r.Left != null) foreach (var item in PostOrderTraversal(r.Left)) yield return item;
                if (r.Right != null) foreach (var item in PostOrderTraversal(r.Right)) yield return item;
                yield return r;
            }
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            return Mode switch
            {
                Traversal.PreOrder => PreOrderTraversal(root).GetEnumerator(),
                Traversal.InOrder => InOrderTraversal(root).GetEnumerator(),
                _ => PostOrderTraversal(root).GetEnumerator(),
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => (IEnumerator)this.GetEnumerator();
    }
}
