/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) 
    {
        var A = new List<ListNode>();
        var B = new List<ListNode>();
        while (headA != null)
        {
            A.Add(headA);
            headA = headA.next;
        }
        while (headB != null)
        {
            B.Add(headB);
            headB = headB.next;
        }
        int iteratorA = A.Count - 1;
        int iteratorB = B.Count - 1;
        if (A[iteratorA] != B[iteratorB])
        {
            return null;
        }
        else
        {
            while (iteratorA > -1 && iteratorB > -1 && A[iteratorA] == B[iteratorB])
            {
                iteratorA--;
                iteratorB--;
            }
            return A[iteratorA + 1];
        }
        
        return null;
    }
}