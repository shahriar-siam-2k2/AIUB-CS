using System;

namespace JaggedArrayOutputTracing1
{
    class Course
    {
        int courseId;
        string title;
        int[][] scores;

        public Course()
        {
            courseId = 0;
            title = "Undefined";

            scores = new int[3][];
            scores[0] = new int[] { 10, 20 };
            scores[1] = new int[] { 30, 40, 50 };
            scores[2] = new int[] { 60 };
        }

        public Course(int id) : this()
        {
            courseId = id;
        }

        internal Course(int id, string t) : this(id)
        {
            title = t;
        }

        internal Course(int id, string t, int size) : this(id, t)
        {
            scores = new int[size][];
            for (int i = 0; i < size; i++)
            {
                scores[i] = new int[i + 2];
                for (int j = 0; j < scores[i].Length; j++)
                {
                    scores[i][j] = (i + 1) * (j + 1) * 5;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine(courseId + " " + title);

            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = 0; j < scores[i].Length; j++)
                {
                    Console.Write(scores[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Course c = new Course(202, "Programming", 4);
            c.Display();
        }
    }
}

/*
    An IT company is willing to have their employee information in a console-based system. For this, they asked to build a simple console-based application which will have two basic employee types: FullTime and PartTime.
    All the employees have id, name, salary and joining date.
    FullTime employee will have bonus which is 2% of their salary.
    PartTime employee will have commission which is 5% of their salary.
    There will be a ShowInfo() method which will provide all the information for each employee.
    There will be a GrossIncome() method for each type of employee:
    For FullTime, it will calculate 12 months salary + 2 bonus per year
    For PartTime, it will calculate monthly salary + commission
 */

namespace EmployeeSystem
{
    // Base Class
    public class Employee
    {
        private string id;
        private string name;
        private double salary;
        private string joiningDate;

        // Properties
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string JoiningDate
        {
            get { return joiningDate; }
            set { joiningDate = value; }
        }

        // Constructor
        public Employee(string id, string name, double salary, string date)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.joiningDate = date;
        }

        // Virtual Method
        public virtual void GrossIncome()
        {
            Console.WriteLine("No income calculation");
        }

        // Show Info
        public void ShowInfo()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Joining Date: " + joiningDate);

            GrossIncome(); // IMPORTANT
        }
    }

    // FullTime Class
    public class FullTime : Employee
    {
        public double bonus;

        public FullTime(string id, string name, double salary, string date) : base(id, name, salary, date)
        {
            bonus = salary * 0.02;
        }

        public override void GrossIncome()
        {
            double total = (Salary * 12) + (bonus * 2);
            Console.WriteLine("FullTime Gross Income: " + total);
        }
    }

    // PartTime Class
    public class PartTime : Employee
    {
        public double commission;

        public PartTime(string id, string name, double salary, string date) : base(id, name, salary, date)
        {
            commission = salary * 0.05;
        }

        public override void GrossIncome()
        {
            double total = Salary + commission;
            Console.WriteLine("PartTime Gross Income: " + total);
        }
    }

    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[2];

            emp[0] = new FullTime("E-1", "Rahim", 50000, "01-01-2022");
            emp[1] = new PartTime("E-2", "Karim", 20000, "05-03-2023");


            foreach (Employee e in emp)
            {
                e.ShowInfo();
                Console.WriteLine();
            }

            //FullTime fullTime = new FullTime("E-1", "Rahim", 50000, "01-01-2022");
            //PartTime partTime = new PartTime("E-2", "Karim", 20000, "05-03-2023");
            //PartTime partTime = new PartTime("E-2", "Karim", 20000, "05-03-2023");

            //fullTime.ShowInfo();
            //Console.WriteLine();
            //partTime.ShowInfo();
        }
    }
}

namespace siam
{
    public class Car // Type
    {
        // Static Member
        public static int TotalCarsProduced = 0;

        // Instance Member
        public string Color;

        // Empty Constructor
        public Car()
        {
            TotalCarsProduced++;
            Console.WriteLine("Empty Constructor");
        }

        // Parameterized Constructor
        public Car(string carColor)
        {
            Color = carColor;
            TotalCarsProduced++;
            Console.WriteLine("Parameterized Constructor");
        }

        // Properties
        public string color
        {
            get { return Color; }
            set { Color = value; }
        }

        // Instance Method
        public void Horn()
        {
            Console.WriteLine("The " + Color + " Color Car Honked"); // The Yellow Color Car honked
            Console.WriteLine($"The {Color} Color Car Honked"); // The Yellow Color Car honked
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car carEro = new Car();
            Car carJui = new Car("Blue");

            carEro.Color = "Pink";

            Console.WriteLine(carEro.Color);
            Console.WriteLine(carJui.Color);

            carEro.Horn();
            carJui.Horn();

            Console.WriteLine(Car.TotalCarsProduced);
        }
    }
}

