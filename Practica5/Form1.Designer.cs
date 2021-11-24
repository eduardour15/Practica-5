
namespace Practica5
{
    partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tipoLetra = new System.Windows.Forms.ToolStripDropDownButton();
            this.WideLatin = new System.Windows.Forms.ToolStripMenuItem();
            this.Arial = new System.Windows.Forms.ToolStripMenuItem();
            this.tamFont = new System.Windows.Forms.ToolStripComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Caracteres = new System.Windows.Forms.ToolStripStatusLabel();
            this.Filas = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textoPantalla = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoLetra,
            this.tamFont});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(809, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tipoLetra
            // 
            this.tipoLetra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tipoLetra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WideLatin,
            this.Arial});
            this.tipoLetra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipoLetra.Name = "tipoLetra";
            this.tipoLetra.Size = new System.Drawing.Size(76, 22);
            this.tipoLetra.Text = "Wide Latin";
            // 
            // WideLatin
            // 
            this.WideLatin.Name = "WideLatin";
            this.WideLatin.Size = new System.Drawing.Size(130, 22);
            this.WideLatin.Text = "Wide Latin";
            this.WideLatin.Click += new System.EventHandler(this.WideLatin_Click);
            // 
            // Arial
            // 
            this.Arial.Name = "Arial";
            this.Arial.Size = new System.Drawing.Size(130, 22);
            this.Arial.Text = "Arial";
            this.Arial.Click += new System.EventHandler(this.Arial_Click);
            // 
            // tamFont
            // 
            this.tamFont.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.tamFont.Name = "tamFont";
            this.tamFont.Size = new System.Drawing.Size(121, 25);
            this.tamFont.Text = "10";
            this.tamFont.SelectedIndexChanged += new System.EventHandler(this.tamFont_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Caracteres,
            this.Filas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(809, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Caracteres
            // 
            this.Caracteres.Name = "Caracteres";
            this.Caracteres.Size = new System.Drawing.Size(74, 17);
            this.Caracteres.Text = "Caracteres: 0";
            // 
            // Filas
            // 
            this.Filas.Name = "Filas";
            this.Filas.Size = new System.Drawing.Size(42, 17);
            this.Filas.Text = "Filas: 0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textoPantalla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 384);
            this.panel1.TabIndex = 4;
            // 
            // textoPantalla
            // 
            this.textoPantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textoPantalla.Location = new System.Drawing.Point(0, 0);
            this.textoPantalla.Name = "textoPantalla";
            this.textoPantalla.Size = new System.Drawing.Size(809, 384);
            this.textoPantalla.TabIndex = 0;
            this.textoPantalla.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tipoLetra;
        private System.Windows.Forms.ToolStripMenuItem WideLatin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem Arial;
        private System.Windows.Forms.ToolStripComboBox tamFont;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Caracteres;
        private System.Windows.Forms.ToolStripStatusLabel Filas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox textoPantalla;
    }
}

