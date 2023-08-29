
namespace ParciallProgra1
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
            this.lblde = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combode = new System.Windows.Forms.ComboBox();
            this.comboa = new System.Windows.Forms.ComboBox();
            this.textocantidad = new System.Windows.Forms.TextBox();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRespuestas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblde
            // 
            this.lblde.AutoSize = true;
            this.lblde.Location = new System.Drawing.Point(60, 53);
            this.lblde.Name = "lblde";
            this.lblde.Size = new System.Drawing.Size(24, 13);
            this.lblde.TabIndex = 1;
            this.lblde.Text = "De:";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(67, 92);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(17, 13);
            this.lbla.TabIndex = 2;
            this.lbla.Text = "A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad:";
            // 
            // combode
            // 
            this.combode.FormattingEnabled = true;
            this.combode.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzanas",
            "Hectareas"});
            this.combode.Location = new System.Drawing.Point(97, 50);
            this.combode.Name = "combode";
            this.combode.Size = new System.Drawing.Size(121, 21);
            this.combode.TabIndex = 5;
            // 
            // comboa
            // 
            this.comboa.FormattingEnabled = true;
            this.comboa.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzanas",
            "Hectareas"});
            this.comboa.Location = new System.Drawing.Point(97, 92);
            this.comboa.Name = "comboa";
            this.comboa.Size = new System.Drawing.Size(121, 21);
            this.comboa.TabIndex = 6;
            // 
            // textocantidad
            // 
            this.textocantidad.Location = new System.Drawing.Point(97, 132);
            this.textocantidad.Name = "textocantidad";
            this.textocantidad.Size = new System.Drawing.Size(121, 20);
            this.textocantidad.TabIndex = 7;
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(97, 213);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(121, 74);
            this.btnconvertir.TabIndex = 8;
            this.btnconvertir.Text = "convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Respuesta:";
            // 
            // labelRespuestas
            // 
            this.labelRespuestas.AutoSize = true;
            this.labelRespuestas.Location = new System.Drawing.Point(106, 178);
            this.labelRespuestas.Name = "labelRespuestas";
            this.labelRespuestas.Size = new System.Drawing.Size(13, 13);
            this.labelRespuestas.TabIndex = 10;
            this.labelRespuestas.Text = "?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelRespuestas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.textocantidad);
            this.Controls.Add(this.comboa);
            this.Controls.Add(this.combode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.lblde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblde;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combode;
        private System.Windows.Forms.ComboBox comboa;
        private System.Windows.Forms.TextBox textocantidad;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRespuestas;
        private System.Windows.Forms.Button button1;
    }
}

