namespace ChainOfResponsibilityDesignPattern_ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Step4: Client

            ATM atm = new ATM();
            Console.WriteLine("Requested Amount 4600");
            atm.Withdraw(4600);

            Console.WriteLine("Requested Amount 1900");
            atm.Withdraw(1900);

            Console.WriteLine("Requested Amount 600");
            atm.Withdraw(600);

            Console.WriteLine("Requested Amount 750");
            atm.Withdraw(750);

            Console.ReadLine();
        }
    }


   // Step1: Creating Abstract Handler

    // Handler Abstract Class
    // The Default Chaining Behavior can be implemented inside the abstract handler class.
    public abstract class Handler
    {

        //The NextHandler will hold the reference of the next handler
        public Handler NextHandler;
        //Initializing NextHandler reference using the class constructor
        public void SetNextHandler(Handler handler)
        {
            this.NextHandler = handler;
        }
        //The following Method needs to be implemented by the Child handler Classes
        //The following method is going to handle a request.
        public abstract void DispatchNote(long requestedAmount);
    }

    //Step2: Creating Concrete Handlers
    //Concrete Handler 1
    //The following class implement the Handler abstract class and 
    //Provide Implementation for DispatchNote abstract method
    public class TwoThousandHandler : Handler
    {
        //First Check the Number of 2000 Notes To Be Dispatched
        public override void DispatchNote(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 2000;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Thousand notes are dispatched by TwoThousandHandler");
                }
                else
                {

                    Console.WriteLine(numberofNotesToBeDispatched + " Two Thousand note is dispatched by TwoThousandHandler");
                }
            }
            //Then check the pending amount
            long pendingAmountToBeProcessed = requestedAmount % 2000;
            //If the Pending amount is greater than 0, then call the next handler to handle the request
            if (pendingAmountToBeProcessed > 0)
            {
                //For TwoThousandHandler, the next handler is FiveHundredHandler
                NextHandler.DispatchNote(pendingAmountToBeProcessed);

            }
        }
        //Concrete Handler 2
        //The following class implement the Handler abstract class and 
        //Provide Implementation for DispatchNote abstract method
        public class FiveHundredHandler : Handler
        {
            public override void DispatchNote(long requestedAmount)
            {

                //First Check the Number of 500 Notes To Be Dispatched
                long numberofNotesToBeDispatched = requestedAmount / 500;
                if (numberofNotesToBeDispatched > 0)
                {
                    if (numberofNotesToBeDispatched > 1)
                    {
                        Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred notes are dispatched by FiveHundredHandler");
                    }
                    else
                    {
                        Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred note is dispatched by FiveHundredHandler");
                    }
                }
                //Then check the Pending amount
                long pendingAmountToBeProcessed = requestedAmount % 500;
                //If Pending amount is greater than 0, then call the next handler to handle the request
                if (pendingAmountToBeProcessed > 0)
                {
                    //For FiveHundredHandler, the next handler is TwoHundredHandler  
                    NextHandler.DispatchNote(pendingAmountToBeProcessed);
                }
            }
        }


        //Concrete Handler 3
        //The following class implement the Handler abstract class and 
        //Provide Implementation for DispatchNote abstract method
        public class TwoHundredHandler : Handler
        {
            public override void DispatchNote(long requestedAmount)
            {
                //First Check the Number of 200 Notes To Be Dispatched
                long numberofNotesToBeDispatched = requestedAmount / 200;
                if (numberofNotesToBeDispatched > 0)
                {
                    if (numberofNotesToBeDispatched > 1)
                    {
                        Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred notes are dispatched by FiveHundredHandler");

                    }
                    else
                    {
                        Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred note is dispatched by FiveHundredHandler");

                    }
                }
                //Then check the Pending amount
                long pendingAmountToBeProcessed = requestedAmount % 200;
                //If the Pending amount is greater than 0, then call the next handler to handle the request
                if (pendingAmountToBeProcessed > 0)
                {
                    //For TwoHundredHandler, the next handler is HundredHandler 
                    NextHandler.DispatchNote(pendingAmountToBeProcessed);

                }
            }
        }
       
    }

    //Concrete Handler 4
    //The following class implement the Handler abstract class and 
    //Provide Implementation for DispatchNote abstract method
    public class HundredHandler : Handler
    {
        //
        public override void DispatchNote(long requestedAmount)
        {
            //First Check the Number of 100 Notes To Be Dispatched
            long numberofNotesToBeDispatched = requestedAmount % 100;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred notes are dispatched by HundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred note is dispatched by HundredHandler");
                }
            }
            ////Then check the Pending amount
            //long pendingAmountToBeProcessed = requestedAmount % 100;
            ////If the Pending amount is greater than 0, then call the next handler to handle the request
            //if (pendingAmountToBeProcessed > 0)
            //{
            //    //For TwoHundredHandler, the next handler is HundredHandler 
            //    NextHandler.DispatchNote(pendingAmountToBeProcessed);

            //}

            //No Need to Check the Next Handler
        }
    }

    //Step3: Chaining the Handlers
}
