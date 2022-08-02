namespace GraphIterator
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node<T> Parent { get; set; }
        public Node(T value) => Value = value;
        public Node(T value, Node<T> left = null, Node<T> right = null)
            : this(value)
        {
            Left = left;
            Right = right;
            if (Left != null) Left.Parent = this;
            if (Right != null) Right.Parent = this;
        }
        public override string ToString() => Value.ToString();
    }
}
