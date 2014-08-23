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
/// This is a dialog that automatically closes after the given action is done.
/// 
/// Please note this dialog is meant to be a solution when other actions should be disabled when the action is being performed.
/// </summary>
  public partial class MessagePopUpDialog : Form
  {
  /// <summary>
  /// The action that is being executed.
  /// </summary>
    public Action action;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message">The message to display in the dialog's label.</param>
    /// <param name="action">The action to perform after the dialog is shown to user.</param>
    public MessagePopUpDialog(string message,Action action)
    {
      InitializeComponent();
      this.lblMessage.Text=message;
      this.action = action;
    }

    private MessagePopUpDialog() { }
    /// <summary>
    /// Since this dialog dosent return meaningful result, this function is created.
    /// It calls ShowDialog(parent), but dosent return result.
    /// </summary>
    /// <param name="parent"></param>
    public void ShowDialogAndDiscardResult(IWin32Window parent)
    {
      this.ShowDialog(parent);
    }

    private void MessagePopUpDialog_Shown(object sender, EventArgs e)
    {
      action.Invoke();
      this.Close();
    }

  }
}
