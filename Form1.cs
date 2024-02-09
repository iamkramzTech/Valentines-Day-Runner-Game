using MaterialSkin;
using MaterialSkin.Controls;
namespace ValentinesDay
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            //Initialize Color scheme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink600,  // primary color
                Primary.Pink700,  // dark primary color
                Primary.Pink200,  // light primary color
                Accent.Red200,    // accent color
                TextShade.WHITE   // text color
                );
        }
    }
}
