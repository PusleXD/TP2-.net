﻿namespace UI.Desktop
{
    partial class ComisionDesktop
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
            this.container = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdComision = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cBIdPlan = new System.Windows.Forms.ComboBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.ColumnCount = 4;
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.Controls.Add(this.label1, 0, 0);
            this.container.Controls.Add(this.label3, 2, 0);
            this.container.Controls.Add(this.label2, 0, 1);
            this.container.Controls.Add(this.label4, 2, 1);
            this.container.Controls.Add(this.txtIdComision, 1, 0);
            this.container.Controls.Add(this.txtDescripcion, 3, 0);
            this.container.Controls.Add(this.btnCancelar, 3, 2);
            this.container.Controls.Add(this.btnAceptar, 2, 2);
            this.container.Controls.Add(this.cBIdPlan, 1, 1);
            this.container.Controls.Add(this.txtAnio, 3, 1);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Margin = new System.Windows.Forms.Padding(4);
            this.container.Name = "container";
            this.container.RowCount = 3;
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.container.Size = new System.Drawing.Size(584, 110);
            this.container.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID comision";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año ";
            // 
            // txtIdComision
            // 
            this.txtIdComision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIdComision.Location = new System.Drawing.Point(150, 4);
            this.txtIdComision.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdComision.Name = "txtIdComision";
            this.txtIdComision.ReadOnly = true;
            this.txtIdComision.Size = new System.Drawing.Size(138, 22);
            this.txtIdComision.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Location = new System.Drawing.Point(442, 4);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(138, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(442, 76);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(296, 76);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cBIdPlan
            // 
            this.cBIdPlan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cBIdPlan.FormattingEnabled = true;
            this.cBIdPlan.Location = new System.Drawing.Point(150, 40);
            this.cBIdPlan.Margin = new System.Windows.Forms.Padding(4);
            this.cBIdPlan.Name = "cBIdPlan";
            this.cBIdPlan.Size = new System.Drawing.Size(136, 24);
            this.cBIdPlan.TabIndex = 10;
            // 
            // txtAnio
            // 
            this.txtAnio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAnio.Location = new System.Drawing.Point(442, 40);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(138, 22);
            this.txtAnio.TabIndex = 6;
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // ComisionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 110);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "ComisionDesktop";
            this.Text = "ComisionDesktop";
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdComision;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cBIdPlan;
        private System.Windows.Forms.TextBox txtAnio;
    }
}