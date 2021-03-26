using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interval_refactor_project
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IntervalView view = new IntervalView();
            IntervalModel mdl = new IntervalModel();
            IntervalController ctl = new IntervalController(mdl, view);

            //we should run control but not if we run directly as a winforms app
            //TODO: perhaps we could look at this again
            view.SetController(ctl);
            Application.Run(view);
        }
    }
}
