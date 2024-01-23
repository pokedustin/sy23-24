using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
struct Struct 
{
    string name;
    string Type;
    int level;
    int HP;
    int spdef;
    int spatk;
    int atk;
    int def;
    int Exp;
    bool legendary;
    bool Shiny;
    int generation;
}
namespace Pokedex.@true
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            debugbox.Text += nametext.Text;
            debugbox.Text += "|";
            debugbox.Text += typetext.Text;
            debugbox.Text += "|";
            debugbox.Text += leveltext.Text;
            debugbox.Text += "|";
            debugbox.Text += atktext.Text;
            debugbox.Text += "|";
            debugbox.Text += gentext.Text;
            debugbox.Text += "|";
            debugbox.Text += HPtext.Text;
            debugbox.Text += "|";
            debugbox.Text += deftext.Text;
            debugbox.Text += "|";
            debugbox.Text += Legendcheck.Checked;
            debugbox.Text += "|";
            debugbox.Text += Shinycheck.Checked;
            debugbox.Text += "|";
            debugbox.Text += spatktext.Text;
            debugbox.Text += "|";
            debugbox.Text += spdeftext.Text;
            debugbox.Text += "|";
            if (Legendcheck.Checked && Shinycheck.Checked)
            {
                debugbox.Text += "Hacked";
                debugbox.Text += "|";
            }
            StreamWriter outfile = new StreamWriter("Pokemon.txt");
            outfile.Write(debugbox.Text);
            outfile.Close();

        }
        private void ShowPokemon()
        {

        }
    }
}
