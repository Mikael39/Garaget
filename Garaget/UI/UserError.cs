using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.UI
{
    public abstract class UserError
    {

        internal abstract string UEMessage();


        public class NumericInputError : UserError
        {

            internal override string UEMessage()
            {
                string output = "You tried to use a text input in a numeric only field. This fired an error!";
                return output;
            }

        }
        public class TextInputError : UserError
        {

            internal override string UEMessage()
            {
                string output = "You tried to use a numeric input in a text only field. This fired an error!";
                return output;
            }
        }

        public class OverFlowError : UserError
        {
            internal override string UEMessage()
            {
                string output = "You tried to enter too much input. This fired an error!";
                return output;
            }
        }
        public class VoidUserError : UserError
        {
            internal override string UEMessage()
            {
                string output = "You did not enter a Value. This fired an error!";
                return output;
            }
        }

        public class ValueOutOfBoundsError : UserError
        {
            internal override string UEMessage()
            {
                string output = "The value you tried to enter is out of bounds. This fired an error!";
                return output;
            }
        }

    }
}
