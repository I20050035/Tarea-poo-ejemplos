namespace Test_Tarea
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
            this.btnCelular = new System.Windows.Forms.Button();
            this.btnCelular_Huawei = new System.Windows.Forms.Button();
            this.btnHuawei_Psmart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCelular
            // 
            this.btnCelular.Location = new System.Drawing.Point(231, 31);
            this.btnCelular.Name = "btnCelular";
            this.btnCelular.Size = new System.Drawing.Size(195, 78);
            this.btnCelular.TabIndex = 0;
            this.btnCelular.Text = "Celular";
            this.btnCelular.UseVisualStyleBackColor = true;
            this.btnCelular.Click += new System.EventHandler(this.btnCelular_Click);
            // 
            // btnCelular_Huawei
            // 
            this.btnCelular_Huawei.Location = new System.Drawing.Point(231, 137);
            this.btnCelular_Huawei.Name = "btnCelular_Huawei";
            this.btnCelular_Huawei.Size = new System.Drawing.Size(195, 78);
            this.btnCelular_Huawei.TabIndex = 1;
            this.btnCelular_Huawei.Text = " Celular_Huawei";
            this.btnCelular_Huawei.UseVisualStyleBackColor = true;
            this.btnCelular_Huawei.Click += new System.EventHandler(this.btnCelular_Huawei_Click);
            // 
            // btnHuawei_Psmart
            // 
            this.btnHuawei_Psmart.Location = new System.Drawing.Point(231, 242);
            this.btnHuawei_Psmart.Name = "btnHuawei_Psmart";
            this.btnHuawei_Psmart.Size = new System.Drawing.Size(195, 78);
            this.btnHuawei_Psmart.TabIndex = 2;
            this.btnHuawei_Psmart.Text = "Huawei_Psmart";
            this.btnHuawei_Psmart.UseVisualStyleBackColor = true;
            this.btnHuawei_Psmart.Click += new System.EventHandler(this.btnHuawei_Psmart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnHuawei_Psmart);
            this.Controls.Add(this.btnCelular_Huawei);
            this.Controls.Add(this.btnCelular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCelular;
        private System.Windows.Forms.Button btnCelular_Huawei;
        private System.Windows.Forms.Button btnHuawei_Psmart;
    }
}

