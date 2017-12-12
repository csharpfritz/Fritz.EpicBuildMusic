namespace Fritz.EpicBuildMusic.Core
{
  partial class GeneralOptionsUserControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralOptionsUserControl));
      this.DuringBuildFilenameLabel = new System.Windows.Forms.Label();
      this.DefaultMusicDuringBuildLabel = new System.Windows.Forms.Label();
      this.DefaultMusicDuringBuildCheckbox = new System.Windows.Forms.CheckBox();
      this.fileDialog = new System.Windows.Forms.OpenFileDialog();
      this.MusicDuringBuildTextbox = new System.Windows.Forms.TextBox();
      this.MusicDuringBuildOpenButton = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // DuringBuildFilenameLabel
      // 
      resources.ApplyResources(this.DuringBuildFilenameLabel, "DuringBuildFilenameLabel");
      this.DuringBuildFilenameLabel.Name = "DuringBuildFilenameLabel";
      // 
      // DefaultMusicDuringBuildLabel
      // 
      resources.ApplyResources(this.DefaultMusicDuringBuildLabel, "DefaultMusicDuringBuildLabel");
      this.DefaultMusicDuringBuildLabel.Name = "DefaultMusicDuringBuildLabel";
      // 
      // DefaultMusicDuringBuildCheckbox
      // 
      resources.ApplyResources(this.DefaultMusicDuringBuildCheckbox, "DefaultMusicDuringBuildCheckbox");
      this.DefaultMusicDuringBuildCheckbox.Name = "DefaultMusicDuringBuildCheckbox";
      this.DefaultMusicDuringBuildCheckbox.UseVisualStyleBackColor = true;
      this.DefaultMusicDuringBuildCheckbox.CheckedChanged += new System.EventHandler(this.DefaultMusicDuringBuildCheckbox_CheckedChanged);
      // 
      // fileDialog
      // 
      this.fileDialog.DefaultExt = "*.mp3";
      resources.ApplyResources(this.fileDialog, "fileDialog");
      // 
      // MusicDuringBuildTextbox
      // 
      resources.ApplyResources(this.MusicDuringBuildTextbox, "MusicDuringBuildTextbox");
      this.MusicDuringBuildTextbox.Name = "MusicDuringBuildTextbox";
      this.MusicDuringBuildTextbox.Leave += new System.EventHandler(this.MusicDuringBuildTextbox_Leave);
      // 
      // MusicDuringBuildOpenButton
      // 
      resources.ApplyResources(this.MusicDuringBuildOpenButton, "MusicDuringBuildOpenButton");
      this.MusicDuringBuildOpenButton.Name = "MusicDuringBuildOpenButton";
      this.MusicDuringBuildOpenButton.UseVisualStyleBackColor = true;
      this.MusicDuringBuildOpenButton.Click += new System.EventHandler(this.MusicDuringBuildOpenButton_Click);
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.DuringBuildFilenameLabel, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.MusicDuringBuildOpenButton, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.DefaultMusicDuringBuildLabel, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.DefaultMusicDuringBuildCheckbox, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.MusicDuringBuildTextbox, 1, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // GeneralOptionsUserControl
      // 
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "GeneralOptionsUserControl";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label DuringBuildFilenameLabel;
    private System.Windows.Forms.Label DefaultMusicDuringBuildLabel;
    private System.Windows.Forms.CheckBox DefaultMusicDuringBuildCheckbox;
    private System.Windows.Forms.OpenFileDialog fileDialog;
    private System.Windows.Forms.TextBox MusicDuringBuildTextbox;
    private System.Windows.Forms.Button MusicDuringBuildOpenButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
