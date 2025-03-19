namespace RemoveAppPackage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtlista = new TextBox();
            txtpackage = new TextBox();
            btnapagar = new Button();
            btnlistar = new Button();
            SuspendLayout();
            // 
            // txtlista
            // 
            txtlista.Location = new Point(39, 12);
            txtlista.Multiline = true;
            txtlista.Name = "txtlista";
            txtlista.ScrollBars = ScrollBars.Vertical;
            txtlista.Size = new Size(1290, 522);
            txtlista.TabIndex = 0;
            // 
            // txtpackage
            // 
            txtpackage.Location = new Point(595, 554);
            txtpackage.Multiline = true;
            txtpackage.Name = "txtpackage";
            txtpackage.Size = new Size(734, 51);
            txtpackage.TabIndex = 1;
            // 
            // btnapagar
            // 
            btnapagar.Location = new Point(328, 554);
            btnapagar.Name = "btnapagar";
            btnapagar.Size = new Size(197, 51);
            btnapagar.TabIndex = 2;
            btnapagar.Text = "Apagar Packages";
            btnapagar.UseVisualStyleBackColor = true;
            btnapagar.Click += btnapagar_Click;
            // 
            // btnlistar
            // 
            btnlistar.Location = new Point(39, 554);
            btnlistar.Name = "btnlistar";
            btnlistar.Size = new Size(197, 51);
            btnlistar.TabIndex = 3;
            btnlistar.Text = "Listar Packages";
            btnlistar.UseVisualStyleBackColor = true;
            btnlistar.Click += btnlistar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 657);
            Controls.Add(btnlistar);
            Controls.Add(btnapagar);
            Controls.Add(txtpackage);
            Controls.Add(txtlista);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtlista;
        private TextBox txtpackage;
        private Button btnapagar;
        private Button btnlistar;
    }
}
