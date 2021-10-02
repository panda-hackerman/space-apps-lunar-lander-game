using System.Collections.Generic;
using UnityEngine;

public static class AdvMath
{
    //Clamps rotation using Euler angles
    public static float ClampEuler(this float value, float min, float max, float middle = 180)
    {
        if (value < middle)
        {
            if (value > max)
                return max;
            else
                return value;
        }
        else
        {
            float n = value - 360;

            if (n < min)
                return min;
            else
                return value;
        }
    }

    //Shuffles and array into a random order using Random.Range pseudorandom number generation
    public static T[] ShuffleArray<T>(this T[] inputArray)
    {
        int count = inputArray.Length;
        int last = count - 1;

        T[] outputArray = new T[count];
        inputArray.CopyTo(outputArray, 0);

        if (count < 2) //If the value is 1 or 0, the list won't change anyway
            return outputArray;

        for (int i = 0; i < last; ++i)
        {
            int r = Random.Range(i, count);
            T temp = inputArray[i];

            outputArray[i] = outputArray[r];
            outputArray[r] = temp;
        }

        return outputArray;
    }

    //Same as above Shuffle Array but with a list
    public static List<T> ShuffleList<T>(this List<T> inputList)
    {
        int count = inputList.Count;
        int last = count - 1;

        T[] outputArray = new T[count];
        inputList.CopyTo(outputArray, 0);

        if (count < 2)
            return new List<T>(outputArray);

        for (int i = 0; i < last; ++i)
        {
            int r = Random.Range(i, count);
            T temp = inputList[i];

            outputArray[i] = outputArray[r];
            outputArray[r] = temp;
        }

        return new List<T>(outputArray);
    }

    #region Roulette
    //Random with weighted probability, using an Array of doubles
    /*Usage: int prefabNum = Roulette(weights)
             Instatiate(prefabList[prefabNum])*/
    public static int Roulette(double[] weights)
    {
        double totalWeight = 0;

        foreach (double item in weights)
        {
            totalWeight += item;
        }

        double randomPoint = Random.value * totalWeight;

        for (int i = 0; i < weights.Length; i++)
        {
            if (randomPoint < weights[i])
                return i;
            else
                randomPoint -= weights[i];
        }

        return weights.Length - 1;
    }

    //Same thing but with ints instead of a double
    public static int Roulette(int[] weights)
    {
        int totalWeight = 0;

        foreach (int item in weights)
        {
            totalWeight += item;
        }

        double randomPoint = Random.value * totalWeight;

        for (int i = 0; i < weights.Length; i++)
        {
            if (randomPoint < weights[i])
                return i;
            else
                randomPoint -= weights[i];
        }

        return weights.Length - 1;
    }
    #endregion

    #region Give or take
    //Add or take a little from a variable
    /*Usage: float someVariable = 20.GiveOrTake(3);
     returns a float from 17 to 23*/

    public static float GiveOrTake(this float f, float n)
    {
        f += Random.Range(-n, n);
        return f;
    }

    public static int GiveOrTake(this int i, int n)
    {
        i += Random.Range(-n, n);
        return i;
    }
    #endregion

    #region Vector math
    //Change a single variable in a Vector3
    //Usage: transform.position = transform.position.X(1);

    public static Vector3 X(this Vector3 v, float x)
    {
        v.x = x;
        return v;
    }

    public static Vector3 Y(this Vector3 v, float y)
    {
        v.y = y;
        return v;
    }

    public static Vector3 Z(this Vector3 v, float z)
    {
        v.z = z;
        return v;
    }

    //In a Vector2
    public static Vector2 X(this Vector2 v, float x)
    {
        v.x = x;
        return v;
    }

    public static Vector2 Y(this Vector2 v, float y)
    {
        v.y = y;
        return v;
    }
    #endregion

    #region CURVES

    //Use points to create a curve and returns a point on that curve (based on t)
    //2 point formula would be equivelent to linear interpolation

    public static Vector3 Bezier(float t, Vector3 p0, Vector3 p1, Vector3 p2) //Quadratic bezier formula based on 3 points
    {
        //B(t) = (1-t)^2 * P0 + 2(1-t) * t * P1 + t^2 * P2

        float u = 1 - t;    //(1-t)
        float tt = t * t;   //t^2
        float uu = u * u;   //u^2 | (1-t)^2

        Vector3 p = uu * p0; //B(t) = (1-t)^2 * P0
        p += 2 * u * t * p1; //+ 2(1 - t) * t * P1
        p += tt * p2;        //+ t^2 * P2

        return p;
    }

    public static Vector3 Bezier(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) //Cubic bezier formula based on 4 points
    {
        //B(t) = (1-t)^3 * P0 + 3(1-t)^2 * t * P1 + 3(1-t)t^2 * P2 + t^3 * P3

        float u = 1 - t;    //(1-t)
        float tt = t * t;   //t^2
        float uu = u * u;   //u^2 | (1-t)^2
        float uuu = uu * u; //u^3 | (1-t)^3
        float ttt = tt * t; //t^3

        Vector3 p = uuu * p0; //B(t) = (1-t)^3 * P0
        p += 3 * uu * t * p1; //+ 3(1-t)^2 * t * P1
        p += 3 * u * tt * p2; //+ 3(1-t) * t^2 * P2
        p += ttt * p3;        //+ t^3 * P3

        return p;
    }

    #endregion
}