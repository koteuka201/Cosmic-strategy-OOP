using CosmStarategy.Buildings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmStarategy
{
    public partial class MapOFBuild : Form
    {
        public Boolean indicator { get; set; }
        Map map = new Map();
        private List<List<PictureBox>> pictureBoxes = new List<List<PictureBox>>();
        private int selectedColumn, selectedRow;
        private List<string> listBuildings = new List<string>() { "BoreHole", "StorageOfMetal", "PowerPlant", "ExchangeTerminal", "Garage", "ChillRoom", "Planitatium", "TGU", "MemRoom", "Gallery" };
        public MapOFBuild()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                pictureBoxes.Add(new List<PictureBox>());

                for (int j = 0; j < 7; j++)
                {
                    pictureBoxes[i].Add(new PictureBox());

                    pictureBoxes[i][j].SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxes[i][j].Image = Image.FromFile("pictures//пустота.png");

                    Table.Controls.Add(pictureBoxes[i][j], j, i);
                    pictureBoxes[i][j].Click += PictureBox_Click;
                }
            }

            foreach (string s in listBuildings)
            {
                comboBox.Items.Add(s);
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            selectedColumn = Table.GetColumn(pictureBox);
            selectedRow = Table.GetRow(pictureBox);
            string name = map.getName(selectedRow, selectedColumn);
            if (name == "ExchangeTerminal")
            {
                ExchangeTerminalWin exchangeTerminalWin = new ExchangeTerminalWin();
                exchangeTerminalWin.Show();
            }
            if (name == "Garage")
            {
                Garage garage = new Garage();
                garage.Show();
            }
            if (name == "BoreHole")
            {
                PetrolStation station = new PetrolStation();
                station.Show();
            }
            if (name == "PowerPlant")
            {
                SolarPanels solarPanels = new SolarPanels();
                solarPanels.Show();
            }
            if (name == "StorageOfMetal")
            {
                Miner miner = new Miner();
                miner.Show();
            }
            if (name == "ChillRoom")
            {
                ChillRoom chillRoom = new ChillRoom();
                chillRoom.Show();
            }
            if (name == "Gallery")
            {
                Gallary gallary = new Gallary();
                gallary.Show();
            }
            if (name == "MemRoom")
            {
                Memroom memroom = new Memroom();
                memroom.Show();
            }
            if (name == "Planitarium")
            {
                Planitarium Plan = new Planitarium();
                Plan.Show();
            }
            if (name == "TGU")
            {
                TGU tgu = new TGU();
                tgu.Show();
            }
            textBox1.Text = map.GetInfoBuilding(selectedRow, selectedColumn);


        }

        private void comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pictureBoxes[selectedRow][selectedColumn].Image = Image.FromFile("pictures//" + comboBox.SelectedItem.ToString() + ".png");
            map.AddBuilding(new Provider(comboBox.SelectedItem.ToString()).GetBuilding(), selectedRow, selectedColumn, indicator);
        }
        private void Table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBackToCrait_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crait crait = new Crait();
            crait.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
