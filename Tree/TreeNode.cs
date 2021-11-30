public class TreeNode
{
    private int _data;
    private TreeNode _leftChild;
    private TreeNode _rightChild;

    public TreeNode(int data)
    {
        _data = data;
    }
    public int Data
    {
        get { return _data; }
        set { _data = value; }
    }

    public TreeNode LeftChild
    {
        get { return _leftChild; }
        set { _leftChild = value; }
    }

    public TreeNode RightChild
    {
        get { return _rightChild; }
        set { _rightChild = value; }
    }

    public void Insert(int value)
    {
        if (value == _data)
            return;
        if (value < _data)
        {
            if (_leftChild == null)
            {
                _leftChild = new TreeNode(value);
                return;
            }
            _leftChild.Insert(value);
        }
        else
        {
            if (_rightChild == null)
            {
                _rightChild = new TreeNode(value);
                return;
            }
            _rightChild.Insert(value);
        }
    }

    public void Remove(int value)
    {

    }

    private TreeNode Remove(TreeNode subtreeRoot, int value)
    {
        if (subtreeRoot == null)
            return subtreeRoot;
        if (value < subtreeRoot.Data)
        {
            subtreeRoot.LeftChild = Remove(subtreeRoot.LeftChild, value);
        }
        else if (value > subtreeRoot.Data)
        {
            subtreeRoot.RightChild = Remove(subtreeRoot.RightChild, value);
        }
        else
        {
            if (subtreeRoot.LeftChild == null)
            {
                return subtreeRoot.RightChild;
            }
            else if (subtreeRoot.RightChild == null)
            {
                return subtreeRoot.LeftChild;
            }
        }
        return subtreeRoot;
    }
    public void TraverseInOrder()
    {
        if (_leftChild != null)
        {
            _leftChild.TraverseInOrder();
        }
        System.Console.Write(_data + ", ");
        if (_rightChild != null)
        {
            _rightChild.TraverseInOrder();
        }
    }

    public TreeNode Get(int value)
    {
        if (value == _data)
            return this;
        if (value < _data)
        {
            if (_leftChild == null)
                return null;
            return _leftChild.Get(value);
        }
        else
        {
            if (_rightChild == null)
                return null;
            return _rightChild.Get(value);
        }
    }

    public int Min()
    {
        if (_leftChild == null)
            return _data;
        return _leftChild.Min();
    }

    public int Max()
    {
        if (_rightChild == null)
            return _data;
        return _rightChild.Max();
    }
}