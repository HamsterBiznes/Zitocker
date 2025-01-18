using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zitocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.Inject();
            label4.Text = "Injected";
            label4.ForeColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InjectCheck_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "loadstring(game:HttpGet(('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'),true))()";
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "-- loadstring(game:HttpGet('https://rawscripts.net/raw/The-Strongest-Battlegrounds-Gojo-tsb-script-WORKS-ON-SOLARA-18641'))() -- Saitama(gojo)" +
                "\n -- loadstring(game:HttpGet('https://raw.githubusercontent.com/sandwichk/RobloxScripts/main/Scripts/BadWare/Hub/Load.lua', true))() -- Main" +
                "\n -- loadstring(game:HttpGet('https://raw.githubusercontent.com/Nova2ezz/Sukuna/refs/heads/main/KenjakuTsbOnYt'))() -- Saitama(sukuna)" +
                "\n -- loadstring(game:HttpGet('https://pastebin.com/raw/gUrBYsGK'))() -- atomic samurai(sukuna)";
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "loadstring(game:HttpGet('https://raw.githubusercontent.com/AhmadV99/Speed-Hub-X/main/Speed%20Hub%20X.lua', true))()";
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "loadstring(game:HttpGet('https://pastefy.app/wa3v2Vgm/raw'))() -- R6";
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "loadstring(game:HttpGet('https://rawscripts.net/raw/Universal-Script-SeX-animation-gui-made-by-Verbal-Hub-Only-R6-26458'))()";
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }
    }
}
