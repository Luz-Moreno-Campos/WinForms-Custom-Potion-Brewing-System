
using WinForms_Custom_Potion_Brewing_System.Services;

namespace WinForms_Custom_Potion_Brewing_System.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly BrewedPotionService _brewedPotionService;
        private readonly IngredientForm _ingredientForm;
        private readonly RecipeForm _recipeForm;
        private readonly BrewingForm _brewingForm;
        public DashboardForm(BrewedPotionService brewedPotionService,
            IngredientForm ingredientForm,
            RecipeForm recipeForm,
            BrewingForm brewingForm)
        {
            InitializeComponent();

            _brewedPotionService = brewedPotionService;
            _ingredientForm = ingredientForm;
            _recipeForm = recipeForm;
            _brewingForm = brewingForm;
        }

        private async Task LoadDashboardAsync()
        {
            try
            {
                dgvFrequentlyBrewed.DataSource = await _brewedPotionService.GetMostFrequentlyBrewedPotionsAsync();
                dgvFrequentlyBrewed.Columns["TimesBrewed"].HeaderText = "Times Brewed";
                
                dgvMostConsumed.DataSource = await _brewedPotionService.GetMostHeavilyConsumedIngredientsAsync();
                dgvMostConsumed.Columns["TotalConsumed"].HeaderText ="Total Consumed";
                
                lblThroughput.Text = (await _brewedPotionService.GetBrewingThroughputAsync(
                        dtpFrom.Value,
                        dtpTo.Value))
                    .ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            //To start wtih a 30-day range
            dtpTo.Value = DateTime.Today;
            dtpFrom.Value = DateTime.Today.AddDays(-30);

            await LoadDashboardAsync();
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            await LoadDashboardAsync();
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            this.Hide();
            _ingredientForm.ShowDialog();
            this.Show();
        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            this.Hide();
            _recipeForm.ShowDialog();
            this.Show();
        }

        private void btnBrewingHub_Click(object sender, EventArgs e)
        {
            this.Hide();
            _brewingForm.ShowDialog();
            this.Show();
        }
    }
}

