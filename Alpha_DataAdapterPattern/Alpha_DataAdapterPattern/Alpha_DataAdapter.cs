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
        //input data
        private static string text1;
        //calcuted output data values
        private static string text2;
        private static string label1;

        private static Alpha_Logic logic1 = new Alpha_Logic();
        private static Alpha_Logic2 logic2 = new Alpha_Logic2();
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
        public string Text2()
        {
            text2 = logic1.doLogic(text1);
            return text2;
        }

        public string Label1()
        {
            label1 = logic2.doLogic(text1);//doesn't really do antying
            return label1;
        }

        

        

    }
}
