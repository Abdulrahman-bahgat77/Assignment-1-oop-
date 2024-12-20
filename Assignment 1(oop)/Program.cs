namespace Assignment_1_oop_
{
    #region Q1
    //enum weekdays
    //{
    //    staurday,
    //    sunday,
    //    monday,
    //    tuesday,
    //    wednesday,
    //    thursday,
    //    friday
    //}

    #endregion

    #region Q2
    //struct person
    //{
    //    public string name { get; set; }
    //    public int age { get; set; }

    //    public person(string _name, int _age)
    //    {
    //        name = _name;
    //        age = _age;

    //    }
    //    public override string ToString()
    //    {
    //        return $"name:{name} \n age:{age}";
    //    }
    //}
    #endregion

    #region Q3
    //enum seasons
    //{
    //    winter,summer,autumn,spring
    //}

    #endregion

    #region Q4
    //[Flags]
    //enum permession
    //{
    //    Read = 1, write = 2, Delete = 4, Execute = 8, Add = 16
    //}
    #endregion

    #region Q5
    //enum colors
    //{
    //    red,green,blue
    //}
    #endregion

    #region Q6
    //struct point  {
    //    public int x { get; set; }
    //    public int y { get; set; }
    //     public point(int x, int y)
    //    {
    //        x = x;
    //        y = y;
    //    }
    //    public override string ToString()
    //    {
    //        return $"x={x} \n y={y}";
    //    }
    //}

    #endregion

    #region Q7
    //struct person
    //{
    //    public string name { get; set; }
    //    public int age { get; set; }

    //    public person(string _name, int _age)
    //    {
    //        name = _name;
    //        age = _age;

    //    }
    //    public override string ToString()
    //    {
    //        return $"name:{name} \n age:{age}";
    //    }
    //}
    #endregion
    internal class Program
    {
        #region Q6
        //static point creationOfPoint(){
        //    point point = new point();
        //   Console.WriteLine("x: ");
        //    point.x = int.Parse(Console.ReadLine());
        //    Console.WriteLine("y: ");
        //    point.y = int.Parse(Console.ReadLine());
        //    return point ;
        //}
        //static double result(point p1,point p2)
        //{
        //    return Math.Sqrt(Math.Pow(p1.x-p2.x,2) + Math.Pow(p1.y-p2.y,2));
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //foreach (var item in Enum.GetValues(typeof(weekdays))) {
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2
            //person[] persons = {

            //  new person("abdo", 22),
            // new person("bahjat", 22),
            //  new person("mohammed", 23),
            //};

            //foreach (var person in persons)
            //{
            //    Console.WriteLine(person);
            //}

            #endregion

            #region Q3
            //   Console.WriteLine("enter season");
            //string input= Console.ReadLine();
            //   seasons season;
            //   if (Enum.TryParse( input, out season)) {
            //       switch (season)
            //       {
            //           case seasons.winter:
            //               Console.WriteLine("winter December to February");
            //               break;
            //           case seasons.summer:
            //               Console.WriteLine("summer june to august");
            //               break;
            //           case seasons.spring:
            //               Console.WriteLine("spring march to may ");
            //               break;
            //           case seasons.autumn:
            //               Console.WriteLine("autumn September to November ");
            //               break;
            //           default:
            //               Console.WriteLine("please enter valid season");
            //               break;

            //       }
            //   }
            #endregion

            #region Q4
            //permession permessions = permession.Read;
            //Console.WriteLine(permessions);
            //  permessions =  permessions ^ permession.Add;
            //permessions = permessions | permession.write;
            //Console.WriteLine(permessions);
            //permessions = permessions ^ permession.Add;
            //Console.WriteLine(permessions);
            //if ((permessions & permession.Execute)== permession.Execute){
            //    Console.WriteLine("Excute is exist");
            //}
            //else
            //{
            //    Console.WriteLine("excute not exist and will added");
            //    permessions = permessions ^ permession.Execute;
            //    Console.WriteLine(permessions);
            //}
            #endregion

            #region Q5
            //  Console.WriteLine("enter color");
            //  string input=Console.ReadLine();
            //  colors color;
            //if(Enum.TryParse(input,out color))
            //  {
            //      Console.WriteLine("primary color");
            //  }
            //  else
            //  {
            //      Console.WriteLine("not primary");
            //  }
            #endregion

            #region Q6
            // Console.WriteLine("enter first point");
            //point p1=creationOfPoint();
            // Console.WriteLine("enter second point");
            // point p2=creationOfPoint();
            // Console.WriteLine($"distance ={result(p1,p2)}");
            #endregion

            #region Q7
            //person[] people = new person[3];
            //for(int i = 0; i < 3; i++)
            //{
            //    string name;
            //    do
            //    {
            //        Console.WriteLine($"enter user{i+1} name");
            //        name = Console.ReadLine();
            //    }while(string.IsNullOrWhiteSpace(name));
            //    people[i].name = name;
            //    int age;
            //    bool flag;
            //    do
            //    {
            //        Console.WriteLine($"enter user{i + 1} age");
            //        flag = int.TryParse(Console.ReadLine(), out age);
            //    } while (!flag);
            //    people[i].age = age;
            //}
            //person old=people[0];
            //for (int i = 0; i < 3; i++)
            //{
            //    if(old.age<people[i].age)
            //        old = people[i];
            //}
            //Console.WriteLine(old);
            #endregion

        }
    }
}
