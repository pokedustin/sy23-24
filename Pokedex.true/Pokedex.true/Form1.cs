using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
        private int count;
        private Pokemon[] pokemons=new Pokemon[50];
        public Form1()
        {
            InitializeComponent();
            current = 1;
            last = 3;
            Currentlabel.Text=current.ToString();
        }
        private Pokemon ReadPokemon(string s)
        {
            Pokemon p = JsonSerializer.Deserialize<Pokemon>(s);
            

            return p;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists("Pokemon.txt"))
            {
                StreamReader infile = new StreamReader("Pokemon.txt");
                while (infile.EndOfStream)
                {
                    string S=infile.ReadLine();
                    Pokemon p=ReadPokemon(S);
                    ShowPokemon(p);
                    count++;
                    
                }
                infile.Close();
                ShowPokemon(pokemons[0]);
                
            }
            else
            {
                Pokemon p = new Pokemon();
                p.name = "pikachu";
                p.spatk = 75;
                p.atk = 65;
                p.def = 25;
                p.spdef = 25;
                p.HP = 38;
                p.level = 17;
                p.Exp = 30507;
                p.generation = 1;
                p.legendary=false;
                p.Shiny=true;
                pokemons[0] = p;
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
            Save();
           /* string tmp = "";
            tmp += nametext.Text;
            tmp += "|";
            tmp += typetext.Text;
            tmp += "|";
            tmp += leveltext.Text;
            tmp += "|";
            tmp += atktext.Text;
            tmp += "|";
            tmp += gentext.Text;
            tmp += "|";
            tmp += HPtext.Text;
            tmp += "|";
            tmp += deftext.Text;
            tmp += "|";
            tmp += Legendcheck.Checked;
            tmp += "|";
            tmp += Shinycheck.Checked;
            tmp += "|";
            tmp += spatktext.Text;
            tmp += "|";
            tmp += spdeftext.Text;
            tmp += "|";
            if (Legendcheck.Checked && Shinycheck.Checked)
            {
                debugbox.Text += "Hacked";
                debugbox.Text += "|";
            }
            StreamWriter outfile = new StreamWriter("Pokemon.txt");
            outfile.Write(tmp);
            outfile.Close();*/

        }
        public void Save()
        {
            StreamWriter outFile = new System.IO.StreamWriter("Pokemon.txt");
            for (int i = 0; i < count; i++)
            {
                string jsonString = JsonSerializer.Serialize(pokemons[i]);
                outFile.WriteLine(jsonString);
            }
            outFile.Close();
        }

        private void ShowPokemon(Pokemon p)
        {
            nametext.Text = p.name;
        }

        

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            Save();
            current = 0;
            Currentlabel.Text = current.ToString();
            ShowPokemon(pokemons[current]);
        }

        private void Lastbutton_Click(object sender, EventArgs e)
        {
            Save();
            current = count - 1;
            Currentlabel.Text = current.ToString();
            ShowPokemon(pokemons[current]);
        }

        private void currentbutton_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
                Save();
                //this line makes you a cool programmer!
                current--;
                Currentlabel.Text = current.ToString();
                ShowPokemon(pokemons[current]);
            }
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            if (current < count - 1)
            {
                Save();
                current++;
                Currentlabel.Text = current.ToString();
                ShowPokemon(pokemons[current]);
            }
        }

        private void clear()
        {
            nametext.Text = "";
            typetext.Text = "";
            leveltext.Text="";
            atktext.Text = "";
            gentext.Text = "";
            HPtext.Text = "";
            deftext.Text = "";
            Legendcheck.Checked = false;
            Shinycheck.Checked = false;
            spatktext.Text = "";
            spdeftext.Text="";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            current=count;
            count++;

        }
    }
}
