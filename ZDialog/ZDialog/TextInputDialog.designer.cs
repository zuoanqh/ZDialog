namespace cn.zuoanqh.open.ZDialog
{
  partial class TextInputDialog
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextInputDialog));
      this.lblText = new System.Windows.Forms.Label();
      this.btnCommit = new System.Windows.Forms.Button();
      this.txtUserInput = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblText
      // 
      resources.ApplyResources(this.lblText, "lblText");
      this.lblText.Name = "lblText";
      // 
      // btnCommit
      // 
      resources.ApplyResources(this.btnCommit, "btnCommit");
      this.btnCommit.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnCommit.Name = "btnCommit";
      this.btnCommit.UseVisualStyleBackColor = true;
      // 
      // txtUserInput
      // 
      resources.ApplyResources(this.txtUserInput, "txtUserInput");
      this.txtUserInput.Name = "txtUserInput";
      // 
      // TextInputDialog
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtUserInput);
      this.Controls.Add(this.btnCommit);
      this.Controls.Add(this.lblText);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TextInputDialog";
      this.ShowInTaskbar = false;
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.Label lblText;
    public System.Windows.Forms.Button btnCommit;
    public System.Windows.Forms.TextBox txtUserInput;

  }
}