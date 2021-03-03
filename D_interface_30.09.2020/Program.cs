using System;


interface IPart
{
   void Part();

}


class Basement:IPart
{
   protected string basement;

    public Basement()
    {
        basement = "======================";
    }

    public string Get_bassement { get;}


    public void  Part()
    {
        Console.Write(basement);

    }

 
}



class  Wall:IPart
{
    string wall;
    public Wall()
    {
        wall = "|                    |\n";
        for (int i = 0; i < 3; i++)
        {
            wall += wall;
        }

    }



    public void Part ()
    {
        Console.Write(wall);

    }

}

class Door:IPart
{
    string door;

    public Door()
    {
        door = "|                    |\n|                    |\n|        ___         |\n|       |   |        |\n|       |  *|        |\n|       |   |        |\n";
             
    }

    public void  Part()
    {
        Console.Write(door);

    }

}

class Window:IPart
{
    string window;

    public Window()
    {
        window = "|                    |\n|  ___          ___  |\n|  |||   ___    |||  |\n|  ---  |   |   ---  |\n|       |  *|        |\n|       |   |        |";
    }

    public void Part()
    {
        Console.WriteLine(window);
    }

  
}

class Roof:IPart
{
    string roof;

    public Roof()
    {
        roof = "              ___ \n    __________| |_\n   /              \\\n  /                \\\n /                  \\\n|--------------------|";

    }

    public void Part()
    {
        Console.WriteLine(roof);
    }

  
}

class House
{
    Basement basement1;
    bool basement_exist;
    Wall Wall1;
    bool wall_exist;
    Door Door1;
    bool door_exist;
    Window window1;
    bool window_exist;
    Roof roof1;
    bool roof_exist;

    public House()
    {
        basement_exist = false;
        wall_exist = false;
        door_exist = false;
        window_exist = false;
        roof_exist = false;
    }
    //фундамент
    public void SetBasement() 
    {
        basement1 =  new Basement();
        basement_exist = true;

    }

    public bool Exist_bassement()
    {
        return basement_exist;
    }

    public Basement GetBasement()
    {
        return basement1;
    }

    //стены
    public void SetWall()
    {
        Wall1 = new Wall();
        wall_exist = true;

    }

    public bool Exist_wall()
    {
        return wall_exist;
    }

    public Wall Getwall()
    {
        return Wall1;
    }
    //двери 
    public void SetDoor()
    {
        Door1 = new Door();
        door_exist = true;

    }

    public bool Exist_door()
    {
        return door_exist;
    }

    public Door GetDoor()
    {
        return Door1;
    }
    //окна
    public void SetWindow()
    {
        window1 = new Window();
        window_exist = true;

    }

    public bool Exist_window()
    {
        return window_exist;
    }

    public Window GetWindow()
    {
        return window1;
    }
    //крыша
    public void SetRoof()
    {
        roof1 = new Roof();
        roof_exist = true;

    }

    public bool Exist_roof()
    {
        return roof_exist;
    }

    public Roof GetRoof()
    {
        return roof1;
    }

    public void Hous_end()
    {
        if (basement1 != null && Wall1 != null && roof1 != null)
        {
            roof1.Part();
            window1.Part();
            basement1.Part();
        }
        else
        {
            Console.WriteLine("Ошибка строительства нет ни одного построеного элемента дома ");
        }
    }

}

class Builders
{
    House house;

    public Builders()
    {
        house = new House();
    }

    public void Begin_build_hous()
    {

        if (house.Exist_bassement()==false)
        {
            house.SetBasement();

            house.GetBasement().Part();
            Console.WriteLine("\nПостроен фундамент\n\n");
        }
        //если есть фундамент строим стены
        else if (house.Exist_wall()==false && house.Exist_bassement()==true)
        {
            house.SetWall();
          
            house.Getwall().Part();
            house.GetBasement().Part();
            Console.WriteLine("\nПостроен фундамент и стены\n\n");
        }
        //если есть фундамент и сетны строим двери
        else if(house.Exist_wall() == true && house.Exist_bassement() == true && house.Exist_door()==false)
        {
            house.SetDoor();
            house.GetDoor().Part();
            house.GetBasement().Part();
            Console.WriteLine("\nПостроен фундамент,стены,и двери\n\n");
        }
        //если есть фундамент, стены,двери, строим окна
        else if (house.Exist_wall() == true && house.Exist_bassement() == true && house.Exist_door() == true && house.Exist_window()==false)
        {
            house.SetWindow();
            house.GetWindow().Part();
            house.GetBasement().Part();
            Console.WriteLine("\nПостроен фундамент,стены,двери и окна\n\n");
        }
        else if (house.Exist_wall() == true && house.Exist_bassement() == true && house.Exist_door() == true && house.Exist_window() == true && house.Exist_roof()==false)
        {
            house.SetRoof();
            house.Hous_end();
            Console.WriteLine("\nКрыша поосроена.");
            Console.WriteLine("Строительство дома заершено.");
            Console.WriteLine("\n\n\t\t\t THE END.");
        }

    }



}

namespace D_interface_30._09._2020
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Builders builders1 = new Builders();
            builders1.Begin_build_hous();
       

            Console.WriteLine("Строительство дома переданно другой бригаде");
            Builders builders2 = new Builders();
            builders2 = builders1;
            builders2.Begin_build_hous();

            Console.WriteLine("Строительство дома переданно другой бригаде");
            Builders builders3 = new Builders();
            builders3 = builders2;
            builders3.Begin_build_hous();

            Console.WriteLine("Строительство дома переданно другой бригаде");
            Builders builders4 = new Builders();
            builders4 = builders3;
            builders4.Begin_build_hous();

            Console.WriteLine("Строительство дома переданно другой бригаде");
            Builders builders5 = new Builders();
            builders5 = builders4;
            builders5.Begin_build_hous();
        }
    }
}
