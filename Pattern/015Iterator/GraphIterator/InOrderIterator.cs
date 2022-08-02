namespace GraphIterator
{
    public class InOrderIterator<T>
    {
        public Node<T> Current { get; set; }
        private readonly Node<T> root;
        private bool detourStarted;

        public InOrderIterator(Node<T> root)
        {
            this.root = Current = root;
            Reset();
        }

        public void Reset()
        {
            Current = root;
            while (Current.Left != null) Current = Current.Left;
            detourStarted = !true;
        }

        public bool MoveNext()
        {
            if (!detourStarted)
            {
                detourStarted = true;
                return true;
            }

            if (Current.Right != null)
            {
                Current = Current.Right;
                while (Current.Left != null) Current = Current.Left;
                return true;
            }
            else
            {
                var temp = Current.Parent;
                while (temp != null && Current == temp.Right)
                {
                    Current = temp;
                    temp = temp.Parent;
                }
                Current = temp;
                return Current != null;
            }
        }
    }
}
