
namespace WinForms_Custom_Potion_Brewing_System.Forms
{
    public partial class PotionEffectForm : Form
    {
        private readonly string _potionName;
        private readonly string _specialEffect;
        public PotionEffectForm(string potionName, string specialEffect)
        {
            InitializeComponent();

            _potionName = potionName;
            _specialEffect = specialEffect;
        }

        private void PotionEffectForm_Load(object sender, EventArgs e)
        {

            label5.Text = _potionName;
            label6.Text = _specialEffect;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}
