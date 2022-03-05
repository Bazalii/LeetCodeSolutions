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
    public ListNode RemoveElements(ListNode head, int val) 
    {
        if (head == null) return null;
        ListNode newHead = new ListNode(0, new ListNode());
        ListNode currentSecond = head;
        while (currentSecond != null && currentSecond.val == val)
        {
            currentSecond = currentSecond.next;
        }
        if (currentSecond == null)
        {
            return null;
        }
        if (currentSecond.next == null)
        {
            return new ListNode(currentSecond.val, null);
        }
        newHead.val = currentSecond.val;
        ListNode currentFirst = newHead;
        currentSecond = currentSecond.next;
        while (currentSecond != null)
        {
            if (currentSecond.val != val)
            {
                currentFirst.next = currentSecond;
                currentFirst = currentFirst.next;
                currentSecond = currentSecond.next;
            }
            else 
            {
                currentSecond = currentSecond.next;
            }
        }
        currentFirst.next = null;
        
        return newHead;
    }
}