﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ChessBroad = new ChessBroadManager(pnlChessBroad, txbPlayerName, ptcbMark);
            ChessBroad.EndedGame += ChessBroad_EndedGame;
            ChessBroad.PlayerMarked += ChessBroad_PlayerMarked;
            
            prcbCoolDown.Step = Cons.COOL_DOWN_STEP;
            prcbCoolDown.Maximum = Cons.COOL_DOWN_TIME;
            prcbCoolDown.Value = 0;
            
            tmCoolDown.Interval = Cons.COOL_DOWN_INTERVAL;
            
            ChessBroad.DrawChessBoard();
        }

        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBroad.Enabled = false;
            MessageBox.Show("Kết thúc!");
        }
        private void ChessBroad_PlayerMarked(object? sender, EventArgs e)
        {
            tmCoolDown.Start();
            prcbCoolDown.Value = 0;
        }

        private void ChessBroad_EndedGame(object? sender, EventArgs e)
        {
            EndGame();
        }
        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prcbCoolDown.PerformStep();

            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                EndGame();
            }
        }
    }
}
