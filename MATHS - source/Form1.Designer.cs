using System;

namespace MATHS___source
{
    partial class maths
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maths));
            this.screen = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ce = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.subs = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.module = new System.Windows.Forms.Button();
            this.numberPI = new System.Windows.Forms.Button();
            this.number10 = new System.Windows.Forms.Button();
            this.number100 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.Location = new System.Drawing.Point(12, 12);
            this.screen.Multiline = true;
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.Size = new System.Drawing.Size(206, 30);
            this.screen.TabIndex = 0;
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.screen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ce
            // 
            this.ce.BackColor = System.Drawing.Color.Black;
            this.ce.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ce.Location = new System.Drawing.Point(12, 48);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(47, 40);
            this.ce.TabIndex = 1;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = false;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.Black;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.div.Location = new System.Drawing.Point(65, 48);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(47, 40);
            this.div.TabIndex = 1;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.Color.Black;
            this.mult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mult.Location = new System.Drawing.Point(118, 48);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(47, 40);
            this.mult.TabIndex = 1;
            this.mult.Text = "X";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // subs
            // 
            this.subs.BackColor = System.Drawing.Color.Black;
            this.subs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subs.Location = new System.Drawing.Point(171, 186);
            this.subs.Name = "subs";
            this.subs.Size = new System.Drawing.Size(47, 40);
            this.subs.TabIndex = 1;
            this.subs.Text = "-";
            this.subs.UseVisualStyleBackColor = false;
            this.subs.Click += new System.EventHandler(this.subs_Click);
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number1.Location = new System.Drawing.Point(10, 232);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(47, 40);
            this.number1.TabIndex = 1;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = false;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number2.Location = new System.Drawing.Point(63, 232);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(47, 40);
            this.number2.TabIndex = 1;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = false;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number3.Location = new System.Drawing.Point(118, 232);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(47, 40);
            this.number3.TabIndex = 1;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = false;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number4
            // 
            this.number4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number4.Location = new System.Drawing.Point(10, 186);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(47, 40);
            this.number4.TabIndex = 1;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = false;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number5
            // 
            this.number5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number5.Location = new System.Drawing.Point(63, 186);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(47, 40);
            this.number5.TabIndex = 1;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = false;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Black;
            this.add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.Location = new System.Drawing.Point(171, 94);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(47, 86);
            this.add.TabIndex = 1;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // number6
            // 
            this.number6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number6.Location = new System.Drawing.Point(118, 186);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(47, 40);
            this.number6.TabIndex = 1;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = false;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number7
            // 
            this.number7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number7.Location = new System.Drawing.Point(10, 140);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(47, 40);
            this.number7.TabIndex = 1;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = false;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number8
            // 
            this.number8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number8.Location = new System.Drawing.Point(65, 140);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(47, 40);
            this.number8.TabIndex = 1;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = false;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            this.number9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number9.Location = new System.Drawing.Point(118, 140);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(47, 40);
            this.number9.TabIndex = 1;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = false;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // number0
            // 
            this.number0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number0.Location = new System.Drawing.Point(10, 278);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(100, 40);
            this.number0.TabIndex = 1;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = false;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dot.Location = new System.Drawing.Point(118, 278);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(47, 40);
            this.dot.TabIndex = 1;
            this.dot.Text = ",";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.Black;
            this.equals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.equals.Location = new System.Drawing.Point(171, 232);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(47, 86);
            this.equals.TabIndex = 1;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // module
            // 
            this.module.BackColor = System.Drawing.Color.Black;
            this.module.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.module.Location = new System.Drawing.Point(171, 48);
            this.module.Name = "module";
            this.module.Size = new System.Drawing.Size(47, 40);
            this.module.TabIndex = 2;
            this.module.Text = "%";
            this.module.UseVisualStyleBackColor = false;
            this.module.Click += new System.EventHandler(this.module_Click);
            // 
            // numberPI
            // 
            this.numberPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.numberPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberPI.Location = new System.Drawing.Point(118, 94);
            this.numberPI.Name = "numberPI";
            this.numberPI.Size = new System.Drawing.Size(47, 40);
            this.numberPI.TabIndex = 1;
            this.numberPI.Text = "π";
            this.numberPI.UseVisualStyleBackColor = false;
            this.numberPI.Click += new System.EventHandler(this.numberPI_Click);
            // 
            // number10
            // 
            this.number10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number10.Location = new System.Drawing.Point(12, 94);
            this.number10.Name = "number10";
            this.number10.Size = new System.Drawing.Size(47, 40);
            this.number10.TabIndex = 1;
            this.number10.Text = "10";
            this.number10.UseVisualStyleBackColor = false;
            this.number10.Click += new System.EventHandler(this.numberten_Click);
            // 
            // number100
            // 
            this.number100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number100.Location = new System.Drawing.Point(65, 94);
            this.number100.Name = "number100";
            this.number100.Size = new System.Drawing.Size(47, 40);
            this.number100.TabIndex = 1;
            this.number100.Text = "100";
            this.number100.UseVisualStyleBackColor = false;
            this.number100.Click += new System.EventHandler(this.number100_Click);
            // 
            // maths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 321);
            this.Controls.Add(this.module);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.number100);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number10);
            this.Controls.Add(this.subs);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.add);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.numberPI);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.div);
            this.Controls.Add(this.ce);
            this.Controls.Add(this.screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "maths";
            this.Text = "CALCULATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void numberten_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "10";
        }

        private void numberPI_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "3,14159265";
        }

        private void number100_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "100";
        }

        #endregion

        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button subs;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button module;
        private System.Windows.Forms.Button numberPI;
        private System.Windows.Forms.Button number10;
        private System.Windows.Forms.Button number100;
        private EventHandler number10_Click;
    }
}

