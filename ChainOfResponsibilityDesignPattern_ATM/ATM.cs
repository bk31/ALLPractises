﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChainOfResponsibilityDesignPattern_ATM.TwoThousandHandler;


namespace ChainOfResponsibilityDesignPattern_ATM
{
    // This class managed the sequence in which all the handlers are going to be chained together
    // This class initiates the request to a ConcreteHandler object on the chain
    public class ATM
    {

        private TwoThousandHandler twoThousandHandler = new TwoThousandHandler();
        private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
        private TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
        private HundredHandler hundredHandler = new HundredHandler();
        public ATM() 
        {
            // Prepare the chain of Handlers
            // Here, we need to set the next handler of each handler
            twoThousandHandler.SetNextHandler(fiveHundredHandler);
            fiveHundredHandler.SetNextHandler(twoHundredHandler);
            twoHundredHandler.SetNextHandler(hundredHandler);
        }
        //The following method handle the request and passes it to the first handler in the chain of responsibility.
        public void Withdraw(long requestedAmount)
        {
            //First check whether the amount is Divisible by 100 or not
            if (requestedAmount % 100 == 0)
            {
                twoThousandHandler.DispatchNote(requestedAmount);
            }
            else
            {
                Console.WriteLine($"You Enter Invalid Amount: {requestedAmount}");
            }
        }
    }
}
