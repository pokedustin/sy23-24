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
        private Pokemon ReadPokemon(string s)
        {
            Pokemon p = new Pokemon();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.Type = fields[1];
            p.Level = int.Parse(fields[2]);
            p.Atk = int.Parse( fields[3]);
            p.HP = int.Parse(fields[4]);
            p.Exp = int.Parse(fields[5]);
            if (fields[6] == "True")
                p.Legendary = true;
            else
                p.Legendary = false;
            if (fields[7] == "True")
                p.Shiny = true;
            else
                p.Shiny = false;
            p.Gen = int.Parse(fields[8]);

            return p;
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
