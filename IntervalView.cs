using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interval_refactor_project
{
    public partial class IntervalView : Form
    {
        public IntervalView()
        {
            InitializeComponent();
        }


        private void StartField_LostFocus(object sender, EventArgs e)
        {
            if (!int.TryParse(_startField.Text.ToString(), out int result))
            {
                _startField.Text = "0";
            }
            //var foo = result;
            CalculateLength();
        }

        private void EndField_LostFocus(object sender, EventArgs e)
        {
            SetEnd(_endField.Text); //catches a direct set of _endField
                                    //and forces the value through the method
                                    //becomes obvious when using the domain model
            if (!int.TryParse(GetEnd(), out int result))
            {
                SetEnd("0");
            }
            //var foo = result;
            CalculateLength();
        }

        private void LengthField_LostFocus(object sender, EventArgs e)
        {
            if (!int.TryParse(_lengthField.Text.ToString(), out int result))
            {
                _lengthField.Text = "0";
            }
            //var foo = result;
            CalculateEnd();
        }

        private string GetEnd()
        {
            return _endField.Text;
        }
        private void SetEnd(string arg)
        {
            _endField.Text = arg;
        }

        private void CalculateLength() 
        {
            try
            {
                int start = int.Parse(_startField.Text);
                int end = int.Parse(GetEnd());
                int length = end - start;
                _lengthField.Text = length.ToString();
            }
            catch (Exception)
            {
                throw new FormatException("Unexpected Number Format Error");
            }
        }

        private void CalculateEnd() 
        {
            try
            {
                int start = int.Parse(_startField.Text);
                int length = int.Parse(_lengthField.Text);
                int end = length + start;
                SetEnd(end.ToString());
            }
            catch (Exception)
            {
                throw new FormatException("Unexpected Number Format Error");
            }
        }
    }
}
