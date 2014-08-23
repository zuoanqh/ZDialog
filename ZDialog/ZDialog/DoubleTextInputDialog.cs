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
  /// <summary>
  /// A dialog that have two input textbox, for sutuations that user can input one text or two, and it will return which button was clicked when user is done, as well as the text in both.
  /// </summary>
  public partial class DoubleTextInputDialog : Form
  {
    private int btnClicked;
    /// <summary>
    /// Create a dialog with default second button text.
    /// </summary>
    /// <param name="title">Title of the dialog.</param>
    /// <param name="text1">Instructions that appears at the top of the dialog.</param>
    /// <param name="text2">Instructions that appears above the second text box.</param>
    public DoubleTextInputDialog(string title, string text1, string text2)
      : this(title, text1, text2, "") { }

    /// <summary>
    /// Create a dialog with given second button text.
    /// </summary>
    /// <param name="title">Title of the dialog.</param>
    /// <param name="text1">Instructions that appears at the top of the dialog.</param>
    /// <param name="text2">Instructions that appears above the second text box.</param>
    /// <param name="secondButtonText">Text for the second ok/confirm button.</param>
    public DoubleTextInputDialog(string title, string text1, string text2, string secondButtonText)
    {
      InitializeComponent();
      btnClicked = 0;
      this.Text = title;
      lblText1.Text = text1;
      lblText2.Text = text2;
      if (secondButtonText.Trim().Length != 0)
        btnCommit2.Text = secondButtonText;
    }
    /// <summary>
    /// Display the dialog box, return proper result.
    /// </summary>
    /// <param name="parent"></param>
    /// <returns>null if user did not click any ok/confirm buttons.</returns>
    public DoubleTextInputDialogResult ShowDialogAndGetInput(IWin32Window parent)
    {
      if (this.ShowDialog(parent) == DialogResult.OK)
        return new DoubleTextInputDialogResult(txtUserInput1.Text, txtUserInput2.Text, btnClicked);
      else
        return null;
    }

    /// <summary>
    /// Bundle for this dialog's result if ok/confirm button clicked.
    /// </summary>
    public class DoubleTextInputDialogResult
    {
      /// <summary>
      /// Text that was in the first text box when the button was clicked.
      /// </summary>
      public readonly string text1;
      /// <summary>
      /// Text that was in the second text box when the button was clicked.
      /// </summary>
      public readonly string text2;
      /// <summary>
      /// A number that is 1 or 2, marking which button was clicked.
      /// </summary>
      public readonly int buttonClicked;
      /// <summary>
      /// Create such a bundle. This was not supposed to be used by the dialog's client normally.
      /// </summary>
      /// <param name="text1">Text that was in the first text box when the button was clicked.</param>
      /// <param name="text2">Text that was in the second text box when the button was clicked.</param>
      /// <param name="buttonClicked">A number that is 1 or 2, marking which button was clicked.</param>
      public DoubleTextInputDialogResult(string text1, string text2, int buttonClicked)
      {
        this.text1 = text1;
        this.text2 = text2;
        this.buttonClicked = buttonClicked;
      }
    }

    private void btnCommit1_Click(object sender, EventArgs e)
    {
      btnClicked = 1;
    }

    private void btnCommit2_Click(object sender, EventArgs e)
    {
      btnClicked = 2;
    }
  }
}
