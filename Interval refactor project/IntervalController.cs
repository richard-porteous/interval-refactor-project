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

        private int _end = 0;
        private int _start = 0;
        private int _length = 0;

        public IntervalController(IntervalView view)
        {
            this.model = new IntervalModel();
            this.view = view;
        }

        public string GetStart()
        {
            return _start.ToString();
        }
        public string GetEnd()
        {
            return _end.ToString();
        }
        public string GetLength()
        {
            return _length.ToString();
        }
        public void SetStart(string arg)
        {
            //validate
            _ = int.TryParse(arg, out int result); // we rely on result being 0 if it failed
            //store
            _start = result;
            //logic
            SetStartChanged();
            //tell observer changes have happened
            NotifyObservers();
        }
        public void SetEnd(string arg)
        {
            _ = int.TryParse(arg, out int result);
            _end = result;
            SetEndChanged();
            NotifyObservers();
        }
        public void SetLength(string arg)
        {
            _ = int.TryParse(arg, out int result);
            _length = result;
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
            _length = _end - _start;
        }

        private void CalculateEnd()
        {
            _end = _length + _start;
        }
    }
}


