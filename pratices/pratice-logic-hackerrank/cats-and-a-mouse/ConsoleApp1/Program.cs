
class Solution
{

    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z)
    {
        string result = "";
        int catA = Math.Abs(x - z);
        int catB = Math.Abs(y - z);

        if (catA < catB)
        {
            result = "Cat A";
        }
        else if (catB < catA)
        {

            result = "Cat B";
        }
        else
        {
            result = "Mouse C";
        }

        return result;

    }
}