/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution
{
    private List<int> result = new List<int>();

    public IList<int> Postorder(Node root)
    {
        if (root != null)
        {
            Run(root);
        }
        return result;
    }

    private void Run(Node node)
    {
        foreach (var child in node.children)
        {
            Run(child);
        }
        result.Add(node.val);
    }
}