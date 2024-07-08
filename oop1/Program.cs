namespace oop1
{
    internal class Program
    {
        public enum WeekDays : int
        {
            sunday, monday, tuesday, wednesday, thursday, friday, saturday


        }

        [Flags]
        public enum Season 
        {
            spring=1,summer,autumn,winter
            

        }

        [Flags]
        public enum Permission:byte
        {
            read =1,write =2,delete=4,execute=8

        }
        
        public enum Colors
        {


            red =1, green, blue
        }


        public struct Point
        { 
            public double x ;
            public double y;
        


        }

        static void Main(string[] args)
        {
            #region Q1
            //foreach (WeekDays days in Enum.GetValues(typeof(WeekDays)))
            //{

            //    Console.WriteLine(days);


            //}


            #endregion



            #region Q2

            // Console.WriteLine("input season");
            //Enum.TryParse(typeof(Season),Console.ReadLine().ToLower(),true,out object? s);
            // Season? ss = (Season?)s;

            // if (ss == (Season)1)
            // {

            //     Console.WriteLine($"{ss } From March to May ");
            // }
            // else if (ss == (Season)2) 
            // {

            //     Console.WriteLine($"{ss} From June to August ");
            // }
            // else if (ss == (Season)3) 
            // {
            //     Console.WriteLine($"{ss} From September to Novamber ");
            // }
            // else if (ss == (Season)4)
            // {

            //     Console.WriteLine($"{ss } From December to Fabruary ");
            // }
            // else { Console.WriteLine("out of Seacon"); }






            #endregion

            #region Q3

           // Permission permissions = (Permission)4;
           //permissions |= Permission.write; //Add
           //permissions ^= Permission.delete; // Remove 
            
           // Console.WriteLine(permissions = permissions | Permission.delete);  //Check
           // Console.WriteLine(permissions);    


           // Console.WriteLine();







            #endregion

            #region Q4


            //Console.WriteLine("input color");
            //Enum.TryParse(typeof(Colors), Console.ReadLine().ToLower(), true, out object? s);
            //Colors? ss = (Colors?)s;

            //if (ss == (Colors)1)
            //{

            //    Console.WriteLine($"{ss} Is Primary Color (:");
            //}
            //else if (ss == (Colors)2)
            //{

            //    Console.WriteLine($"{ss} Is Primary Color (:");
            //}
            //else if (ss == (Colors)3)
            //{
            //    Console.WriteLine($"{ss} Is Primary Color (:  ");
            //}

            //else { Console.WriteLine($" {ss} Is Not Primary Color :( "); }
            #endregion

            #region Q5
            //Point Point = new ();
            //Console.WriteLine("first");
            //Point.x = double.Parse(Console.ReadLine()); 
            //Console.WriteLine("second");
            //Point.y = double.Parse(Console.ReadLine()); 
            //Console.WriteLine(Math.Sqrt((Point.x-Point.x)*2+ (Point.y - Point.y) *2));


            #endregion


        }
    }
}
