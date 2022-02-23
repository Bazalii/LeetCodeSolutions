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
    public ListNode DeleteDuplicates(ListNode head) 
    {
        if (head == null) return null;
        int currentNumber = head.val;
        int nextNumber;
        ListNode currentOldNode = head;
        ListNode newHead = head;
        ListNode currentNewNode = newHead;
        while(currentOldNode.next != null)
        {
            if (currentOldNode.next.val != currentNumber)
            {
                currentNewNode.next = currentOldNode.next;
                currentNewNode = currentNewNode.next;
                currentNumber = currentOldNode.next.val;
            }
            currentOldNode = currentOldNode.next;
        }
        
        currentNewNode.next = null;
        return newHead;
    }
}