using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.btnpersonalizados
{
    public class PlaceholderTextBox : TextBox
    {
        private string placeholderText;
        private bool isPlaceholder;

        [Category("Placeholder")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set { placeholderText = value; SetPlaceholder(); }
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrEmpty(this.Text) || isPlaceholder)
            {
                this.Text = placeholderText;
                this.ForeColor = Color.Gray;
                isPlaceholder = true;
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder)
            {
                this.Text = "";
                this.ForeColor = Color.Black;
                isPlaceholder = false;
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SetPlaceholder();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            RemovePlaceholder();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            SetPlaceholder();
        }
    }
}
