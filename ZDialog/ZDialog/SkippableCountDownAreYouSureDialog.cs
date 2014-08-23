using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Resources;

namespace cn.zuoanqh.open.ZDialog
{
/// <summary>
/// This is a confirmation dialog. It have an disabled button at first, counts down and display time remaining under the confirm button's text. When time is up, the confirm button becomes clickable.
/// </summary>
  public partial class SkippableCountdownAreyousureDialog : Form
  {
    public static readonly int DEFAULT_COUNTDOWN_MILLIS = 3000;

    /// <summary>
    /// Create a dialog with default confirm button text and countdown time.
    /// </summary>
    /// <param name="title">Title of the dialog, this should be specific to the action user is about to perform.</param>
    /// <param name="warningText">Text displayed on the warning label, this should again be specific to the action.</param>
    public SkippableCountdownAreyousureDialog(string title, string warningtext)
      : this(title, warningtext, DEFAULT_COUNTDOWN_MILLIS) { }
    /// <summary>
    /// Create a dialog with default confirm button text.
    /// </summary>
    /// <param name="title">Title of the dialog, this should be specific to the action user is about to perform.</param>
    /// <param name="warningText">Text displayed on the warning label, this should again be specific to the action.</param>
    /// <param name="countdownMillisecond">How long until the button is clickable. This does not change how frequent the "time remaining" text is updated. Negative number will lead to unexpected behaviour.</param>
    public SkippableCountdownAreyousureDialog(string title, string warningtext, int countdownMillisecond)
      : this(title, warningtext, countdownMillisecond, "") { }
    /// <summary>
    /// Create a dialog with default countdown time.
    /// </summary>
    /// <param name="title">Title of the dialog, this should be specific to the action user is about to perform.</param>
    /// <param name="warningText">Text displayed on the warning label, this should again be specific to the action.</param>
    /// <param name="confirmButtonText">Text for the confirm button.</param>
    public SkippableCountdownAreyousureDialog(string title, string warningtext, string confirmButtonText)
      : this(title, warningtext, DEFAULT_COUNTDOWN_MILLIS, confirmButtonText) { }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="title">Title of the dialog, this should be specific to the action user is about to perform.</param>
    /// <param name="warningText">Text displayed on the warning label, this should again be specific to the action.</param>
    /// <param name="countdownMillisecond">How long until the button is clickable. This does not change how frequent the "time remaining" text is updated. Negative number will lead to unexpected behaviour.</param>
    /// <param name="confirmButtonText">Text for the confirm button.</param>
    public SkippableCountdownAreyousureDialog(string title, string warningText, int countdownMillisecond, string confirmButtonText)
    {
      InitializeComponent();
      timepassed = 0;
      Text = title;
      lblWarning.Text = warningText;
      if (confirmButtonText.Trim().Length != 0)
        btnConfirm.Text = confirmButtonText;
      confirmButtonText = btnConfirm.Text;
      countdownLength = countdownMillisecond;
      updateCountdownButtonText();
    }

    private SkippableCountdownAreyousureDialog() { }

    private string confirmButtonText;
    private int timepassed;
    private int countdownLength;
    //public DialogResult ShowDialog(IWin32Window parent)
    //{
    //  return this.ShowDialog(parent);
    //}

    private void tmrCountDown_Tick(object sender, EventArgs e)
    {
      timepassed += tmrCountdown.Interval;
      updateCountdownButtonText();
      if (timepassed >= countdownLength)
      {
        btnConfirm.Enabled = true;
        tmrCountdown.Enabled = false;
      }
    }

    private void updateCountdownButtonText()
    {
      if (timepassed < countdownLength)
        btnConfirm.Text = confirmButtonText + "\n" +
        string.Format(Strings.Resources.SkippableCountdownAreyousureDialog_btnCountdownText, (int)Math.Ceiling((countdownLength - timepassed) * 1.0 / 1000));
      else
        btnConfirm.Text = confirmButtonText;
    }
  }
}
