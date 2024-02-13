using System.Globalization;

namespace DEMO;

public class program
{
    static void Main(string[] args)
    {
        #region events

        Ball ball = new Ball();

        Player P01 = new Player() { Name = "Messi", Team = "Miami" };
        Player P02 = new Player() { Name = "CR7", Team = "Alnassr" };

        Player P03 = new Player() { Name = "Nymar", Team = "Alhilal" };

        Player P04 = new Player() { Name = "Salah", Team = "Liverpool" };

        Referee referee = new Referee() { Name = "Ibrahim Nour Eldeen" };

        ball.OnLocationChanged += P01.Run;
        ball.OnLocationChanged += P02.Run;
        ball.OnLocationChanged += P03.Run;
        ball.OnLocationChanged += P04.Run;

        ball.OnLocationChanged += referee.Look;

        ball.BallLocation = new Location() { X = 10, Y = 20, Z = 30 };

        #endregion


        #region Implicitely typed local variable [var,dynamic]

       // var data = 22;
        //Compiler will detect variable datatype based on its initial value at compilation time
        //must be initialized
        //can not be initialized to null
        //After its initialization you can't change its datatype
        //    data = "Ahmed";

        dynamic data = 10;
        //Compiler will detect variable datatype based on its last value at Run time
        //not neccessary to be initialized
        //can be initialized by null
        //you can change its datatype after initialization


        #endregion

        #region Extension methods
        int x = 123456;
       int rev= x.Reverse();
        Console.WriteLine( rev);
        #endregion

        #region LINQ Introduction ==>Language integrated Query
        // +40 Extension methods (Class that implements the IEnumerable Interface)
        // [Query Operators] Existing at Enumerable class and categorized in 13 category

        //LINQ Operators can be used against any data sequence
        //Sequence==> Any class implementing IEnumerable==>List Array Dictionary
        //1. Local sequence 
        //2. Remote sequence 
        #endregion

        List<int> list = new List<int>() { 1 ,2,3,4,5,6,7};

        #region LINQ Syntax
        //1. Fluent Syntax
        //1.1 Calling LINQ Method as static method through Enuerable class
        var result = Enumerable.Where(list, (num) => num % 2 == 0);

        //1.2 Calling LINQ Method as extension method
        result=list.Where((num) => num % 2 == 0);


        //2 Query Syntax [Query Expression]=> Like SQL Query style 
        //start with from introducing range variable : representing each element at sequence
        //end with select or group by

        result=from num in list
               where num%2==0
               select num;

        #endregion

        #region LINQ Excution
        //1. Deffered excution=> Latest update of data
        //All LINQ Operators except => Element, Aggregate, Casting Operators
        //result = list.Where((num) => num % 2 == 0);

        //list.Remove(2);
        //list.AddRange(new int[] { 8, 9, 10, 11, 12, 13, 14 });

        //foreach (var num in list)
        //{
        //    Console.WriteLine(num);
        //}

        //2. Immdeiate Excution
        result = list.Where((num) => num % 2 == 0).ToList(); //turned into immediate excution

        list.Remove(2);
        list.AddRange(new int[] { 8, 9, 10, 11, 12, 13, 14 });

        foreach (var num in list)
        {
            Console.WriteLine(num);
        }
        #endregion

    }
}