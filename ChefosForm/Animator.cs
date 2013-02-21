using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Transitions;
using System.Drawing;

namespace ChefosForm
{
    public class Animator
    {
        public void flash(Control control) {
            var transition = new Transition(new TransitionType_Flash(2, 700));
            transition.add(control, "BackColor", Color.FromArgb(151, 31, 62));
            transition.run();
        }
    }
}
