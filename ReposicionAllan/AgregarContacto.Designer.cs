
namespace ReposicionAllan
{
    partial class AgregarContacto
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
            this.nombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telfijo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telcelular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.cod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombres
            // 
            this.nombres.Location = new System.Drawing.Point(394, 82);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(215, 22);
            this.nombres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres";
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(512, 352);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(97, 29);
            this.guardar.TabIndex = 2;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // apellidos
            // 
            this.apellidos.Location = new System.Drawing.Point(120, 139);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(215, 22);
            this.apellidos.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(120, 203);
            this.direccion.Multiline = true;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(215, 64);
            this.direccion.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Direccion";
            // 
            // telfijo
            // 
            this.telfijo.Location = new System.Drawing.Point(394, 139);
            this.telfijo.MaxLength = 8;
            this.telfijo.Name = "telfijo";
            this.telfijo.Size = new System.Drawing.Size(215, 22);
            this.telfijo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tel Fijo";
            // 
            // telcelular
            // 
            this.telcelular.Location = new System.Drawing.Point(394, 218);
            this.telcelular.MaxLength = 8;
            this.telcelular.Name = "telcelular";
            this.telcelular.Size = new System.Drawing.Size(215, 22);
            this.telcelular.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tel Celular";
            // 
            // cancelar
            // 
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Location = new System.Drawing.Point(120, 352);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(97, 29);
            this.cancelar.TabIndex = 2;
            this.cancelar.Text = "cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // cod
            // 
            this.cod.Location = new System.Drawing.Point(120, 82);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(215, 22);
            this.cod.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Codigo";
            // 
            // AgregarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.telcelular);
            this.Controls.Add(this.telfijo);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.nombres);
            this.Name = "AgregarContacto";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telfijo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telcelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox cod;
        private System.Windows.Forms.Label label6;
    }
}

