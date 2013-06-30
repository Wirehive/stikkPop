using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stikkPop
{
    public partial class History : Form
    {
        public static List<Tuple<string, string>> HistoryList = new List<Tuple<string, string>>
        {
                Tuple.Create( "hello","world"),
                Tuple.Create( "foo","bar"),
                Tuple.Create( "cow","chicken")
        };

        public History()
        {
            InitializeComponent();

            historyListBox.DataSource=HistoryList;

        }

        public static void AddHistory(string time, string link)
        {
            HistoryList.Add(Tuple.Create(time,link));
        }
    }
}
