﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwittPeek.userControls
{
    public partial class userControl_SendTwitt : UserControl
    {

        csMainTweetinvi oClassMainTweetinvi;
        int nCountChar = 140;

        public userControl_SendTwitt(csMainTweetinvi Tweetinvi)
        {
            InitializeComponent();

            oClassMainTweetinvi = Tweetinvi;
        }

        private void btnTweetPost_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Status info:";

            if (txtTweetBox.TextLength > 0)
            {

                if (oClassMainTweetinvi.mPostTwitt(txtTweetBox.Text))
                {
                    lblStatus.Text += " Texto publicado!";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text += " Falha ao publicar texto!";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            else
            {
                lblStatus.Text += " Falha! Caixa de texto com 0 caracteres.";
                lblStatus.ForeColor = Color.Red;
            }

        }

        private void txtTweetBox_TextChanged(object sender, EventArgs e)
        {
            if (txtTweetBox.TextLength >= nCountChar)
            {
                btnTweetPost.Enabled = false;

                txtTweetBox.ForeColor = Color.Red;
            }
            else
            {
                txtTweetBox.ForeColor = Color.CornflowerBlue;

                btnTweetPost.Enabled = true;
            }

            lblTweetCounter.Text = (nCountChar - txtTweetBox.TextLength).ToString();
        }
    }
}
