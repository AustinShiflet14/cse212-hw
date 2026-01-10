using System;
using System.Collections.Generic;
using System.Diagnostics;

public static class Arrays
{
    // Part 1: MultiplesOf
    public static double[] MultiplesOf(double start, int count)
    {
        //make an array that can hold count numbers
        double[] result = new double[count];

        //loop through the array and fill it with multiples
        for (int i = 0; i < count; i++)
        {
            //each element should be start times (i+1) so it counts correctly
            result[i] = start * (i + 1);
        }

        // done filling the array, return it
        return result;
    }

    // Part 2: RotateListRight
    public static void RotateListRight(List<int> data, int amount)
    {
        // first get how many elements are in the list
        int size = data.Count;

        // if the amount is 0 or the same as the size, don't do anything
        if (amount <= 0 || amount == size)
        {
            return;
        }

        // get the last amount elements, this will move to the front
        List<int> lastPart = data.GetRange(size - amount, amount);

        // get the first part of the list that will go after
        List<int> firstPart = data.GetRange(0, size - amount);

        // clear the original list so we can rebuild it
        data.Clear();

        // add the last part first
        data.AddRange(lastPart);

        // then add the first part
        data.AddRange(firstPart);

        // list should be rotated now
    }
}
