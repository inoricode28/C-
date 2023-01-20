namespace Calculadora
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_1 = new System.Windows.Forms.TextBox();
            this.Tb_2 = new System.Windows.Forms.TextBox();
            this.Tb_3 = new System.Windows.Forms.TextBox();
            this.Bt_Suma = new System.Windows.Forms.Button();
            this.Bt_Limpiar = new System.Windows.Forms.Button();
            this.Bt_Resta = new System.Windows.Forms.Button();
            this.Bt_Multiplicar = new System.Windows.Forms.Button();
            this.Bt_Dividir = new System.Windows.Forms.Button();
            this.BT_Siguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(658, 73);
            this.label2.TabIndex = 0;
            this.label2.Text = "Operaciones Basicas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Primer Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Segundo Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Resultado";
            // 
            // Tb_1
            // 
            this.Tb_1.Location = new System.Drawing.Point(319, 132);
            this.Tb_1.Name = "Tb_1";
            this.Tb_1.Size = new System.Drawing.Size(100, 20);
            this.Tb_1.TabIndex = 2;
            // 
            // Tb_2
            // 
            this.Tb_2.Location = new System.Drawing.Point(319, 209);
            this.Tb_2.Name = "Tb_2";
            this.Tb_2.Size = new System.Drawing.Size(100, 20);
            this.Tb_2.TabIndex = 2;
            // 
            // Tb_3
            // 
            this.Tb_3.Enabled = false;
            this.Tb_3.Location = new System.Drawing.Point(319, 270);
            this.Tb_3.Name = "Tb_3";
            this.Tb_3.Size = new System.Drawing.Size(100, 20);
            this.Tb_3.TabIndex = 2;
            // 
            // Bt_Suma
            // 
            this.Bt_Suma.Location = new System.Drawing.Point(118, 345);
            this.Bt_Suma.Name = "Bt_Suma";
            this.Bt_Suma.Size = new System.Drawing.Size(130, 53);
            this.Bt_Suma.TabIndex = 3;
            this.Bt_Suma.Text = "&SUMAR";
            this.Bt_Suma.UseVisualStyleBackColor = true;
            this.Bt_Suma.Click += new System.EventHandler(this.Bt_Suma_Click);
            // 
            // Bt_Limpiar
            // 
            this.Bt_Limpiar.Location = new System.Drawing.Point(538, 132);
            this.Bt_Limpiar.Name = "Bt_Limpiar";
            this.Bt_Limpiar.Size = new System.Drawing.Size(113, 53);
            this.Bt_Limpiar.TabIndex = 4;
            this.Bt_Limpiar.Text = "&LIMPIAR";
            this.Bt_Limpiar.UseVisualStyleBackColor = true;
            this.Bt_Limpiar.Click += new System.EventHandler(this.Bt_Limpiar_Click);
            // 
            // Bt_Resta
            // 
            this.Bt_Resta.Location = new System.Drawing.Point(264, 345);
            this.Bt_Resta.Name = "Bt_Resta";
            this.Bt_Resta.Size = new System.Drawing.Size(130, 53);
            this.Bt_Resta.TabIndex = 3;
            this.Bt_Resta.Text = "&RESTA";
            this.Bt_Resta.UseVisualStyleBackColor = true;
            this.Bt_Resta.Click += new System.EventHandler(this.Bt_Suma_Click);
            // 
            // Bt_Multiplicar
            // 
            this.Bt_Multiplicar.Location = new System.Drawing.Point(410, 345);
            this.Bt_Multiplicar.Name = "Bt_Multiplicar";
            this.Bt_Multiplicar.Size = new System.Drawing.Size(130, 53);
            this.Bt_Multiplicar.TabIndex = 3;
            this.Bt_Multiplicar.Text = "&MULTIPLICAR";
            this.Bt_Multiplicar.UseVisualStyleBackColor = true;
            this.Bt_Multiplicar.Click += new System.EventHandler(this.Bt_Suma_Click);
            // 
            // Bt_Dividir
            // 
            this.Bt_Dividir.Location = new System.Drawing.Point(555, 345);
            this.Bt_Dividir.Name = "Bt_Dividir";
            this.Bt_Dividir.Size = new System.Drawing.Size(130, 53);
            this.Bt_Dividir.TabIndex = 3;
            this.Bt_Dividir.Text = "&DIVIDIR";
            this.Bt_Dividir.UseVisualStyleBackColor = true;
            this.Bt_Dividir.Click += new System.EventHandler(this.Bt_Suma_Click);
            // 
            // BT_Siguiente
            // 
            this.BT_Siguiente.Location = new System.Drawing.Point(538, 209);
            this.BT_Siguiente.Name = "BT_Siguiente";
            this.BT_Siguiente.Size = new System.Drawing.Size(113, 62);
            this.BT_Siguiente.TabIndex = 5;
            this.BT_Siguiente.Text = "&SIGUIENTE";
            this.BT_Siguiente.UseVisualStyleBackColor = true;
            this.BT_Siguiente.Click += new System.EventHandler(this.BT_Siguiente_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(806, 422);
            this.Controls.Add(this.BT_Siguiente);
            this.Controls.Add(this.Bt_Limpiar);
            this.Controls.Add(this.Bt_Dividir);
            this.Controls.Add(this.Bt_Multiplicar);
            this.Controls.Add(this.Bt_Resta);
            this.Controls.Add(this.Bt_Suma);
            this.Controls.Add(this.Tb_3);
            this.Controls.Add(this.Tb_2);
            this.Controls.Add(this.Tb_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Operaciones Basicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_1;
        private System.Windows.Forms.TextBox Tb_2;
        private System.Windows.Forms.TextBox Tb_3;
        private System.Windows.Forms.Button Bt_Suma;
        private System.Windows.Forms.Button Bt_Limpiar;
        private System.Windows.Forms.Button Bt_Resta;
        private System.Windows.Forms.Button Bt_Multiplicar;
        private System.Windows.Forms.Button Bt_Dividir;
        private System.Windows.Forms.Button BT_Siguiente;
    }
}

