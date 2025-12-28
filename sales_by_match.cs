// There is a large pile of socks that must be paired by color. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

// Example


// There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .

// Function Description

// Complete the sockMerchant function in the editor below.

// sockMerchant has the following parameter(s):

// int n: the number of socks in the pile
// int ar[n]: the colors of each sock
// Returns

// int: the number of pairs
// Input Format

// The first line contains an integer , the number of socks represented in .
// The second line contains  space-separated integers, , the colors of the socks in the pile.

// Constraints

//  where 
// Sample Input

// STDIN                       Function
// -----                       --------
// 9                           n = 9
// 10 20 20 10 10 30 50 10 20  ar = [10, 20, 20, 10, 10, 30, 50, 10, 20]
// Sample Output

// 3
// Explanation

// sock.png

// There are three pairs of socks.

class Result
{
    public static int sockMerchant(int n, List<int> ar)
    {
        List<int> ar2 = ar.Order().ToList();
        int counter = 0;
        int counter2 = 1;
        int result = 0;
        int first = ar2[0];

        foreach (int item in ar2)
        {
            if (first != item)
            {
                if (counter != 0 && counter % 2 == 0)
                {
                    result += counter / 2;
                }
                else if (counter != 0 && counter % 2 != 0)
                {
                    counter -= 1;
                    result += counter / 2;
                }
                first = item;
                counter = 0;
            }

            if (first == item)
            {
                counter++;
            }
            counter2++;
        }

        if (counter != 0 && counter % 2 == 0)
        {
            result += counter / 2;
        }
        else if (counter != 0 && counter % 2 != 0)
        {
            counter -= 1;
            result += counter / 2;
        }

        return result;
    }
}