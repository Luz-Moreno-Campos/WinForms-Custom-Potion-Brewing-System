using WinForms_Custom_Potion_Brewing_System.Models;
using WinForms_Custom_Potion_Brewing_System.Services;

namespace WinForms_Custom_Potion_Brewing_System.Forms
{
    public partial class RecipeForm : Form
    {
        private readonly RecipeService _recipeService;
        private readonly IngredientService _ingredientService;

        private Recipe? _selectedRecipe;

        private List<RecipeIngredient> _currentRecipeIngredients = new();

        public RecipeForm(RecipeService recipeService, IngredientService ingredientService)
        {
            InitializeComponent();
            _recipeService = recipeService;
            _ingredientService = ingredientService;

        }

        private async Task LoadRecipesAsync()
        {
            var recipes = await _recipeService.GetAllRecipesAsync();

            dgvRecipes.DataSource = recipes;
            dgvRecipes.Columns["SpecialEffect"].HeaderText = "Special Effect";
            dgvRecipes.Columns["BrewingDurationSeconds"].HeaderText = "Brewing Time";

            if (dgvRecipes.Columns["Id"] != null)
                dgvRecipes.Columns["Id"].Visible = false;

            if (dgvRecipes.Columns["RecipeIngredients"] != null)
                dgvRecipes.Columns["RecipeIngredients"].Visible = false;

            if (dgvRecipes.Columns["BrewedPotions"] != null)
                dgvRecipes.Columns["BrewedPotions"].Visible = false;
        }

        private async Task LoadIngredientsAsync()
        {
            var ingredients = await _ingredientService.GetAllIngredientsAsync();

            cmbIngredient.DataSource = ingredients;
            cmbIngredient.DisplayMember = "Name";
            cmbIngredient.ValueMember = "Id";
        }

        private async void RecipeForm_Load(object sender, EventArgs e)
        {
            await LoadIngredientsAsync();
            await LoadRecipesAsync();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _selectedRecipe = null;
            _currentRecipeIngredients.Clear();
            txtRecipeName.Clear();
            txtSpecialEffect.Clear();
            nudBrewingDuration.Value = 0;
            nudRequiredQuantity.Value = 0;
            dgvIngredients.DataSource = null;
            txtRecipeName.Focus();
        }

        private void HideIngredientColumns()
        {
            if (dgvIngredients.Columns["Id"] != null)
                dgvIngredients.Columns["Id"].Visible = false;

            if (dgvIngredients.Columns["RecipeId"] != null)
                dgvIngredients.Columns["RecipeId"].Visible = false;

            if (dgvIngredients.Columns["Recipe"] != null)
                dgvIngredients.Columns["Recipe"].Visible = false;

            if (dgvIngredients.Columns["IngredientId"] != null)
                dgvIngredients.Columns["IngredientId"].Visible = false;
        }

