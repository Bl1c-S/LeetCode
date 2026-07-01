namespace LeetCode;

/// <summary>
/// url:
/// </summary>
public class TwoSumSolution
{
    /// <summary>
    /// <param name="nums">Only one valid answer exists.</param>>
    /// </summary>
    public int[] TwoSum(int[] nums, int target)
    {
        var second = 0;
        
        for (var i = second; i < nums.Length; i++)
        {
            var first = FindIndexLessTargetItem(nums, i, target);
            second = FindIndexLessTargetItem(nums, first + 1, target);
            if (nums[first] + nums[second] == target) return [first, second];
        }
        throw new NotImplementedException();
    }

    private int FindIndexLessTargetItem(int[] nums, int index, int target)
    {
        for (var i = index; i < nums.Length; i++)
        {
            var subject = nums[i];
            if (subject > target)
                continue;

            return i;
        }
        throw new NotImplementedException();
    }
}