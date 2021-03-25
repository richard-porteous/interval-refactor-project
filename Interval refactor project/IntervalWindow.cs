using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interval_refactor_project
{
    public partial class IntervalWindow : Form
    {
        public IntervalWindow()
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
            if (!int.TryParse(_endField.Text.ToString(), out int result))
            {
                _endField.Text = "0";
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

        private void CalculateLength() 
        {
            try
            {
                int start = int.Parse(_startField.Text);
                int end = int.Parse(_endField.Text);
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
                _endField.Text = end.ToString();
            }
            catch (Exception)
            {
                throw new FormatException("Unexpected Number Format Error");
            }
        }
    }
}
