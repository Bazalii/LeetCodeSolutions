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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        if (list1 == null && list2 == null)
            return null;
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;
        ListNode currentFirst = list1;
        ListNode currentSecond = list2;
        ListNode head = new ListNode();
        ListNode currentOut = null;
        if (currentFirst.val <= currentSecond.val)
        {
            head = currentFirst;
            currentFirst = currentFirst.next;
        }
        else
        {
            head = currentSecond;
            currentSecond = currentSecond.next;
        }
        currentOut = head;
        while (currentFirst != null || currentSecond != null)
        {
            if (currentFirst != null && currentSecond != null)
            {
                if (currentFirst.val <= currentSecond.val)
                {
                    currentOut.next = currentFirst;
                    currentFirst = currentFirst.next;
                }
                else 
                {
                    currentOut.next = currentSecond;
                    currentSecond = currentSecond.next;
                }
            }
            else if (currentFirst != null)
            {
                currentOut.next = currentFirst;
                currentFirst = currentFirst.next;
            }
            else
            {
                currentOut.next = currentSecond;
                currentSecond = currentSecond.next;
            }
            
            currentOut = currentOut.next;
        }
        
        return head;
    }
}