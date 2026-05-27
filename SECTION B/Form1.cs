namespace WinFormsApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnGreeting_Click(object? sender, EventArgs e)
    {
        string name = txtName.Text.Trim();

        if (string.IsNullOrWhiteSpace(name))
        {
            MessageBox.Show(
                "Please enter your name before clicking Greeting.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtName.Focus();
            return;
        }

        MessageBox.Show(
            $"Hello, {name}! Welcome to the Section B form.",
            "Greeting",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void btnClose_Click(object? sender, EventArgs e)
    {
        Close();
    }
}