namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/two-sum/description/">leetcode.com</see>
/// </summary>
public class TwoSumSolution
{
    /// <summary>
    /// <param name="nums">Only one valid answer exists.</param>>
    /// </summary>
    public int[] TwoSum(int[] nums, int target)
    {
        //O(n^2)
        for (var i = 0; i < nums.Length; i++)
        {
            var first = nums[i];
            var expected = target - first;

            for (var x = i + 1; x < nums.Length; x++)
            {
                if (nums[x] == expected)
                    return [i, x];
            }
        }
        throw new NotImplementedException();
    }
}