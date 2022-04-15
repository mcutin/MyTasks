using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTasks
{
    public static class RichTextBoxExtensions
    {
        /// <summary>
        /// Appends <c>text</c> to <c>box</c> Text property formatted with <c>color</c>.
        /// </summary>
        /// <param name="box">RichTextBox where <c>text</c> should be appended to Text property.</param>
        /// <param name="text">String to be appended to <c>box</c> Text property.</param>
        /// <param name="color">Color to format <c>text</c>.</param>
        /// <param name="addNewLine">if <c>true</c>, <c>text</c> will be appended to <c>box</c> Text property with a new line character in the end.</param>
        public static void AppendText(this RichTextBox box, string text, Color color, HorizontalAlignment alignment = HorizontalAlignment.Left, bool addNewLine = false)
        {
            // Define append position as the first character
            // after the last one in box.Text property
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SuspendLayout();
            box.SelectionColor = color;
            box.SelectionAlignment = alignment;
            box.AppendText(addNewLine ? $"{text}{Environment.NewLine}" : text);
            //box.SelectionColor = box.ForeColor;
            box.ResumeLayout();
        }
    }
}
