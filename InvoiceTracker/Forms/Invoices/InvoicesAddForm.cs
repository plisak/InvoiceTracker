using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models;
using Domain.Validators;
using FluentValidation.Results;
using InvoiceTracker.Validators;
using InvoiceTracker.ViewModels;

namespace InvoiceTracker.Forms.Invoices
{
    public partial class InvoicesAddForm : Form
    {
        private InvoiceViewModel _invoiceViewModel;
        private InvoiceItemViewModel? _editedItem = null;

        const int NoColumnIndex = 0;
        const int NameColumnIndex = 1;
        const int QuantityColumnIndex = 2;
        const int PriceColumnIndex = 3;
        const int NetSubtotalColumnIndex = 4;
        const int GrossColumnIndex = 5;
        const int VATColumnIndex = 6;
        const int EditButtonColumnIndex = 7;
        const int DeleteButtonColumnIndex = 8;

        public InvoicesAddForm()
        {
            InitializeComponent();
        }
        private void InvoicesAddForm_Load(object sender, EventArgs e)
        {
            _invoiceViewModel = new InvoiceViewModel();

            InitializeControls();
            InitializeGrid();
            UpdateTotals();
        }

        private void InitializeControls()
        {
            ShowItemEditFields(false);
            itemPriceNumericUpDown.Maximum = Decimal.MaxValue;
            itemQuantityNumericUpDown.Maximum = Decimal.MaxValue;
        }

        private void InitializeGrid()
        {
            invoiceItemsGridView.ColumnCount = 7;
            invoiceItemsGridView.Columns[NoColumnIndex].Name = "No";
            invoiceItemsGridView.Columns[NoColumnIndex].DataPropertyName = "OrderNo";
            invoiceItemsGridView.Columns[NoColumnIndex].Width = 35;
            invoiceItemsGridView.Columns[NameColumnIndex].Name = "Name";
            invoiceItemsGridView.Columns[NameColumnIndex].DataPropertyName = "ItemName";
            invoiceItemsGridView.Columns[NameColumnIndex].Width = 210;
            invoiceItemsGridView.Columns[QuantityColumnIndex].Name = "Quantity";
            invoiceItemsGridView.Columns[QuantityColumnIndex].DataPropertyName = "Quantity";
            invoiceItemsGridView.Columns[QuantityColumnIndex].Width = 70;
            invoiceItemsGridView.Columns[PriceColumnIndex].Name = "Price";
            invoiceItemsGridView.Columns[PriceColumnIndex].DataPropertyName = "Price";
            invoiceItemsGridView.Columns[PriceColumnIndex].Width = 70;
            invoiceItemsGridView.Columns[NetSubtotalColumnIndex].Name = "Net";
            invoiceItemsGridView.Columns[NetSubtotalColumnIndex].DataPropertyName = "NetSubtotal";
            invoiceItemsGridView.Columns[NetSubtotalColumnIndex].Width = 70;
            invoiceItemsGridView.Columns[GrossColumnIndex].Name = "VAT [%]";
            invoiceItemsGridView.Columns[GrossColumnIndex].DataPropertyName = "VAT";
            invoiceItemsGridView.Columns[GrossColumnIndex].Width = 70;
            invoiceItemsGridView.Columns[VATColumnIndex].Name = "Gross";
            invoiceItemsGridView.Columns[VATColumnIndex].DataPropertyName = "GrossSubtotal";
            invoiceItemsGridView.Columns[VATColumnIndex].Width = 70;

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = string.Empty;
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            invoiceItemsGridView.Columns.Insert(EditButtonColumnIndex, editButtonColumn);
            invoiceItemsGridView.Columns[EditButtonColumnIndex].Width = 50;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = string.Empty;
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            invoiceItemsGridView.Columns.Insert(DeleteButtonColumnIndex, deleteButtonColumn);
            invoiceItemsGridView.Columns[DeleteButtonColumnIndex].Width = 50;

            invoiceItemsGridView.AutoGenerateColumns = false;
            invoiceItemsGridView.DataSource = _invoiceViewModel.InvoiceItems;
        }

        private void ShowItemEditFields(bool show)
        {
            addItemButton.Visible = !show;

            itemNameLabel.Visible = show;
            itemNameTextBox.Visible = show;

            itemQuantityLabel.Visible = show;
            itemQuantityNumericUpDown.Visible = show;

            itemPriceLabel.Visible = show;
            itemPriceNumericUpDown.Visible = show;
            itemCurrencyLabel.Visible = show;

            itemVATLabel.Visible = show;
            itemVatPNumericUpDown.Visible = show;

            saveItemButton.Visible = show;
            cancelEditItemButton.Visible = show;

            if (show)
            {
                itemNameTextBox.Focus();
            }
        }
        private void SetDefaultsForItemEditFields()
        {
            itemNameTextBox.Text = string.Empty;
            itemQuantityNumericUpDown.Text = "0";
            itemPriceNumericUpDown.Text = "0";
            itemVatPNumericUpDown.Text = "23";
        }