namespace SIMBA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = { "Siam", "Prottoy", "Jui", "Ero", "Runib" };

            for (int i=0; i<names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

namespace ClassOutputTracing
{
    public class A
    {
        internal int num = 15;
    }

    public class B : A
    {
        protected internal int val = 30;
    }

    public class Alpha
    {
        protected static string data = "Start ";

        protected Alpha()
        {
            data += "alpha ";
        }
    }

    class SubAlpha : Alpha
    {
        public SubAlpha()
        {
            data += "subalpha ";
        }

        public void ShowData()
        {
            Console.WriteLine(data);
        }
    }

    public class SubSubAlpha : Alpha
    {
        public SubSubAlpha()
        {
            data += "subsubalpha ";
        }

        public static void DisplayNum(A objA)
        {
            Console.WriteLine(objA.num);
        }

        public static void DisplayVal(B objB)
        {
            Console.WriteLine(objB.val);
        }

        public static void Main(string[] args)
        {
            A objA = new A();
            objA.num = 40;
            B objB = new B();
            objB.val = 50;
            DisplayNum(objA);
            DisplayNum(objB);
            DisplayVal(objB);

            Console.WriteLine(data);
            Console.WriteLine("Determine:");

            data = "Reset ";
            new SubSubAlpha();
            Console.WriteLine(data);

            Console.WriteLine("Final data = " + data);
            Console.WriteLine("Final num = " + objA.num);
        }
    }
}

namespace JaggedArrayOutputTracing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[4][];
            myArray[0] = new int[] { 1, 3, 5, 7, 9, -2 };
            myArray[1] = new int[4];
            myArray[2] = new int[] { 2, 4, 6, 8, 5, 3 };
            myArray[3] = new int[4];

            for (int row = 0; row < 4; row += 2)
            {
                for (int column = 1; column < myArray[row].Length; column += 2)
                {
                    Console.Write("{0} ", myArray[row][column]);
                }
                Console.WriteLine();
            }

            for (int index = 0; index < myArray[1].Length; index++)
            {
                myArray[1][index] = myArray[0][index + 1] * 2;
            }

            for (int index = 0; index < myArray[3].Length; index++)
            {
                myArray[3][index] = myArray[2][index] + myArray[2][index + 2];
            }

            for (int row = 1; row < 4; row += 2)
            {
                for (int column = 0; column < myArray[row].Length; column++)
                {
                    Console.Write("{0} ", myArray[row][column]);
                }
                Console.WriteLine();
            }
        }
    }
}

namespace ConsoleAppCricketWorldCup
{
    public class Player
    {
        private string playerId;
        private string playerName;
        private string teamName;

        public Player(string playerId, string playerName, string teamName)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.teamName = teamName;
        }

        public virtual bool PlayerPerformance()
        {
            return false;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Player ID: " + playerId);
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("Player team Name: " + teamName);

            string eligibility;
            if (PlayerPerformance() == true)
            {
                eligibility = "Eligible";
            }
            else
            {
                eligibility = "Not Eligible";
            }

            Console.WriteLine($"Player is {eligibility} for Award!");
        }
    }

    public class Batsman : Player
    {
        public int totalRuns;
        public double battingAverage;
        public int highestScore;

        public Batsman(string playerId, string playerName, string teamName, int totalRuns, double battingAverage, int highestScore) : base(playerId, playerName, teamName)
        {
            this.totalRuns = totalRuns;
            this.battingAverage = battingAverage;
            this.highestScore = highestScore;
        }

        public override bool PlayerPerformance()
        {
            return battingAverage > 50;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Runs: " + totalRuns);
            Console.WriteLine("Batting Average: " + battingAverage);
            Console.WriteLine("Highest Score: " + highestScore);
        }
    }

    public class Bowler : Player
    {
        public int totalWickets;
        public double bowlingAverage;

        public Bowler(string playerId, string playerName, string teamName, int totalWickets, double bowlingAverage) : base(playerId, playerName, teamName)
        {
            this.totalWickets = totalWickets;
            this.bowlingAverage = bowlingAverage;
        }

        public override bool PlayerPerformance()
        {
            return totalWickets > 100;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Wickets: " + totalWickets);
            Console.WriteLine("Bowling Average: " + bowlingAverage);
        }
    }

    public class AllRounder : Player
    {
        public int totalRuns;
        public int totalWickets;

        public AllRounder(string playerId, string playerName, string teamName, int totalRuns, int totalWickets) : base(playerId, playerName, teamName)
        {
            this.totalRuns = totalRuns;
            this.totalWickets = totalWickets;
        }

        public override bool PlayerPerformance()
        {
            return (totalRuns > 1000 && totalWickets > 50);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Runs: " + totalRuns);
            Console.WriteLine("Total Wickets: " + totalWickets);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[4];
            players[0] = new Batsman("P-1", "Tom Latham", "NZ", 6789, 57.3, 183);
            players[1] = new Bowler("P-2", "Taskin Ahmed", "BD", 104, 23.2);
            players[2] = new AllRounder("P-3", "Glenn Maxwell", "AUS", 7590, 98);
            players[3] = new AllRounder("P-4", "Sam Curran", "Eng", 781, 60);

            foreach (Player player in players)
            {
                player.ShowInfo(); // Fixed from players.ShowInfo();
                Console.WriteLine();
            }
        }
    }
}