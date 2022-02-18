using System;
using System.Windows.Forms;

namespace MorseFlyweight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string document = textBox1.Text;
            char[] chars = document.ToCharArray();
            var factory = new CharacterFactory();
            
            foreach (char c in chars)
            {
                var character = factory[c];
                character.Display( textBox2);
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
