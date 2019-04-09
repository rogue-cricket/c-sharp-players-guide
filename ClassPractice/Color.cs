using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;
 
        public int Red
        {
            get
            {
                return red;
            }
            set
            {
                if (value > 255)
                    red = 255;
                else if (value < 0)
                    red = 0;
                else
                    red = value;
            }
        }

        public int Green
        {
            get
            {
                return green;
            }
            set
            {
                if (value > 255)
                    green = 255;
                else if (value < 0)
                    green = 0;
                else
                    green = value;
            }
        }

        public int Blue
        {
            get
            {
                return blue;
            }
            set
            {
                if (value > 255)
                    blue = 255;
                else if (value < 0)
                    blue = 0;
                else
                    blue = value;
            }
        }

        public int Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                if (value > 255)
                    alpha = 255;
                else if (value < 0)
                    alpha = 0;
                else
                    alpha = value;
            }
        }

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

        public int getGrayscale()
        {
            return (this.red + this.blue + this.green / 3);
        }
    }
}
