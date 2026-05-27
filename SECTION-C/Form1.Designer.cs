namespace WinFormsApp;

partial class Form1
{
    private System.ComponentModel.IContainer components = null!;
    private Label lblTitle = null!;
    private Label lblMobileCode = null!;
    private Label lblMake = null!;
    private Label lblQuantity = null!;
    private TextBox txtMobileCode = null!;
    private TextBox txtMake = null!;
    private TextBox txtQuantity = null!;
    private Button btnAdd = null!;
    private Button btnDelete = null!;
    private Button btnFind = null!;
    private DataGridView dgvStock = null!;
    private DataGridViewTextBoxColumn colMobileCode = null!;
    private DataGridViewTextBoxColumn colMake = null!;
    private DataGridViewTextBoxColumn colQuantity = null!;

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
        lblTitle = new Label();
        lblMobileCode = new Label();
        lblMake = new Label();
        lblQuantity = new Label();
        txtMobileCode = new TextBox();
        txtMake = new TextBox();
        txtQuantity = new TextBox();
        btnAdd = new Button();
        btnDelete = new Button();
        btnFind = new Button();
        dgvStock = new DataGridView();
        colMobileCode = new DataGridViewTextBoxColumn();
        colMake = new DataGridViewTextBoxColumn();
        colQuantity = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.Location = new Point(26, 19);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(250, 25);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Mobile Stock Capture Form";
        // 
        // lblMobileCode
        // 
        lblMobileCode.AutoSize = true;
        lblMobileCode.Location = new Point(32, 72);
        lblMobileCode.Name = "lblMobileCode";
        lblMobileCode.Size = new Size(74, 15);
        lblMobileCode.TabIndex = 1;
        lblMobileCode.Text = "Mobile code";
        // 
        // lblMake
        // 
        lblMake.AutoSize = true;
        lblMake.Location = new Point(32, 113);
        lblMake.Name = "lblMake";
        lblMake.Size = new Size(39, 15);
        lblMake.TabIndex = 2;
        lblMake.Text = "Make";
        // 
        // lblQuantity
        // 
        lblQuantity.AutoSize = true;
        lblQuantity.Location = new Point(32, 154);
        lblQuantity.Name = "lblQuantity";
        lblQuantity.Size = new Size(53, 15);
        lblQuantity.TabIndex = 3;
        lblQuantity.Text = "Quantity";
        // 
        // txtMobileCode
        // 
        txtMobileCode.Location = new Point(131, 69);
        txtMobileCode.Name = "txtMobileCode";
        txtMobileCode.PlaceholderText = "Example: IP14-128";
        txtMobileCode.Size = new Size(214, 23);
        txtMobileCode.TabIndex = 0;
        // 
        // txtMake
        // 
        txtMake.Location = new Point(131, 110);
        txtMake.Name = "txtMake";
        txtMake.PlaceholderText = "Example: Apple";
        txtMake.Size = new Size(214, 23);
        txtMake.TabIndex = 1;
        // 
        // txtQuantity
        // 
        txtQuantity.Location = new Point(131, 151);
        txtQuantity.Name = "txtQuantity";
        txtQuantity.PlaceholderText = "Positive whole number";
        txtQuantity.Size = new Size(214, 23);
        txtQuantity.TabIndex = 2;
        txtQuantity.KeyPress += txtQuantity_KeyPress;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(32, 198);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(90, 30);
        btnAdd.TabIndex = 3;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(143, 198);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(90, 30);
        btnDelete.TabIndex = 4;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnFind
        // 
        btnFind.Location = new Point(255, 198);
        btnFind.Name = "btnFind";
        btnFind.Size = new Size(90, 30);
        btnFind.TabIndex = 5;
        btnFind.Text = "Find";
        btnFind.UseVisualStyleBackColor = true;
        btnFind.Click += btnFind_Click;
        // 
        // dgvStock
        // 
        dgvStock.AllowUserToAddRows = false;
        dgvStock.AllowUserToDeleteRows = false;
        dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvStock.Columns.AddRange(new DataGridViewColumn[] { colMobileCode, colMake, colQuantity });
        dgvStock.Location = new Point(32, 247);
        dgvStock.MultiSelect = false;
        dgvStock.Name = "dgvStock";
        dgvStock.ReadOnly = true;
        dgvStock.RowHeadersVisible = false;
        dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvStock.Size = new Size(523, 181);
        dgvStock.TabIndex = 6;
        // 
        // colMobileCode
        // 
        colMobileCode.DataPropertyName = "MobileCode";
        colMobileCode.HeaderText = "Mobile code";
        colMobileCode.Name = "colMobileCode";
        colMobileCode.ReadOnly = true;
        // 
        // colMake
        // 
        colMake.DataPropertyName = "Make";
        colMake.HeaderText = "Make";
        colMake.Name = "colMake";
        colMake.ReadOnly = true;
        // 
        // colQuantity
        // 
        colQuantity.DataPropertyName = "Quantity";
        colQuantity.HeaderText = "Quantity";
        colQuantity.Name = "colQuantity";
        colQuantity.ReadOnly = true;
        // 
        // Form1
        // 
        AcceptButton = btnAdd;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(588, 450);
        Controls.Add(dgvStock);
        Controls.Add(btnFind);
        Controls.Add(btnDelete);
        Controls.Add(btnAdd);
        Controls.Add(txtQuantity);
        Controls.Add(txtMake);
        Controls.Add(txtMobileCode);
        Controls.Add(lblQuantity);
        Controls.Add(lblMake);
        Controls.Add(lblMobileCode);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Mobile Stock Capture";
        ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
