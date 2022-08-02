using System.Collections.Generic;

namespace GraphTreeIterator
{
    class IteratorTree<T>
    {
        readonly Node<T> root;

        public IteratorTree(Node<T> root) => this.root = root;

        // https://ru.wikipedia.org/wiki/Обход_дерева#Поиск_в_глубину
        public IEnumerable<Node<T>> GetIterator(Traversal traversal)
        {
            ////Прямой обход
            IEnumerable<Node<T>> PreOrderTraversal(Node<T> r)
            {
                if (r != null)
                {
                    yield return r;
                    if (r.Left != null) foreach (var item in PreOrderTraversal(r.Left)) yield return item;
                    if (r.Right != null) foreach (var item in PreOrderTraversal(r.Right)) yield return item;
                }
            }

            //Центрированный обход
            IEnumerable<Node<T>> InOrderTraversal(Node<T> r)
            {
                if (r != null)
                {
                    if (r.Left != null) foreach (var item in InOrderTraversal(r.Left)) yield return item;
                    yield return r;
                    if (r.Right != null) foreach (var item in InOrderTraversal(r.Right)) yield return item;
                }
            }

            // Обратный обход
            IEnumerable<Node<T>> PostOrderTraversal(Node<T> r)
            {
                if (r != null)
                {
                    if (r.Left != null) foreach (var item in PostOrderTraversal(r.Left)) yield return item;
                    if (r.Right != null) foreach (var item in PostOrderTraversal(r.Right)) yield return item;
                    yield return r;
                }
            }

            IEnumerable<Node<T>> mode = traversal switch
            {
                Traversal.PreOrder => PreOrderTraversal(root),
                Traversal.InOrder => InOrderTraversal(root),
                _ => PostOrderTraversal(root),
            };
            foreach (var item in mode) yield return item;

            //foreach (var item in traversal switch
            //{
            //    Traversal.PreOrder => PreOrderTraversal(root),
            //    Traversal.InOrder => InOrderTraversal(root),
            //    _ => PostOrderTraversal(root),
            //}) yield return item;
        }
    }
}


