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

            //TODO: this is because form is initialized in program.cs - not necessarily the only way.
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
            SetStart(_startField.Text);   //use field to update domain (is validated by domain too)        
        }

        private void EndField_LostFocus(object sender, EventArgs e)
        {
            SetEnd(_endField.Text);
        }

        private void LengthField_LostFocus(object sender, EventArgs e)
        {
            SetLength(_lengthField.Text);
        }

        public void UpdateFields()
        {
            _endField.Text = GetEnd();
            _startField.Text = GetStart();
            _lengthField.Text = GetLength();
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
