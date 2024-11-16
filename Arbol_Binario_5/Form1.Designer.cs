namespace ArbolBinarioApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAmplitud;
        private System.Windows.Forms.Button btnPreorden;
        private System.Windows.Forms.Button btnInorden;
        private System.Windows.Forms.Button btnPostorden;
        private System.Windows.Forms.TextBox textBoxResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAmplitud = new System.Windows.Forms.Button();
            this.btnPreorden = new System.Windows.Forms.Button();
            this.btnInorden = new System.Windows.Forms.Button();
            this.btnPostorden = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // btnAmplitud
            // 
            this.btnAmplitud.Location = new System.Drawing.Point(12, 12);
            this.btnAmplitud.Name = "btnAmplitud";
            this.btnAmplitud.Size = new System.Drawing.Size(150, 30);
            this.btnAmplitud.TabIndex = 0;
            this.btnAmplitud.Text = "Recorrido Amplitud";
            this.btnAmplitud.UseVisualStyleBackColor = true;
            this.btnAmplitud.Click += new System.EventHandler(this.btnAmplitud_Click);

            // 
            // btnPreorden
            // 
            this.btnPreorden.Location = new System.Drawing.Point(12, 48);
            this.btnPreorden.Name = "btnPreorden";
            this.btnPreorden.Size = new System.Drawing.Size(150, 30);
            this.btnPreorden.TabIndex = 1;
            this.btnPreorden.Text = "Recorrido Preorden";
            this.btnPreorden.UseVisualStyleBackColor = true;
            this.btnPreorden.Click += new System.EventHandler(this.btnPreorden_Click);

            // 
            // btnInorden
            // 
            this.btnInorden.Location = new System.Drawing.Point(12, 84);
            this.btnInorden.Name = "btnInorden";
            this.btnInorden.Size = new System.Drawing.Size(150, 30);
            this.btnInorden.TabIndex = 2;
            this.btnInorden.Text = "Recorrido Inorden";
            this.btnInorden.UseVisualStyleBackColor = true;
            this.btnInorden.Click += new System.EventHandler(this.btnInorden_Click);

            // 
            // btnPostorden
            // 
            this.btnPostorden.Location = new System.Drawing.Point(12, 120);
            this.btnPostorden.Name = "btnPostorden";
            this.btnPostorden.Size = new System.Drawing.Size(150, 30);
            this.btnPostorden.TabIndex = 3;
            this.btnPostorden.Text = "Recorrido Postorden";
            this.btnPostorden.UseVisualStyleBackColor = true;
            this.btnPostorden.Click += new System.EventHandler(this.btnPostorden_Click);

            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(180, 12);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultado.Size = new System.Drawing.Size(300, 138);
            this.textBoxResultado.TabIndex = 4;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 180);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.btnPostorden);
            this.Controls.Add(this.btnInorden);
            this.Controls.Add(this.btnPreorden);
            this.Controls.Add(this.btnAmplitud);
            this.Name = "Form1";
            this.Text = "Árbol Binario - Recorridos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}