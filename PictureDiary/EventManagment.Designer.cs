
namespace PictureDiary
{
    partial class EventManagment
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
            this.createEventButton = new System.Windows.Forms.Button();
            this.updateEventButton = new System.Windows.Forms.Button();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.EventDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createEventButton
            // 
            this.createEventButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEventButton.Location = new System.Drawing.Point(12, 205);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(146, 43);
            this.createEventButton.TabIndex = 1;
            this.createEventButton.Text = "Create Event";
            this.createEventButton.UseVisualStyleBackColor = true;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // updateEventButton
            // 
            this.updateEventButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEventButton.Location = new System.Drawing.Point(12, 292);
            this.updateEventButton.Name = "updateEventButton";
            this.updateEventButton.Size = new System.Drawing.Size(146, 43);
            this.updateEventButton.TabIndex = 3;
            this.updateEventButton.Text = "Update Event";
            this.updateEventButton.UseVisualStyleBackColor = true;
            this.updateEventButton.Click += new System.EventHandler(this.updateEventButton_Click);
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEventButton.Location = new System.Drawing.Point(12, 379);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(146, 43);
            this.deleteEventButton.TabIndex = 4;
            this.deleteEventButton.Text = "Delete Event";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // EventDataGridView
            // 
            this.EventDataGridView.AllowUserToAddRows = false;
            this.EventDataGridView.AllowUserToDeleteRows = false;
            this.EventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDataGridView.Location = new System.Drawing.Point(164, 12);
            this.EventDataGridView.Name = "EventDataGridView";
            this.EventDataGridView.ReadOnly = true;
            this.EventDataGridView.Size = new System.Drawing.Size(439, 640);
            this.EventDataGridView.TabIndex = 5;
            // 
            // EventManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 664);
            this.Controls.Add(this.EventDataGridView);
            this.Controls.Add(this.deleteEventButton);
            this.Controls.Add(this.updateEventButton);
            this.Controls.Add(this.createEventButton);
            this.Name = "EventManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Managment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventManagment_FormClosing);
            this.Load += new System.EventHandler(this.EventManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.Button updateEventButton;
        private System.Windows.Forms.Button deleteEventButton;
        private System.Windows.Forms.DataGridView EventDataGridView;
    }
}