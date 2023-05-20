public class Solution
{
    public int FindContentChildren(int[] children, int[] cookies)
    {
        Array.Sort(children);
        Array.Sort(cookies);

        var contentChildrenNumber = 0;

        var currentChild = children.Length - 1;
        var currentCookie = cookies.Length - 1;

        while (currentChild != -1 && currentCookie != -1)
        {
            if (children[currentChild] <= cookies[currentCookie])
            {
                contentChildrenNumber++;

                currentChild--;
                currentCookie--;

                continue;
            }

            currentChild--;
        }

        return contentChildrenNumber;
    }
}