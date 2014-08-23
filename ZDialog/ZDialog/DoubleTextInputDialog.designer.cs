namespace cn.zuoanqh.open.ZDialog
{
  partial class DoubleTextInputDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoubleTextInputDialog));
      this.lblText1 = new System.Windows.Forms.Label();
      this.btnCommit1 = new System.Windows.Forms.Button();
      this.txtUserInput1 = new System.Windows.Forms.TextBox();
      this.txtUserInput2 = new System.Windows.Forms.TextBox();
      this.btnCommit2 = new System.Windows.Forms.Button();
      this.lblText2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblText1
      // 
      resources.ApplyResources(this.lblText1, "lblText1");
      this.lblText1.Name = "lblText1";
      // 
      // btnCommit1
      // 
      resources.ApplyResources(this.btnCommit1, "btnCommit1");
      this.btnCommit1.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnCommit1.Name = "btnCommit1";
      this.btnCommit1.UseVisualStyleBackColor = true;
      this.btnCommit1.Click += new System.EventHandler(this.btnCommit1_Click);
      // 
      // txtUserInput1
      // 
      resources.ApplyResources(this.txtUserInput1, "txtUserInput1");
      this.txtUserInput1.Name = "txtUserInput1";
      // 
      // txtUserInput2
      // 
      resources.ApplyResources(this.txtUserInput2, "txtUserInput2");
      this.txtUserInput2.Name = "txtUserInput2";
      // 
      // btnCommit2
      // 
      resources.ApplyResources(this.btnCommit2, "btnCommit2");
      this.btnCommit2.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnCommit2.Name = "btnCommit2";
      this.btnCommit2.UseVisualStyleBackColor = true;
      this.btnCommit2.Click += new System.EventHandler(this.btnCommit2_Click);
      // 
      // lblText2
      // 
      resources.ApplyResources(this.lblText2, "lblText2");
      this.lblText2.Name = "lblText2";
      // 
      // DoubleTextInputDialog
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtUserInput2);
      this.Controls.Add(this.btnCommit2);
      this.Controls.Add(this.lblText2);
      this.Controls.Add(this.txtUserInput1);
      this.Controls.Add(this.btnCommit1);
      this.Controls.Add(this.lblText1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DoubleTextInputDialog";
      this.ShowInTaskbar = false;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.Label lblText1;
    public System.Windows.Forms.Button btnCommit1;
    public System.Windows.Forms.TextBox txtUserInput1;
    public System.Windows.Forms.TextBox txtUserInput2;
    public System.Windows.Forms.Button btnCommit2;
    public System.Windows.Forms.Label lblText2;

  }
}