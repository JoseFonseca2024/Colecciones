namespace PracticaColecciones
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
            label1 = new Label();
            label2 = new Label();
            txtElemento = new TextBox();
            txtValor = new TextBox();
            btnAgregarArrayList = new Button();
            btnAgregaraHashtable = new Button();
            btnAgregarQueue = new Button();
            btnProcesarQueue = new Button();
            lstColecciones = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 39);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 0;
            label1.Text = "Elemento";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 71);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 1;
            label2.Text = "Valor";
            // 
            // txtElemento
            // 
            txtElemento.Anchor = AnchorStyles.None;
            txtElemento.Location = new Point(147, 39);
            txtElemento.Multiline = true;
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(124, 21);
            txtElemento.TabIndex = 2;
            // 
            // txtValor
            // 
            txtValor.Anchor = AnchorStyles.None;
            txtValor.Location = new Point(147, 71);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(124, 21);
            txtValor.TabIndex = 3;
            // 
            // btnAgregarArrayList
            // 
            btnAgregarArrayList.Anchor = AnchorStyles.None;
            btnAgregarArrayList.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarArrayList.Location = new Point(299, 35);
            btnAgregarArrayList.Name = "btnAgregarArrayList";
            btnAgregarArrayList.Size = new Size(143, 28);
            btnAgregarArrayList.TabIndex = 4;
            btnAgregarArrayList.Text = "Agregar a ArrayList";
            btnAgregarArrayList.UseVisualStyleBackColor = true;
            btnAgregarArrayList.Click += AgregaraArrayList;
            // 
            // btnAgregaraHashtable
            // 
            btnAgregaraHashtable.Anchor = AnchorStyles.None;
            btnAgregaraHashtable.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregaraHashtable.Location = new Point(299, 69);
            btnAgregaraHashtable.Name = "btnAgregaraHashtable";
            btnAgregaraHashtable.Size = new Size(143, 28);
            btnAgregaraHashtable.TabIndex = 5;
            btnAgregaraHashtable.Text = "Agregar a Hashtable";
            btnAgregaraHashtable.UseVisualStyleBackColor = true;
            btnAgregaraHashtable.Click += Agregarhastable;
            // 
            // btnAgregarQueue
            // 
            btnAgregarQueue.Anchor = AnchorStyles.None;
            btnAgregarQueue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarQueue.Location = new Point(71, 110);
            btnAgregarQueue.Name = "btnAgregarQueue";
            btnAgregarQueue.Size = new Size(143, 28);
            btnAgregarQueue.TabIndex = 6;
            btnAgregarQueue.Text = "Agregar Queue";
            btnAgregarQueue.UseVisualStyleBackColor = true;
            btnAgregarQueue.Click += AgregarQueue;
            // 
            // btnProcesarQueue
            // 
            btnProcesarQueue.Anchor = AnchorStyles.None;
            btnProcesarQueue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcesarQueue.Location = new Point(248, 110);
            btnProcesarQueue.Name = "btnProcesarQueue";
            btnProcesarQueue.Size = new Size(143, 28);
            btnProcesarQueue.TabIndex = 7;
            btnProcesarQueue.Text = "Procesar Queue";
            btnProcesarQueue.UseVisualStyleBackColor = true;
            btnProcesarQueue.Click += ProcesarQueue;
            // 
            // lstColecciones
            // 
            lstColecciones.Anchor = AnchorStyles.None;
            lstColecciones.FormattingEnabled = true;
            lstColecciones.ItemHeight = 15;
            lstColecciones.Location = new Point(48, 156);
            lstColecciones.Name = "lstColecciones";
            lstColecciones.Size = new Size(394, 259);
            lstColecciones.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 450);
            Controls.Add(lstColecciones);
            Controls.Add(btnProcesarQueue);
            Controls.Add(btnAgregarQueue);
            Controls.Add(btnAgregaraHashtable);
            Controls.Add(btnAgregarArrayList);
            Controls.Add(txtValor);
            Controls.Add(txtElemento);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtElemento;
        private TextBox txtValor;
        private Button btnAgregarArrayList;
        private Button btnAgregaraHashtable;
        private Button btnAgregarQueue;
        private Button btnProcesarQueue;
        private ListBox lstColecciones;
    }
}
