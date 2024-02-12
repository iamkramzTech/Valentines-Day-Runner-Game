using MaterialSkin;
using MaterialSkin.Controls;
using static System.Formats.Asn1.AsnWriter;
using System.Windows.Forms;
namespace ValentinesDay
{
    public partial class Form1 : MaterialForm
    {
        private Character _mario;
        private List<IObstacle> _obstacles;
        private int _groundLevel = 650;
        private int _obstacleSpeed = 5;
        private bool _isJumping = false;

        private bool _isGameOver = false;
        private bool _isFalling = false;

        private bool _isSpaceKeyDown = false;
        //private int _jumpSpeed;
        private int _score = 0;
        //private int _position;
        //private int _force;
        //private int _obstacleSpeed = 20;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            InitializeColorScheme();

            InitializeGame();

            //ResetGame();
        }

        /// <summary>
        /// This method initialize a color scheme of the MaterialSkin Form
        /// during runtime
        /// </summary>
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

        /// <summary>
        /// This method initialize a game to start
        /// </summary>
        private void InitializeGame()
        {
            _obstacles = new List<IObstacle>();
            _mario = new Mario(Mario, 3, 0);
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimer_Tick;
            GameTimer.Start();
        }
        /// <summary>
        /// This method is triggered on each tick of the game timer.
        /// If the control is a PictureBox and tagged as an "obstacle",
        /// it updates the control and stops the game if there's an intersection.
        /// If the control is tagged as a "heart",it updates the control and increases the score if there's an intersection.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            lblScore.Text = $"Score: {_score}";
            if (!_isSpaceKeyDown)
            {
                _isJumping = false;
            }
            _mario.Update(_isJumping, _groundLevel);

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    if ((string)control.Tag == "obstacle")
                    {
                        UpdateControl(control, () =>
                        {
                            GameTimer.Stop();
                            _mario.CharacterPictureBox.Image = Properties.Resources.mario_steady;
                            _isGameOver = true;
                        });
                    }
                    else if ((string)control.Tag == "heart")
                    {
                        UpdateControl(control, () =>
                        {
                            _score += 1;
                            control.Left = ClientSize.Width + random.Next(300, 800) + (control.Width * 10);

                            if (_score > 2)
                                _obstacleSpeed += 20;
                        });
                    }
                }
            }


            Invalidate();
        }

        /// <summary>
        /// This method is triggered when a key is pressed down in the form.
        /// If the space key or up key is pressed,
        /// and the character is not currently jumping and is on the ground,
        /// it sets _isJumping to true,  makes the character jump, and sets _isSpaceKeyDown to true.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A KeyEventArgs that contains the event data.</param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space || e.KeyCode == Keys.Up) && !_isJumping && _mario.CharacterPictureBox.Top == _groundLevel)
            {
                _isJumping = true;
                _mario.Jump();
                _isSpaceKeyDown = true;
            }
        }

        /// <summary>
        /// This method is triggered when a key is released in the form. If the space key or up key is released, 
        ///  it sets _isSpaceKeyDown to false. If the game is over and the space key or up key is released,
        ///  If the game is over and the space key or up key is released,it resets the game.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A KeyEventArgs that contains the event data.</param>
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {
                // _isJumping = false;
                _isSpaceKeyDown = false;
            }
            if ((e.KeyCode==Keys.Space || e.KeyCode == Keys.Up) && _isGameOver)
            {
                ResetGame();
            }
        }
        /// <summary>
        ///  This method resets the game to its initial state. It resets all game variables,
        ///  updates the score label, and restarts the game timer.
        /// </summary>
        private void ResetGame()
        {
            _groundLevel = 650;
            lblScore.Text = $"Score: {_score}";
            _score = 0;
            _obstacleSpeed = 5;
            _isJumping = false;
            _isGameOver = false;
            _isFalling = false;
            _isSpaceKeyDown = false;

            _mario.CharacterPictureBox.Image = Properties.Resources.mario_run;
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && (string)control.Tag == "obstacle")
                {
                    control.Left = ClientSize.Width + random.Next(500, 800) + (control.Width * 40);
                }
            }
            GameTimer.Start();
        }

        /// <summary>
        /// This method updates a control's position and checks for intersections with the Mario character. 
        ///  If there's an intersection, it executes a specified action.
        /// </summary>
        /// <param name="control">The control to update.</param>
        /// <param name="onIntersection">The action to execute if there's an intersection.</param>
        private void UpdateControl(Control control, Action onIntersection)
        {
            control.Left -= _obstacleSpeed;

            if (control.Left < -100)
            {
                control.Left = ClientSize.Width + random.Next(200, 500) + (control.Width * 15);
            }

            if (_mario.CharacterPictureBox.Bounds.IntersectsWith(control.Bounds))
            {
                onIntersection();
            }
        }
        //private void Form1_Load(object sender, EventArgs e)
        //{


        //}

    }
}

