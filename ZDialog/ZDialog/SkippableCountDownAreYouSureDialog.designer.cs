namespace cn.zuoanqh.open.ZDialog
{
  partial class SkippableCountdownAreyousureDialog
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkippableCountdownAreyousureDialog));
      this.btnConfirm = new System.Windows.Forms.Button();
      this.btnImmediateConfirm = new System.Windows.Forms.Button();
      this.lbl_NoMoreHiddenButton = new System.Windows.Forms.Label();
      this.lblWarning = new System.Windows.Forms.Label();
      this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // btnConfirm
      // 
      this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
      resources.ApplyResources(this.btnConfirm, "btnConfirm");
      this.btnConfirm.Name = "btnConfirm";
      this.btnConfirm.UseVisualStyleBackColor = true;
      // 
      // btnImmediateConfirm
      // 
      this.btnImmediateConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
      resources.ApplyResources(this.btnImmediateConfirm, "btnImmediateConfirm");
      this.btnImmediateConfirm.Name = "btnImmediateConfirm";
      this.btnImmediateConfirm.UseVisualStyleBackColor = true;
      // 
      // lbl_NoMoreHiddenButton
      // 
      resources.ApplyResources(this.lbl_NoMoreHiddenButton, "lbl_NoMoreHiddenButton");
      this.lbl_NoMoreHiddenButton.Name = "lbl_NoMoreHiddenButton";
      // 
      // lblWarning
      // 
      resources.ApplyResources(this.lblWarning, "lblWarning");
      this.lblWarning.Name = "lblWarning";
      // 
      // tmrCountdown
      // 
      this.tmrCountdown.Enabled = true;
      this.tmrCountdown.Interval = 1000;
      this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
      // 
      // SkippableCountdownAreyousureDialog
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblWarning);
      this.Controls.Add(this.lbl_NoMoreHiddenButton);
      this.Controls.Add(this.btnImmediateConfirm);
      this.Controls.Add(this.btnConfirm);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SkippableCountdownAreyousureDialog";
      this.ShowInTaskbar = false;
      this.TopMost = true;
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer tmrCountdown;
    public System.Windows.Forms.Button btnConfirm;
    public System.Windows.Forms.Button btnImmediateConfirm;
    public System.Windows.Forms.Label lbl_NoMoreHiddenButton;
    public System.Windows.Forms.Label lblWarning;
  }
}