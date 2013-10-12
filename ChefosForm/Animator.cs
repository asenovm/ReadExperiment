using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Transitions;

namespace Read
{
    public class Animator
    {
        private static string ANIMATED_PROPERTY_COLOR = "BackColor";

        private static int ANIMATED_PROPERTY_FLASH_NUMBER = 1;

        private static int ANIMATED_PROPERTY_FLASH_TIME = 200;

        public void flash(Control control)
        {
            var transition = new Transition(new TransitionType_Flash(ANIMATED_PROPERTY_FLASH_NUMBER, ANIMATED_PROPERTY_FLASH_TIME));
            transition.add(control, ANIMATED_PROPERTY_COLOR, Color.DARK_RED);
            transition.run();
        }
    }
}
