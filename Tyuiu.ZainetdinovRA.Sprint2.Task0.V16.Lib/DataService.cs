﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZainetdinovRA.Sprint2.Task0.V16.Lib
{
    public class DataService : ISprint2Task0V16
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[] { (x - 750) == y, x != (y + 750), y < x, y > x, y <= x, y >= x };
        }
    }
}