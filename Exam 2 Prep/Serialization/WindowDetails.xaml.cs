using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Serialization
{
    /// <summary>
    /// Interaction logic for WindowDetails.xaml
    /// </summary>
    public partial class WindowDetails : Window
    {
        public WindowDetails()
        {
            InitializeComponent();
        }

        public void SetData (Game selectedgame)
        {
            txtMetaScore.Text = selectedgame.meta_score.ToString();
            txtName.Text = selectedgame.name.ToString();
            txtPlatform.Text = selectedgame.platform.ToString();
            txtReleaseDate.Text = selectedgame.release_date.ToString();
            txtReview.Text = selectedgame.user_review.ToString();
            txtSummary.Text = selectedgame.summary.ToString();

            Title = $"{selectedgame.name}'s Info";

        }
    }
}
