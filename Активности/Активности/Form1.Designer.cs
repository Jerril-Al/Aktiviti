namespace Активности
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabControl tabControl1;
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._ObGuild10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._obGuidStroi = new System.Windows.Forms.Label();
            this._ObPirat = new System.Windows.Forms.Label();
            this._ObChernRn = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this._FrUch = new System.Windows.Forms.Label();
            this._FrMedv = new System.Windows.Forms.Label();
            this._FrFalm = new System.Windows.Forms.Label();
            this._FrGrib = new System.Windows.Forms.Label();
            this._FrKril = new System.Windows.Forms.Label();
            this._FrSulan = new System.Windows.Forms.Label();
            this._FrBamb = new System.Windows.Forms.Label();
            this._FrSever = new System.Windows.Forms.Label();
            this._FrVarv = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(this.tabPage1);
            tabControl1.Controls.Add(this.tabPage2);
            tabControl1.Controls.Add(this.tabPage3);
            tabControl1.Location = new System.Drawing.Point(-1, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(344, 275);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._ObChernRn);
            this.tabPage1.Controls.Add(this._ObPirat);
            this.tabPage1.Controls.Add(this._obGuidStroi);
            this.tabPage1.Controls.Add(this._ObGuild10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(336, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Обязательное";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Еженедельные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _ObGuild10
            // 
            this._ObGuild10.AutoSize = true;
            this._ObGuild10.ForeColor = System.Drawing.Color.Red;
            this._ObGuild10.Location = new System.Drawing.Point(15, 16);
            this._ObGuild10.Name = "_ObGuild10";
            this._ObGuild10.Size = new System.Drawing.Size(91, 13);
            this._ObGuild10.TabIndex = 0;
            this._ObGuild10.Text = "10 Клан квестов";
            this._ObGuild10.Click += new System.EventHandler(this._ObGuild10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время на сервере";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // _obGuidStroi
            // 
            this._obGuidStroi.AutoSize = true;
            this._obGuidStroi.ForeColor = System.Drawing.Color.Red;
            this._obGuidStroi.Location = new System.Drawing.Point(3, 88);
            this._obGuidStroi.Name = "_obGuidStroi";
            this._obGuidStroi.Size = new System.Drawing.Size(156, 13);
            this._obGuidStroi.TabIndex = 1;
            this._obGuidStroi.Text = "Клановые квесты на стройку";
            // 
            // _ObPirat
            // 
            this._ObPirat.AutoSize = true;
            this._ObPirat.ForeColor = System.Drawing.Color.Red;
            this._ObPirat.Location = new System.Drawing.Point(3, 101);
            this._ObPirat.Name = "_ObPirat";
            this._ObPirat.Size = new System.Drawing.Size(92, 13);
            this._ObPirat.TabIndex = 2;
            this._ObPirat.Text = "Пиратская бухта";
            // 
            // _ObChernRn
            // 
            this._ObChernRn.AutoSize = true;
            this._ObChernRn.ForeColor = System.Drawing.Color.Red;
            this._ObChernRn.Location = new System.Drawing.Point(3, 114);
            this._ObChernRn.Name = "_ObChernRn";
            this._ObChernRn.Size = new System.Drawing.Size(82, 13);
            this._ObChernRn.TabIndex = 3;
            this._ObChernRn.Text = "Чёрный рынок";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this._FrVarv);
            this.tabPage3.Controls.Add(this._FrSever);
            this.tabPage3.Controls.Add(this._FrBamb);
            this.tabPage3.Controls.Add(this._FrSulan);
            this.tabPage3.Controls.Add(this._FrKril);
            this.tabPage3.Controls.Add(this._FrGrib);
            this.tabPage3.Controls.Add(this._FrFalm);
            this.tabPage3.Controls.Add(this._FrMedv);
            this.tabPage3.Controls.Add(this._FrUch);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(336, 249);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Фракционки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // _FrUch
            // 
            this._FrUch.AutoSize = true;
            this._FrUch.ForeColor = System.Drawing.Color.Red;
            this._FrUch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._FrUch.Location = new System.Drawing.Point(9, 9);
            this._FrUch.Name = "_FrUch";
            this._FrUch.Size = new System.Drawing.Size(46, 13);
            this._FrUch.TabIndex = 0;
            this._FrUch.Text = "Учёные";
            this._FrUch.Click += new System.EventHandler(this._FrUch_Click);
            // 
            // _FrMedv
            // 
            this._FrMedv.AutoSize = true;
            this._FrMedv.ForeColor = System.Drawing.Color.Red;
            this._FrMedv.Location = new System.Drawing.Point(9, 22);
            this._FrMedv.Name = "_FrMedv";
            this._FrMedv.Size = new System.Drawing.Size(52, 13);
            this._FrMedv.TabIndex = 1;
            this._FrMedv.Text = "Медведи";
            this._FrMedv.Click += new System.EventHandler(this._FrMedv_Click);
            // 
            // _FrFalm
            // 
            this._FrFalm.AutoSize = true;
            this._FrFalm.ForeColor = System.Drawing.Color.Red;
            this._FrFalm.Location = new System.Drawing.Point(9, 35);
            this._FrFalm.Name = "_FrFalm";
            this._FrFalm.Size = new System.Drawing.Size(56, 13);
            this._FrFalm.TabIndex = 2;
            this._FrFalm.Text = "Фалмари";
            this._FrFalm.Click += new System.EventHandler(this._FrFalm_Click);
            // 
            // _FrGrib
            // 
            this._FrGrib.AutoSize = true;
            this._FrGrib.ForeColor = System.Drawing.Color.Red;
            this._FrGrib.Location = new System.Drawing.Point(9, 48);
            this._FrGrib.Name = "_FrGrib";
            this._FrGrib.Size = new System.Drawing.Size(54, 13);
            this._FrGrib.TabIndex = 3;
            this._FrGrib.Text = "Грибочки";
            this._FrGrib.Click += new System.EventHandler(this._FrGrib_Click);
            // 
            // _FrKril
            // 
            this._FrKril.AutoSize = true;
            this._FrKril.ForeColor = System.Drawing.Color.Red;
            this._FrKril.Location = new System.Drawing.Point(9, 61);
            this._FrKril.Name = "_FrKril";
            this._FrKril.Size = new System.Drawing.Size(59, 13);
            this._FrKril.TabIndex = 4;
            this._FrKril.Text = "Крылатые";
            this._FrKril.Click += new System.EventHandler(this._FrKril_Click);
            // 
            // _FrSulan
            // 
            this._FrSulan.AutoSize = true;
            this._FrSulan.ForeColor = System.Drawing.Color.Red;
            this._FrSulan.Location = new System.Drawing.Point(9, 74);
            this._FrSulan.Name = "_FrSulan";
            this._FrSulan.Size = new System.Drawing.Size(83, 13);
            this._FrSulan.TabIndex = 5;
            this._FrSulan.Text = "Главный город";
            this._FrSulan.Click += new System.EventHandler(this._FrSulan_Click);
            // 
            // _FrBamb
            // 
            this._FrBamb.AutoSize = true;
            this._FrBamb.ForeColor = System.Drawing.Color.Red;
            this._FrBamb.Location = new System.Drawing.Point(9, 87);
            this._FrBamb.Name = "_FrBamb";
            this._FrBamb.Size = new System.Drawing.Size(114, 13);
            this._FrBamb.TabIndex = 6;
            this._FrBamb.Text = "Бамбуковая деревня";
            this._FrBamb.Click += new System.EventHandler(this._FrBamb_Click);
            // 
            // _FrSever
            // 
            this._FrSever.AutoSize = true;
            this._FrSever.ForeColor = System.Drawing.Color.Red;
            this._FrSever.Location = new System.Drawing.Point(9, 100);
            this._FrSever.Name = "_FrSever";
            this._FrSever.Size = new System.Drawing.Size(56, 13);
            this._FrSever.TabIndex = 7;
            this._FrSever.Text = "Северяне";
            this._FrSever.Click += new System.EventHandler(this._FrSever_Click);
            // 
            // _FrVarv
            // 
            this._FrVarv.AutoSize = true;
            this._FrVarv.ForeColor = System.Drawing.Color.Red;
            this._FrVarv.Location = new System.Drawing.Point(9, 113);
            this._FrVarv.Name = "_FrVarv";
            this._FrVarv.Size = new System.Drawing.Size(52, 13);
            this._FrVarv.TabIndex = 8;
            this._FrVarv.Text = "Варвары";
            this._FrVarv.Click += new System.EventHandler(this._FrVarv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Обнулить всё";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(343, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Активности";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label _ObGuild10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _ObPirat;
        private System.Windows.Forms.Label _obGuidStroi;
        private System.Windows.Forms.Label _ObChernRn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label _FrVarv;
        private System.Windows.Forms.Label _FrSever;
        private System.Windows.Forms.Label _FrBamb;
        private System.Windows.Forms.Label _FrSulan;
        private System.Windows.Forms.Label _FrKril;
        private System.Windows.Forms.Label _FrGrib;
        private System.Windows.Forms.Label _FrFalm;
        private System.Windows.Forms.Label _FrMedv;
        private System.Windows.Forms.Label _FrUch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

