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
public struct Pokemon 
{
    public string name;
    public string Type;
    public int level;
    public int HP;
    public int spdef;
    public int spatk;
    public int atk;
    public int def;
    public int Exp;
    public bool legendary;
    public bool Shiny;
    public int generation;
}
namespace Pokedex.@true
{
    
    public partial class Form1 : Form
    {
        private int current;
        private int last;
        public Form1()
        {
            InitializeComponent();
            current = 1;
            last = 3;
            Currentlabel.Text=current.ToString();
        }
        private Pokemon ReadPokemon(string s)
        {
            Pokemon p = new Pokemon();
            string[] fields = s.Split('|');
            p.name = fields[0];
            p.Type = fields[1];
            p.level = int.Parse(fields[2]);
            p.atk = int.Parse( fields[3]);
            p.def = int.Parse(fields[4]);
            p.HP = int.Parse(fields[5]);
            p.Exp = int.Parse(fields[6]);
            if (fields[7] == "True")
                p.legendary = true;
            else
                p.legendary = false;
            if (fields[8] == "True")
                p.Shiny = true;
            else
                p.Shiny = false;
            p.generation = int.Parse(fields[9]);

            return p;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.txt"))
            {
                StreamReader infile=new
            }
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

        

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            if (current > 1)
            {
                current--;
                Currentlabel.Text=current.ToString();
            }
        }

        private void Lastbutton_Click(object sender, EventArgs e)
        {
            current = last;
        }

        private void currentbutton_Click(object sender, EventArgs e)
        {

        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            if (current < 1)
            {
                current++;
                Currentlabel.Text = current.ToString();
            }
        }
    }
}
