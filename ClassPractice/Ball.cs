using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Ball
    {
        private int size;
        private Color color;
        private int thrown;

        public Ball(int size, Color color)
        {
            this.size = size > 0 ? size : 1;
            this.color = color;
            this.thrown = 0;
        }

        public Ball(int size)
        {
            Random random = new Random();
            this.size = size > 0 ? size : 1;
            this.color = new Color(random.Next(256), random.Next(256), random.Next(256));
            this.thrown = 0;
        }

        public int GetThrown()
        {
            return this.thrown;
        }

        public void Pop()
        {
            this.size = 0;
        }

        public void Throw()
        {
            if (this.size > 0)
                this.thrown += 1;
        }

    }
}
