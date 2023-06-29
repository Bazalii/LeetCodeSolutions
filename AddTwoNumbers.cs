/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode AddTwoNumbers(ListNode firstNode, ListNode secondNode)
    {
        var newHead = new ListNode();
        var currentNode = newHead;
        var overdraft = 0;

        while (firstNode is not null || secondNode is not null)
        {
            var currentSummary = overdraft;

            if (firstNode is not null)
            {
                currentSummary += firstNode.val;
                firstNode = firstNode.next;
            }

            if (secondNode is not null)
            {
                currentSummary += secondNode.val;
                secondNode = secondNode.next;
            }

            if (currentSummary > 9)
            {
                overdraft = 1;
                currentSummary -= 10;
            }
            else
            {
                overdraft = 0;
            }

            currentNode.val = currentSummary;
            currentNode.next = new ListNode();
            currentNode = currentNode.next;
        }

        currentNode = newHead;
        var nodeBeforeLast = newHead;

        while (currentNode.next is not null)
        {
            nodeBeforeLast = currentNode;
            currentNode = currentNode.next;
        }

        if (overdraft == 0)
        {
            nodeBeforeLast.next = null;
        }
        else
        {
            nodeBeforeLast.next.val = overdraft;
        }

        return newHead;
    }
}