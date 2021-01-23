using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSPBenchmark;
using GASolverLibrary;

namespace TSP
{
    public partial class MainForm : Form
    {
        AntColonySystemForTSP theSolver;
        
        PermutationGA thePermutationGA;
        public MainForm()
        {
            InitializeComponent();
            rbtACOSolver.Enabled = false;
            rbtCreateGA.Enabled = false;
            btnReset.Enabled = false;
            btnRunOneIteration.Enabled = false;
            btnRunEnd.Enabled = false;
            cbxAnimation.Enabled = false;
            cbxChecked.Enabled = false;
            WindowState = FormWindowState.Maximized;
        }
        private void tsbOpen_Click(object sender, EventArgs e)
        {
            theSolver = null;
            thePermutationGA = null;
            //open
            int status = TSPBenchmarkProblem.ImportATSPFile(true,true);

            if (status == -1) return;
            ACO.Refresh();
            
            title.Text = $"Title: { TSPBenchmarkProblem.Name }";
            numCities.Text = $"Number Of Cities: { TSPBenchmarkProblem.NumberOfCities }";
            
            ShortestLen.Text = $"Global Shortest Length: { TSPBenchmarkProblem.OptimumObjective:0.00}";
            txtGreedy.Text = $"Greedy Route Length: {TSPBenchmarkProblem.ComputeRouteLength(TSPBenchmarkProblem.GetGreedyShortestRoute())}";
            rtbDataDescription.Text = TSPBenchmarkProblem.Comment;

            int[] cities = new int[TSPBenchmarkProblem.NumberOfCities];

            
            cities = TSPBenchmarkProblem.OptimalTour;
            if (cities != null) {
                rtbShort.AppendText("Global Shortest Route: \n");
                for (int c = 0; c < TSPBenchmarkProblem.NumberOfCities; c++)
                    rtbShort.AppendText($"{cities[c]} ");
            }
            cities = TSPBenchmarkProblem.GetGreedyShortestRoute();
            if (cities != null)
            {
                rtbGreedy.AppendText("Greedy Shortest Route: \n");  
                for (int c = 0; c < TSPBenchmarkProblem.NumberOfCities; c++)
                    rtbGreedy.AppendText($"{cities[c]} ");
            }
            rbtCreateGA.Enabled = true;
            rbtACOSolver.Enabled = true;
            btnReset.Enabled = true;
       }
        private void ACOSolution_Paint(object sender, PaintEventArgs e)
        {
            TSPBenchmarkProblem.DrawCitesAndARoute(e.Graphics, ACO.Width,ACO.Height, null);
            if( theSolver != null | thePermutationGA != null) { 
                if (rbtACOSolver.Checked)
                {
                    TSPBenchmarkProblem.DrawCitesAndARoute(e.Graphics, ACO.Width,
                        ACO.Height, theSolver.SoFarTheBestSolution);
                }
                else
                {
                    TSPBenchmarkProblem.DrawCitesAndARoute(e.Graphics, ACO.Width,
                        ACO.Height, thePermutationGA.SoFarTheBestSolution);
                }
            }           
        }
        private void Greedy_Paint(object sender, PaintEventArgs e)
        {
            TSPBenchmarkProblem.DrawCitiesOptimalRouteAndARoute(e.Graphics, Greedy.Width,
                    Greedy.Height, TSPBenchmarkProblem.GetGreedyShortestRoute());
        }
        private void Optimal_Paint(object sender, PaintEventArgs e)
        {
            TSPBenchmarkProblem.DrawCitiesOptimalRouteAndARoute(e.Graphics, Optimal.Width,
                    Optimal.Height, TSPBenchmarkProblem.OptimalTour);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            createSolver();
            theChart.Series[0].Points.Clear();
            theChart.Series[1].Points.Clear();
            theChart.Series[2].Points.Clear();
            if (rbtACOSolver.Checked)
            {
                theSolver.Reset();
            }
            else
            {
                thePermutationGA.reset();
            }
            if (cbxChecked.Checked)
            {
                showResults();
                theChart.Update();
            }
            else
            {
                rtbPheromone.Clear();
                rtbSolution.Clear();
                rtbBestSol.Clear();
                rtbLen.Clear();
            }
            cbxAnimation.Enabled = true;
            btnRunOneIteration.Enabled = true;
            btnRunEnd.Enabled = true;
        }
        private void createSolver()
        {
            if (rbtACOSolver.Checked)
            {
                theSolver = new AntColonySystemForTSP(TSPBenchmarkProblem.NumberOfCities,
                    TSPBenchmarkProblem.ComputeRouteLength, TSPBenchmarkProblem.FromToDistanceMatrix);
                ppg.SelectedObject = theSolver;
            }
            else
            {
                thePermutationGA = new PermutationGA(TSPBenchmarkProblem.NumberOfCities,
                    OptimizationType.Min, TSPBenchmarkProblem.ComputeObjectiveValue);
                ppg.SelectedObject = thePermutationGA;
            }
            ACO.Refresh();
            btnReset.Enabled = true;
            cbxChecked.Enabled = true;
        }
        private void btnRunOneIteration_Click(object sender, EventArgs e)
        {
            if(rbtACOSolver.Checked)
                theSolver.RunOneIteration();
            else
                thePermutationGA.executeOneIteration();

            if (cbxChecked.Checked)
            {
                showResults();
                ACO.Refresh();
            }
            else
            {
                rtbPheromone.Clear();
                rtbSolution.Clear();
                rtbBestSol.Clear();
                rtbLen.Clear();
            }
            if (cbxAnimation.Checked)
            {
                showSeries();
                theChart.Update();
            }
        }
        private void showResults()
        {
            rtbPheromone.Clear();
            rtbSolution.Clear();
            rtbBestSol.Clear();
            rtbLen.Clear();
            if (rbtACOSolver.Checked)
            {
                // show so far the best
                for (int i = 0; i < theSolver.numberOfCities; i++)
                {
                    rtbBestSol.AppendText($"{theSolver.SoFarTheBestSolution[i]} ");
                }
                rtbLen.Text = $"{theSolver.SoFarTheBestObjective}";
                // show pheromoneMap
                for (int r = 0; r < theSolver.numberOfCities; r++)
                {
                    for (int c = 0; c < theSolver.numberOfCities; c++)
                    {
                        rtbPheromone.AppendText($"{theSolver.pheromoneMap[r, c].ToString("f3")} ");
                    }
                    rtbPheromone.AppendText("\n");
                }
                // show initial solution
                for (int i = 0; i < theSolver.NumberOfAnts; i++)
                {
                    rtbSolution.AppendText($"Solution{i}:\n");
                    for (int c = 0; c < theSolver.numberOfCities; c++)
                        rtbSolution.AppendText($"{theSolver.Solutions[i][c]} ");
                    rtbSolution.AppendText("\n");
                }
            }
            else
            {
                // best solution value
                rtbLen.Text = $"{thePermutationGA.SoFarTheBestObjective}";

                // best solution matrix
                for (int r = 0; r < TSPBenchmarkProblem.NumberOfCities; r++)
                {
                    rtbBestSol.AppendText($"{thePermutationGA.SoFarTheBestSolution[r]} ");
                }
                // show population
                for (int r = 0; r < thePermutationGA.PopulationSize; r++)
                {
                    rtbSolution.AppendText($"P{r} ");
                    for (int c = 0; c < TSPBenchmarkProblem.NumberOfCities; c++)
                    {
                        rtbSolution.AppendText($"{thePermutationGA.Chromosomes[r][c]} ");
                    }
                    rtbSolution.AppendText($"obj: {thePermutationGA.GetObjectiveValueFunction(thePermutationGA.Chromosomes[r])} \n");
                }
                if (thePermutationGA.IterationCount > 0)
                {

                    // show crossover
                    for (int r = thePermutationGA.PopulationSize + 1; r < thePermutationGA.PopulationSize * (1 + thePermutationGA.CrossoverRate) + 1; r++)
                    {
                        rtbSolution.AppendText($"C{r}  ");
                        for (int c = 0; c < TSPBenchmarkProblem.NumberOfCities; c++)
                        {
                            rtbSolution.AppendText($"{thePermutationGA.Chromosomes[r - 1][c]} ");
                        }
                        rtbSolution.AppendText($"obj: {thePermutationGA.GetObjectiveValueFunction(thePermutationGA.Chromosomes[r-1])} \n");
                    }
                    //show mutation
                    for (int r = thePermutationGA.PopulationSize + Convert.ToInt32(thePermutationGA.PopulationSize * thePermutationGA.CrossoverRate)+ 1;
                        r < thePermutationGA.PopulationSize * (1 + thePermutationGA.CrossoverRate + thePermutationGA.MutationRate) + 1; r++)
                    {
                        rtbSolution.AppendText($"P{r}  ");
                        for (int c = 0; c < TSPBenchmarkProblem.NumberOfCities; c++)
                        {
                            rtbSolution.AppendText($"{thePermutationGA.Chromosomes[r - 1][c]} ");
                        }
                        rtbSolution.AppendText($"obj: {thePermutationGA.GetObjectiveValueFunction(thePermutationGA.Chromosomes[r-1])} \n");
                    }
                }
            }
        }
        private void showSeries()
        {
            if (rbtACOSolver.Checked)
            {
                double y1 = theSolver.IterationAverage;
                double y2 = theSolver.IterationBestObjective;
                double y3 = theSolver.SoFarTheBestObjective;
                double x = theSolver.IterationCount;
                
                theChart.Series[0].Points.AddXY(x, y1);
                theChart.Series[1].Points.AddXY(x, y2);
                theChart.Series[2].Points.AddXY(x, y3);
                
            }
            else
            {
                double y1 = thePermutationGA.IterationAverage;
                double y2 = thePermutationGA.IterationBestObjective;
                double y3 = thePermutationGA.SoFarTheBestObjective;

                double x = thePermutationGA.IterationCount;

                theChart.Series[0].Points.AddXY(x, y1);
                theChart.Series[1].Points.AddXY(x, y2);
                theChart.Series[2].Points.AddXY(x, y3);
            }
        }
        private void btnRunEnd_Click(object sender, EventArgs e)
        {
            //theSolver.RunToEnd();

            cbxChecked.Checked = false;

            if (rbtACOSolver.Checked)
            {
                for (int i = 0; i < theSolver.IterationLimit; i++)
                    btnRunOneIteration.PerformClick();
            }
            else
            {
                for (int i = 0; i < thePermutationGA.IterationLimit; i++)
                    btnRunOneIteration.PerformClick();
            }
            cbxChecked.Checked = true;
            ACO.Refresh();
            showResults();
        }
        private void rbtACOSolver_CheckedChanged(object sender, EventArgs e)
        {
            thePermutationGA = null;
            theSolver = null;
            rtbPheromone.Clear();
            rtbSolution.Clear();
            rtbBestSol.Clear();
            rtbLen.Clear();
            ACO.Refresh();

            ppg.SelectedObject = null;

            theChart.Series[0].Points.Clear();
            theChart.Series[1].Points.Clear();
            theChart.Series[2].Points.Clear();
        }
    }
}
