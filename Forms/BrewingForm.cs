
using WinForms_Custom_Potion_Brewing_System.Services;

namespace WinForms_Custom_Potion_Brewing_System.Forms
{
    public partial class BrewingForm : Form
    {
        private readonly BrewedPotionService _brewingService;
        private readonly RecipeService _recipeService;
        public BrewingForm(BrewedPotionService brewingService, RecipeService recipeService)
        {
            InitializeComponent();
            _brewingService = brewingService;
            _recipeService = recipeService;

        }
        private async Task LoadRecipesAsync()
        {
            var recipes = await _recipeService.GetAllRecipesAsync();

            cmbRecipes.DataSource = recipes;
            cmbRecipes.DisplayMember = "Name";
            cmbRecipes.ValueMember = "Id";
        }

        private async Task LoadBrewedPotionsAsync()
        {
            try
            {
                var brewedPotions = await _brewingService.GetAllBrewedPotionsAsync();

                var displayList = brewedPotions.Select(bp => new
                {
                    bp.Id, 
                    RecipeName = bp.Recipe != null ? bp.Recipe.Name : "Unknown Recipe",
                    SpecialEffect = bp.Recipe != null ? bp.Recipe.SpecialEffect : "Unknown Effect",
                    bp.CreatedAt
                }).ToList();

                dgvBrewedPotions.DataSource = displayList;
                dgvBrewedPotions.Columns["RecipeName"].HeaderText = "Potion Name";

                if (dgvBrewedPotions.Columns["Id"] != null)
                    dgvBrewedPotions.Columns["Id"].Visible = false;

                if (dgvBrewedPotions.Columns["CreatedAt"] != null)
                    dgvBrewedPotions.Columns["CreatedAt"].Visible = false; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading brewed potions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BrewingForm_Load(object sender, EventArgs e)
        {
            await LoadRecipesAsync();
           await LoadBrewedPotionsAsync();
        }

        private void btnStartBrewing_Click(object sender, EventArgs e)
        {
            if (cmbRecipes.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid recipe first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
           int recipeId = (int)cmbRecipes.SelectedValue;

            progressBar.Value = 0;

            //Disable contorls to prevent double-clicks
            btnStartBrewing.Enabled = false;
            cmbRecipes.Enabled = false;

            timerBrewing.Start();

        }

        private async void timerBrewing_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 1;
            }
            else
            {
                timerBrewing.Stop();

                int recipeId = (int)cmbRecipes.SelectedValue;

                try
                {
                    await _brewingService.BrewPotionAsync(recipeId);

                    MessageBox.Show("Potion brewed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await LoadBrewedPotionsAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Brewing Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnStartBrewing.Enabled = true;
                    cmbRecipes.Enabled = true;
                    progressBar.Value = 0;
                }
            }
        }


        private void btnConsumePotion_Click(object sender, EventArgs e)
        {
            if (dgvBrewedPotions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a brewed potion to consume.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvBrewedPotions.SelectedRows[0];
            int brewedPotionId = (int)selectedRow.Cells["Id"].Value;

            string potionName = selectedRow.Cells["RecipeName"].Value?.ToString() ?? "Unknown";
            string specialEffect = selectedRow.Cells["SpecialEffect"]?.Value?.ToString() ?? "Unknown";

            try
            {
                using (PotionEffectForm effectForm = new PotionEffectForm(potionName, specialEffect))
                {
                    effectForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error consuming potion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBrewedPotions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a brewed potion to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int brewedPotionId = (int)dgvBrewedPotions.SelectedRows[0].Cells["Id"].Value;

            var confirm = MessageBox.Show("Are you sure you want to delete this brewed potion?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            try
            {
                await _brewingService.DeleteBrewedPotionAsync(brewedPotionId);

                MessageBox.Show("Potion deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadBrewedPotionsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

