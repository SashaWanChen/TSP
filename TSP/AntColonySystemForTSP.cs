using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    delegate double ObjectiveFunction(int[] s);
    class AntColonySystemForTSP
    {
        Random rnd = new Random();
        double deterministicThresh;
        double dropMultiplier;
        double dropPheromone;
        double evaporationRate;
        double heuristicFactor;
        double[,] heuristicValues;
        double initialPheromone;
        public double iterationAverage;
        public double iterationBestObjective;
        int iterationCount;
        double iterationLimit;
        double[] objectiveValues;
        double pheromoneFactor;
        public double soFarTheBestObjective;
        public int[] soFarTheBestSolution;
        int[][] solutions;
        public double[,] pheromoneMap;

        int iterationBestAnt;
        double maxFit;
        public int numberOfCities;
        bool[] cityAvailable;
        int[] availableCityIds;
        double[] fitness;
        int mmas = 0;

        [Category("SelectionFactor"), Description("確定型選擇比率，1:確定型，0:隨機型")]
        public double DeterministicThresh { get => deterministicThresh; set => deterministicThresh = value; }
        [Category("Pheromone"), Description("費洛蒙添加乘數，用來規範一目標函數值不同的添加量")]
        public double DropMultiplier { get => dropMultiplier; set => dropMultiplier = value; }
        [Category("Pheromone"), Description("每代次費洛蒙蒸發率，建議值為0.1")]
        public double EvaporationRate { get => evaporationRate; set => evaporationRate = value; }
        [Category("Factor"), Description("選擇機率的啟發值乘方，建議值>1")]
        public double HeuristicFactor { get => heuristicFactor; set => heuristicFactor = value; }
        [Category("Pheromone"), Description("費洛蒙初始值")]
        public double InitialPheromone { get => initialPheromone; set => initialPheromone = value; }
        [Browsable(false)]
        public double IterationAverage { get => iterationAverage; set => iterationAverage = value; }
        [Browsable(false)]
        public double IterationBestObjective { get => iterationBestObjective; set => iterationBestObjective = value; }
        [Browsable(false)]
        public int IterationCount { set; get; } = 0;
        [Description("疊代次數上限")]
        public double IterationLimit { get => iterationLimit; set => iterationLimit = value; }
        [Category("Pheromone"), Description("費洛蒙添加量")]
        public double PheromoneDropAmount { get => dropPheromone; set => dropPheromone = value; }
        public enum PheromoneDropMode { AllAnts, IterationBestOnly, SoFarTheBestOnly, Mix, MMAS };
        [Description("費洛蒙添加策略，AllAnts:所有螞蟻都添加，SoFarTheBestOnly:只有迄今最佳解添加，Mix:所有螞蟻和最佳解都添加")]
        public PheromoneDropMode pheromoneDropMode { get; set; } = PheromoneDropMode.Mix;
        [Category("Factor"), Description("選擇機率的費洛蒙值乘方，建議值>1")]
        public double PheromoneFactor { get => pheromoneFactor; set => pheromoneFactor = value; }
        [Browsable(false)]
        public int[] SoFarTheBestSolution{ get => soFarTheBestSolution; }
        [Browsable(false)]
        public double SoFarTheBestObjective{ get => soFarTheBestObjective; }
        [Browsable(false)]
        public int[][] Solutions { get => solutions; set => solutions = value; }

        int numberOfAnts;
        [Description("螞蟻數量")]
        public int NumberOfAnts { get => numberOfAnts; set => numberOfAnts = value; }

        internal void Reset()
        {
            iterationCount = 0;
            objectiveValues = new double[numberOfAnts];
            solutions = new int[numberOfAnts][];

            //randomly initialize pheromone table
            for(int r = 0; r < numberOfCities; r++)
                for(int c = 0; c < numberOfCities; c++)
                    pheromoneMap[r, c] = initialPheromone;
         
            iterationAverage = 0.0;
            iterationBestObjective = double.MaxValue;
            soFarTheBestObjective = double.MaxValue;

            for (int i = 0; i < NumberOfAnts; i++)
            {
                //randomly initialize solutions
                solutions[i] = new int[numberOfCities];
                for (int c = 0; c < numberOfCities; c++)
                {
                    solutions[i][c] = c;
                }
                    
                SuffleIntegerArray(solutions[i]);

                objectiveValues[i] = TSPBenchmark.TSPBenchmarkProblem.ComputeObjectiveValue(solutions[i]);

                if (objectiveValues[i] < iterationBestObjective) 
                { 
                    iterationBestObjective = objectiveValues[i];
                    if (objectiveValues[i] < soFarTheBestObjective)
                    {
                        soFarTheBestObjective = objectiveValues[i];
                        soFarTheBestSolution = solutions[i];
                    }
                } 

                iterationAverage += objectiveValues[i];
            }
            iterationAverage /= NumberOfAnts;
        }
        private void SuffleIntegerArray(int[] vs)
        {
            int pos;
            int temp;
            for (int c = numberOfCities - 1; c > 1; c--)
            {
                pos = rnd.Next(c + 1);
                temp = vs[c];
                vs[c] = vs[pos];
                vs[pos] = temp;
            }

        }
        public AntColonySystemForTSP(int numberOfCities, ObjectiveFunction obj, double[,] fromToDistance)
        {
            numberOfAnts = 100;
            initialPheromone = 0.001;
            deterministicThresh = 0.95;
            dropMultiplier = 1.1;
            dropPheromone = 0.001;
            evaporationRate = 0.1;
            heuristicFactor = 3.0;
            iterationLimit = 300;
            pheromoneFactor = 1.0;
            this.numberOfCities = numberOfCities;
            soFarTheBestSolution = new int[this.numberOfCities];
            pheromoneMap = new double[numberOfCities, numberOfCities];
            heuristicValues = new double[numberOfCities, numberOfCities];
            
            for (int r = 0; r < numberOfCities; r++)
            {
                for (int c = 0; c < numberOfCities; c++)
                {
                    if (fromToDistance[r, c] <= 250)
                        heuristicValues[r, c] = fromToDistance[r, c];
                    else if (fromToDistance[r, c] < 500 & fromToDistance[r, c] > 250)
                        heuristicValues[r, c] = (int)fromToDistance[r, c] / 50 * 50;
                    else
                        heuristicValues[r, c] = (int)fromToDistance[r, c] / 300 * 300;
                    if (r == c) heuristicValues[r, c] = 1e10;
                    else heuristicValues[r, c] = 1 / heuristicValues[r,c];
                }
            }
            cityAvailable = new bool[numberOfCities];
            availableCityIds = new int[numberOfCities];
            fitness = new double[numberOfCities];
        }
        internal void RunToEnd()
        {
            for (int i = 0; i < IterationLimit; i++)
            {
                RunOneIteration();
            }
        }
        internal void RunOneIteration()
        {
            iterationCount++;
            EachAntContructionItsSolution();
            ComputerObjectiveValueAndUpdateSoFarTheBest();
            UpdatePheromoneMap();
        }
        private void UpdatePheromoneMap()
        {
            int fid, tid;
            //update pheromone(all ants are allowed)
            double avg = TSPBenchmark.TSPBenchmarkProblem.AverageDistance;
            for (int i = 0; i < numberOfCities; i++)
            {
                for (int j = 0; j < numberOfCities; j++)
                {
                    pheromoneMap[i, j] = (1 - evaporationRate) * pheromoneMap[i, j];
                    if (pheromoneDropMode == PheromoneDropMode.MMAS)
                    {
                        if (pheromoneMap[i, j] > 3) pheromoneMap[i, j] = 3;
                        else if (pheromoneMap[i, j] < 0.00001) pheromoneMap[i, j] = 0;
                    }
                }
            }

            for (int k = 1; k < numberOfAnts; k++)
            {
                fid = solutions[k][0];
                for (int i = 1; i < numberOfCities; i++)
                {

                    tid = solutions[k][i];

                    if (longPath[k] != 0)
                    {
                        pheromoneMap[fid, tid] += dropMultiplier / objectiveValues[k] / longPath[k];
                        pheromoneMap[tid, fid] += dropMultiplier / objectiveValues[k] / longPath[k];
                    }
                    else
                    {
                        pheromoneMap[fid, tid] += dropMultiplier / objectiveValues[k];
                        pheromoneMap[tid, fid] += dropMultiplier / objectiveValues[k];
                    }

                    if (pheromoneDropMode == PheromoneDropMode.AllAnts | pheromoneDropMode == PheromoneDropMode.Mix)
                    {
                        pheromoneMap[fid, tid] += evaporationRate * initialPheromone * (1 - i / numberOfCities);
                        pheromoneMap[tid, fid] += evaporationRate * initialPheromone * (1 - i / numberOfCities);

                    }
                    fid = tid;

                }
            }

            if (pheromoneDropMode == PheromoneDropMode.MMAS)
            {

                if (iterationCount % 5 == 0 & iterationCount < 100) mmas = 1; //pheromoneDropMode = PheromoneDropMode.SoFarTheBestOnly
                if (iterationCount % 3 == 0 & iterationCount > 100) mmas = 1;// pheromoneDropMode = PheromoneDropMode.SoFarTheBestOnly;
                else mmas = 2;// pheromoneDropMode = PheromoneDropMode.InterationBestOnly;
            }
            else mmas = 0;

            fid = solutions[iterationBestAnt][0];
            //update iteration best solution pheromone
            if (pheromoneDropMode == PheromoneDropMode.IterationBestOnly | pheromoneDropMode == PheromoneDropMode.Mix |mmas ==2)
            {
                for (int i = 1; i < numberOfCities; i++)
                {
                    tid = solutions[iterationBestAnt][i];

                    if (longPath[iterationBestAnt] != 0)
                    {
                        pheromoneMap[fid, tid] += evaporationRate / objectiveValues[iterationBestAnt] / longPath[iterationBestAnt];
                        pheromoneMap[tid, fid] += evaporationRate / objectiveValues[iterationBestAnt] / longPath[iterationBestAnt];
                    }
                    else
                    {
                        pheromoneMap[fid, tid] += evaporationRate / objectiveValues[iterationBestAnt];
                        pheromoneMap[tid, fid] += evaporationRate / objectiveValues[iterationBestAnt];
                    }
                    fid = tid;
                }
            }
            //update so far the Best Solution pheromone

            fid = soFarTheBestSolution[0];
            if (pheromoneDropMode == PheromoneDropMode.SoFarTheBestOnly | pheromoneDropMode == PheromoneDropMode.Mix | mmas == 1)
            {
                for (int i = 1; i < numberOfCities; i++)
                {
                    //pheromone evaporation
                    //pheromoneMap[fid, j] = (1 - evaporationRate*2) * pheromoneMap[fid, j];
                    //elitism pheromone dropping strategy
                    tid = soFarTheBestSolution[i];
                    pheromoneMap[fid, tid] += evaporationRate / soFarTheBestObjective;
                    pheromoneMap[tid, fid] += evaporationRate / soFarTheBestObjective;

                    fid = soFarTheBestSolution[i];
                }
            }
        }
        private void ComputerObjectiveValueAndUpdateSoFarTheBest()
        {
            iterationAverage = 0.0;
            iterationBestObjective = double.MaxValue;

            //get objective value
            for (int i = 0; i < NumberOfAnts; i++)
            {
                objectiveValues[i] = TSPBenchmark.TSPBenchmarkProblem.ComputeObjectiveValue(solutions[i]);

                if (objectiveValues[i] < iterationBestObjective)
                {
                    iterationBestObjective = objectiveValues[i];
                    iterationBestAnt = i;
                }
                iterationAverage += objectiveValues[i];

                if (objectiveValues[i] < soFarTheBestObjective)
                {
                    soFarTheBestObjective = objectiveValues[i];
                    soFarTheBestSolution = solutions[i];
                }
            }
            iterationAverage /= NumberOfAnts;
            
        }
        public void localSearch()
        {
            double path1 = double.MinValue;
            double path2 = double.MinValue;
            int fid = soFarTheBestSolution[0], tid;
            int f1 = -1, f2 = -1, t1 = -1, t2 = -1;
            int i1 = -1, i2 = -1;
            for (int i = 1; i < numberOfCities; i++)
            {
                tid = soFarTheBestSolution[i];
                double path = TSPBenchmark.TSPBenchmarkProblem.FromToMatrix[fid, tid];
                if (path > path1)
                {
                    path2 = path1;
                    path1 = path;
                    i2 = i1;
                    i1 = i;
                    f2 = f1;
                    t2 = t1;
                    f1 = fid;
                    t1 = tid;
                }
                fid = soFarTheBestSolution[i];
            }
            if (path2 > 1)
            {
                if (TSPBenchmark.TSPBenchmarkProblem.FromToMatrix[f2, f1] + TSPBenchmark.TSPBenchmarkProblem.FromToMatrix[t2, t1] < (path1 + path2))
                {
                    int j = (i1 < i2) ? i2 : (i1 - 1);
                    for (int i = (i1 < i2) ? i1 : i2; i < (i2 + i1) / 2; i++)
                    {
                        int temp = soFarTheBestSolution[j];
                        soFarTheBestSolution[j] = soFarTheBestSolution[i];
                        soFarTheBestSolution[i] = temp;
                        j--;
                    }
                    soFarTheBestObjective= TSPBenchmark.TSPBenchmarkProblem.ComputeObjectiveValue(soFarTheBestSolution);
                }
            }

            //if (TSPBenchmark.TSPBenchmarkProblem.FromToMatrix[t2, f1] + TSPBenchmark.TSPBenchmarkProblem.FromToMatrix[f2, t1] < (path1 + path2)) ;

        }

        int[] longPath;
        private void EachAntContructionItsSolution()
        {
            int currentCityID;
            //random the start city
            //int pos = rnd.Next(numberOfCities);
            int pos = 0;
            longPath = new int[numberOfAnts];

            double avg = TSPBenchmark.TSPBenchmarkProblem.AverageDistance;

            for (int i = 0; i< NumberOfAnts; i++)
            {
                longPath[i] = 0;
                int numberCandidate = numberOfCities;
                for (int j = 0; j < numberOfCities; j++) availableCityIds[j] = j;
                
                currentCityID =  availableCityIds[pos];
                availableCityIds[pos] = availableCityIds[numberCandidate - 1];

                solutions[i][0] = currentCityID;
                
                
                //step count
                for (int s = 1; s < numberOfCities; s++)
                {
                    numberCandidate--;
                    
                    maxFit = double.MinValue;
                    double totalFitness = 0.0;
                    for (int j = 0; j < numberCandidate; j++)
                    {
                        //compute relative probability for each candidate
                        int candidateID = availableCityIds[j];
                        fitness[j] = Math.Pow(pheromoneMap[currentCityID, candidateID],PheromoneFactor) * Math.Pow(heuristicValues[currentCityID, candidateID],HeuristicFactor);
                        
                        if(fitness[j] > maxFit)
                        {
                            pos = j;                           
                            maxFit = fitness[j];
                        }
                    }
                    
                    double r = rnd.NextDouble();
                    int nextCityID = -1;
                    if (r >= DeterministicThresh)
                    {
                        //stochastic
                        double selected = rnd.NextDouble();
                        for (int j = 0; j < numberCandidate; j++)
                        {
                            totalFitness += fitness[j];
                            fitness[j] = totalFitness;
                        }
                        for (int j = 0; j < numberCandidate; j++)
                        {
                            fitness[j] /= totalFitness;
                        }
                        for (int j = 0; j < numberCandidate; j++)
                        {
                            if (selected >= fitness[j] && selected < fitness[j + 1])
                            {
                                pos = j;
                                break;
                            }                              
                            else
                                pos = 0;
                        }
                        nextCityID = availableCityIds[pos];
                        solutions[i][s] = nextCityID;
                        if(numberCandidate>0)
                            availableCityIds[pos] = availableCityIds[numberCandidate - 1];
                    }
                    else
                    {
                        nextCityID = availableCityIds[pos];
                        solutions[i][s] = nextCityID;
                        //detrministic
                        if (numberCandidate > 0)
                            availableCityIds[pos] = availableCityIds[numberCandidate - 1];
                    }
                    //if the route has long path get penalty
                    if (TSPBenchmark.TSPBenchmarkProblem.FromToMatrix[currentCityID, nextCityID] > avg*0.8) longPath[i]++;
                    if (TSPBenchmark.TSPBenchmarkProblem.FromToMatrix[currentCityID, nextCityID] > avg * 1.5) longPath[i]++;
                    if (TSPBenchmark.TSPBenchmarkProblem.FromToMatrix[currentCityID, nextCityID] > avg*2) longPath[i]++;

                    pos = solutions[i][2];
                    currentCityID = nextCityID;
                }
            }

        }
    }
}
