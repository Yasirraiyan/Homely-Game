public class House
{
    public double length;
    public double breadth;
    public string roomtype;
    public double lengthofbedroom;
    public double breadthofbedroom;
    public double lengthofkitchen;
    public double breadthofkitchen;
    public double lengthofveranda;
    public double breadthofveranda;
    public double lengthoftoilet;
    public double breadthoftoilet;
    public int windows;
    public int doors;
    public bool windowscondition = false;
    public bool doorscondition = false;
    public int x;
    public int y;
    public bool furniturecondition = false;
    public House(double length, double breadth, string roomtype, double lengthofbedroom, double breadthofbedroom, double lengthofkitchen, double breadthofkitchen, double lengthofveranda, double breadthofveranda, double lengthoftoilet, double breadthoftoilet, int windows, int doors, bool windowscondition, bool doorscondition, int x, int y, bool furniturecondition)
    {
        this.length = length;
        this.breadth = breadth;
        this.roomtype = roomtype;
        this.lengthofbedroom = lengthofbedroom;
        this.breadthofbedroom = breadthofbedroom;
        this.lengthofkitchen = lengthofkitchen;
        this.breadthofkitchen = breadthofkitchen;
        this.lengthofveranda = lengthofveranda;
        this.breadthofveranda = breadthofveranda;
        this.lengthoftoilet = lengthoftoilet;
        this.breadthoftoilet = breadthoftoilet;
        this.windows = windows;
        this.doors = doors;
        this.windowscondition = windowscondition;
        this.doorscondition = doorscondition;
        this.x = x;
        this.y = y;
        this.furniturecondition = furniturecondition;
    }
    public (double,double) checklengthvalidity(double length,double breadth)
    {
        if (length>0&&breadth>0)
        {
            Console.WriteLine("The components are valid");
        }
        else
        {
            Console.WriteLine("The components are invalid");
        }
        return (length, breadth);   
    }
    public double getareaofhouse(double length, double breadth)
    {
        double area = length * breadth;
        return area;
    }

    public string getroomtype(string roomtype)
    {
        switch (roomtype.ToLower())
        {
            case "bedroom":
                Console.WriteLine("The roomtype is bedroom.");
                break;
            case "kitchen":
                Console.WriteLine("The roomtype is kitchen.");
                break;
            case "toilet":
                Console.WriteLine("The roomtype is toilet.");
                break;
            case "veranda":
                Console.WriteLine("The roomtype is veranda.");
                break;
            default:
                Console.WriteLine("Invalid room type.");
                break;
        }
        return roomtype;
    }

    public double getareaofbedroom(double lengthofbedroom, double breadthofbedroom)
    {
        double areaofbedrooom = lengthofbedroom * breadthofbedroom;
        Console.WriteLine($"The area of bedroom is: {areaofbedrooom}");
        return areaofbedrooom;
    }
    public (double,double) checkbedroom(double lengthofbedroom, double breadthofbedroom)
    {
        if (lengthofbedroom > 0 && breadthofbedroom > 0)
        {
            Console.WriteLine($"The room is valid.The length of bedrrom is:{lengthofbedroom}.The breadth of bedroom is:{breadthofbedroom}");
        }
        else
        {
            Console.WriteLine("The room is invalid!");
        }
        return (lengthofbedroom, breadthofbedroom);
    }
    public (double, double) checkkitchen(double lengthofkitchen, double breadthofkitchen)
    {
        if (lengthofkitchen > 0 && breadthofkitchen > 0)
        {
            Console.WriteLine($"The kitchen is valid.The length of bedrrom is:{lengthofkitchen}.The breadth of kitchen is:{breadthofkitchen}");
        }
        else
        {
            Console.WriteLine("The kitchen is invalid!");
        }
        return (lengthofkitchen, breadthofkitchen);
    }
    public (double, double) checkveranda(double lengthofveranda, double breadthofveranda)
    {
        if (lengthofveranda > 0 && breadthofveranda > 0)
        {
            Console.WriteLine($"The veranda is valid.The length of veranda is:{lengthofveranda}.The breadth of veranda is:{breadthofveranda}");
        }
        else
        {
            Console.WriteLine("The veranda is invalid!");
        }
        return (lengthofveranda, breadthofveranda);
    }
    public (double, double) checktoilet(double lengthoftoilet, double breadthoftoilet)
    {
        if (lengthoftoilet > 0 && breadthoftoilet > 0)
        {
            Console.WriteLine($"The toilet is valid.The length of toilet is:{lengthoftoilet}.The breadth of toilet is:{breadthoftoilet}");
        }
        else
        {
            Console.WriteLine("The toilet is invalid!");
        }
        return (lengthoftoilet, breadthoftoilet);
    }


    public double getareaofkitchen(double lengthofkitchen, double breadthofkitchen)
    {
        
            double areaofkitchen = lengthofkitchen * breadthofkitchen;
            Console.WriteLine($"The area of kitchen is: {areaofkitchen}");
        
        return areaofkitchen;
    }

    public double getareaofveranda(double lengthofveranda, double breadthofveranda)
    {
        double areaofveranda = lengthofveranda * breadthofveranda;
        Console.WriteLine($"The area of veranda is: {areaofveranda}");
        return areaofveranda;
    }

    public double getareaoftoilet(double lengthoftoilet, double breadthoftoilet)
    {
        double areaoftoilet = lengthoftoilet * breadthoftoilet;
        Console.WriteLine($"The area of toilet is: {areaoftoilet}");
        return areaoftoilet;
    }

    public void checkarea(double length, double breadth, double lengthofbedroom, double breadthofbedroom,
                          double lengthofkitchen, double breadthofkitchen, double lengthofveranda, double breadthofveranda,
                          double lengthoftoilet, double breadthoftoilet)
    {
        double area = length * breadth;
        double areaofbedrooom = lengthofbedroom * breadthofbedroom;
        double areaofkitchen = lengthofkitchen * breadthofkitchen;
        double areaofveranda = lengthofveranda * breadthofveranda;
        double areaoftoilet = lengthoftoilet * breadthoftoilet;
        double totalareaofhouse = areaofbedrooom + areaofkitchen + areaofveranda + areaoftoilet;

        if (area == totalareaofhouse)
        {
            Console.WriteLine("It is a perfect house.");
        }
        else
        {
            Console.WriteLine("It is not a perfect house.");
        }
    }

    public void getcolor(string roomtype)
    {
        switch (roomtype.ToLower())
        {
            case "kitchen":
                Console.WriteLine("The color of the kitchen is green.");
                break;
            case "bedroom":
                Console.WriteLine("The color of the bedroom is blue.");
                break;
            case "toilet":
                Console.WriteLine("The color of the toilet is white.");
                break;
            case "veranda":
                Console.WriteLine("The color of the veranda is violet.");
                break;
            default:
                Console.WriteLine("Invalid room type for color.");
                break;
        }
    }

    public (bool, bool) getconditionofcomponent(bool windowscondition, bool doorscondition)
    {
        if (!windowscondition && !doorscondition)
        {
            Console.WriteLine("Windows and doors are open.");
        }
        else if (windowscondition && !doorscondition)
        {
            Console.WriteLine("Windows are closed and doors are open.");
        }
        else if (!windowscondition && doorscondition)
        {
            Console.WriteLine("Windows are open and doors are closed.");
        }
        else
        {
            Console.WriteLine("Windows and doors are both closed.");
        }
        return (windowscondition, doorscondition);
    }

    public (int, int) getpositionofpersonin2-D-System(int x, int y)
    {
        Console.WriteLine($"The present location of the person is: {x}, {y}");

        if (x == 0 && y == 0)
        {
            Console.WriteLine($"The current location is at the center. The location is: {x}, {y}");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine($"The current location is in the 1st quadrant. The location is: {x}, {y}");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"The current location is in the 2nd quadrant. The location is: {x}, {y}");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"The current location is in the 3rd quadrant. The location is: {x}, {y}");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"The current location is in the 4th quadrant. The location is: {x}, {y}");
        }
        else if (x > 0 && y == 0)
        {
            Console.WriteLine($"The current location is on the positive side of the x-axis. The location is: {x}, {y}");
        }
        else if (x < 0 && y == 0)
        {
            Console.WriteLine($"The current location is on the negative side of the x-axis. The location is: {x}, {y}");
        }
        else if (x == 0 && y > 0)
        {
            Console.WriteLine($"The current location is on the positive side of the y-axis. The location is: {x}, {y}");
        }
        else if (x == 0 && y < 0)
        {
            Console.WriteLine($"The current location is on the negative side of the y-axis. The location is: {x}, {y}");
        }
        return (x, y);
    }
    public (int,int,int) getpisitionofpersonin3-Dcoordinates(int x,int y,int z)
    {
        Console.WriteLine($"The present location of person in 3-D coordinates is in:{x,y,z}");
        return(x,y,z);
    }
    public void gettypeoffurniture(bool furniturecondition)
    {
        if (!furniturecondition)
        {
            Console.WriteLine("The furniture is unlock.");
        }
        else
        {
            Console.WriteLine("The furniture is locked.");
        }
    }
}
