namespace IntegratedFormTest
{
  partial class Form1
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
      this.generalOptionsUserControl1 = new Fritz.EpicBuildMusic.Core.GeneralOptionsUserControl();
      this.SuspendLayout();
      // 
      // generalOptionsUserControl1
      // 
      this.generalOptionsUserControl1.DefaultMusicDuringBuild = false;
      this.generalOptionsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.generalOptionsUserControl1.Location = new System.Drawing.Point(0, 0);
      this.generalOptionsUserControl1.Name = "generalOptionsUserControl1";
      this.generalOptionsUserControl1.OtherMusicDuringBuild = "";
      this.generalOptionsUserControl1.Size = new System.Drawing.Size(1180, 459);
      this.generalOptionsUserControl1.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1180, 459);
      this.Controls.Add(this.generalOptionsUserControl1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private Fritz.EpicBuildMusic.Core.GeneralOptionsUserControl generalOptionsUserControl1;
  }
}

