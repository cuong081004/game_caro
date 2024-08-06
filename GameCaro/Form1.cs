namespace GameCaro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBroadManager ChessBroad;
        #endregion
        public Form1()
        {
            InitializeComponent();
            ChessBroad = new ChessBroadManager(pnlChessBroad);
            ChessBroad.DrawChessBoard();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
