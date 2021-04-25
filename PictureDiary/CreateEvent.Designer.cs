
namespace PictureDiary
{
    partial class CreateEvent
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
            this.createeveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eventdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EventTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createeveButton
            // 
            this.createeveButton.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createeveButton.Location = new System.Drawing.Point(137, 271);
            this.createeveButton.Name = "createeveButton";
            this.createeveButton.Size = new System.Drawing.Size(111, 43);
            this.createeveButton.TabIndex = 0;
            this.createeveButton.Text = "Create";
            this.createeveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createeveButton.UseVisualStyleBackColor = true;
            this.createeveButton.Click += new System.EventHandler(this.createeveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Event Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date";
            // 
            // eventdateTimePicker
            // 
            this.eventdateTimePicker.Enabled = false;
            this.eventdateTimePicker.Location = new System.Drawing.Point(178, 182);
            this.eventdateTimePicker.Name = "eventdateTimePicker";
            this.eventdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.eventdateTimePicker.TabIndex = 3;
            // 
            // EventTextBox
            // 
            this.EventTextBox.Location = new System.Drawing.Point(178, 126);
            this.EventTextBox.Name = "EventTextBox";
            this.EventTextBox.Size = new System.Drawing.Size(198, 20);
            this.EventTextBox.TabIndex = 4;
            // 
            // CreateEvent
            // 
            this.ClientSize = new System.Drawing.Size(388, 404);
            this.Controls.Add(this.EventTextBox);
            this.Controls.Add(this.eventdateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createeveButton);
            this.Name = "CreateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateEvent_FormClosing_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button createeveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker eventdateTimePicker;
        private System.Windows.Forms.TextBox EventTextBox;
    }
}