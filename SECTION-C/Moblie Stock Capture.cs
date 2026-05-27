using System.ComponentModel;

namespace WinFormsApp;

public partial class Form1 : Form
{
    private readonly BindingList<StockItem> _stockItems = new();
    private readonly BindingSource _stockBindingSource = new();

    public Form1()
    {
        InitializeComponent();

        _stockBindingSource.DataSource = _stockItems;
        dgvStock.AutoGenerateColumns = false;
        dgvStock.DataSource = _stockBindingSource;
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        if (!TryCreateStockItem(out StockItem stockItem))
        {
            return;
        }

        bool duplicateCode = _stockItems.Any(item =>
            string.Equals(item.MobileCode, stockItem.MobileCode, StringComparison.OrdinalIgnoreCase));

        if (duplicateCode)
        {
            ShowValidationMessage("A record with this mobile code already exists.");
            txtMobileCode.Focus();
            txtMobileCode.SelectAll();
            return;
        }

        _stockItems.Add(stockItem);
        ApplyFilter();
        ClearInputs();
        txtMobileCode.Focus();
    }

    private void btnDelete_Click(object? sender, EventArgs e)
    {
        if (dgvStock.CurrentRow?.DataBoundItem is not StockItem selectedStock)
        {
            MessageBox.Show(
                "Select a stock record before trying to delete it.",
                "No Selection",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        DialogResult result = MessageBox.Show(
            $"Delete stock item '{selectedStock.MobileCode}'?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result != DialogResult.Yes)
        {
            return;
        }

        _stockItems.Remove(selectedStock);
        ApplyFilter();
    }

    private void btnFind_Click(object? sender, EventArgs e)
    {
        if (!TryReadQuantityFilter(out int? quantityFilter))
        {
            return;
        }

        ApplyFilter(quantityFilter);

        if (_stockBindingSource.Count == 0)
        {
            MessageBox.Show(
                "No stock items matched the entered search values.",
                "No Results",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void txtQuantity_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private bool TryCreateStockItem(out StockItem stockItem)
    {
        stockItem = null!;

        string mobileCode = txtMobileCode.Text.Trim();
        string make = txtMake.Text.Trim();

        if (string.IsNullOrWhiteSpace(mobileCode))
        {
            ShowValidationMessage("Mobile code is required.");
            txtMobileCode.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(make))
        {
            ShowValidationMessage("Make is required.");
            txtMake.Focus();
            return false;
        }

        if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity))
        {
            ShowValidationMessage("Quantity must be a valid whole number.");
            txtQuantity.Focus();
            txtQuantity.SelectAll();
            return false;
        }

        if (quantity <= 0)
        {
            ShowValidationMessage("Quantity must be greater than zero.");
            txtQuantity.Focus();
            txtQuantity.SelectAll();
            return false;
        }

        stockItem = new StockItem
        {
            MobileCode = mobileCode,
            Make = make,
            Quantity = quantity
        };

        return true;
    }

    private bool TryReadQuantityFilter(out int? quantityFilter)
    {
        quantityFilter = null;
        string quantityText = txtQuantity.Text.Trim();

        if (string.IsNullOrEmpty(quantityText))
        {
            return true;
        }

        if (!int.TryParse(quantityText, out int parsedQuantity))
        {
            ShowValidationMessage("Quantity search must be a valid whole number.");
            txtQuantity.Focus();
            txtQuantity.SelectAll();
            return false;
        }

        if (parsedQuantity < 0)
        {
            ShowValidationMessage("Quantity search cannot be negative.");
            txtQuantity.Focus();
            txtQuantity.SelectAll();
            return false;
        }

        quantityFilter = parsedQuantity;
        return true;
    }

    private void ApplyFilter(int? quantityFilter = null)
    {
        string mobileCodeFilter = txtMobileCode.Text.Trim();
        string makeFilter = txtMake.Text.Trim();

        IEnumerable<StockItem> filteredItems = _stockItems;

        if (!string.IsNullOrWhiteSpace(mobileCodeFilter))
        {
            filteredItems = filteredItems.Where(item =>
                item.MobileCode.Contains(mobileCodeFilter, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(makeFilter))
        {
            filteredItems = filteredItems.Where(item =>
                item.Make.Contains(makeFilter, StringComparison.OrdinalIgnoreCase));
        }

        if (quantityFilter.HasValue)
        {
            filteredItems = filteredItems.Where(item => item.Quantity == quantityFilter.Value);
        }

        _stockBindingSource.DataSource = filteredItems.ToList();
        dgvStock.ClearSelection();
    }

    private void ClearInputs()
    {
        txtMobileCode.Clear();
        txtMake.Clear();
        txtQuantity.Clear();
    }

    private static void ShowValidationMessage(string message)
    {
        MessageBox.Show(
            message,
            "Validation Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
    }

    private sealed class StockItem
    {
        public string MobileCode { get; init; } = string.Empty;
        public string Make { get; init; } = string.Empty;
        public int Quantity { get; init; }
    }
}