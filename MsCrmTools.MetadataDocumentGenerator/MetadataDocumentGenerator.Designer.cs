﻿using System.Windows.Forms;

namespace MsCrmTools.MetadataDocumentGenerator
{
    partial class MetadataDocumentGenerator
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetadataDocumentGenerator));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tssbLoadEntities = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiLoadEntitiesFromSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGenerate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveCurrentSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chkAddFormLocation = new System.Windows.Forms.CheckBox();
            this.chkDisplayEntityList = new System.Windows.Forms.CheckBox();
            this.chkAddValidForAf = new System.Windows.Forms.CheckBox();
            this.chkAddRequiredLevel = new System.Windows.Forms.CheckBox();
            this.chkAddFls = new System.Windows.Forms.CheckBox();
            this.chkAddAudit = new System.Windows.Forms.CheckBox();
            this.chkOneSheet = new System.Windows.Forms.CheckBox();
            this.gbAttributeSelection = new System.Windows.Forms.GroupBox();
            this.chkFilterByPrefix = new System.Windows.Forms.CheckBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtPrefixes = new System.Windows.Forms.TextBox();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.lblSubSelect = new System.Windows.Forms.Label();
            this.lblEntities = new System.Windows.Forms.Label();
            this.lvEntities = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSelectionType = new System.Windows.Forms.ComboBox();
            this.lvForms = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAttributes = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.lblLcid = new System.Windows.Forms.Label();
            this.cbbLcid = new System.Windows.Forms.ComboBox();
            this.btnBrowseFilePath = new System.Windows.Forms.Button();
            this.txtOutputFilePath = new System.Windows.Forms.TextBox();
            this.lblOutputFilePath = new System.Windows.Forms.Label();
            this.lblOutputType = new System.Windows.Forms.Label();
            this.cbbOutputType = new System.Windows.Forms.ComboBox();
            this.toolStripMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbAttributeSelection.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbLoadEntities,
            this.toolStripSeparator1,
            this.tsbGenerate,
            this.toolStripSeparator2,
            this.settingsToolStripDropDownButton});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1821, 39);
            this.toolStripMenu.TabIndex = 2;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tssbLoadEntities
            // 
            this.tssbLoadEntities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadEntitiesFromSolution});
            this.tssbLoadEntities.Image = global::MsCrmTools.MetadataDocumentGenerator.Properties.Resources.ico_16_0;
            this.tssbLoadEntities.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbLoadEntities.Name = "tssbLoadEntities";
            this.tssbLoadEntities.Size = new System.Drawing.Size(209, 36);
            this.tssbLoadEntities.Text = "Load Entities";
            this.tssbLoadEntities.ToolTipText = "Load all entities from the connected organization";
            this.tssbLoadEntities.ButtonClick += new System.EventHandler(this.tssbLoadEntities_ButtonClick);
            // 
            // tsmiLoadEntitiesFromSolution
            // 
            this.tsmiLoadEntitiesFromSolution.Name = "tsmiLoadEntitiesFromSolution";
            this.tsmiLoadEntitiesFromSolution.Size = new System.Drawing.Size(424, 38);
            this.tsmiLoadEntitiesFromSolution.Text = "Load Entities from solution(s)";
            this.tsmiLoadEntitiesFromSolution.Click += new System.EventHandler(this.tsmiLoadEntitiesFromSolution_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbGenerate
            // 
            this.tsbGenerate.Enabled = false;
            this.tsbGenerate.Image = ((System.Drawing.Image)(resources.GetObject("tsbGenerate.Image")));
            this.tsbGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerate.Name = "tsbGenerate";
            this.tsbGenerate.Size = new System.Drawing.Size(248, 36);
            this.tsbGenerate.Text = "Generate document";
            this.tsbGenerate.Click += new System.EventHandler(this.TsbGenerateClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // settingsToolStripDropDownButton
            // 
            this.settingsToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCurrentSettingsToolStripMenuItem,
            this.loadSettingsToolStripMenuItem});
            this.settingsToolStripDropDownButton.Enabled = false;
            this.settingsToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripDropDownButton.Image")));
            this.settingsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsToolStripDropDownButton.Name = "settingsToolStripDropDownButton";
            this.settingsToolStripDropDownButton.Size = new System.Drawing.Size(277, 36);
            this.settingsToolStripDropDownButton.Text = "Generation settings";
            // 
            // saveCurrentSettingsToolStripMenuItem
            // 
            this.saveCurrentSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveCurrentSettingsToolStripMenuItem.Image")));
            this.saveCurrentSettingsToolStripMenuItem.Name = "saveCurrentSettingsToolStripMenuItem";
            this.saveCurrentSettingsToolStripMenuItem.Size = new System.Drawing.Size(460, 38);
            this.saveCurrentSettingsToolStripMenuItem.Text = "Save current generation settings";
            this.saveCurrentSettingsToolStripMenuItem.Click += new System.EventHandler(this.SaveCurrentSettingsToolStripMenuItemClick);
            // 
            // loadSettingsToolStripMenuItem
            // 
            this.loadSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadSettingsToolStripMenuItem.Image")));
            this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
            this.loadSettingsToolStripMenuItem.Size = new System.Drawing.Size(460, 38);
            this.loadSettingsToolStripMenuItem.Text = "Load generation settings";
            this.loadSettingsToolStripMenuItem.Click += new System.EventHandler(this.LoadSettingsToolStripMenuItemClick);
            // 
            // toolImageList
            // 
            this.toolImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolImageList.ImageStream")));
            this.toolImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.toolImageList.Images.SetKeyName(0, "Icon.png");
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.gbOptions);
            this.panel1.Controls.Add(this.gbAttributeSelection);
            this.panel1.Controls.Add(this.gbOutput);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1821, 1106);
            this.panel1.TabIndex = 3;
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.chkAddFormLocation);
            this.gbOptions.Controls.Add(this.chkDisplayEntityList);
            this.gbOptions.Controls.Add(this.chkAddValidForAf);
            this.gbOptions.Controls.Add(this.chkAddRequiredLevel);
            this.gbOptions.Controls.Add(this.chkAddFls);
            this.gbOptions.Controls.Add(this.chkAddAudit);
            this.gbOptions.Controls.Add(this.chkOneSheet);
            this.gbOptions.Enabled = false;
            this.gbOptions.Location = new System.Drawing.Point(5, 861);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbOptions.Size = new System.Drawing.Size(1777, 250);
            this.gbOptions.TabIndex = 8;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chkAddFormLocation
            // 
            this.chkAddFormLocation.AutoSize = true;
            this.chkAddFormLocation.Location = new System.Drawing.Point(520, 81);
            this.chkAddFormLocation.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkAddFormLocation.Name = "chkAddFormLocation";
            this.chkAddFormLocation.Size = new System.Drawing.Size(369, 29);
            this.chkAddFormLocation.TabIndex = 5;
            this.chkAddFormLocation.Text = "Include Attribute location in Forms";
            this.chkAddFormLocation.UseVisualStyleBackColor = true;
            // 
            // chkDisplayEntityList
            // 
            this.chkDisplayEntityList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDisplayEntityList.AutoSize = true;
            this.chkDisplayEntityList.Location = new System.Drawing.Point(1227, 36);
            this.chkDisplayEntityList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkDisplayEntityList.Name = "chkDisplayEntityList";
            this.chkDisplayEntityList.Size = new System.Drawing.Size(470, 29);
            this.chkDisplayEntityList.TabIndex = 4;
            this.chkDisplayEntityList.Text = "Gather entities list in a summary (Excel only)";
            this.chkDisplayEntityList.UseVisualStyleBackColor = true;
            // 
            // chkAddValidForAf
            // 
            this.chkAddValidForAf.AutoSize = true;
            this.chkAddValidForAf.Location = new System.Drawing.Point(520, 36);
            this.chkAddValidForAf.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkAddValidForAf.Name = "chkAddValidForAf";
            this.chkAddValidForAf.Size = new System.Drawing.Size(460, 29);
            this.chkAddValidForAf.TabIndex = 3;
            this.chkAddValidForAf.Text = "Include Valid for Advanced Find information";
            this.chkAddValidForAf.UseVisualStyleBackColor = true;
            // 
            // chkAddRequiredLevel
            // 
            this.chkAddRequiredLevel.AutoSize = true;
            this.chkAddRequiredLevel.Location = new System.Drawing.Point(12, 125);
            this.chkAddRequiredLevel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkAddRequiredLevel.Name = "chkAddRequiredLevel";
            this.chkAddRequiredLevel.Size = new System.Drawing.Size(404, 29);
            this.chkAddRequiredLevel.TabIndex = 2;
            this.chkAddRequiredLevel.Text = "Include Requirement level information";
            this.chkAddRequiredLevel.UseVisualStyleBackColor = true;
            // 
            // chkAddFls
            // 
            this.chkAddFls.AutoSize = true;
            this.chkAddFls.Location = new System.Drawing.Point(12, 81);
            this.chkAddFls.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkAddFls.Name = "chkAddFls";
            this.chkAddFls.Size = new System.Drawing.Size(420, 29);
            this.chkAddFls.TabIndex = 1;
            this.chkAddFls.Text = "Include Field Level Security information";
            this.chkAddFls.UseVisualStyleBackColor = true;
            // 
            // chkAddAudit
            // 
            this.chkAddAudit.AutoSize = true;
            this.chkAddAudit.Location = new System.Drawing.Point(12, 36);
            this.chkAddAudit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkAddAudit.Name = "chkAddAudit";
            this.chkAddAudit.Size = new System.Drawing.Size(280, 29);
            this.chkAddAudit.TabIndex = 0;
            this.chkAddAudit.Text = "Include Audit information";
            this.chkAddAudit.UseVisualStyleBackColor = true;
            // 
            // chkOneSheet
            // 
            this.chkOneSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOneSheet.AutoSize = true;
            this.chkOneSheet.Location = new System.Drawing.Point(1227, 81);
            this.chkOneSheet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkOneSheet.Name = "chkOneSheet";
            this.chkOneSheet.Size = new System.Drawing.Size(472, 29);
            this.chkOneSheet.TabIndex = 1;
            this.chkOneSheet.Text = "Export all attributes in one sheet (Excel only)";
            this.chkOneSheet.UseVisualStyleBackColor = true;
            // 
            // gbAttributeSelection
            // 
            this.gbAttributeSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAttributeSelection.Controls.Add(this.chkFilterByPrefix);
            this.gbAttributeSelection.Controls.Add(this.btnEdit);
            this.gbAttributeSelection.Controls.Add(this.txtPrefixes);
            this.gbAttributeSelection.Controls.Add(this.chkSelectAll);
            this.gbAttributeSelection.Controls.Add(this.lblSubSelect);
            this.gbAttributeSelection.Controls.Add(this.lblEntities);
            this.gbAttributeSelection.Controls.Add(this.lvEntities);
            this.gbAttributeSelection.Controls.Add(this.label1);
            this.gbAttributeSelection.Controls.Add(this.cbbSelectionType);
            this.gbAttributeSelection.Controls.Add(this.lvForms);
            this.gbAttributeSelection.Controls.Add(this.lvAttributes);
            this.gbAttributeSelection.Enabled = false;
            this.gbAttributeSelection.Location = new System.Drawing.Point(5, 221);
            this.gbAttributeSelection.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbAttributeSelection.Name = "gbAttributeSelection";
            this.gbAttributeSelection.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbAttributeSelection.Size = new System.Drawing.Size(1777, 629);
            this.gbAttributeSelection.TabIndex = 7;
            this.gbAttributeSelection.TabStop = false;
            this.gbAttributeSelection.Text = "Attributes Selection";
            // 
            // chkFilterByPrefix
            // 
            this.chkFilterByPrefix.AutoSize = true;
            this.chkFilterByPrefix.Location = new System.Drawing.Point(816, 40);
            this.chkFilterByPrefix.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkFilterByPrefix.Name = "chkFilterByPrefix";
            this.chkFilterByPrefix.Size = new System.Drawing.Size(350, 29);
            this.chkFilterByPrefix.TabIndex = 89;
            this.chkFilterByPrefix.Text = "Filter custom attributes by prefix";
            this.chkFilterByPrefix.UseVisualStyleBackColor = true;
            this.chkFilterByPrefix.CheckedChanged += new System.EventHandler(this.chkFilterByPrefix_CheckedChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(1718, 32);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 44);
            this.btnEdit.TabIndex = 88;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtPrefixes
            // 
            this.txtPrefixes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrefixes.Enabled = false;
            this.txtPrefixes.Location = new System.Drawing.Point(1219, 36);
            this.txtPrefixes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPrefixes.Name = "txtPrefixes";
            this.txtPrefixes.Size = new System.Drawing.Size(485, 31);
            this.txtPrefixes.TabIndex = 87;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(565, 98);
            this.chkSelectAll.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(222, 29);
            this.chkSelectAll.TabIndex = 85;
            this.chkSelectAll.Text = "Select/Unselect all";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // lblSubSelect
            // 
            this.lblSubSelect.AutoSize = true;
            this.lblSubSelect.Location = new System.Drawing.Point(811, 100);
            this.lblSubSelect.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubSelect.Name = "lblSubSelect";
            this.lblSubSelect.Size = new System.Drawing.Size(103, 25);
            this.lblSubSelect.TabIndex = 83;
            this.lblSubSelect.Text = "Attributes";
            this.lblSubSelect.Visible = false;
            // 
            // lblEntities
            // 
            this.lblEntities.AutoSize = true;
            this.lblEntities.Location = new System.Drawing.Point(19, 100);
            this.lblEntities.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEntities.Name = "lblEntities";
            this.lblEntities.Size = new System.Drawing.Size(83, 25);
            this.lblEntities.TabIndex = 82;
            this.lblEntities.Text = "Entities";
            // 
            // lvEntities
            // 
            this.lvEntities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvEntities.CheckBoxes = true;
            this.lvEntities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader7});
            this.lvEntities.FullRowSelect = true;
            this.lvEntities.GridLines = true;
            this.lvEntities.HideSelection = false;
            this.lvEntities.Location = new System.Drawing.Point(19, 131);
            this.lvEntities.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lvEntities.Name = "lvEntities";
            this.lvEntities.Size = new System.Drawing.Size(776, 483);
            this.lvEntities.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvEntities.TabIndex = 80;
            this.lvEntities.UseCompatibleStateImageBehavior = false;
            this.lvEntities.View = System.Windows.Forms.View.Details;
            this.lvEntities.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewsColumnClick);
            this.lvEntities.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LvEntitiesItemChecked);
            this.lvEntities.SelectedIndexChanged += new System.EventHandler(this.LvEntitiesSelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Display name";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Schema name";
            this.columnHeader7.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Generate for";
            // 
            // cbbSelectionType
            // 
            this.cbbSelectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectionType.FormattingEnabled = true;
            this.cbbSelectionType.Items.AddRange(new object[] {
            "All attributes",
            "All attributes contained in forms",
            "All attributes NOT contained in forms",
            "Option Sets, Boolean, State and Status attributes",
            "Selected attributes"});
            this.cbbSelectionType.Location = new System.Drawing.Point(236, 36);
            this.cbbSelectionType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbbSelectionType.Name = "cbbSelectionType";
            this.cbbSelectionType.Size = new System.Drawing.Size(559, 33);
            this.cbbSelectionType.TabIndex = 2;
            this.cbbSelectionType.SelectedIndexChanged += new System.EventHandler(this.CbbSelectionTypeSelectedIndexChanged);
            // 
            // lvForms
            // 
            this.lvForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvForms.CheckBoxes = true;
            this.lvForms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8});
            this.lvForms.FullRowSelect = true;
            this.lvForms.GridLines = true;
            this.lvForms.Location = new System.Drawing.Point(811, 131);
            this.lvForms.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lvForms.Name = "lvForms";
            this.lvForms.Size = new System.Drawing.Size(950, 483);
            this.lvForms.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvForms.TabIndex = 84;
            this.lvForms.UseCompatibleStateImageBehavior = false;
            this.lvForms.View = System.Windows.Forms.View.Details;
            this.lvForms.Visible = false;
            this.lvForms.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewsColumnClick);
            this.lvForms.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LvFormsItemChecked);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Form name";
            this.columnHeader8.Width = 400;
            // 
            // lvAttributes
            // 
            this.lvAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAttributes.CheckBoxes = true;
            this.lvAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.lvAttributes.FullRowSelect = true;
            this.lvAttributes.GridLines = true;
            this.lvAttributes.Location = new System.Drawing.Point(811, 131);
            this.lvAttributes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lvAttributes.Name = "lvAttributes";
            this.lvAttributes.Size = new System.Drawing.Size(950, 483);
            this.lvAttributes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAttributes.TabIndex = 81;
            this.lvAttributes.UseCompatibleStateImageBehavior = false;
            this.lvAttributes.View = System.Windows.Forms.View.Details;
            this.lvAttributes.Visible = false;
            this.lvAttributes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewsColumnClick);
            this.lvAttributes.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LvAttributesItemChecked);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Attribute Display Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Attribute Logical Name";
            this.columnHeader1.Width = 200;
            // 
            // gbOutput
            // 
            this.gbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOutput.Controls.Add(this.lblLcid);
            this.gbOutput.Controls.Add(this.cbbLcid);
            this.gbOutput.Controls.Add(this.btnBrowseFilePath);
            this.gbOutput.Controls.Add(this.txtOutputFilePath);
            this.gbOutput.Controls.Add(this.lblOutputFilePath);
            this.gbOutput.Controls.Add(this.lblOutputType);
            this.gbOutput.Controls.Add(this.cbbOutputType);
            this.gbOutput.Enabled = false;
            this.gbOutput.Location = new System.Drawing.Point(5, 6);
            this.gbOutput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbOutput.Size = new System.Drawing.Size(1777, 204);
            this.gbOutput.TabIndex = 6;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // lblLcid
            // 
            this.lblLcid.AutoSize = true;
            this.lblLcid.Location = new System.Drawing.Point(12, 146);
            this.lblLcid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLcid.Name = "lblLcid";
            this.lblLcid.Size = new System.Drawing.Size(108, 25);
            this.lblLcid.TabIndex = 6;
            this.lblLcid.Text = "Language";
            // 
            // cbbLcid
            // 
            this.cbbLcid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbLcid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLcid.FormattingEnabled = true;
            this.cbbLcid.Location = new System.Drawing.Point(236, 140);
            this.cbbLcid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbbLcid.Name = "cbbLcid";
            this.cbbLcid.Size = new System.Drawing.Size(1525, 33);
            this.cbbLcid.TabIndex = 5;
            // 
            // btnBrowseFilePath
            // 
            this.btnBrowseFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFilePath.Location = new System.Drawing.Point(1683, 85);
            this.btnBrowseFilePath.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBrowseFilePath.Name = "btnBrowseFilePath";
            this.btnBrowseFilePath.Size = new System.Drawing.Size(80, 44);
            this.btnBrowseFilePath.TabIndex = 4;
            this.btnBrowseFilePath.Text = "...";
            this.btnBrowseFilePath.UseVisualStyleBackColor = true;
            this.btnBrowseFilePath.Click += new System.EventHandler(this.BtnBrowseFilePathClick);
            // 
            // txtOutputFilePath
            // 
            this.txtOutputFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputFilePath.Location = new System.Drawing.Point(236, 89);
            this.txtOutputFilePath.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtOutputFilePath.Name = "txtOutputFilePath";
            this.txtOutputFilePath.ReadOnly = true;
            this.txtOutputFilePath.Size = new System.Drawing.Size(1431, 31);
            this.txtOutputFilePath.TabIndex = 3;
            // 
            // lblOutputFilePath
            // 
            this.lblOutputFilePath.AutoSize = true;
            this.lblOutputFilePath.Location = new System.Drawing.Point(12, 94);
            this.lblOutputFilePath.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOutputFilePath.Name = "lblOutputFilePath";
            this.lblOutputFilePath.Size = new System.Drawing.Size(95, 25);
            this.lblOutputFilePath.TabIndex = 2;
            this.lblOutputFilePath.Text = "File path";
            // 
            // lblOutputType
            // 
            this.lblOutputType.AutoSize = true;
            this.lblOutputType.Location = new System.Drawing.Point(12, 42);
            this.lblOutputType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOutputType.Name = "lblOutputType";
            this.lblOutputType.Size = new System.Drawing.Size(175, 25);
            this.lblOutputType.TabIndex = 1;
            this.lblOutputType.Text = "Document format";
            // 
            // cbbOutputType
            // 
            this.cbbOutputType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbOutputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOutputType.FormattingEnabled = true;
            this.cbbOutputType.Items.AddRange(new object[] {
            "Excel Workbook",
            "Word Document"});
            this.cbbOutputType.Location = new System.Drawing.Point(236, 36);
            this.cbbOutputType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbbOutputType.Name = "cbbOutputType";
            this.cbbOutputType.Size = new System.Drawing.Size(1525, 33);
            this.cbbOutputType.TabIndex = 0;
            this.cbbOutputType.SelectedIndexChanged += new System.EventHandler(this.CbbOutputTypeSelectedIndexChanged);
            // 
            // MetadataDocumentGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MetadataDocumentGenerator";
            this.Size = new System.Drawing.Size(1821, 1154);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbAttributeSelection.ResumeLayout(false);
            this.gbAttributeSelection.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ImageList toolImageList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.GroupBox gbAttributeSelection;
        private System.Windows.Forms.Label lblSubSelect;
        private System.Windows.Forms.Label lblEntities;
        private System.Windows.Forms.ListView lvAttributes;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvEntities;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSelectionType;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.Label lblLcid;
        private System.Windows.Forms.ComboBox cbbLcid;
        private System.Windows.Forms.Button btnBrowseFilePath;
        private System.Windows.Forms.TextBox txtOutputFilePath;
        private System.Windows.Forms.Label lblOutputFilePath;
        private System.Windows.Forms.Label lblOutputType;
        private System.Windows.Forms.ComboBox cbbOutputType;
        private System.Windows.Forms.ListView lvForms;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbGenerate;
        private System.Windows.Forms.CheckBox chkDisplayEntityList;
        private System.Windows.Forms.CheckBox chkAddValidForAf;
        private System.Windows.Forms.CheckBox chkAddRequiredLevel;
        private System.Windows.Forms.CheckBox chkAddFls;
        private System.Windows.Forms.CheckBox chkOneSheet;
        private System.Windows.Forms.CheckBox chkAddAudit;
        private System.Windows.Forms.CheckBox chkAddFormLocation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton settingsToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtPrefixes;
        private System.Windows.Forms.CheckBox chkFilterByPrefix;
        private System.Windows.Forms.ToolStripSplitButton tssbLoadEntities;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadEntitiesFromSolution;
    }
}
