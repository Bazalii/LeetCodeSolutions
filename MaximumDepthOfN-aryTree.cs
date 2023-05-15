public class Solution
{
    public int MaxDepth(Node root)
    {
        if (root is null)
        {
            return 0;
        }

        return CalculateHeight(root, 0);
    }

    private int CalculateHeight(Node node, int height)
    {
        height++;

        if (node.children.Count == 0)
        {
            return height;
        }

        var biggestHeight = height;

        for (var i = 0; i < node.children.Count; i++)
        {
            var currentHeight = CalculateHeight(node.children[i], height);

            if (currentHeight > biggestHeight)
            {
                biggestHeight = currentHeight;
            }
        }

        return biggestHeight;
    }
}