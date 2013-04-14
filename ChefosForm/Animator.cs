using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Transitions;
using System.Drawing;

namespace Read
{
    public class Animator
    {
        public void flash(Control control) {
            var transition = new Transition(new TransitionType_Flash(2, 500));
            transition.add(control, "BackColor", Color.FromArgb(240, 121, 88));
            transition.run();
        }
    }
}
