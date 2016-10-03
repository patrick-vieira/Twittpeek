using System;
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
    public partial class userControl_Alg_BBST : UserControl
    {
        csMainTweetinvi oClassMainTweetinvi;

        public userControl_Alg_BBST(csMainTweetinvi Tweetinvi)
        {
            InitializeComponent();

            oClassMainTweetinvi = Tweetinvi;
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            /*
             * procedure bubbleSort( A : list of sortable items )
                    n = length(A)
                    repeat
                       swapped = false
                       for i = 1 to n-1 inclusive do
                          if A[i-1] > A[i] then
                             swap(A[i-1], A[i])
                             swapped = true
                          end if
                       end for
                       n = n - 1
                    until not swapped
                end procedure

                    */
        }
    }
}
