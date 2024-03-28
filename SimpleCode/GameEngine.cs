using System;
using System.Collections.Generic;

namespace SimpleCode
{
    public static class Probability
    {
        public static int PlantVer, GrowthRate, GrowthTime, Decomposition, AgeCell, Starve, Division, DivisionTravo;
    }

    public class Data
    {
        public int Generation, CPlants, CTravo, CPloto;
        public Data(int generation, int cPlants, int cTravo, int cPloto)
        {
            Generation = generation;
            CPlants = cPlants;
            CTravo = cTravo;
            CPloto = cPloto;
        }
    }

    public class GameEngine
    {
        
        public int CurrentGeneration { get; private set; }
        public int CurrentTravo { get; private set; }
        public int CurrentPloto { get; private set; }
        public int CurrentPlants { get; private set; }
        private Cell[,] field;
        private readonly int rows;
        private readonly int cols;
        private Random rnd = new Random();
        public List<Data> data = new List<Data>();
        private int[] statistic = { 0, 0, 0 };
        public GameEngine(int rows, int cols, int density)
        {
            this.rows = rows;
            this.cols = cols;
            field = new Cell[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    int a = rnd.Next(density);
                    if(a == 0)
                    {
                        field[x, y] = new Cell(a == 0 ? "Travo" : "Empty");
                    }
                    else
                    {
                        a = rnd.Next(1000);
                        if (a == 0)
                        {
                            field[x, y] = new Cell(a == 0 ? "Ploto" : "Empty");
                        }
                        else
                        {
                            field[x, y] = new Cell(rnd.Next(101 - Probability.PlantVer) == 0 ? "Plant" : "Empty");
                        }
                    }
                }
            }
        }
        private int CountNeedNeighboor(int x, int y, string Need)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int col = (x + i + cols) % cols;
                    int row = (y + j + rows) % rows;
                    var hasLife = field[col, row];
                    if(field[x, y].Stage == "Travo" && Need!="Empty")
                    {
                        if (hasLife.IsEatable())
                        {
                            count++;
                        }
                    }
                    else if (hasLife.Stage==Need)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public void NextGeneration()
        {
            var newfield = new Cell[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var hasLife = field[x, y];
                    bool eat;
                    int n;
                    int move;
                    switch (hasLife.Stage)
                    {
                        case "Travo":
                            if(CountNeedNeighboor(x,y,"Plant") > 0)
                            {
                                //реализация питания
                                eat = true;
                                for (int i = -1; i < 2; i++)
                                {
                                    for (int j = -1; j < 2; j++)
                                    {
                                        int col = (x + i + cols) % cols;
                                        int row = (y + j + rows) % rows;
                                        var neighbor = field[col, row];
                                        if (neighbor.IsEatable() && hasLife.KnowAge() > 0)
                                        {
                                            if (eat)
                                            {
                                                int rate = rnd.Next(100);
                                                newfield[col, row] = new Cell(Probability.DivisionTravo > rate ? "Travo" : "Empty");
                                                field[col, row] = new Cell(Probability.DivisionTravo > rate ? "Travo" : "Empty");
                                                eat = false;
                                            }
                                            else
                                            {
                                                newfield[col, row] = field[col, row];
                                            }
                                        }
                                        else
                                            newfield[col, row] = field[col, row];
                                    }
                                }
                                newfield[x, y].StarveNull();
                                newfield[x, y].AgeUp();
                            }
                            else
                            {
                                //движение
                                if (CountNeedNeighboor(x, y, "Empty") > 0)
                                {
                                link1:
                                    move = rnd.Next(1, 10);
                                    n = 1;
                                    for (int i = -1; i < 2; i++)
                                    {
                                        for (int j = -1; j < 2; j++)
                                        {
                                            int col = (x + i + cols) % cols;
                                            int row = (y + j + rows) % rows;
                                            var neighbor = field[col, row];
                                            if (n == move)
                                            {
                                                if (neighbor.Stage == "Empty")
                                                {
                                                    newfield[col, row] = field[x, y];
                                                    field[col, row] = field[x, y];
                                                    newfield[col, row].StarveUp();
                                                    newfield[col, row].AgeUp();
                                                    newfield[col, row].IsDead();
                                                    newfield[x, y] = new Cell();
                                                    field[x, y] = new Cell();
                                                }
                                                else
                                                {
                                                    goto link1;
                                                }
                                            }
                                            n++;
                                        }
                                    }
                                }
                                else
                                {
                                    newfield[x, y] = field[x, y];
                                    newfield[x, y].StarveUp();
                                    newfield[x, y].AgeUp();
                                    newfield[x, y].IsDead();
                                }
                            
                            }
                            break;
                        case "Ploto":
                            //реализация питания
                            if (CountNeedNeighboor(x, y, "Travo") > 0)
                            {
                                eat = true;
                                for (int i = -1; i < 2; i++)
                                {
                                    for (int j = -1; j < 2; j++)
                                    {
                                        int col = (x + i + cols) % cols;
                                        int row = (y + j + rows) % rows;
                                        var neighbor = field[col, row];
                                        if (neighbor.Stage == "Travo" && hasLife.KnowAge() > 0)
                                        {
                                            if (eat)
                                            {
                                                int rate = rnd.Next(100);
                                                newfield[col, row] = new Cell(Probability.Division > rate ? "Ploto" : "Empty");
                                                field[col, row] = new Cell(Probability.Division > rate ? "Ploto" : "Empty");
                                                eat = false;
                                            }
                                            else
                                            {
                                                newfield[col, row] = field[col, row];
                                            }
                                        }
                                        else
                                            newfield[col, row] = field[col, row];
                                    }
                                }
                                newfield[x, y].StarveNull();
                                newfield[x, y].AgeUp();
                            }
                            else
                            {
                                //движение
                                if (CountNeedNeighboor(x, y, "Empty") > 0)
                                {
                                link1:
                                    move = rnd.Next(1, 10);
                                    n = 1;
                                    for (int i = -1; i < 2; i++)
                                    {
                                        for (int j = -1; j < 2; j++)
                                        {
                                            int col = (x + i + cols) % cols;
                                            int row = (y + j + rows) % rows;
                                            var neighbor = field[col, row];
                                            if (n == move)
                                            {
                                                if (neighbor.Stage == "Empty")
                                                {
                                                    newfield[col, row] = field[x, y];
                                                    field[col, row] = field[x, y];
                                                    newfield[col, row].StarveUp();
                                                    newfield[col, row].AgeUp();
                                                    newfield[col, row].IsDead();
                                                    newfield[x, y] = new Cell();
                                                    field[x, y] = new Cell();
                                                }
                                                else
                                                {
                                                    goto link1;
                                                }
                                            }
                                            n++;
                                        }
                                    }
                                    newfield[x, y] = field[x, y];
                                }
                                else
                                {
                                    newfield[x, y] = field[x, y];
                                    newfield[x, y].StarveUp();
                                    newfield[x, y].AgeUp();
                                    newfield[x, y].IsDead();
                                }

                            }
                            break;
                        case "Empty":
                            //Генерация растения
                            int chance = rnd.Next(100);
                            if (chance < Probability.PlantVer && statistic[0] <= Convert.ToInt32(Convert.ToDouble(cols*rows)*0.3) && CurrentGeneration%Probability.GrowthRate==0)
                            {
                                newfield[x, y] = new Cell("Plant");
                            }
                            else
                            {
                                newfield[x, y] = field[x, y];
                            }
                            break;
                        case "Plant":
                            newfield[x, y] = field[x, y];
                            newfield[x, y].StarveUp();
                            newfield[x, y].AgeUp();
                            newfield[x, y].IsDead();
                            break;
                    }
                }
            }
            field = newfield;
            CurrentGeneration++;
            statistic = CountCells();
            CurrentPlants = statistic[0];
            CurrentTravo = statistic[1];
            CurrentPloto = statistic[2];
            data.Add(new Data(CurrentGeneration, statistic[0], statistic[1],statistic[2]));
        }
        public Cell[,] GetCurrentGeneration()
        {
            var result = new Cell[cols, rows];
            for(int x=0; x < cols; x++)
            {
                for(int y=0; y < rows; y++)
                {
                    result[x,y] = field[x, y];
                }
            }
            return result;
        }
        private int[] CountCells()
        {
            int countPla = 0;
            int countPlo = 0;
            int countTra = 0;
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    switch(field[x, y].Stage)
                    {
                        case "Ploto":
                            countPlo++;
                            break;
                        case "Travo":
                            countTra++;
                            break;
                        case "Plant":
                            countPla++;
                            break;
                    }
                }
            }
            int[] a = { countPla, countTra, countPlo };
            return a;
        }
        private bool ValidateCellPosition(int x, int y)
        {
            return x>=0 && y>=0 && x<cols && y<rows;
        }
        private void UpdateCell(int x,int y, Cell state)
        {
            if (ValidateCellPosition(x,y))
                field[x,y] = state;
        }
        public void AddCell(int x,int y, string stage)
        {
            UpdateCell(x, y, new Cell(stage));
        }
        public void RemoveCell(int x, int y)
        {
            UpdateCell(x, y, new Cell("Empty"));
        }
    }
}