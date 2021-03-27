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

        public IntervalController(IntervalModel model, IntervalView view)
        {
            this.model = model;
            this.view = view;
        }

        public string GetEnd()
        {
            return _end;
        }
        public void SetEnd(string arg)
        {
            _end = arg;
            SetChanged();
            NotifyObservers();
        }

        private void SetChanged() { }
        private void NotifyObservers() { }
    }

}
