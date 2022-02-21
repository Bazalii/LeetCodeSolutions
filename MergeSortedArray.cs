public class Solution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        var result = new int[m + n];
        int resultIterator = 0;
        int leftIterator = 0;
        int rightIterator = 0;
        while (leftIterator < m || rightIterator < n)
        {
            if (leftIterator < m && rightIterator < n)
            {
                if (nums1[leftIterator] <= nums2[rightIterator])
                {
                    result[resultIterator] =  nums1[leftIterator]; 
                    leftIterator++;
                }
                else
                {
                    result[resultIterator] =  nums2[rightIterator]; 
                    rightIterator++; 
                }
            } 
            else if (leftIterator < m)
            {
                result[resultIterator] =  nums1[leftIterator]; 
                leftIterator++;
            }
            else
            {
                result[resultIterator] =  nums2[rightIterator]; 
                rightIterator++;
            }
            resultIterator++;
        }
        for (int i = 0; i < resultIterator; i++)
            nums1[i] = result[i];
    }
}