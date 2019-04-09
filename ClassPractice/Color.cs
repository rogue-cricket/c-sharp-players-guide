using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Color
    {
        int red;
        int green;
        int blue;
        int alpha;

        public Color(int red, int green, int blue, int alpha)
        {
            if (red > 255)
                this.red = 255;
            else if (red < 0)
                this.red = 0;
            else
                this.red = red;

            if (green > 255)
                this.green = 255;
            else if (green < 0)
                this.green = 0;
            else
                this.green = green;

            if (blue > 255)
                this.blue = 255;
            else if (blue < 0)
                this.blue = 0;
            else
                this.blue = blue;

            if (alpha > 255)
                this.alpha = 255;
            else if (alpha < 0)
                this.alpha = 0;
            else
                this.alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            if (red > 255)
                this.red = 255;
            else if (red < 0)
                this.red = 0;
            else
                this.red = red;

            if (green > 255)
                this.green = 255;
            else if (green < 0)
                this.green = 0;
            else
                this.green = green;

            if (blue > 255)
                this.blue = 255;
            else if (blue < 0)
                this.blue = 0;
            else
                this.blue = blue;

            this.alpha = 255;

        }

        public int GetRed()
        {
            return this.red;
        }

        public void SetRed(int red)
        {
            if (red > 255)
                this.red = 255;
            else if (red < 0)
                this.red = 0;
            else
                this.red = red;
        }

        public int GetGreen()
        {
            return this.green;
        }

        public void SetGreen(int green)
        {
            if (green > 255)
                this.green = 255;
            else if (green < 0)
                this.green = 0;
            else
                this.green = green;

        }

        public int GetBlue(int blue)
        {
            return this.blue;
        }

        public void SetBlue()
        {
            if (blue > 255)
                this.blue = 255;
            else if (blue < 0)
                this.blue = 0;
            else
                this.blue = blue;
        }

        public int GetAlpha()
        {
            return this.alpha;
        }

        public void SetAlpha()
        {
            if (alpha > 255)
                this.alpha = 255;
            else if (alpha < 0)
                this.alpha = 0;
            else
                this.alpha = alpha;
        }

        public int getGrayscale()
        {
            return (this.red + this.blue + this.green / 3);
        }
    }
}
