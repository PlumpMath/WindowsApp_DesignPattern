using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_DataAdapterPattern
{
    public class Alpha_DataAdapter
    {
        //Everything would be encapsulated and data flow would be much easier to understand
        //since this would be the only class that updates data on the form or forms
        //Everything from the ui would need to pass into an adapter into order to be used
        //by logic classes

        //Input and output should be made static for
        //input data
        private static string text1;
        //calcuted output data values
        private static string text2;
        private static string label1;

        //All the top level logic classes would be easily seen
        private static Alpha_Logic logic1 = new Alpha_Logic();
        private static Alpha_Logic2 logic2 = new Alpha_Logic2();
        //We could easily incorporate error handling in a central class
        private static Alpha_ErrorHandler errorChecker = new Alpha_ErrorHandler();
        
        public bool seedData(string val1)
        {
            bool posted = true;
            if (errorChecker.BlankCheck(val1))
            {
                text1 = val1;
            }
            else
            {
                posted = false;
            }
            return posted;
        }

        //We would need to be able to pass the data back to the form
        public string Text2()
        {
            text2 = logic1.doLogic(text1);
            return text2;
        }
        public string Label1()
        {
            label1 = logic2.doLogic(text1);
            return label1;
        }

        

        

    }
}
