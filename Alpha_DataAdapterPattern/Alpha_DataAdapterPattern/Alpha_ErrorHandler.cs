using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha_DataAdapterPattern
{
    public class Alpha_ErrorHandler
    {
        private string message;
        private MessageBox errorMessageBox;

        public bool BlankCheck(string val)
        {
            bool error = true;
            if (val == "" || val == null)
            {
                error = false;
                message = "Does not allow blanks!";
                MessageBox.Show(message);
            }
            
            return error;
        }


    }
}
