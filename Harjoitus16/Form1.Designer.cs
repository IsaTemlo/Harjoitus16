
namespace Harjoitus16
{
    partial class LaskuriForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinuutitCB = new System.Windows.Forms.ComboBox();
            this.SekunnitCB = new System.Windows.Forms.ComboBox();
            this.TimeLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minuutit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sekunnit";
            // 
            // MinuutitCB
            // 
            this.MinuutitCB.FormattingEnabled = true;
            this.MinuutitCB.Location = new System.Drawing.Point(19, 72);
            this.MinuutitCB.Name = "MinuutitCB";
            this.MinuutitCB.Size = new System.Drawing.Size(121, 33);
            this.MinuutitCB.TabIndex = 2;
            // 
            // SekunnitCB
            // 
            this.SekunnitCB.FormattingEnabled = true;
            this.SekunnitCB.Location = new System.Drawing.Point(205, 72);
            this.SekunnitCB.Name = "SekunnitCB";
            this.SekunnitCB.Size = new System.Drawing.Size(121, 33);
            this.SekunnitCB.TabIndex = 3;
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLB.Location = new System.Drawing.Point(33, 141);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(284, 108);
            this.TimeLB.TabIndex = 4;
            this.TimeLB.Text = "00:00";
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(19, 334);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(122, 63);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(195, 334);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(122, 63);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // AjastinTM
            // 
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // LaskuriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 479);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.SekunnitCB);
            this.Controls.Add(this.MinuutitCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LaskuriForm";
            this.Text = "Laskuri";
            this.Load += new System.EventHandler(this.LaskuriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MinuutitCB;
        private System.Windows.Forms.ComboBox SekunnitCB;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}

