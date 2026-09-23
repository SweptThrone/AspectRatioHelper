namespace AspectRatioHelper {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
            this.widthTextBox = new TextBox();
            this.heightTextBox = new TextBox();
            this.modeButton = new Button();
            this.ratioLabel = new Label();
            this.SuspendLayout();
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new Point( 12, 34 );
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new Size( 100, 23 );
            this.widthTextBox.TabIndex = 0;
            this.widthTextBox.TextAlign = HorizontalAlignment.Right;
            this.widthTextBox.TextChanged +=  this.numTextBox_TextChanged ;
            this.widthTextBox.KeyPress +=  this.numTextBox_KeyPress ;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new Point( 158, 34 );
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new Size( 100, 23 );
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.TextChanged +=  this.numTextBox_TextChanged ;
            this.heightTextBox.KeyPress +=  this.numTextBox_KeyPress ;
            // 
            // modeButton
            // 
            this.modeButton.BackColor = Color.LightSalmon;
            this.modeButton.Location = new Point( 118, 34 );
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new Size( 34, 23 );
            this.modeButton.TabIndex = 2;
            this.modeButton.Text = "R";
            this.modeButton.UseVisualStyleBackColor = false;
            this.modeButton.Click +=  this.modeButton_Click ;
            // 
            // ratioLabel
            // 
            this.ratioLabel.AutoSize = true;
            this.ratioLabel.Location = new Point( 12, 9 );
            this.ratioLabel.Name = "ratioLabel";
            this.ratioLabel.Size = new Size( 161, 15 );
            this.ratioLabel.TabIndex = 3;
            this.ratioLabel.Text = "Click the R button to set ratio";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF( 7F, 15F );
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.ClientSize = new Size( 271, 69 );
            this.Controls.Add( this.ratioLabel );
            this.Controls.Add( this.modeButton );
            this.Controls.Add( this.heightTextBox );
            this.Controls.Add( this.widthTextBox );
            this.Icon = ( Icon )resources.GetObject( "$this.Icon" );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Aspect Ratio Helper";
            this.Load +=  this.MainForm_Load ;
            this.ResumeLayout( false );
            this.PerformLayout();
        }

        #endregion

        private TextBox widthTextBox;
        private TextBox heightTextBox;
        private Button modeButton;
        private Label ratioLabel;
    }
}
