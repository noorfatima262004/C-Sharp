﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Packman
{
    public class Grid
    {
        public int rows;
        public int col;
        public Cell[,] maze;

        public Grid()
        {

        }
        public Grid(int rows, int col, string path)
        {
            this.rows = rows;
            this.col = col;

            if (File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        file.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public Cell GetLeftCell(Cell cell)
        {
            cell.X = cell.X - 1;
            cell.setValue(maze[cell.X, cell.Y].value);
            Cell c = new Cell(cell.value, cell.X, cell.Y);
            return c;
        }
        public Cell GetRightCell(Cell cell)
        {

            cell.X = cell.X + 1;
            cell.setValue(maze[cell.X, cell.Y].value);
            Cell c = new Cell(cell.value, cell.X, cell.Y);
            return c;
        }

        public Cell GetUpCell(Cell cell)
        {
            cell.Y = cell.Y - 1;
            cell.setValue(maze[cell.X, cell.Y].value);
            Cell c = new Cell(cell.value, cell.X, cell.Y);
            return c;
        }

        public Cell GetDownCell(Cell cell)
        {
            cell.Y = cell.Y + 1;
            cell.setValue(maze[cell.X, cell.Y].value);
            Cell c = new Cell(cell.value, cell.X, cell.Y);
            return c;
        }
        public Cell FindPacMan()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (maze[i, j].value == 'P')
                    {
                        Cell cell = new Cell(maze[i, j].value, i, j);
                        return cell;
                    }
                }
            }
            return null;
        }

        public Cell FindGhost(char ghostcharacter)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (maze[i, j].value == ghostcharacter)
                    {
                        Cell cell = new Cell(maze[i, j].value, i, j);
                        return cell;
                    }
                }
            }
            return null;
        }

        public void storeMaze(int rows, int col)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Cell cell = new Cell(' ', i, j);
                    maze[i, j] = cell;
                }
            }
        }

        public void readMaze(string path)
        {
            int row = 0;
            int col = 0;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    for (int i = 0; i < record.Length; i++)
                    {
                        Cell cell = new Cell(record[i], col, i);
                        maze[row, i] = cell;
                        row++;
                    }
                    col++;
                }
            }
        }

        public void Draw()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(maze[i, j].value);
                }
                Console.WriteLine();
            }
        }

    }
}
