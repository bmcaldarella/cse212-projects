public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN (MultiplesOf):
        // 1) Create a double[] of size 'length' to hold the result.
        // 2) Loop i from 0 to length - 1.
        //    - For each i, set result[i] = number * (i + 1), so we produce:
        //      number, 2*number, 3*number, ... length*number.
        // 3) Return the filled array.
        // Notes:
        // - The problem statement guarantees length > 0.
        // - Using double[] ensures we preserve decimals if 'number' is non-integer.
        // Complexity:
        // - Time:  O(length) due to a single loop.
        // - Space: O(length) for the output array.

        var result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN (RotateListRight):
        // Goal: Rotate the list to the RIGHT by 'amount' positions, modifying 'data' in place.
        // Example: [1,2,3,4,5,6,7,8,9], amount=3 -> [7,8,9,1,2,3,4,5,6]
        //
        // Steps:
        // 1) Let n = data.Count. Normalize k = amount % n (handles amount == n).
        // 2) If k == 0, no rotation needed -> return.
        // 3) Split the list into two segments:
        //    - tail = last k elements        => data.GetRange(n - k, k)
        //    - head = first n - k elements   => data.GetRange(0, n - k)
        // 4) Clear the original list, then append tail followed by head:
        //    data.Clear(); data.AddRange(tail); data.AddRange(head);
        // Notes:
        // - This approach modifies the same 'data' list as required by the prompt.
        // - Alternative (not required here): in-place triple-reverse method.
        // Complexity:
        // - Time:  O(n) due to slicing and rebuilding.
        // - Space: O(n) for temporary segments (tail/head).

        int n = data.Count;
        if (n == 0) return; // Defensive guard; the prompt implies n >= 1.
        int k = amount % n;
        if (k == 0) return;

        var tail = data.GetRange(n - k, k);
        var head = data.GetRange(0, n - k);

        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
}
