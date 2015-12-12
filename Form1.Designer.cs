namespace DirectoryRenamer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.renamerPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelRenamerPage = new System.Windows.Forms.TableLayoutPanel();
            this.selectAllCheckboxRenamerPage = new System.Windows.Forms.CheckBox();
            this.openButtonRenamerPage = new System.Windows.Forms.Button();
            this.progressBarRenamerPage = new System.Windows.Forms.ProgressBar();
            this.richTextBoxRenamerPage = new System.Windows.Forms.RichTextBox();
            this.checkedListBoxRenamerPage = new System.Windows.Forms.CheckedListBox();
            this.renameButtonRenamerPage = new System.Windows.Forms.Button();
            this.resultLabelRenamerPage = new System.Windows.Forms.Label();
            this.incrementalRenamerPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelIncrementalRenamerPage = new System.Windows.Forms.TableLayoutPanel();
            this.selectAllCheckboxIncrementalRenamerPage = new System.Windows.Forms.CheckBox();
            this.openButtonIncrementalRenamerPage = new System.Windows.Forms.Button();
            this.progressBarIncrementalRenamerPage = new System.Windows.Forms.ProgressBar();
            this.richTextBoxIncrementalRenamerPage = new System.Windows.Forms.RichTextBox();
            this.checkedListBoxIncrementalRenamerPage = new System.Windows.Forms.CheckedListBox();
            this.renameButtonIncrementalRenamerPage = new System.Windows.Forms.Button();
            this.resultLabelIncrementalRenamerPage = new System.Windows.Forms.Label();
            this.numberInitialDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.numberInitialDirectoryLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.renamerPage.SuspendLayout();
            this.tableLayoutPanelRenamerPage.SuspendLayout();
            this.incrementalRenamerPage.SuspendLayout();
            this.tableLayoutPanelIncrementalRenamerPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.renamerPage);
            this.tabControl.Controls.Add(this.incrementalRenamerPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(934, 562);
            this.tabControl.TabIndex = 1;
            // 
            // renamerPage
            // 
            this.renamerPage.Controls.Add(this.tableLayoutPanelRenamerPage);
            this.renamerPage.Location = new System.Drawing.Point(4, 22);
            this.renamerPage.Name = "renamerPage";
            this.renamerPage.Padding = new System.Windows.Forms.Padding(3);
            this.renamerPage.Size = new System.Drawing.Size(926, 536);
            this.renamerPage.TabIndex = 0;
            this.renamerPage.Text = "Classique";
            this.renamerPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelRenamerPage
            // 
            this.tableLayoutPanelRenamerPage.AutoSize = true;
            this.tableLayoutPanelRenamerPage.ColumnCount = 4;
            this.tableLayoutPanelRenamerPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRenamerPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRenamerPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRenamerPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRenamerPage.Controls.Add(this.selectAllCheckboxRenamerPage, 1, 2);
            this.tableLayoutPanelRenamerPage.Controls.Add(this.openButtonRenamerPage, 1, 1);
            this.tableLayoutPanelRenamerPage.Controls.Add(this.progressBarRenamerPage, 2, 1);
            this.tableLayoutPanelRenamerPage.Controls.Add(this.richTextBoxRenamerPage, 2, 3);
            this.tableLayoutPanelRenamerPage.Controls.Add(this.checkedListBoxRenamerPage, 1, 3);
            this.tableLayoutPanelRenamerPage.Controls.Add(this.renameButtonRenamerPage, 1, 4);
            this.tableLayoutPanelRenamerPage.Controls.Add(this.resultLabelRenamerPage, 2, 2);
            this.tableLayoutPanelRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRenamerPage.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelRenamerPage.Name = "tableLayoutPanelRenamerPage";
            this.tableLayoutPanelRenamerPage.RowCount = 6;
            this.tableLayoutPanelRenamerPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRenamerPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelRenamerPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRenamerPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRenamerPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelRenamerPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRenamerPage.Size = new System.Drawing.Size(920, 530);
            this.tableLayoutPanelRenamerPage.TabIndex = 1;
            // 
            // selectAllCheckboxRenamerPage
            // 
            this.selectAllCheckboxRenamerPage.AutoSize = true;
            this.selectAllCheckboxRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectAllCheckboxRenamerPage.Location = new System.Drawing.Point(23, 53);
            this.selectAllCheckboxRenamerPage.Name = "selectAllCheckboxRenamerPage";
            this.selectAllCheckboxRenamerPage.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.selectAllCheckboxRenamerPage.Size = new System.Drawing.Size(434, 17);
            this.selectAllCheckboxRenamerPage.TabIndex = 1;
            this.selectAllCheckboxRenamerPage.Text = "Sélectionner tous les dossiers";
            this.selectAllCheckboxRenamerPage.UseVisualStyleBackColor = true;
            this.selectAllCheckboxRenamerPage.CheckedChanged += new System.EventHandler(this.selectAllCheckboxRenamerPage_CheckedChanged);
            // 
            // openButtonRenamerPage
            // 
            this.openButtonRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openButtonRenamerPage.Location = new System.Drawing.Point(23, 23);
            this.openButtonRenamerPage.Name = "openButtonRenamerPage";
            this.openButtonRenamerPage.Size = new System.Drawing.Size(434, 24);
            this.openButtonRenamerPage.TabIndex = 0;
            this.openButtonRenamerPage.Text = "Sélectionner le dossier source";
            this.openButtonRenamerPage.UseVisualStyleBackColor = true;
            this.openButtonRenamerPage.Click += new System.EventHandler(this.openButtonRenamerPage_Click);
            // 
            // progressBarRenamerPage
            // 
            this.progressBarRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarRenamerPage.Location = new System.Drawing.Point(463, 23);
            this.progressBarRenamerPage.Name = "progressBarRenamerPage";
            this.progressBarRenamerPage.Size = new System.Drawing.Size(434, 24);
            this.progressBarRenamerPage.Step = 1;
            this.progressBarRenamerPage.TabIndex = 1;
            // 
            // richTextBoxRenamerPage
            // 
            this.richTextBoxRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxRenamerPage.Location = new System.Drawing.Point(463, 76);
            this.richTextBoxRenamerPage.Name = "richTextBoxRenamerPage";
            this.richTextBoxRenamerPage.ReadOnly = true;
            this.tableLayoutPanelRenamerPage.SetRowSpan(this.richTextBoxRenamerPage, 2);
            this.richTextBoxRenamerPage.Size = new System.Drawing.Size(434, 431);
            this.richTextBoxRenamerPage.TabIndex = 2;
            this.richTextBoxRenamerPage.Text = "";
            // 
            // checkedListBoxRenamerPage
            // 
            this.checkedListBoxRenamerPage.CheckOnClick = true;
            this.checkedListBoxRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxRenamerPage.FormattingEnabled = true;
            this.checkedListBoxRenamerPage.Location = new System.Drawing.Point(23, 76);
            this.checkedListBoxRenamerPage.Name = "checkedListBoxRenamerPage";
            this.checkedListBoxRenamerPage.Size = new System.Drawing.Size(434, 401);
            this.checkedListBoxRenamerPage.TabIndex = 3;
            this.checkedListBoxRenamerPage.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxRenamerPage_ItemCheck);
            // 
            // renameButtonRenamerPage
            // 
            this.renameButtonRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renameButtonRenamerPage.Enabled = false;
            this.renameButtonRenamerPage.Location = new System.Drawing.Point(23, 483);
            this.renameButtonRenamerPage.Name = "renameButtonRenamerPage";
            this.renameButtonRenamerPage.Size = new System.Drawing.Size(434, 24);
            this.renameButtonRenamerPage.TabIndex = 4;
            this.renameButtonRenamerPage.Text = "Renommer les dossiers sélectionnés";
            this.renameButtonRenamerPage.UseVisualStyleBackColor = true;
            this.renameButtonRenamerPage.Click += new System.EventHandler(this.renameButtonRenamerPage_Click);
            // 
            // resultLabelRenamerPage
            // 
            this.resultLabelRenamerPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resultLabelRenamerPage.AutoSize = true;
            this.resultLabelRenamerPage.Location = new System.Drawing.Point(463, 55);
            this.resultLabelRenamerPage.Name = "resultLabelRenamerPage";
            this.resultLabelRenamerPage.Size = new System.Drawing.Size(296, 13);
            this.resultLabelRenamerPage.TabIndex = 5;
            this.resultLabelRenamerPage.Text = "Vos dossiers renommés ont désormais  ces chemins d\'accès :";
            this.resultLabelRenamerPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // incrementalRenamerPage
            // 
            this.incrementalRenamerPage.Controls.Add(this.tableLayoutPanelIncrementalRenamerPage);
            this.incrementalRenamerPage.Location = new System.Drawing.Point(4, 22);
            this.incrementalRenamerPage.Name = "incrementalRenamerPage";
            this.incrementalRenamerPage.Padding = new System.Windows.Forms.Padding(3);
            this.incrementalRenamerPage.Size = new System.Drawing.Size(926, 536);
            this.incrementalRenamerPage.TabIndex = 1;
            this.incrementalRenamerPage.Text = "Incrémentiel";
            this.incrementalRenamerPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelIncrementalRenamerPage
            // 
            this.tableLayoutPanelIncrementalRenamerPage.AutoSize = true;
            this.tableLayoutPanelIncrementalRenamerPage.ColumnCount = 4;
            this.tableLayoutPanelIncrementalRenamerPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelIncrementalRenamerPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelIncrementalRenamerPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelIncrementalRenamerPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelIncrementalRenamerPage.Controls.Add(this.selectAllCheckboxIncrementalRenamerPage, 1, 3);
            this.tableLayoutPanelIncrementalRenamerPage.Controls.Add(this.openButtonIncrementalRenamerPage, 1, 1);
            this.tableLayoutPanelIncrementalRenamerPage.Controls.Add(this.progressBarIncrementalRenamerPage, 2, 1);
            this.tableLayoutPanelIncrementalRenamerPage.Controls.Add(this.richTextBoxIncrementalRenamerPage, 2, 4);
            this.tableLayoutPanelIncrementalRenamerPage.Controls.Add(this.checkedListBoxIncrementalRenamerPage, 1, 4);
            this.tableLayoutPanelIncrementalRenamerPage.Controls.Add(this.renameButtonIncrementalRenamerPage, 1, 5);
            this.tableLayoutPanelIncrementalRenamerPage.Controls.Add(this.resultLabelIncrementalRenamerPage, 2, 3);
            this.tableLayoutPanelIncrementalRenamerPage.Controls.Add(this.numberInitialDirectoryTextBox, 2, 2);
            this.tableLayoutPanelIncrementalRenamerPage.Controls.Add(this.numberInitialDirectoryLabel, 1, 2);
            this.tableLayoutPanelIncrementalRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelIncrementalRenamerPage.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelIncrementalRenamerPage.Name = "tableLayoutPanelIncrementalRenamerPage";
            this.tableLayoutPanelIncrementalRenamerPage.RowCount = 7;
            this.tableLayoutPanelIncrementalRenamerPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelIncrementalRenamerPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelIncrementalRenamerPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelIncrementalRenamerPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelIncrementalRenamerPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelIncrementalRenamerPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelIncrementalRenamerPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelIncrementalRenamerPage.Size = new System.Drawing.Size(920, 530);
            this.tableLayoutPanelIncrementalRenamerPage.TabIndex = 2;
            // 
            // selectAllCheckboxIncrementalRenamerPage
            // 
            this.selectAllCheckboxIncrementalRenamerPage.AutoSize = true;
            this.selectAllCheckboxIncrementalRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectAllCheckboxIncrementalRenamerPage.Location = new System.Drawing.Point(23, 83);
            this.selectAllCheckboxIncrementalRenamerPage.Name = "selectAllCheckboxIncrementalRenamerPage";
            this.selectAllCheckboxIncrementalRenamerPage.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.selectAllCheckboxIncrementalRenamerPage.Size = new System.Drawing.Size(434, 17);
            this.selectAllCheckboxIncrementalRenamerPage.TabIndex = 1;
            this.selectAllCheckboxIncrementalRenamerPage.Text = "Sélectionner tous les dossiers";
            this.selectAllCheckboxIncrementalRenamerPage.UseVisualStyleBackColor = true;
            this.selectAllCheckboxIncrementalRenamerPage.CheckedChanged += new System.EventHandler(this.selectAllCheckboxIncrementalRenamerPage_CheckedChanged);
            // 
            // openButtonIncrementalRenamerPage
            // 
            this.openButtonIncrementalRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openButtonIncrementalRenamerPage.Location = new System.Drawing.Point(23, 23);
            this.openButtonIncrementalRenamerPage.Name = "openButtonIncrementalRenamerPage";
            this.openButtonIncrementalRenamerPage.Size = new System.Drawing.Size(434, 24);
            this.openButtonIncrementalRenamerPage.TabIndex = 0;
            this.openButtonIncrementalRenamerPage.Text = "Sélectionner le dossier source";
            this.openButtonIncrementalRenamerPage.UseVisualStyleBackColor = true;
            this.openButtonIncrementalRenamerPage.Click += new System.EventHandler(this.openButtonIncrementalRenamerPage_Click);
            // 
            // progressBarIncrementalRenamerPage
            // 
            this.progressBarIncrementalRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarIncrementalRenamerPage.Location = new System.Drawing.Point(463, 23);
            this.progressBarIncrementalRenamerPage.Name = "progressBarIncrementalRenamerPage";
            this.progressBarIncrementalRenamerPage.Size = new System.Drawing.Size(434, 24);
            this.progressBarIncrementalRenamerPage.Step = 1;
            this.progressBarIncrementalRenamerPage.TabIndex = 1;
            // 
            // richTextBoxIncrementalRenamerPage
            // 
            this.richTextBoxIncrementalRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxIncrementalRenamerPage.Location = new System.Drawing.Point(463, 106);
            this.richTextBoxIncrementalRenamerPage.Name = "richTextBoxIncrementalRenamerPage";
            this.richTextBoxIncrementalRenamerPage.ReadOnly = true;
            this.tableLayoutPanelIncrementalRenamerPage.SetRowSpan(this.richTextBoxIncrementalRenamerPage, 2);
            this.richTextBoxIncrementalRenamerPage.Size = new System.Drawing.Size(434, 401);
            this.richTextBoxIncrementalRenamerPage.TabIndex = 2;
            this.richTextBoxIncrementalRenamerPage.Text = "";
            // 
            // checkedListBoxIncrementalRenamerPage
            // 
            this.checkedListBoxIncrementalRenamerPage.CheckOnClick = true;
            this.checkedListBoxIncrementalRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxIncrementalRenamerPage.FormattingEnabled = true;
            this.checkedListBoxIncrementalRenamerPage.Location = new System.Drawing.Point(23, 106);
            this.checkedListBoxIncrementalRenamerPage.Name = "checkedListBoxIncrementalRenamerPage";
            this.checkedListBoxIncrementalRenamerPage.Size = new System.Drawing.Size(434, 371);
            this.checkedListBoxIncrementalRenamerPage.TabIndex = 3;
            this.checkedListBoxIncrementalRenamerPage.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxIncrementalRenamerPage_ItemCheck);
            // 
            // renameButtonIncrementalRenamerPage
            // 
            this.renameButtonIncrementalRenamerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renameButtonIncrementalRenamerPage.Enabled = false;
            this.renameButtonIncrementalRenamerPage.Location = new System.Drawing.Point(23, 483);
            this.renameButtonIncrementalRenamerPage.Name = "renameButtonIncrementalRenamerPage";
            this.renameButtonIncrementalRenamerPage.Size = new System.Drawing.Size(434, 24);
            this.renameButtonIncrementalRenamerPage.TabIndex = 4;
            this.renameButtonIncrementalRenamerPage.Text = "Renommer les dossiers sélectionnés";
            this.renameButtonIncrementalRenamerPage.UseVisualStyleBackColor = true;
            this.renameButtonIncrementalRenamerPage.Click += new System.EventHandler(this.renameButtonIncrementalRenamerPage_Click);
            // 
            // resultLabelIncrementalRenamerPage
            // 
            this.resultLabelIncrementalRenamerPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resultLabelIncrementalRenamerPage.AutoSize = true;
            this.resultLabelIncrementalRenamerPage.Location = new System.Drawing.Point(463, 85);
            this.resultLabelIncrementalRenamerPage.Name = "resultLabelIncrementalRenamerPage";
            this.resultLabelIncrementalRenamerPage.Size = new System.Drawing.Size(418, 13);
            this.resultLabelIncrementalRenamerPage.TabIndex = 5;
            this.resultLabelIncrementalRenamerPage.Text = "Vos dossiers après un renommage incrémentiel auront désormais ces chemins d\'accès" +
    " :";
            this.resultLabelIncrementalRenamerPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberInitialDirectoryTextBox
            // 
            this.numberInitialDirectoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberInitialDirectoryTextBox.Location = new System.Drawing.Point(463, 53);
            this.numberInitialDirectoryTextBox.MaxLength = 3;
            this.numberInitialDirectoryTextBox.Name = "numberInitialDirectoryTextBox";
            this.numberInitialDirectoryTextBox.Size = new System.Drawing.Size(434, 20);
            this.numberInitialDirectoryTextBox.TabIndex = 6;
            this.numberInitialDirectoryTextBox.Text = "001";
            this.numberInitialDirectoryTextBox.TextChanged += new System.EventHandler(this.numberInitialDirectoryTextBox_TextChanged);
            // 
            // numberInitialDirectoryLabel
            // 
            this.numberInitialDirectoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numberInitialDirectoryLabel.AutoSize = true;
            this.numberInitialDirectoryLabel.Location = new System.Drawing.Point(23, 58);
            this.numberInitialDirectoryLabel.Name = "numberInitialDirectoryLabel";
            this.numberInitialDirectoryLabel.Size = new System.Drawing.Size(343, 13);
            this.numberInitialDirectoryLabel.TabIndex = 7;
            this.numberInitialDirectoryLabel.Text = "Entrez le numéro de dossier à partir du quel commencer le renommage :";
            this.numberInitialDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(934, 562);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainWindow";
            this.Text = "Directory Renamer";
            this.tabControl.ResumeLayout(false);
            this.renamerPage.ResumeLayout(false);
            this.renamerPage.PerformLayout();
            this.tableLayoutPanelRenamerPage.ResumeLayout(false);
            this.tableLayoutPanelRenamerPage.PerformLayout();
            this.incrementalRenamerPage.ResumeLayout(false);
            this.incrementalRenamerPage.PerformLayout();
            this.tableLayoutPanelIncrementalRenamerPage.ResumeLayout(false);
            this.tableLayoutPanelIncrementalRenamerPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage renamerPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRenamerPage;
        private System.Windows.Forms.CheckBox selectAllCheckboxRenamerPage;
        private System.Windows.Forms.Button openButtonRenamerPage;
        private System.Windows.Forms.ProgressBar progressBarRenamerPage;
        private System.Windows.Forms.RichTextBox richTextBoxRenamerPage;
        private System.Windows.Forms.CheckedListBox checkedListBoxRenamerPage;
        private System.Windows.Forms.Button renameButtonRenamerPage;
        private System.Windows.Forms.Label resultLabelRenamerPage;
        private System.Windows.Forms.TabPage incrementalRenamerPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelIncrementalRenamerPage;
        private System.Windows.Forms.CheckBox selectAllCheckboxIncrementalRenamerPage;
        private System.Windows.Forms.Button openButtonIncrementalRenamerPage;
        private System.Windows.Forms.ProgressBar progressBarIncrementalRenamerPage;
        private System.Windows.Forms.RichTextBox richTextBoxIncrementalRenamerPage;
        private System.Windows.Forms.CheckedListBox checkedListBoxIncrementalRenamerPage;
        private System.Windows.Forms.Button renameButtonIncrementalRenamerPage;
        private System.Windows.Forms.Label resultLabelIncrementalRenamerPage;
        private System.Windows.Forms.TextBox numberInitialDirectoryTextBox;
        private System.Windows.Forms.Label numberInitialDirectoryLabel;
    }
}

