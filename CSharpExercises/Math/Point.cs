﻿using System;

namespace CSharpExercises.Math
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void move(Point newLocation)
        {
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }
            move(newLocation.x, newLocation.y);
        }
    }
}