        private void RefreshIngredientsGrid()
        {
            dgvIngredients.DataSource = null;
            dgvIngredients.DataSource = _currentRecipeIngredients
                .Select(ri => new
                {
                    IngredientId = ri.IngredientId, 
                    Ingredient = ri.Ingredient != null ? ri.Ingredient.Name : "N/A",
                    QuantityRequired = ri.QuantityRequired
                })
                .ToList();

            if (dgvIngredients.Columns["QuantityRequired"] != null)
                dgvIngredients.Columns["QuantityRequired"].HeaderText = "Quantity";

            HideIngredientColumns();
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            if (cmbIngredient.SelectedValue == null) return;

            int ingredientId = (int)cmbIngredient.SelectedValue;
            int newQuantity = (int)nudRequiredQuantity.Value;

            if (newQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RecipeIngredient? existingIngredient = _currentRecipeIngredients.FirstOrDefault(
                ri => ri.IngredientId == ingredientId);

            if (existingIngredient != null)
            {
                existingIngredient.QuantityRequired = newQuantity;
            }
            else
            {
                Ingredient ingredient = (Ingredient)cmbIngredient.SelectedItem;

                RecipeIngredient recipeIngredient = new RecipeIngredient
                {
                    IngredientId = ingredient.Id,
                    Ingredient = ingredient,
                    QuantityRequired = newQuantity
                };

                _currentRecipeIngredients.Add(recipeIngredient);
            }

            RefreshIngredientsGrid();
        }

        private void btnRemoveIngredient_Click(object sender, EventArgs e)
        {
            if (dgvIngredients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an ingredient from the table to remove.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIngredientId = Convert.ToInt32(dgvIngredients.SelectedRows[0].Cells["IngredientId"].Value);

            RecipeIngredient? recipeIngredient = _currentRecipeIngredients.FirstOrDefault(
                ri => ri.IngredientId == selectedIngredientId);

            if (recipeIngredient == null)
            {
                MessageBox.Show("This ingredient is not part of the recipe.","Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var confirmResult = MessageBox.Show( "Are you sure you want to remove this ingredient from the recipe?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                _currentRecipeIngredients.Remove(recipeIngredient);

                RefreshIngredientsGrid();

                nudRequiredQuantity.Value = 0;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRecipes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a recipe first.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selectedRecipe = (Recipe)dgvRecipes.SelectedRows[0].DataBoundItem;

            txtRecipeName.Text = _selectedRecipe.Name;
            txtSpecialEffect.Text = _selectedRecipe.SpecialEffect;
            nudBrewingDuration.Value = _selectedRecipe.BrewingDurationSeconds;

            _currentRecipeIngredients = _selectedRecipe.RecipeIngredients
                .Select(ri => new RecipeIngredient
                {
                    Id = ri.Id,
                    RecipeId = ri.RecipeId,
                    IngredientId = ri.IngredientId,
                    Ingredient = ri.Ingredient,
                    QuantityRequired = ri.QuantityRequired
                })
                .ToList();

            RefreshIngredientsGrid();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvIngredients.SelectedRows.Count > 0 && dgvIngredients.SelectedRows[0].Cells["IngredientId"].Value != null)
            {
                int currentIngId = (int)dgvIngredients.SelectedRows[0].Cells["IngredientId"].Value;
                var targetIng = _currentRecipeIngredients.FirstOrDefault(ri => ri.IngredientId == currentIngId);
                if (targetIng != null)
                {
                    targetIng.QuantityRequired = (int)nudRequiredQuantity.Value;
                }
            }

            if (string.IsNullOrWhiteSpace(txtRecipeName.Text))
            {
                MessageBox.Show("Please enter a recipe name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSpecialEffect.Text))
            {
                MessageBox.Show("Please enter a special effect.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_currentRecipeIngredients.Count == 0)
            {
                MessageBox.Show("Please add at least one ingredient.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Temporarily stop this event so it doesn't trigger itself again while refreshing
                dgvRecipes.SelectionChanged -= dgvRecipes_SelectionChanged;
                dgvIngredients.SelectionChanged -= dgvIngredients_SelectionChanged;

                if (_selectedRecipe == null)
                {
                    Recipe recipe = new Recipe
                    {
                        Name = txtRecipeName.Text.Trim(),
                        SpecialEffect = txtSpecialEffect.Text.Trim(),
                        BrewingDurationSeconds = (int)nudBrewingDuration.Value,
                        RecipeIngredients = _currentRecipeIngredients
                    };

                    await _recipeService.AddRecipeAsync(recipe);
                    MessageBox.Show("Recipe added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _selectedRecipe.Name = txtRecipeName.Text.Trim();
                    _selectedRecipe.SpecialEffect = txtSpecialEffect.Text.Trim();
                    _selectedRecipe.BrewingDurationSeconds = (int)nudBrewingDuration.Value;
                    _selectedRecipe.RecipeIngredients = _currentRecipeIngredients;

                    await _recipeService.UpdateRecipeAsync(_selectedRecipe);
                    MessageBox.Show("Recipe updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _selectedRecipe = null;
                _currentRecipeIngredients = new List<RecipeIngredient>();
                dgvIngredients.DataSource = null;

                /*
                  Temporarily disable validation while clearing inputs
                  to prevent false validation error popup when clearing textboxes
                */
                txtRecipeName.CausesValidation = false;
                txtSpecialEffect.CausesValidation = false;

                txtRecipeName.Clear();
                txtSpecialEffect.Clear();
                nudBrewingDuration.Value = 0;
                nudRequiredQuantity.Value = 0;

                txtRecipeName.CausesValidation = true;
                txtSpecialEffect.CausesValidation = true;

                await LoadRecipesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving recipe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Re-subscribe events
                dgvRecipes.SelectionChanged += dgvRecipes_SelectionChanged;
                dgvIngredients.SelectionChanged += dgvIngredients_SelectionChanged;
            }
        }
        private async void dgvRecipes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRecipes.SelectedRows.Count == 0)
            {
                return;
            }

            if (dgvRecipes.SelectedRows[0].DataBoundItem is Recipe selectedRecipe)
            {
                Recipe fullRecipe = await _recipeService.GetRecipeByIdAsync(selectedRecipe.Id);

                if (fullRecipe != null && fullRecipe.RecipeIngredients != null)
                {
                    _currentRecipeIngredients = fullRecipe.RecipeIngredients.ToList();
                    RefreshIngredientsGrid();
                }
            }
        }

        private void dgvIngredients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIngredients.SelectedRows.Count == 0 || dgvIngredients.DataSource == null) return;

            if (dgvIngredients.SelectedRows[0].Cells["IngredientId"].Value != null)
            {
                int ingredientId = (int)dgvIngredients.SelectedRows[0].Cells["IngredientId"].Value;

                if (cmbIngredient.SelectedValue == null || (int)cmbIngredient.SelectedValue != ingredientId)
                {
                    cmbIngredient.SelectedValue = ingredientId;
                }

                var recipeIngredient = _currentRecipeIngredients.FirstOrDefault(ri => ri.IngredientId == ingredientId);
                if (recipeIngredient != null)
                {
                    nudRequiredQuantity.Value = recipeIngredient.QuantityRequired;
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRecipes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a recipe from the table to delete.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Recipe selectedRecipe = (Recipe)dgvRecipes.SelectedRows[0].DataBoundItem;

            var confirmResult = MessageBox.Show($"Are you sure you want to delete the recipe '{selectedRecipe.Name}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    await _recipeService.DeleteRecipeAsync(selectedRecipe.Id);
                    MessageBox.Show("Recipe deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clean selection and interface
                    btnCreate_Click(sender, e);
                    await LoadRecipesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting recipe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _selectedRecipe = null;
            _currentRecipeIngredients.Clear();

            txtRecipeName.CausesValidation = false;
            txtSpecialEffect.CausesValidation = false;

            txtRecipeName.Clear();
            txtSpecialEffect.Clear();
            nudBrewingDuration.Value = 0;
            nudRequiredQuantity.Value = 0;

            txtRecipeName.CausesValidation = true;
            txtSpecialEffect.CausesValidation = true;

            dgvIngredients.DataSource = null;

            if (dgvRecipes.SelectedRows.Count > 0)
            {
                dgvRecipes.ClearSelection();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}