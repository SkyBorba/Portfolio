using System;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class Intro : Form
    {
        PokedexGen2 pokemon = new PokedexGen2();

        public Intro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Opens the main pokédex
           pokemon.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {   
            //closes the form 
            Close();
        }

    }
 }


