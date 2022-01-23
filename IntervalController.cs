using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interval_refactor_project
{
    class IntervalController
    {
        private IntervalModel model;
        private Iforms view;

        private string _end = "0";
        private string _start = "0";
        private string _length = "0";

        public string end
        {
            get => _end; 
            set
            {
                _end = value;
                SetEndChanged();
                NotifyObservers();
            }
        }

        public string start { 
            get => _start;
            set
            {
                _start = value;
                SetStartChanged();
                NotifyObservers();

            }
        }

        public string length { 
            get => _length;
            set { 
                _length = value;
                SetLengthChanged();
                NotifyObservers();
            }
        }

        public IntervalController(Iforms view)
        {
            this.model = new IntervalModel();
            this.view = view;
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
            view.Update();
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
