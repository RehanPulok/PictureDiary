
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.CaptionTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createeveButton
            // 
            this.createeveButton.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createeveButton.Location = new System.Drawing.Point(772, 353);
            this.createeveButton.Name = "createeveButton";
            this.createeveButton.Size = new System.Drawing.Size(170, 43);
            this.createeveButton.TabIndex = 0;
            this.createeveButton.Text = "Create";
            this.createeveButton.UseVisualStyleBackColor = true;
            this.createeveButton.Click += new System.EventHandler(this.createeveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Event Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date";
            // 
            // eventdateTimePicker
            // 
            this.eventdateTimePicker.Location = new System.Drawing.Point(193, 110);
            this.eventdateTimePicker.Name = "eventdateTimePicker";
            this.eventdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.eventdateTimePicker.TabIndex = 3;
            // 
            // EventTextBox
            // 
            this.EventTextBox.Location = new System.Drawing.Point(193, 57);
            this.EventTextBox.Name = "EventTextBox";
            this.EventTextBox.Size = new System.Drawing.Size(198, 20);
            this.EventTextBox.TabIndex = 4;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(193, 155);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(517, 292);
            this.PictureBox.TabIndex = 5;
            this.PictureBox.TabStop = false;
            // 
            // CaptionTextBox
            // 
            this.CaptionTextBox.Location = new System.Drawing.Point(193, 482);
            this.CaptionTextBox.Multiline = true;
            this.CaptionTextBox.Name = "CaptionTextBox";
            this.CaptionTextBox.Size = new System.Drawing.Size(517, 153);
            this.CaptionTextBox.TabIndex = 6;
            this.CaptionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.Menu;
            this.browseButton.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(772, 273);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(170, 44);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(838, 594);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(89, 41);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // CreateEvent
            // 
            this.ClientSize = new System.Drawing.Size(954, 647);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.CaptionTextBox);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.EventTextBox);
            this.Controls.Add(this.eventdateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createeveButton);
            this.Name = "CreateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateEvent_FormClosing_1);
            this.Load += new System.EventHandler(this.CreateEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox CaptionTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button BackButton;
    }
}