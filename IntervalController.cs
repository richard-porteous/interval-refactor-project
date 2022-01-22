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
        private IntervalView view;

        public IntervalController(IntervalView view)
        {
            this.model = new IntervalModel();
            this.view = view;
        }

        private void SetChanged() { }
        private void NotifyObservers() 
        {
            view.Update();
        }
    }

}
