public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head is null)
        {
            return null;
        }

        var nodeValues = new List<int>();

        while (head != null)
        {
            nodeValues.Add(head.val);

            head = head.next;
        }

        head = new ListNode(nodeValues[^1]);
        var currentNode = head;

        for (var i = nodeValues.Count - 1; i > 0; i--)
        {
            var nextNode = new ListNode(nodeValues[i - 1]);
            currentNode.next = nextNode;
            currentNode = nextNode;
        }

        return head;
    }
}