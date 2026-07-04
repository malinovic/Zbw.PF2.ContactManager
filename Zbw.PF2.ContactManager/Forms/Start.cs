using MaterialSkin.Controls;

namespace Zbw.PF2.ContactManager
{
    public partial class Start : MaterialForm
    {
        public Start()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900,
                MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE

                // Das ist ein Testkommentar
            );
        }
    }
}