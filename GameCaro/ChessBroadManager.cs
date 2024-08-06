using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    public class ChessBroadManager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }
        #endregion

        #region Initialize
        public ChessBroadManager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            Button oldBtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                    };
                    ChessBoard.Controls.Add(btn);
                    oldBtn = btn;
                }
                oldBtn.Location = new Point(0, oldBtn.Location.Y + Cons.CHESS_HEIGHT);
                oldBtn.Width = 0;
                oldBtn.Height = 0;
            }
        }
    }
    #endregion

}
