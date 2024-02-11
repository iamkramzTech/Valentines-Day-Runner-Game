using MaterialSkin;
using MaterialSkin.Controls;
namespace ValentinesDay
{
    public partial class Form1 : MaterialForm
    {
        private Character _mario;
        private const int _groundLevel = 650;
        private bool _isJumping = false;
        ////private List<IObstacle> obstacles;
        //private bool _isGameOver = false;
        //private bool _isJumping = false;
        //private int _jumpSpeed;
        //private int _score = 0;
        //private int _position;
        //private int _force;
        //private int _obstacleSpeed = 20;
        //Random random = new Random();



        public Form1()
        {
            InitializeComponent();

            InitializeColorScheme();

            InitializeGame();
        }

        private void InitializeColorScheme()
        {
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

        private void InitializeGame()
        {
            _mario = new Mario(Mario, 3, 0);
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimer_Tick;
            GameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            _mario.Update(_isJumping, _groundLevel);

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode==Keys.Up && !_isJumping)
            {
                _isJumping = true;
                _mario.Jump();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space || e.KeyCode==Keys.Up)
            {
                _isJumping = false;
            }    
        }
    }
}
