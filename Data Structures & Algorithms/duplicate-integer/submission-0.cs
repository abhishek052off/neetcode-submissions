public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        HashSet<int> keySet = new HashSet<int>();

        foreach (int i in nums)
        {
            if (keySet.Contains(i)) return true;
            else keySet.Add(i);
        }
        return false;
    }
}