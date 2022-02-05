public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        int[] numsCopy = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            numsCopy[i] = nums[i];
        }
        for (int i = 1; i < numsCopy.Length; i++)
        {
            int key = numsCopy[i];
            int j = i - 1;
            while (j >= 0 && numsCopy[j] > key)
            {
                numsCopy[j + 1] = numsCopy[j];
                j -= 1;
            }

            numsCopy[j + 1] = key;
        }
        for (int i = 0; i < numsCopy.Length; i++)
        {
            int bottom = i + 1;
            int top = numsCopy.Length - 1;
            while (bottom <= top)
            {
                int mid = Convert.ToInt32((bottom + top) / 2);
                if (numsCopy[mid] + numsCopy[i] > target)
                {
                    top = mid - 1;   
                }
                else if (numsCopy[mid] + numsCopy[i] < target)
                {
                    bottom = mid + 1;
                }
                else
                {
                    int[] output = { -1, -1 };
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] == numsCopy[i])
                        {
                            output[0] = j;
                            break;
                        }
                    }
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] == numsCopy[mid] && output[0] != j)
                        {
                            output[1] = j;
                        }
                    }

                    return output;
                }
            }
        }

        return new[] {-1};
    }
}