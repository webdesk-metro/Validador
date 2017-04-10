namespace Validador
{
    partial class Validy
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
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.statusbar_lbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusbar_lbl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ValidyTitle = new System.Windows.Forms.Label();
            this.ValidyTab = new MetroFramework.Controls.MetroTabControl();
            this.ValidyArea = new MetroFramework.Controls.MetroTabPage();
            this.MessageBar = new MetroFramework.Controls.MetroTile();
            this.tbx_doc = new MetroFramework.Controls.MetroTextBox();
            this.lbl_doc = new MetroFramework.Controls.MetroLabel();
            this.rbt_pis = new MetroFramework.Controls.MetroRadioButton();
            this.rbt_cnpj = new MetroFramework.Controls.MetroRadioButton();
            this.rbt_cpf = new MetroFramework.Controls.MetroRadioButton();
            this.lnk_go = new MetroFramework.Controls.MetroLink();
            this.statusbar.SuspendLayout();
            this.ValidyTab.SuspendLayout();
            this.ValidyArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusbar
            // 
            this.statusbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusbar_lbl1,
            this.statusbar_lbl2});
            this.statusbar.Location = new System.Drawing.Point(0, 308);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(530, 22);
            this.statusbar.SizingGrip = false;
            this.statusbar.TabIndex = 1;
            this.statusbar.Text = "statusStrip1";
            // 
            // statusbar_lbl1
            // 
            this.statusbar_lbl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusbar_lbl1.ForeColor = System.Drawing.Color.White;
            this.statusbar_lbl1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.statusbar_lbl1.Name = "statusbar_lbl1";
            this.statusbar_lbl1.Size = new System.Drawing.Size(257, 20);
            this.statusbar_lbl1.Spring = true;
            this.statusbar_lbl1.Text = "Validação concluída!";
            this.statusbar_lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusbar_lbl2
            // 
            this.statusbar_lbl2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusbar_lbl2.ForeColor = System.Drawing.Color.White;
            this.statusbar_lbl2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.statusbar_lbl2.Name = "statusbar_lbl2";
            this.statusbar_lbl2.Size = new System.Drawing.Size(257, 20);
            this.statusbar_lbl2.Spring = true;
            this.statusbar_lbl2.Text = "© Webdesk Metro";
            this.statusbar_lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ValidyTitle
            // 
            this.ValidyTitle.AutoSize = true;
            this.ValidyTitle.Font = new System.Drawing.Font("Segoe UI Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidyTitle.ForeColor = System.Drawing.Color.DimGray;
            this.ValidyTitle.Location = new System.Drawing.Point(0, 10);
            this.ValidyTitle.Name = "ValidyTitle";
            this.ValidyTitle.Size = new System.Drawing.Size(277, 47);
            this.ValidyTitle.TabIndex = 3;
            this.ValidyTitle.Text = "Metro Validy 2017";
            // 
            // ValidyTab
            // 
            this.ValidyTab.Controls.Add(this.ValidyArea);
            this.ValidyTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValidyTab.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.ValidyTab.ItemSize = new System.Drawing.Size(125, 34);
            this.ValidyTab.Location = new System.Drawing.Point(0, 70);
            this.ValidyTab.Name = "ValidyTab";
            this.ValidyTab.SelectedIndex = 0;
            this.ValidyTab.Size = new System.Drawing.Size(530, 238);
            this.ValidyTab.Style = MetroFramework.MetroColorStyle.Green;
            this.ValidyTab.TabIndex = 4;
            this.ValidyTab.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ValidyTab.UseSelectable = true;
            // 
            // ValidyArea
            // 
            this.ValidyArea.Controls.Add(this.MessageBar);
            this.ValidyArea.Controls.Add(this.tbx_doc);
            this.ValidyArea.Controls.Add(this.lbl_doc);
            this.ValidyArea.Controls.Add(this.rbt_pis);
            this.ValidyArea.Controls.Add(this.rbt_cnpj);
            this.ValidyArea.Controls.Add(this.rbt_cpf);
            this.ValidyArea.Controls.Add(this.lnk_go);
            this.ValidyArea.HorizontalScrollbarBarColor = true;
            this.ValidyArea.HorizontalScrollbarHighlightOnWheel = false;
            this.ValidyArea.HorizontalScrollbarSize = 5;
            this.ValidyArea.Location = new System.Drawing.Point(4, 38);
            this.ValidyArea.Name = "ValidyArea";
            this.ValidyArea.Size = new System.Drawing.Size(522, 196);
            this.ValidyArea.Style = MetroFramework.MetroColorStyle.Green;
            this.ValidyArea.TabIndex = 0;
            this.ValidyArea.Text = " Validar ";
            this.ValidyArea.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ValidyArea.VerticalScrollbarBarColor = true;
            this.ValidyArea.VerticalScrollbarHighlightOnWheel = false;
            this.ValidyArea.VerticalScrollbarSize = 7;
            // 
            // MessageBar
            // 
            this.MessageBar.ActiveControl = null;
            this.MessageBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageBar.Location = new System.Drawing.Point(0, -40);
            this.MessageBar.Name = "MessageBar";
            this.MessageBar.Size = new System.Drawing.Size(522, 40);
            this.MessageBar.Style = MetroFramework.MetroColorStyle.Green;
            this.MessageBar.TabIndex = 11;
            this.MessageBar.Text = "MessageBar";
            this.MessageBar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MessageBar.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MessageBar.UseSelectable = true;
            this.MessageBar.Click += new System.EventHandler(this.MessageBar_Click);
            // 
            // tbx_doc
            // 
            // 
            // 
            // 
            this.tbx_doc.CustomButton.Image = null;
            this.tbx_doc.CustomButton.Location = new System.Drawing.Point(369, 1);
            this.tbx_doc.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_doc.CustomButton.Name = "";
            this.tbx_doc.CustomButton.Size = new System.Drawing.Size(28, 25);
            this.tbx_doc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_doc.CustomButton.TabIndex = 1;
            this.tbx_doc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_doc.CustomButton.UseSelectable = true;
            this.tbx_doc.CustomButton.Visible = false;
            this.tbx_doc.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbx_doc.Lines = new string[0];
            this.tbx_doc.Location = new System.Drawing.Point(13, 119);
            this.tbx_doc.MaxLength = 32767;
            this.tbx_doc.Name = "tbx_doc";
            this.tbx_doc.PasswordChar = '\0';
            this.tbx_doc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx_doc.SelectedText = "";
            this.tbx_doc.SelectionLength = 0;
            this.tbx_doc.SelectionStart = 0;
            this.tbx_doc.ShortcutsEnabled = true;
            this.tbx_doc.Size = new System.Drawing.Size(465, 35);
            this.tbx_doc.Style = MetroFramework.MetroColorStyle.Green;
            this.tbx_doc.TabIndex = 10;
            this.tbx_doc.UseSelectable = true;
            this.tbx_doc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_doc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbx_doc.Enter += new System.EventHandler(this.tbx_doc_Enter);
            this.tbx_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_doc_KeyPress);
            // 
            // lbl_doc
            // 
            this.lbl_doc.AutoSize = true;
            this.lbl_doc.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_doc.Location = new System.Drawing.Point(9, 97);
            this.lbl_doc.Name = "lbl_doc";
            this.lbl_doc.Size = new System.Drawing.Size(312, 19);
            this.lbl_doc.Style = MetroFramework.MetroColorStyle.Green;
            this.lbl_doc.TabIndex = 9;
            this.lbl_doc.Text = "Digite o número do documento escolhido acima...";
            this.lbl_doc.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // rbt_pis
            // 
            this.rbt_pis.AutoSize = true;
            this.rbt_pis.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbt_pis.Location = new System.Drawing.Point(158, 50);
            this.rbt_pis.Margin = new System.Windows.Forms.Padding(10);
            this.rbt_pis.Name = "rbt_pis";
            this.rbt_pis.Size = new System.Drawing.Size(44, 19);
            this.rbt_pis.Style = MetroFramework.MetroColorStyle.Green;
            this.rbt_pis.TabIndex = 8;
            this.rbt_pis.Text = "PIS";
            this.rbt_pis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbt_pis.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rbt_pis.UseSelectable = true;
            // 
            // rbt_cnpj
            // 
            this.rbt_cnpj.AutoSize = true;
            this.rbt_cnpj.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbt_cnpj.Location = new System.Drawing.Point(82, 50);
            this.rbt_cnpj.Margin = new System.Windows.Forms.Padding(10);
            this.rbt_cnpj.Name = "rbt_cnpj";
            this.rbt_cnpj.Size = new System.Drawing.Size(56, 19);
            this.rbt_cnpj.Style = MetroFramework.MetroColorStyle.Green;
            this.rbt_cnpj.TabIndex = 7;
            this.rbt_cnpj.Text = "CNPJ";
            this.rbt_cnpj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbt_cnpj.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rbt_cnpj.UseSelectable = true;
            // 
            // rbt_cpf
            // 
            this.rbt_cpf.AutoSize = true;
            this.rbt_cpf.Checked = true;
            this.rbt_cpf.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbt_cpf.Location = new System.Drawing.Point(13, 50);
            this.rbt_cpf.Margin = new System.Windows.Forms.Padding(10);
            this.rbt_cpf.Name = "rbt_cpf";
            this.rbt_cpf.Size = new System.Drawing.Size(49, 19);
            this.rbt_cpf.Style = MetroFramework.MetroColorStyle.Green;
            this.rbt_cpf.TabIndex = 6;
            this.rbt_cpf.TabStop = true;
            this.rbt_cpf.Text = "CPF";
            this.rbt_cpf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbt_cpf.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rbt_cpf.UseSelectable = true;
            // 
            // lnk_go
            // 
            this.lnk_go.Image = global::Validador.Properties.Resources.In_Progress_50;
            this.lnk_go.ImageSize = 35;
            this.lnk_go.Location = new System.Drawing.Point(482, 118);
            this.lnk_go.Name = "lnk_go";
            this.lnk_go.Size = new System.Drawing.Size(35, 35);
            this.lnk_go.Style = MetroFramework.MetroColorStyle.Green;
            this.lnk_go.TabIndex = 5;
            this.lnk_go.UseCustomBackColor = true;
            this.lnk_go.UseSelectable = true;
            this.lnk_go.Click += new System.EventHandler(this.lnk_go_Click);
            // 
            // Validy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 330);
            this.Controls.Add(this.ValidyTab);
            this.Controls.Add(this.ValidyTitle);
            this.Controls.Add(this.statusbar);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Validy";
            this.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.Validy_Load);
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.ValidyTab.ResumeLayout(false);
            this.ValidyArea.ResumeLayout(false);
            this.ValidyArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel statusbar_lbl1;
        private System.Windows.Forms.ToolStripStatusLabel statusbar_lbl2;
        private System.Windows.Forms.Label ValidyTitle;
        private MetroFramework.Controls.MetroTabControl ValidyTab;
        private MetroFramework.Controls.MetroTabPage ValidyArea;
        private MetroFramework.Controls.MetroLink lnk_go;
        private MetroFramework.Controls.MetroRadioButton rbt_pis;
        private MetroFramework.Controls.MetroRadioButton rbt_cnpj;
        private MetroFramework.Controls.MetroRadioButton rbt_cpf;
        private MetroFramework.Controls.MetroLabel lbl_doc;
        private MetroFramework.Controls.MetroTextBox tbx_doc;
        private MetroFramework.Controls.MetroTile MessageBar;
    }
}

