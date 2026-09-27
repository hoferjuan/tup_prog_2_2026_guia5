namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxChar = new System.Windows.Forms.ListBox();
            this.listBoxRegex = new System.Windows.Forms.ListBox();
            this.btnProbarChar = new System.Windows.Forms.Button();
            this.btnProbarRegex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxChar
            // 
            this.listBoxChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChar.FormattingEnabled = true;
            this.listBoxChar.ItemHeight = 20;
            this.listBoxChar.Location = new System.Drawing.Point(12, 127);
            this.listBoxChar.Name = "listBoxChar";
            this.listBoxChar.Size = new System.Drawing.Size(370, 544);
            this.listBoxChar.TabIndex = 0;
            // 
            // listBoxRegex
            // 
            this.listBoxRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRegex.FormattingEnabled = true;
            this.listBoxRegex.ItemHeight = 20;
            this.listBoxRegex.Location = new System.Drawing.Point(418, 127);
            this.listBoxRegex.Name = "listBoxRegex";
            this.listBoxRegex.Size = new System.Drawing.Size(370, 544);
            this.listBoxRegex.TabIndex = 1;
            // 
            // btnProbarChar
            // 
            this.btnProbarChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbarChar.Location = new System.Drawing.Point(12, 31);
            this.btnProbarChar.Name = "btnProbarChar";
            this.btnProbarChar.Size = new System.Drawing.Size(370, 60);
            this.btnProbarChar.TabIndex = 2;
            this.btnProbarChar.Text = "Probar Ejemplos Char";
            this.btnProbarChar.UseVisualStyleBackColor = true;
            this.btnProbarChar.Click += new System.EventHandler(this.btnProbarChar_Click);
            // 
            // btnProbarRegex
            // 
            this.btnProbarRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbarRegex.Location = new System.Drawing.Point(418, 31);
            this.btnProbarRegex.Name = "btnProbarRegex";
            this.btnProbarRegex.Size = new System.Drawing.Size(370, 60);
            this.btnProbarRegex.TabIndex = 3;
            this.btnProbarRegex.Text = "Probar Ejemplos Regex";
            this.btnProbarRegex.UseVisualStyleBackColor = true;
            this.btnProbarRegex.Click += new System.EventHandler(this.btnProbarRegex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.btnProbarRegex);
            this.Controls.Add(this.btnProbarChar);
            this.Controls.Add(this.listBoxRegex);
            this.Controls.Add(this.listBoxChar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxChar;
        private System.Windows.Forms.ListBox listBoxRegex;
        private System.Windows.Forms.Button btnProbarChar;
        private System.Windows.Forms.Button btnProbarRegex;
    }
}

