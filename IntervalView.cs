namespace interval_refactor_project
{
    public partial class IntervalView : Form
    {
        private IntervalController controller;

        public IntervalView()
        {
            InitializeComponent();

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
            try
            {
                controller.start = _startField.Text;
            }
            catch
            {
                controller.start = "0";
                MessageBox.Show("Start needs to be a valid Integer");
            }
        }

        private void EndField_LostFocus(object sender, EventArgs e)
        {
            try
            {
                controller.end = _endField.Text;
            }
            catch
            {
                controller.end = "0";
                MessageBox.Show("End needs to be a valid Integer");
            }
        }

        private void LengthField_LostFocus(object sender, EventArgs e)
        {
            try
            {
                controller.length = _lengthField.Text;
            }
            catch
            {
                controller.length = "0";
                MessageBox.Show("Length needs to be a valid Integer");
            }
        }

        public void Update()
        {
            _endField.Text = controller.end;
            _startField.Text = controller.start;
            _lengthField.Text = controller.length;
        }

    }
}
