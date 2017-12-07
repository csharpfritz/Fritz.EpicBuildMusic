namespace Fritz.EpicBuildMusic
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
      this.DuringBuildFilenameLabel = new System.Windows.Forms.Label();
      this.DefaultMusicDuringBuildLabel = new System.Windows.Forms.Label();
      this.DefaultMusicDuringBuildCheckbox = new System.Windows.Forms.CheckBox();
      this.fileDialog = new System.Windows.Forms.OpenFileDialog();
      this.MusicDuringBuildTextbox = new System.Windows.Forms.TextBox();
      this.MusicDuringBuildOpenButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // DuringBuildFilenameLabel
      // 
      this.DuringBuildFilenameLabel.AutoSize = true;
      this.DuringBuildFilenameLabel.Location = new System.Drawing.Point(44, 67);
      this.DuringBuildFilenameLabel.Name = "DuringBuildFilenameLabel";
      this.DuringBuildFilenameLabel.Size = new System.Drawing.Size(286, 25);
      this.DuringBuildFilenameLabel.TabIndex = 0;
      this.DuringBuildFilenameLabel.Text = "Music to play DURING Build:";
      // 
      // DefaultMusicDuringBuildLabel
      // 
      this.DefaultMusicDuringBuildLabel.AutoSize = true;
      this.DefaultMusicDuringBuildLabel.Location = new System.Drawing.Point(44, 106);
      this.DefaultMusicDuringBuildLabel.Name = "DefaultMusicDuringBuildLabel";
      this.DefaultMusicDuringBuildLabel.Size = new System.Drawing.Size(149, 25);
      this.DefaultMusicDuringBuildLabel.TabIndex = 1;
      this.DefaultMusicDuringBuildLabel.Text = "Default Music:";
      // 
      // DefaultMusicDuringBuildCheckbox
      // 
      this.DefaultMusicDuringBuildCheckbox.AutoSize = true;
      this.DefaultMusicDuringBuildCheckbox.Location = new System.Drawing.Point(483, 103);
      this.DefaultMusicDuringBuildCheckbox.Name = "DefaultMusicDuringBuildCheckbox";
      this.DefaultMusicDuringBuildCheckbox.Size = new System.Drawing.Size(28, 27);
      this.DefaultMusicDuringBuildCheckbox.TabIndex = 2;
      this.DefaultMusicDuringBuildCheckbox.UseVisualStyleBackColor = true;
      this.DefaultMusicDuringBuildCheckbox.CheckedChanged += new System.EventHandler(this.DefaultMusicDuringBuildCheckbox_CheckedChanged);
      // 
      // fileDialog
      // 
      this.fileDialog.DefaultExt = "*.mp3";
      this.fileDialog.Filter = "Music files|*.mp3;*.wav|All files|*.*";
      // 
      // MusicDuringBuildTextbox
      // 
      this.MusicDuringBuildTextbox.Location = new System.Drawing.Point(483, 61);
      this.MusicDuringBuildTextbox.Name = "MusicDuringBuildTextbox";
      this.MusicDuringBuildTextbox.Size = new System.Drawing.Size(236, 31);
      this.MusicDuringBuildTextbox.TabIndex = 3;
      this.MusicDuringBuildTextbox.Leave += new System.EventHandler(this.MusicDuringBuildTextbox_Leave);
      // 
      // MusicDuringBuildOpenButton
      // 
      this.MusicDuringBuildOpenButton.Location = new System.Drawing.Point(726, 61);
      this.MusicDuringBuildOpenButton.Name = "MusicDuringBuildOpenButton";
      this.MusicDuringBuildOpenButton.Size = new System.Drawing.Size(56, 31);
      this.MusicDuringBuildOpenButton.TabIndex = 4;
      this.MusicDuringBuildOpenButton.Text = "...";
      this.MusicDuringBuildOpenButton.UseVisualStyleBackColor = true;
      this.MusicDuringBuildOpenButton.Click += new System.EventHandler(this.MusicDuringBuildOpenButton_Click);
      // 
      // GeneralOptionsUserControl
      // 
      this.Controls.Add(this.MusicDuringBuildOpenButton);
      this.Controls.Add(this.MusicDuringBuildTextbox);
      this.Controls.Add(this.DefaultMusicDuringBuildCheckbox);
      this.Controls.Add(this.DefaultMusicDuringBuildLabel);
      this.Controls.Add(this.DuringBuildFilenameLabel);
      this.Name = "GeneralOptionsUserControl";
      this.Size = new System.Drawing.Size(841, 330);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label DuringBuildFilenameLabel;
    private System.Windows.Forms.Label DefaultMusicDuringBuildLabel;
    private System.Windows.Forms.CheckBox DefaultMusicDuringBuildCheckbox;
    private System.Windows.Forms.OpenFileDialog fileDialog;
    private System.Windows.Forms.TextBox MusicDuringBuildTextbox;
    private System.Windows.Forms.Button MusicDuringBuildOpenButton;
  }
}
