using static ConsoleApp2.MethodOverriding;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EvenOddNumber.CalculateEvenOdd();
            //PrimeNumber.CalculatePrimeNumber();
            //PrimeNumberInGivenRange.CalculatePrimeNumberInGivenRange();
            //PrimeFactor.PrimeFactorization();
            //Week.DayOfWeek();
            //VowelOrConstant.CheckVowelConstant();
            //VendingMachine.Display();
            //TempratureConversion.Conversion();
            //SwapTwoNum.TwoNumSwap();
            //StopWatch.StartStopwatch();
            //ReverseNumber.CheckReverseNumber();
            //reverseString.ReverseString();
            //QuotientRemainder.CalculateQuotientAndRemainder();
            //Powerof2.power();
            //PerfectNumber.CheckPerfectNumber();
            //MonthlyPayment.Payment();
            //LeapYear.CalculateLeap();
            //LargestNumber.FindLargestNum();
            //Harmonic.Harmonicnumber();
            //Fibonacci.FindFibonacci();
            //Factorial.CalculateFactorial();
            //Coupon.CheckCoupon();
            //Palindrome.CheckPalindrome();
            //RemoveDuplicateCharaterFromString.RemoveChar();
            //ReverseEachWord.ReverseWord();
            //HappyNumber.Happy();
            //SumOfDigits.SumDigit();
            //Flipcoin.CalculatePercentage();

            /* SingleInheritance
             Mango mango = new Mango();
             mango.Calculate();
             mango.SumOfTwoNumbers(2,4);*/

            /*HirarchicalInheritance
            Banana banana = new Banana();
            banana.SumOfTwoNumbers(30,20);
            Apple apple = new Apple();
            apple.SumOfTwoNumbers(20,20);
            apple.SumOfFourNumbers();*/

            /*MultilevelInheritance
            Derived1 derived1= new Derived1();
            derived1.Noisy();
            derived1.Calculate(10, 20);*/

            /*
            IMultipleInheritanceInterface
            Water water= new Water();
            IFruit i1 = water;
            i1.InterfaceMethodBody();
            
            IMultipleInheritanceInterface i2 = water;
            i2.InterfaceMethodBody();
            i2.Display();*/

            /* MethodOverloading
             MethodOverloading methodOverloading = new MethodOverloading();
             methodOverloading.Display(10, 20);
             methodOverloading.Display("Dhanashri", 20);*/

            /*
            MethodOverriding
            Over over = new Over();
            over.MethodOverridingCalculate();*/

            /*Abstraction
            Honda honda = new Honda();
            honda.Display();
            honda.Camera();*/

            /*Encapsulation encapsulation = new Encapsulation();
            encapsulation.NameOfPerson= 9456223;
            Console.WriteLine(encapsulation.NameOfPerson);*/

            /*Generic Classes
            create an instance with data type string 
            GenericClass<string> genericClass = new GenericClass<string>("Avicii");*/

            /*Generic Method
            create an instance of Employee class by specifying T as string
            GenericMethod<string> method = new GenericMethod<string>();*/

            /*Stack stack = new Stack();
            stack.DisplayStack();*/

            /*Queue queue = new Queue();
            queue.DisplayQueue();*/

            //Anagram.DisplayAnagram();

            /*Linked List
            LinkedList linkedlist = new LinkedList();
            linkedlist.Add(10);
            linkedlist.Add(20);
            linkedlist.Add(30);
            linkedlist.Add(40);*/

            /*
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.DisplayBubbleSort();*/

            /*StringUsingBubbleSort bubbleSort = new StringUsingBubbleSort();
            bubbleSort.DisplyStringBubbleSort();*/

            //InsertionSort.DisplayInsertionSort();

            //Exception.ExceptionClass();

            //GenericCollection.doStackDemo();

            /*var square = (int num)=> num * num;
            Console.WriteLine(square(5));*/


            //File IO Operation
            /*string path = "C:\\Users\\ganesh\\source\\repos\\File-I-O-Operation\\File-I-O-Operation\\imp.txt";
            CheckFileExists(path);*/
            //ReadTheDataFromFile(path);
            //ReadFromFile(path);
            //CopyToAnotherFile(path);
            //DeleteFile(path);
            //ReadFromStremReader(path);
            //WriteUsingStremWriter(path);
        }
    }
}