namespace TestMyRadioGroup
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.MyControl.MyRadioGroupItem myRadioGroupItem1 = new DevExpress.MyControl.MyRadioGroupItem();
            DevExpress.MyControl.MyRadioGroupItem myRadioGroupItem2 = new DevExpress.MyControl.MyRadioGroupItem();
            DevExpress.MyControl.MyRadioGroupItem myRadioGroupItem3 = new DevExpress.MyControl.MyRadioGroupItem();
            DevExpress.MyControl.MyRadioGroupItem myRadioGroupItem4 = new DevExpress.MyControl.MyRadioGroupItem();
            this.myRadioGroup1 = new DevExpress.MyControl.MyRadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.myRadioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // myRadioGroup1
            // 
            this.myRadioGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myRadioGroup1.Location = new System.Drawing.Point(12, 12);
            this.myRadioGroup1.Name = "myRadioGroup1";
            myRadioGroupItem1.Description = "Item 1";
            myRadioGroupItem1.ToolTip = "This is tooltip for item 1";
            myRadioGroupItem1.Value = null;
            myRadioGroupItem2.Description = "Item 2";
            myRadioGroupItem2.ToolTip = "This is tooltip for item 2";
            myRadioGroupItem2.Value = null;
            myRadioGroupItem3.Description = "Item 3";
            myRadioGroupItem3.ToolTip = "This is tooltip for item 3";
            myRadioGroupItem3.Value = null;
            myRadioGroupItem4.Description = "Item 4";
            myRadioGroupItem4.ToolTip = "This is tooltip for item 4";
            myRadioGroupItem4.Value = null;
            this.myRadioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            myRadioGroupItem1,
            myRadioGroupItem2,
            myRadioGroupItem3,
            myRadioGroupItem4});
            this.myRadioGroup1.Size = new System.Drawing.Size(200, 201);
            this.myRadioGroup1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 225);
            this.Controls.Add(this.myRadioGroup1);
            this.Name = "FormMain";
            this.Text = "Main form";
            ((System.ComponentModel.ISupportInitialize)(this.myRadioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.MyControl.MyRadioGroup myRadioGroup1;

    }
}

