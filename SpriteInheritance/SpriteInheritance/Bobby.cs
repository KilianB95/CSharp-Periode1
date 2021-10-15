using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Eindopdracht
{
    class Bobby : Sprite
    {
        public Bobby(RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(95, 286, 16, 16);
        }
    }
}
