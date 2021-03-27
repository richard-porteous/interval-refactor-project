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
    public partial class IntervalView : Form
    {
        private IntervalController controller;
        public IntervalView()
        {
            InitializeComponent();

            //TODO: perhaps we could look at this again
            IntervalController ctl = new IntervalController(this);
            SetController(ctl);
        }

        internal void SetController(IntervalController cont)
        {
            controller = cont;
            Update();
        }

        private void StartField_LostFocus(object sender, EventArgs e)
        {
            SetStart(_startField.Text);
            if (!int.TryParse(GetStart(), out int result))
            {
                SetStart("0");
            }
           
        }

        private void EndField_LostFocus(object sender, EventArgs e)
        {
            SetEnd(_endField.Text);
            if (!int.TryParse(GetEnd(), out int result))
            {
                SetEnd("0");
            }
            
        }

        private void LengthField_LostFocus(object sender, EventArgs e)
        {
            SetLength(_lengthField.Text);
            if (!int.TryParse(GetLength(), out int result))
            {
                SetLength("0");
            }
        }

        public void UpdateFields()
        {
            _endField.Text = controller.GetEnd(); //avoids recursion by direct setting
            _startField.Text = controller.GetStart();
            _lengthField.Text = controller.GetLength();
        }

        private string GetEnd()
        {
            return controller.GetEnd();
        }
        private string GetStart()
        {
            return controller.GetStart();
        }
        private string GetLength()
        {
            return controller.GetLength();
        }
        private void SetStart(string arg)
        {
            controller.SetStart(arg);
        }
        private void SetEnd(string arg)
        {
            controller.SetEnd(arg);
        }
        private void SetLength(string arg)
        {
            controller.SetLength(arg);
        }

    }
}
