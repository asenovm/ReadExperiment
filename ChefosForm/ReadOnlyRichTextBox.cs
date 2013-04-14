using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Read
{
    public class ReadOnlyRichTextBox : System.Windows.Forms.RichTextBox
    {

        [DllImport("user32.dll")]
        private static extern int HideCaret(IntPtr hwnd);

        public ReadOnlyRichTextBox()
        {
            MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            Resize += new System.EventHandler(this.OnResize);
            Font = new Font(FontFamily.GenericSansSerif, 10f);
            ScrollBars = RichTextBoxScrollBars.None;
            BorderStyle = BorderStyle.None;
            ReadOnly = true;
            TabStop = false;
            HideCaret(this.Handle);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            HideCaret(this.Handle);
        }

        protected override void OnEnter(EventArgs e)
        {
            HideCaret(this.Handle);
        }

        [DefaultValue(true)]
        public new bool ReadOnly
        {
            get { return true; }
            set { }
        }

        [DefaultValue(false)]
        public new bool TabStop
        {
            get { return false; }
            set { }
        }

        private void OnMouseEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            HideCaret(this.Handle);
        }


        private void OnResize(object sender, System.EventArgs e)
        {
            HideCaret(this.Handle);

        }

    }
}
