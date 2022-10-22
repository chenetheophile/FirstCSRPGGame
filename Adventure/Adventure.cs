using Engine;

namespace Adventure
{
    public partial class Adventure : Form
    {
        private Player _player;
        public Adventure()
        {
            InitializeComponent();
            _player = new Player(10,10,20,0,1);

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

            Location location = new Location(1,"Home","This is your house");
        }

        private void Adventure_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}