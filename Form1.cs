// Donn Gerald
// CPT-A80S-CityList
// 01.20.2025

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGerald_CPT_A80S_CityList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {                       
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        private void populationAscendButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopulation(this.cityDBDataSet.City);
 
        }

        private void populationDescButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopulationDesc(this.cityDBDataSet.City);
        }

        private void sortCityButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByCity(this.cityDBDataSet.City);
        }

        private void totalPopulationButton_Click(object sender, EventArgs e)
        {
            // declare variable to hold total population of all cities combined
            int sumPopulation;

            // total population defined
            sumPopulation =  (int)this.cityTableAdapter.SumPopulation();

            // display total population
            MessageBox.Show("Total population is " + sumPopulation.ToString("#,##0"));
        }

        private void averagePopulationButton_Click(object sender, EventArgs e)
        {
            // declare variable to hold average population of all cities 
            int averagePopulation;

            // average population defined
            averagePopulation = (int)this.cityTableAdapter.AveragePopulation();

            // display average population
            MessageBox.Show("Average population is " + averagePopulation.ToString("#,##0"));
        }

        private void highestPopulationButton_Click(object sender, EventArgs e)
        {
            // declare variable to hold highest population of all cities 
            int highestPopulation;

            // highest population defined
            highestPopulation = (int)this.cityTableAdapter.HighestPopulation();

            // display highest population
            MessageBox.Show("Highest population is " + highestPopulation.ToString("#,##0"));
        }

        private void lowestPopulationButton_Click(object sender, EventArgs e)
        {
            // declare variable to hold lowest population of all cities 
            int lowestPopulation;

            // lowest population defined
            lowestPopulation = (int)this.cityTableAdapter.LowestPopulation();

            // display lowest population
            MessageBox.Show("Lowest population is " + lowestPopulation.ToString("#,##0"));
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.SearchState(this.cityDBDataSet.City, searchTextBox.Text);
        }

        private void showAllCitiesButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
