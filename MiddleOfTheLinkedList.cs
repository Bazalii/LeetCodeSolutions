public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        var nodesCount = 0;
        var currentNode = head;

        while (currentNode is not null)
        {
            nodesCount++;

            currentNode = currentNode.next;
        }

        var resultNode = head;

        for (var i = 0; i < nodesCount / 2; i++)
        {
            resultNode = resultNode.next;
        }

        return resultNode;
    }
}