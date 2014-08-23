using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cn.zuoanqh.open.ZDialog
{
  public partial class TextInputDialog : Form
  {
    /// <summary>
    /// Create a new dialog with an empty Text Box.
    /// </summary>
    /// <param name="title">Dialog Title.</param>
    /// <param name="text">Instructions on what will this input be used for.</param>
    public TextInputDialog(string title, string text) : this(title,text,"")
    {}

    /// <summary>
    /// Create a new dialog with something already in the Text Box.
    /// </summary>
    /// <param name="title">Dialog Title.</param>
    /// <param name="text">Instructions on what will this input be used for.</param>
    /// <param name="preSetText">Text Box's pre-set text</param>
    public TextInputDialog(string title, string text, string preSetText)
    {
      InitializeComponent();
      this.Text = title;
      this.lblText.Text = text;
      this.txtUserInput.Text = preSetText;
    }

    private TextInputDialog() { }

    /// <summary>
    /// Use the initialized dialog to fetch user's input.
    /// </summary>
    /// <param name="parent">Parent Dialog</param>
    /// <returns>string if OK is clicked, null otherwise.</returns>
    public string ShowDialogAndFetchInput(IWin32Window parent)
    {
      if (this.ShowDialog(parent) == DialogResult.OK)
        return this.txtUserInput.Text;
      else
        return null;
    }
  }
}
