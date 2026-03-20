public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        if((IsIsosceles(side1,side2,side3) || IsEquilateral(side1,side2,side3)) || !isTriangle(side1,side2,side3))
        {
            return false;
        }
        else return true;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if((side1 == side2 || side2 == side3 || side3 == side1) && isTriangle(side1,side2,side3))
        {
            return true;
        }
        else return false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
       if(side1 == side2 && side2 == side3 && isTriangle(side1,side2,side3))
        {
            return true;
        }
        else return false;
    }

    public static bool isTriangle(double side1, double side2, double side3)
    {
        if(side1 > 0 && side2 > 0 && side3 > 0)
        {
            if(side1 + side2 >= side3 && side2 + side3 >= side1 && side3 + side1 >= side2)
            {
                return true;
            }
            else return false;
            
        }
        else return false;
    }
}