
namespace ReposicionAllan
{
    partial class Inicio
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
            this.label2 = new System.Windows.Forms.Label();
            this.ingresar = new System.Windows.Forms.Button();
            this.dgv_contactos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contactos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contactos";
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(806, 445);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(95, 43);
            this.ingresar.TabIndex = 4;
            this.ingresar.Text = "Agregar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // dgv_contactos
            // 
            this.dgv_contactos.AllowUserToAddRows = false;
            this.dgv_contactos.AllowUserToDeleteRows = false;
            this.dgv_contactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contactos.Location = new System.Drawing.Point(92, 192);
            this.dgv_contactos.Name = "dgv_contactos";
            this.dgv_contactos.ReadOnly = true;
            this.dgv_contactos.RowHeadersWidth = 51;
            this.dgv_contactos.RowTemplate.Height = 24;
            this.dgv_contactos.Size = new System.Drawing.Size(809, 232);
            this.dgv_contactos.TabIndex = 5;
            this.dgv_contactos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_contactos_CellClick);
            this.dgv_contactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_contactos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "click en un registro para ver el Polimorfismo";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 539);
            this.Controls.Add(this.dgv_contactos);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.DataGridView dgv_contactos;
        private System.Windows.Forms.Label label1;
    }
}