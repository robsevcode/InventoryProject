namespace Bodega
{
    partial class Bodega
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuNuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRealizarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMostrarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNuevoCliente,
            this.menuRealizarPedido,
            this.menuMostrarPedido});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNuevoCliente
            // 
            this.menuNuevoCliente.Name = "menuNuevoCliente";
            this.menuNuevoCliente.Size = new System.Drawing.Size(94, 20);
            this.menuNuevoCliente.Text = "Nuevo Cliente";
            this.menuNuevoCliente.Click += new System.EventHandler(this.menuNuevoCliente_Click);
            // 
            // menuRealizarPedido
            // 
            this.menuRealizarPedido.Name = "menuRealizarPedido";
            this.menuRealizarPedido.Size = new System.Drawing.Size(99, 20);
            this.menuRealizarPedido.Text = "Realizar Pedido";
            // 
            // menuMostrarPedido
            // 
            this.menuMostrarPedido.Name = "menuMostrarPedido";
            this.menuMostrarPedido.Size = new System.Drawing.Size(100, 20);
            this.menuMostrarPedido.Text = "Mostrar Pedido";
            // 
            // Bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 338);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bodega";
            this.Text = "Bodega";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuNuevoCliente;
        private System.Windows.Forms.ToolStripMenuItem menuRealizarPedido;
        private System.Windows.Forms.ToolStripMenuItem menuMostrarPedido;
    }
}

