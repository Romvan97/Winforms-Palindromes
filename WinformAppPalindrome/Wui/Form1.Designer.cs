namespace Wui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LstPalindromes = new System.Windows.Forms.ListBox();
            this.BtnFileChoice = new System.Windows.Forms.Button();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.TxtReadText = new System.Windows.Forms.TextBox();
            this.LstPalindromeOK = new System.Windows.Forms.ListBox();
            this.LstPalindromeNOK = new System.Windows.Forms.ListBox();
            this.BtnTestAllWords = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstPalindromes
            // 
            this.LstPalindromes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstPalindromes.FormattingEnabled = true;
            this.LstPalindromes.ItemHeight = 15;
            this.LstPalindromes.Location = new System.Drawing.Point(0, 23);
            this.LstPalindromes.Name = "LstPalindromes";
            this.LstPalindromes.Size = new System.Drawing.Size(287, 622);
            this.LstPalindromes.TabIndex = 0;
            // 
            // BtnFileChoice
            // 
            this.BtnFileChoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFileChoice.Location = new System.Drawing.Point(0, 0);
            this.BtnFileChoice.Name = "BtnFileChoice";
            this.BtnFileChoice.Size = new System.Drawing.Size(287, 23);
            this.BtnFileChoice.TabIndex = 1;
            this.BtnFileChoice.Text = "Choisir un fichier";
            this.BtnFileChoice.UseVisualStyleBackColor = true;
            this.BtnFileChoice.Click += new System.EventHandler(this.BtnFileChoice_Click);
            // 
            // TxtFileName
            // 
            this.TxtFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtFileName.Location = new System.Drawing.Point(0, 0);
            this.TxtFileName.Multiline = true;
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(570, 132);
            this.TxtFileName.TabIndex = 2;
            // 
            // TxtReadText
            // 
            this.TxtReadText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtReadText.Location = new System.Drawing.Point(0, 205);
            this.TxtReadText.Multiline = true;
            this.TxtReadText.Name = "TxtReadText";
            this.TxtReadText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtReadText.Size = new System.Drawing.Size(570, 145);
            this.TxtReadText.TabIndex = 3;
            // 
            // LstPalindromeOK
            // 
            this.LstPalindromeOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstPalindromeOK.FormattingEnabled = true;
            this.LstPalindromeOK.ItemHeight = 15;
            this.LstPalindromeOK.Location = new System.Drawing.Point(0, 0);
            this.LstPalindromeOK.Name = "LstPalindromeOK";
            this.LstPalindromeOK.Size = new System.Drawing.Size(251, 258);
            this.LstPalindromeOK.TabIndex = 4;
            // 
            // LstPalindromeNOK
            // 
            this.LstPalindromeNOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstPalindromeNOK.FormattingEnabled = true;
            this.LstPalindromeNOK.ItemHeight = 15;
            this.LstPalindromeNOK.Location = new System.Drawing.Point(0, 0);
            this.LstPalindromeNOK.Name = "LstPalindromeNOK";
            this.LstPalindromeNOK.Size = new System.Drawing.Size(315, 258);
            this.LstPalindromeNOK.TabIndex = 5;
            // 
            // BtnTestAllWords
            // 
            this.BtnTestAllWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTestAllWords.Location = new System.Drawing.Point(0, 0);
            this.BtnTestAllWords.Name = "BtnTestAllWords";
            this.BtnTestAllWords.Size = new System.Drawing.Size(570, 33);
            this.BtnTestAllWords.TabIndex = 6;
            this.BtnTestAllWords.Text = "Test de tous les mots de la listebox";
            this.BtnTestAllWords.UseVisualStyleBackColor = true;
            this.BtnTestAllWords.Click += new System.EventHandler(this.BtnTestAllWords_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LstPalindromes);
            this.splitContainer1.Panel1.Controls.Add(this.BtnFileChoice);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(861, 645);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TxtFileName);
            this.splitContainer2.Panel2.Controls.Add(this.TxtReadText);
            this.splitContainer2.Size = new System.Drawing.Size(570, 645);
            this.splitContainer2.SplitterDistance = 291;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnTestAllWords);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 33);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 33);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.LstPalindromeOK);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.LstPalindromeNOK);
            this.splitContainer3.Size = new System.Drawing.Size(570, 258);
            this.splitContainer3.SplitterDistance = 251;
            this.splitContainer3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 645);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox LstPalindromes;
        private Button BtnFileChoice;
        private TextBox TxtFileName;
        private TextBox TxtReadText;
        private ListBox LstPalindromeOK;
        private ListBox LstPalindromeNOK;
        private Button BtnTestAllWords;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Panel panel1;
    }
}