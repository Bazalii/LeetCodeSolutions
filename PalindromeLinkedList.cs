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
    public bool IsPalindrome(ListNode head) 
    {
        ListNode currentNode = head;
        List<int> number = new List<int>();
        while (currentNode.next != null)
        {
            number.Add(currentNode.val);
            currentNode = currentNode.next;
        }    

        number.Add(currentNode.val);
        int bottom = 0;
        int top = number.Count - 1;
        while(bottom < top)
        {
            if (number[bottom] != number[top])
                return false;
            bottom++;
            top--;
        }
        
        return true;
    }
}