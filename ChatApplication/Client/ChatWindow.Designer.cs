namespace ChatApplication
{
    partial class ChatWindow
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
            this.registerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.messageEditor = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.portValue = new System.Windows.Forms.NumericUpDown();
            this.messagesList = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.portValue)).BeginInit();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(491, 19);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // nameValue
            // 
            this.nameValue.Location = new System.Drawing.Point(62, 21);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(268, 20);
            this.nameValue.TabIndex = 4;
            this.nameValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // messageEditor
            // 
            this.messageEditor.Location = new System.Drawing.Point(62, 222);
            this.messageEditor.Multiline = true;
            this.messageEditor.Name = "messageEditor";
            this.messageEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageEditor.Size = new System.Drawing.Size(423, 65);
            this.messageEditor.TabIndex = 7;
            this.messageEditor.TextChanged += new System.EventHandler(this.messageEditor_TextChanged);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(492, 222);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(74, 65);
            this.send.TabIndex = 8;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.button2_Click);
            // 
            // portValue
            // 
            this.portValue.Location = new System.Drawing.Point(365, 21);
            this.portValue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.portValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portValue.Name = "portValue";
            this.portValue.Size = new System.Drawing.Size(120, 20);
            this.portValue.TabIndex = 9;
            this.portValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // messagesList
            // 
            this.messagesList.Location = new System.Drawing.Point(62, 48);
            this.messagesList.Multiline = true;
            this.messagesList.Name = "messagesList";
            this.messagesList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messagesList.Size = new System.Drawing.Size(504, 168);
            this.messagesList.TabIndex = 10;
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 303);
            this.Controls.Add(this.messagesList);
            this.Controls.Add(this.portValue);
            this.Controls.Add(this.send);
            this.Controls.Add(this.messageEditor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerButton);
            this.Name = "ChatWindow";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.ChatWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox messageEditor;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.NumericUpDown portValue;
        private System.Windows.Forms.TextBox messagesList;
    }
}

