namespace AspectRatioHelper {
    public partial class MainForm : Form {
        bool isReferenceMode = true;
        double ratio = 0;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load( object sender, EventArgs e ) {
            Form mainForm = ( Form )sender;

            mainForm.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void numTextBox_KeyPress( object sender, KeyPressEventArgs e ) {
            TextBox thisTextBox = ( TextBox )sender;

            if ( !char.IsControl( e.KeyChar ) && !char.IsDigit( e.KeyChar ) && e.KeyChar != '.' ) {
                e.Handled = true;
            }

            if ( e.KeyChar == '.' && thisTextBox.Text.Contains( '.' ) ) {
                e.Handled = true;
            }
        }

        private void numTextBox_TextChanged( object sender, EventArgs e ) {
            TextBox thisTextBox = ( TextBox )sender;
            double width;
            double height;
            try {
                width = Convert.ToDouble( widthTextBox.Text );
                height = Convert.ToDouble( heightTextBox.Text );
            } catch ( FormatException ) {
                return; // if it's not in the right format, just do nothing
            }

            if ( !isReferenceMode && thisTextBox.Modified && Convert.ToDouble( heightTextBox.Text ) != 0 ) {
                if ( thisTextBox == widthTextBox ) {
                    heightTextBox.Text = ( width / ratio ).ToString();
                } else {
                    widthTextBox.Text = ( height * ratio ).ToString();
                }
            }
        }

        private void modeButton_Click( object sender, EventArgs e ) {
            Button thisButton = ( Button )sender;

            isReferenceMode = !isReferenceMode;

            if ( isReferenceMode ) {
                thisButton.Text = "R";
                thisButton.BackColor = Color.LightSalmon;

                ratioLabel.Text = "Click the R button to set ratio";
            } else {
                thisButton.Text = "x";
                thisButton.BackColor = Color.LightSkyBlue;

                double width;
                double height;
                try {
                    width = Convert.ToDouble( widthTextBox.Text );
                    height = Convert.ToDouble( heightTextBox.Text );
                } catch ( FormatException ) {
                    ratioLabel.Text = "Current ratio:  Invalid";
                    return; // if it's not in the right format, just do nothing
                }

                if ( height != 0 ) {
                    ratio = width / height;
                } else {
                    ratio = 1;
                }

                ratioLabel.Text = "Current ratio:  " + ratio.ToString();
            }

        }
    }
}
