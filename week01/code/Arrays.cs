public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN (MultiplesOf):
        // I need to return an array with "length" elements.
        // Each element will be the number multiplied by 1, 2, 3, ... until "length".
        // Example: number=3, length=5 -> {3,6,9,12,15}.
        // Steps:
        // 1) Make an array with size "length".
        // 2) Use a loop from 0 to length-1.
        // 3) Put number * (i+1) in each spot of the array.
        // 4) Return the array when done.

        var result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// Example: List<int>{1,2,3,4,5,6,7,8,9}, amount = 3 -> List<int>{7,8,9,1,2,3,4,5,6}.  
    /// The value of amount will be in the range of 1 to data.Count, inclusive.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN (RotateListRight):
        // I need to move the list "amount" steps to the right.
        // Example: {1,2,3,4,5,6,7,8,9}, amount=3 -> {7,8,9,1,2,3,4,5,6}.
        // Steps:
        // 1) Find the length of the list (n).
        // 2) Use amount % n in case amount == n (rotation would do nothing).
        // 3) If the result is 0, just return the same list.
        // 4) Take the last "k" elements (tail).
        // 5) Take the first "n-k" elements (head).
        // 6) Clear the list, then add the tail first and the head after.

        int n = data.Count;
        if (n == 0) return;
        int k = amount % n;
        if (k == 0) return;

        var tail = data.GetRange(n - k, k);
        var head = data.GetRange(0, n - k);

        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
}