        private void createInvoiceButton_Click(object sender, EventArgs e)
        {

        }

        private void saveItemButton_Click(object sender, EventArgs e)
        {
            var item = CreateInvoiceItemViewModelFromFields();

            var errors = ValidateItem(item);
            if (errors.Any())
            {
                MessageBox.Show($"Errors:\n{String.Join(", \n", errors)}", "Validation errors!");
                return;
            }

            if (_editedItem == null)
                AddNewInvoiceItem(item);
            else
            {
                _editedItem.UpdateValues(item);
                _editedItem = null;
                invoiceItemsGridView.Refresh();
            }

            UpdateTotals();

            CloseEditFormForInvoiceItem();
        }

        private void UpdateTotals()
        {
            _invoiceViewModel.Currency = "PLN";
            grossTotalAmountLabel.Text = _invoiceViewModel.GrossTotalString;
            netTotalAmountLabel.Text = _invoiceViewModel.NetTotalString;
        }

        private void AddNewInvoiceItem(InvoiceItemViewModel item)
        {
            item.Id = 0;
            item.OrderNo = _invoiceViewModel.InvoiceItems.Count + 1;
            _invoiceViewModel.InvoiceItems.Add(item);
        }

        private InvoiceItemViewModel CreateInvoiceItemViewModelFromFields()
        {
            var item = new InvoiceItemViewModel
            {
                ItemName = itemNameTextBox.Text,
                Quantity = itemQuantityNumericUpDown.Value,
                Price = itemPriceNumericUpDown.Value,
                VAT = itemVatPNumericUpDown.Value
            };
            return item;
        }
        private void SetControlsFromInvoiceItemViewModel(InvoiceItemViewModel item)
        {
            itemNameTextBox.Text = item.ItemName;
            itemQuantityNumericUpDown.Value = item.Quantity;
            itemPriceNumericUpDown.Value = item.Price;
            itemVatPNumericUpDown.Value = item.VAT;
        }

        private static List<ValidationFailure> ValidateItem(InvoiceItemViewModel item)
        {
            var validator = new InvoiceItemViewModelValidator();
            var results = validator.Validate(item);
            return results.Errors;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            ShowItemEditFields(true);
        }

        private void InvoicesAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Exit without saving?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                e.Cancel = true;
        }

        private void NumericUpDown_SelectAllOnEnter(object sender, EventArgs e)
        {
            var control = (NumericUpDown)sender;
            control.Select(0, control.Text.Length);
        }

        private void invoiceItemsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var clickedRowIndex = e.RowIndex;
            if (clickedRowIndex < 0)
                return;

            switch (e.ColumnIndex)
            {
                case EditButtonColumnIndex:
                    EditInvoiceItemFromList(clickedRowIndex);
                    break;
                case DeleteButtonColumnIndex:
                    {
                        var dialogResult = MessageBox.Show("Are you sure you want delete this item?", "Warning", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                            return;

                        RemoveInvoiceItemFromList(clickedRowIndex);
                        break;
                    }
            }
        }

        private void EditInvoiceItemFromList(int indexToEdit)
        {
            _editedItem = _invoiceViewModel.InvoiceItems[indexToEdit];
            SetControlsFromInvoiceItemViewModel(_editedItem);
            ShowItemEditFields(true);
        }

        private void RemoveInvoiceItemFromList(int indexToRemove)
        {
            CloseEditFormForInvoiceItem();

            _invoiceViewModel.InvoiceItems.RemoveAt(indexToRemove);
            UpdateOrderNoInAllItems();
            UpdateTotals();
        }

        private void UpdateOrderNoInAllItems()
        {
            foreach (var item in _invoiceViewModel.InvoiceItems.Select((value, index) => (value, index)))
            {
                item.value.OrderNo = item.index + 1;
            }
        }

        private void CloseEditFormForInvoiceItem()
        {
            _editedItem = null;
            SetDefaultsForItemEditFields();
            ShowItemEditFields(false);
        }

        private void cancelEditItemButton_Click(object sender, EventArgs e)
        {
            CloseEditFormForInvoiceItem();
        }
    }
}