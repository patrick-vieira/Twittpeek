﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwittPeek.userControls.algoritmos
{
    public partial class userControl_Alg_MGST : UserControl
    {
        csMainTweetinvi oClassMainTweetinvi;

        public userControl_Alg_MGST(csMainTweetinvi Tweetinvi)
        {
            InitializeComponent();

            oClassMainTweetinvi = Tweetinvi;
        }
    }
}
