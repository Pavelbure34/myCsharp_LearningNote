using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /* Conditional Statements are conventionally
     * if (condition) { block }
     * 
     * However, in C#, you can use ? operator.
     * FOr example)
     * double GPA;
     * int TOTAL = 300;
     * GPA = (TOTAL > 250) ? 3.5 : 2.0;
         */

    class Day03
    {
        void QuestionMarkOperator()
        {
            double GPA = 3.5;
            string Log = (GPA > 3.0)?"Good JOB":(GPA > 2.50)?"WorkHarder":(GPA>1.50)?"stillCould have been Better":"FAIL";
            Console.WriteLine(Log);

            //that is equivalent to this,
            if (GPA > 3.0)
                Log = "Good Job";
            else
                Log = "WorkHarder";

            //
        }
        
    }
}
