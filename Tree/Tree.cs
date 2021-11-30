public class Tree
{
    private TreeNode _root;

    public TreeNode Root
    {
        get { return _root; }
        set { _root = value; }
    }

    public void Insert(int value)
    {
        if (_root == null)
        {
            _root = new TreeNode(value);
        }
        else
        {
            _root.Insert(value);
        }
    }

    public void TraverseInOrder()
    {
        if (_root != null)
            _root.TraverseInOrder();
    }

    public TreeNode Get(int value)
    {
        if (_root == null)
            return null;
        return _root.Get(value);
    }

    public int Min()
    {
        if (_root == null)
            throw new System.InvalidOperationException("Tree is empty");
        return _root.Min();
    }

    public int Max()
    {
        if (_root == null)
            throw new System.InvalidOperationException("Tree is empty");
        return _root.Max();
    }
}