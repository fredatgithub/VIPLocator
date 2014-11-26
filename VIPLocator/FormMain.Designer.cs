namespace VIPLocator
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.webBrowser2 = new System.Windows.Forms.WebBrowser();
      this.SuspendLayout();
      // 
      // webBrowser2
      // 
      this.webBrowser2.Location = new System.Drawing.Point(90, 96);
      this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser2.Name = "webBrowser2";
      this.webBrowser2.Size = new System.Drawing.Size(929, 378);
      this.webBrowser2.TabIndex = 0;
      // 
      // FormMain
      // 
      this.ClientSize = new System.Drawing.Size(1127, 512);
      this.Controls.Add(this.webBrowser2);
      this.Name = "FormMain";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.WebBrowser webBrowser1;
    private System.Windows.Forms.WebBrowser webBrowser2;
  }
}

