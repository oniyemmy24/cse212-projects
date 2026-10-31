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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

         // STEP 1: Receive the starting number and number of multiples.

        // STEP 2: Create an array to store the multiples.
        double[] multiples = new double[length];

        // STEP 3: Loop through each position in the array.
        for (int i = 0; i < length; i++) {

            // STEP 4: Calculate each multiple.
            multiples[i] = number * (i + 1);
        }

        // STEP 5: Return the completed array.
        return multiples;

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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // STEP 1: Get the number of elements in the list.
        int count = data.Count;

        // STEP 2: Calculate where the last elements begin.
        int splitPosition = count - amount;

        // STEP 3: Copy the last 'amount' elements.
        List<int> lastElements = data.GetRange(splitPosition, amount);

        // STEP 4: Copy the remaining elements.
        List<int> firstElements = data.GetRange(0, splitPosition);

        // STEP 5: Clear the original list.
        data.Clear();

        // STEP 6: Add the last elements first.
        data.AddRange(lastElements);

        // STEP 7: Add the remaining elements.
        data.AddRange(firstElements);
   }

}
