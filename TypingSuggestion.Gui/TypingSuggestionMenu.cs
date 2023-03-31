using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingSuggestion.Gui
{
    public partial class TypingSuggestionMenu : Form
    {
        public TypingSuggestionMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) ||
           (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            {
                // Get the character corresponding to the key code
                char keyChar = (char)e.KeyCode;

                // Append the character to the textbox
                textBox2.AppendText(keyChar.ToString());
            }
        }
    }
}
