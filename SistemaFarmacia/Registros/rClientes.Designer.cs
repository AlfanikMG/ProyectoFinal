namespace SistemaFarmacia.Registros
{
    partial class rClientes
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
            this.components = new System.ComponentModel.Container();
            this.ClientesId = new System.Windows.Forms.Label();
            this.DireccionLabel = new System.Windows.Forms.Label();
            this.Celularlabel = new System.Windows.Forms.Label();
            this.CedulaLabel = new System.Windows.Forms.Label();
            this.NombresLabel = new System.Windows.Forms.Label();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.CedulaTextBox = new System.Windows.Forms.TextBox();
            this.ClientesIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CelularTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesId
            // 
            this.ClientesId.AutoSize = true;
            this.ClientesId.Location = new System.Drawing.Point(25, 20);
            this.ClientesId.Name = "ClientesId";
            this.ClientesId.Size = new System.Drawing.Size(53, 13);
            this.ClientesId.TabIndex = 0;
            this.ClientesId.Text = "ClientesId";
            // 
            // DireccionLabel
            // 
            this.DireccionLabel.AutoSize = true;
            this.DireccionLabel.Location = new System.Drawing.Point(25, 150);
            this.DireccionLabel.Name = "DireccionLabel";
            this.DireccionLabel.Size = new System.Drawing.Size(52, 13);
            this.DireccionLabel.TabIndex = 2;
            this.DireccionLabel.Text = "Direccion";
            // 
            // Celularlabel
            // 
            this.Celularlabel.AutoSize = true;
            this.Celularlabel.Location = new System.Drawing.Point(25, 124);
            this.Celularlabel.Name = "Celularlabel";
            this.Celularlabel.Size = new System.Drawing.Size(39, 13);
            this.Celularlabel.TabIndex = 3;
            this.Celularlabel.Text = "Celular";
            // 
            // CedulaLabel
            // 
            this.CedulaLabel.AutoSize = true;
            this.CedulaLabel.Location = new System.Drawing.Point(25, 72);
            this.CedulaLabel.Name = "CedulaLabel";
            this.CedulaLabel.Size = new System.Drawing.Size(40, 13);
            this.CedulaLabel.TabIndex = 4;
            this.CedulaLabel.Text = "Cedula";
            // 
            // NombresLabel
            // 
            this.NombresLabel.AutoSize = true;
            this.NombresLabel.Location = new System.Drawing.Point(25, 46);
            this.NombresLabel.Name = "NombresLabel";
            this.NombresLabel.Size = new System.Drawing.Size(49, 13);
            this.NombresLabel.TabIndex = 5;
            this.NombresLabel.Text = "Nombres";
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(98, 46);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(158, 20);
            this.NombresTextBox.TabIndex = 10;
            // 
            // CedulaTextBox
            // 
            this.CedulaTextBox.Location = new System.Drawing.Point(98, 72);
            this.CedulaTextBox.Name = "CedulaTextBox";
            this.CedulaTextBox.Size = new System.Drawing.Size(158, 20);
            this.CedulaTextBox.TabIndex = 11;
            // 
            // ClientesIdNumericUpDown
            // 
            this.ClientesIdNumericUpDown.Location = new System.Drawing.Point(98, 20);
            this.ClientesIdNumericUpDown.Name = "ClientesIdNumericUpDown";
            this.ClientesIdNumericUpDown.Size = new System.Drawing.Size(91, 20);
            this.ClientesIdNumericUpDown.TabIndex = 12;
            // 
            // CelularTextBox
            // 
            this.CelularTextBox.Location = new System.Drawing.Point(98, 124);
            this.CelularTextBox.Name = "CelularTextBox";
            this.CelularTextBox.Size = new System.Drawing.Size(157, 20);
            this.CelularTextBox.TabIndex = 13;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(98, 150);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(157, 20);
            this.DireccionTextBox.TabIndex = 14;
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BuscarButton.Image = global::SistemaFarmacia.Properties.Resources.search_iconGuardar;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(195, 18);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(61, 23);
            this.BuscarButton.TabIndex = 9;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = false;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GuardarButton.Image = global::SistemaFarmacia.Properties.Resources.save_icon;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(109, 212);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(67, 23);
            this.GuardarButton.TabIndex = 8;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EliminarButton.Image = global::SistemaFarmacia.Properties.Resources.user_remove_icon;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(193, 212);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(63, 23);
            this.EliminarButton.TabIndex = 7;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = false;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NuevoButton.Image = global::SistemaFarmacia.Properties.Resources.New;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(28, 212);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(64, 23);
            this.NuevoButton.TabIndex = 6;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = false;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(98, 98);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(158, 20);
            this.TelefonoTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Telefono";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 261);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.CelularTextBox);
            this.Controls.Add(this.ClientesIdNumericUpDown);
            this.Controls.Add(this.CedulaTextBox);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.NombresLabel);
            this.Controls.Add(this.CedulaLabel);
            this.Controls.Add(this.Celularlabel);
            this.Controls.Add(this.DireccionLabel);
            this.Controls.Add(this.ClientesId);
            this.Name = "rClientes";
            this.Text = "rClientes";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientesId;
        private System.Windows.Forms.Label DireccionLabel;
        private System.Windows.Forms.Label Celularlabel;
        private System.Windows.Forms.Label CedulaLabel;
        private System.Windows.Forms.Label NombresLabel;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.TextBox CedulaTextBox;
        private System.Windows.Forms.NumericUpDown ClientesIdNumericUpDown;
        private System.Windows.Forms.TextBox CelularTextBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}