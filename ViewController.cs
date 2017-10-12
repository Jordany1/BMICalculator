using System;
using UIKit;

namespace BMICalculator
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            calculateButton.TouchUpInside+= calculateButton_TouchInside;
        }

        void calculateButton_TouchInside(object sender, EventArgs e)
        {
            float height = float.Parse(heightTextField.Text);
            float weight = float.Parse(weightTextField.Text);

            float bmi = (weight / (height * height));

            bmiLabel.Text = bmi.ToString (); 
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


    }
}
