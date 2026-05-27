namespace WinFormsApp;

partial class Form1
{
    private System.ComponentModel.IContainer components = null!;
    private Label lblPrompt = null!;
    private TextBox txtName = null!;
    private Button btnGreeting = null!;
    private Button btnClose = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblPrompt = new Label();
        txtName = new TextBox();
        btnGreeting = new Button();
        btnClose = new Button();
        SuspendLayout();
        // 
        // lblPrompt
        // 
        lblPrompt.AutoSize = true;
        lblPrompt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblPrompt.Location = new Point(42, 48);
        lblPrompt.Name = "lblPrompt";
        lblPrompt.Size = new Size(121, 20);
        lblPrompt.TabIndex = 0;
        lblPrompt.Text = "Enter your name:";
        // 
        // txtName
        // 
        txtName.Location = new Point(46, 80);
        txtName.Name = "txtName";
        txtName.PlaceholderText = "Type your name here";
        txtName.Size = new Size(278, 23);
        txtName.TabIndex = 0;
        // 
        // btnGreeting
        // 
        btnGreeting.Location = new Point(46, 128);
        btnGreeting.Name = "btnGreeting";
        btnGreeting.Size = new Size(120, 34);
        btnGreeting.TabIndex = 1;
        btnGreeting.Text = "Greeting";
        btnGreeting.UseVisualStyleBackColor = true;
        btnGreeting.Click += btnGreeting_Click;
        // 
        // btnClose
        // 
        btnClose.Location = new Point(204, 128);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(120, 34);
        btnClose.TabIndex = 2;
        btnClose.Text = "Close App";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // Form1
        // 
        AcceptButton = btnGreeting;
        CancelButton = btnClose;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(381, 214);
        Controls.Add(btnClose);
        Controls.Add(btnGreeting);
        Controls.Add(txtName);
        Controls.Add(lblPrompt);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Greeting Form";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}