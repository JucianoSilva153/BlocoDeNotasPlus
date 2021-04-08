namespace BlocoDeNotasPLUS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu_ms = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corDeFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corDePáginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOBlocoDeNotasPLUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagina_rtb = new System.Windows.Forms.RichTextBox();
            this.Cor_cdl = new System.Windows.Forms.ColorDialog();
            this.fonte_fdl = new System.Windows.Forms.FontDialog();
            this.abrirFicheiro_ofd = new System.Windows.Forms.OpenFileDialog();
            this.salvarFicheiro_sfd = new System.Windows.Forms.SaveFileDialog();
            this.nomeDocumento_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.barraDeStatus_ss = new System.Windows.Forms.StatusStrip();
            this.menu_ms.SuspendLayout();
            this.barraDeStatus_ss.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_ms
            // 
            this.menu_ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menu_ms.Location = new System.Drawing.Point(0, 0);
            this.menu_ms.Name = "menu_ms";
            this.menu_ms.Size = new System.Drawing.Size(673, 24);
            this.menu_ms.TabIndex = 0;
            this.menu_ms.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::BlocoDeNotasPLUS.Properties.Resources.abrir_btn;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = global::BlocoDeNotasPLUS.Properties.Resources.salvar_png;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salvarToolStripMenuItem.Text = "Salvar...";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Enabled = false;
            this.exportarToolStripMenuItem.Image = global::BlocoDeNotasPLUS.Properties.Resources.salvar_como;
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::BlocoDeNotasPLUS.Properties.Resources.GV_btn_fechar;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonteToolStripMenuItem,
            this.corDeFonteToolStripMenuItem,
            this.corDePáginaToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Image = global::BlocoDeNotasPLUS.Properties.Resources.fonte;
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fonteToolStripMenuItem.Text = "Fonte";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.fonteToolStripMenuItem_Click);
            // 
            // corDeFonteToolStripMenuItem
            // 
            this.corDeFonteToolStripMenuItem.Image = global::BlocoDeNotasPLUS.Properties.Resources.cor_fonte;
            this.corDeFonteToolStripMenuItem.Name = "corDeFonteToolStripMenuItem";
            this.corDeFonteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.corDeFonteToolStripMenuItem.Text = "Cor de fonte";
            this.corDeFonteToolStripMenuItem.Click += new System.EventHandler(this.corDeFonteToolStripMenuItem_Click);
            // 
            // corDePáginaToolStripMenuItem
            // 
            this.corDePáginaToolStripMenuItem.Image = global::BlocoDeNotasPLUS.Properties.Resources.cor_página;
            this.corDePáginaToolStripMenuItem.Name = "corDePáginaToolStripMenuItem";
            this.corDePáginaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.corDePáginaToolStripMenuItem.Text = "Cor de página";
            this.corDePáginaToolStripMenuItem.Click += new System.EventHandler(this.corDePáginaToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraStatusToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // barraStatusToolStripMenuItem
            // 
            this.barraStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.ocultarToolStripMenuItem});
            this.barraStatusToolStripMenuItem.Image = global::BlocoDeNotasPLUS.Properties.Resources.btn_sobre;
            this.barraStatusToolStripMenuItem.Name = "barraStatusToolStripMenuItem";
            this.barraStatusToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.barraStatusToolStripMenuItem.Text = "Barra status";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Image = global::BlocoDeNotasPLUS.Properties.Resources.expand;
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // ocultarToolStripMenuItem
            // 
            this.ocultarToolStripMenuItem.Image = global::BlocoDeNotasPLUS.Properties.Resources.collapse;
            this.ocultarToolStripMenuItem.Name = "ocultarToolStripMenuItem";
            this.ocultarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.ocultarToolStripMenuItem.Text = "Ocultar";
            this.ocultarToolStripMenuItem.Click += new System.EventHandler(this.ocultarToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOBlocoDeNotasPLUSToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreOBlocoDeNotasPLUSToolStripMenuItem
            // 
            this.sobreOBlocoDeNotasPLUSToolStripMenuItem.Image = global::BlocoDeNotasPLUS.Properties.Resources.ajuda;
            this.sobreOBlocoDeNotasPLUSToolStripMenuItem.Name = "sobreOBlocoDeNotasPLUSToolStripMenuItem";
            this.sobreOBlocoDeNotasPLUSToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.sobreOBlocoDeNotasPLUSToolStripMenuItem.Text = "Sobre o Bloco de Notas PLUS";
            this.sobreOBlocoDeNotasPLUSToolStripMenuItem.Click += new System.EventHandler(this.sobreOBlocoDeNotasPLUSToolStripMenuItem_Click);
            // 
            // pagina_rtb
            // 
            this.pagina_rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagina_rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pagina_rtb.Location = new System.Drawing.Point(0, 27);
            this.pagina_rtb.Name = "pagina_rtb";
            this.pagina_rtb.Size = new System.Drawing.Size(673, 341);
            this.pagina_rtb.TabIndex = 1;
            this.pagina_rtb.Text = " ";
            // 
            // abrirFicheiro_ofd
            // 
            this.abrirFicheiro_ofd.Filter = "Documento de Texto|*.txt";
            this.abrirFicheiro_ofd.Title = "Abrir documento...";
            this.abrirFicheiro_ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.abrirFicheiro_ofd_FileOk);
            // 
            // salvarFicheiro_sfd
            // 
            this.salvarFicheiro_sfd.Filter = "Documento de Texto|*.txt";
            this.salvarFicheiro_sfd.Title = "Abrir Documento...";
            // 
            // nomeDocumento_lbl
            // 
            this.nomeDocumento_lbl.Name = "nomeDocumento_lbl";
            this.nomeDocumento_lbl.Size = new System.Drawing.Size(102, 17);
            this.nomeDocumento_lbl.Text = "Novo Documento";
            // 
            // barraDeStatus_ss
            // 
            this.barraDeStatus_ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeDocumento_lbl});
            this.barraDeStatus_ss.Location = new System.Drawing.Point(0, 371);
            this.barraDeStatus_ss.Name = "barraDeStatus_ss";
            this.barraDeStatus_ss.Size = new System.Drawing.Size(673, 22);
            this.barraDeStatus_ss.TabIndex = 2;
            this.barraDeStatus_ss.Text = "statusStrip1";
            this.barraDeStatus_ss.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.barraDeStatus_ss_ItemClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 393);
            this.Controls.Add(this.barraDeStatus_ss);
            this.Controls.Add(this.pagina_rtb);
            this.Controls.Add(this.menu_ms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_ms;
            this.Name = "Form1";
            this.Text = "Bloco de Notas PLUS - Novo Documento";
            this.menu_ms.ResumeLayout(false);
            this.menu_ms.PerformLayout();
            this.barraDeStatus_ss.ResumeLayout(false);
            this.barraDeStatus_ss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_ms;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corDeFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corDePáginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barraStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOBlocoDeNotasPLUSToolStripMenuItem;
        private System.Windows.Forms.RichTextBox pagina_rtb;
        private System.Windows.Forms.ColorDialog Cor_cdl;
        private System.Windows.Forms.FontDialog fonte_fdl;
        private System.Windows.Forms.OpenFileDialog abrirFicheiro_ofd;
        private System.Windows.Forms.SaveFileDialog salvarFicheiro_sfd;
        private System.Windows.Forms.ToolStripStatusLabel nomeDocumento_lbl;
        private System.Windows.Forms.StatusStrip barraDeStatus_ss;
    }
}

