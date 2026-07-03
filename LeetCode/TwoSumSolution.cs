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
        var candidate = new Dictionary<int, int>();
        
        for (var i = 0; i < nums.Length; i++)
        {
            var n = nums[i];
            var expected = target - n;
            
            if (candidate.TryGetValue(n, out var value))
                return [value, i];

            candidate.TryAdd(expected, i);
        }
        
        return [-1, -1];
    }
}