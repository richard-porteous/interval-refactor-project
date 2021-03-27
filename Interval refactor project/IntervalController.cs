using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval_refactor_project
{
    class IntervalController
    {
        private IntervalModel model;
        private IntervalView view;

        private string _end = "0";
        private string _start = "0";
        private string _length = "0";

        public IntervalController(IntervalView view)
        {
            this.model = new IntervalModel();
            this.view = view;
        }

        public string GetStart()
        {
            return _start;
        }
        public string GetEnd()
        {
            return _end;
        }
        public string GetLength()
        {
            return _length;
        }
        public void SetStart(string arg)
        {
            _start = arg;
            SetStartChanged();
            NotifyObservers();
        }
        public void SetEnd(string arg)
        {
            _end = arg;
            SetEndChanged();
            NotifyObservers();
        }
        public void SetLength(string arg)
        {
            _length = arg;
            SetLengthChanged();
            NotifyObservers();
        }

        private void SetStartChanged() 
        {
            CalculateLength();
        }
        private void SetEndChanged() 
        {
            CalculateLength();
        }
        private void SetLengthChanged() 
        {
            CalculateEnd();
        }

        private void NotifyObservers() 
        {
            view.UpdateFields();
        }


        private void CalculateLength()
        {
            try
            {
                int start = int.Parse(_start);
                int end = int.Parse(_end);
                int length = end - start;
                _length = length.ToString();
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
                int start = int.Parse(_start);
                int length = int.Parse(_length);
                int end = length + start;
                _end = end.ToString();
            }
            catch (Exception)
            {
                throw new FormatException("Unexpected Number Format Error");
            }
        }
    }
}


