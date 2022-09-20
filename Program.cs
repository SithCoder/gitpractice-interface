namespace Interface

{
    interface GovtRules
    {
        void EmployeePF(); //abstract method
        void LeaveDetails();

        void gratuityAmount();
    }
    class TCS : GovtRules
    {
        double basicSalary;
        float serviceCompleted;

        public TCS(double basicSalary1,float serviceCompleted1)
        {
            this.basicSalary = basicSalary1;
            this.serviceCompleted = serviceCompleted1;
        }

        public void EmployeePF()
        {
            double z1;
            z1 = (basicSalary * 12)/100;
            Console.WriteLine("TCS employee salary= {0}",basicSalary);
            Console.WriteLine("Provident Fund cut for TCS employee is: {0}", z1);
            Console.WriteLine("TCS contribution to your Provident Fund= {0}", (basicSalary * 8.33)/100);
            Console.WriteLine("TCS contribution to your Pension Fund= {0}\n",(basicSalary * 3.67)/100);
        }
        public void LeaveDetails()
        {
            Console.WriteLine(@"As a TCS employee you have-

1 day of Casual Leave per month
12 days of Sick Leave per year
10 days of Previlage Leave per year
");
        }

        public void gratuityAmount()
        {
            if(serviceCompleted > 10)
            {
                Console.WriteLine("Your gratuity amount as a TCS employee is: {0}\n", 2*basicSalary);
            }
            else if(serviceCompleted > 20)
            {
                Console.WriteLine("Your gratuity amount as a TCS employee is: {0}. Thank you foryour service\n", 3 * basicSalary);
            }
            else {
                Console.WriteLine("No gratuity amount");
            }
        }
    }
    class Accenture : GovtRules
    {
        double basicSalary;
        float serviceCompleted;
        public Accenture(double basicSalary1,float serviceCompleted1)
        {
            this.basicSalary = basicSalary1;
            this.serviceCompleted = serviceCompleted1;
        }
        public void EmployeePF()
        {
            double x1;
            x1= (basicSalary * 12)/100;
            Console.WriteLine("Accenture employee salary= {0}", basicSalary);
            Console.WriteLine("Provident Fund cut for Accenture employee is: {0}", x1);
            Console.WriteLine("Accenture contribution to your Provident Fund= {0}\n",x1);
            
        }
        public void LeaveDetails()
        {
            Console.WriteLine(@"As a Accenture employee, you have-

2 day of Casual Leave per month
5 days of Sick Leave per year
5 days of Previlage Leave per year
");
        }
        //public void M1() { }
        public void gratuityAmount()
        {
            Console.WriteLine("Sorry Accenture employee, we do not provide any Gratuity");
        }
    }
    //class Rectangle : GovtRules
    //{
    //    int l;
    //    int w;

    //    public Rectangle(int l, int w)
    //    {
    //        this.l = l;
    //        this.w = w;
    //    }

    //    public void EmployeePF()
    //    {
    //        Console.WriteLine("Area of Rectangle: " + (l * w));
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            GovtRules TCSemp1 = new TCS(325000,12);
            TCSemp1.EmployeePF(); //access only interface members not class or strunct members
            TCSemp1.LeaveDetails();
            TCSemp1.gratuityAmount();

            GovtRules Accentureemp1 = new Accenture(4502300,21);
            Accentureemp1.EmployeePF(); //access only interface members not class or strunct members
            Accentureemp1.LeaveDetails();
            Accentureemp1.gratuityAmount();

            ////Accenture Accentureemp2 = new Accenture(34500);
            ////Accentureemp2.EmployeePF();
            ////Accentureemp2.M1();
            //GovtRules rectangle = new Rectangle(12, 34);
            //rectangle.EmployeePF();
            
            
            ////TCS square1 = new TCS(2);
            ////square1.EmployeePF();
        }
    }
}
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }

//    interface IGovtRules
//    {
//        double EmployeePF();
//        //public string LeaveDetails();
//        //public double gratuityAmount(float serviceCompleted, double basicSalary);
//    }
    
//    public class TCS : IGovtRules
//    {
//        public EmployeePF()
//        {

//        }
//    }
//}