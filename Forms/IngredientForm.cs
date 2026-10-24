
using WinForms_Custom_Potion_Brewing_System.Models;
using WinForms_Custom_Potion_Brewing_System.Services;

namespace WinForms_Custom_Potion_Brewing_System.Forms
{
    public partial class IngredientForm : Form
    {
        private readonly IngredientService _ingredientService;
        public IngredientForm(IngredientService ingredientService)
        {
            InitializeComponent();

            _ingredientService = ingredientService;

        }

        private async void IngredientForm_Load(object sender, EventArgs e)
        {
            await LoadIngredientsAsync();

            if (dgvIngredients.Columns["Id"] != null)
                dgvIngredients.Columns["Id"].Visible = false;

            if (dgvIngredients.Columns["RecipeIngredients"] != null)
                dgvIngredients.Columns["RecipeIngredients"].Visible = false;
        }

        private async Task LoadIngredientsAsync()
        {
            try
            {
                var ingredients = await _ingredientService.GetAllIngredientsAsync();
                dgvIngredients.DataSource = ingredients;
            }
            catch (Exception ex)
            {
                /* 
                 MessageBoxButtons.OK and MessageBoxIcon.xxx configures the message box
                 to display an 'OK' button and a specific icon depending on the type of message.
                */
                MessageBox.Show($"Error loading ingredients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddIngredient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIngredientName.Text))
            {
                MessageBox.Show("Please enter an ingredient name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newIngredient = new Ingredient
                {
                    Name = txtIngredientName.Text.Trim(),
                    StockLevel = (int)numericUpDown1.Value
                };

                await _ingredientService.AddIngredientAsync(newIngredient);

                txtIngredientName.Clear();
                numericUpDown1.Value = 0;
                await LoadIngredientsAsync();

                MessageBox.Show("Ingredient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void btnAdjustStock_Click(object sender, EventArgs e)
        {
            if (dgvIngredients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an ingredient from the table first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int ingredientId = Convert.ToInt32(dgvIngredients.SelectedRows[0].Cells["Id"].Value);
                int adjustment = (int)numericUpDown2.Value;

                await _ingredientService.AdjustStockAsync(ingredientId, adjustment);
                await LoadIngredientsAsync();

                MessageBox.Show("Stock adjusted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adjusting stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvIngredients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an ingredient to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this ingredient?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int ingredientId = Convert.ToInt32(dgvIngredients.SelectedRows[0].Cells["Id"].Value);
                    await _ingredientService.DeleteIngredientAsync(ingredientId);
                    await LoadIngredientsAsync();

                    MessageBox.Show("Ingredient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string errorDetails = ex.InnerException?.Message ?? ex.Message;

                    // Safeguard warning: preventing deletion if ingredient is being used by recipe.
                    if (errorDetails.Contains("FOREIGN KEY", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Cannot delete ingredient: It is being used by recipes.",
                                        "Safeguard Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"Database Error: {errorDetails}",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

