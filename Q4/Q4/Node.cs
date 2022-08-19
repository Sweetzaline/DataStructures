namespace Q4
{
    public class Node<T>
    {
        public T data;
        public Node<T> nextNode;
        public Node(T data)
        {
            this.data = data;
        }
    }
}