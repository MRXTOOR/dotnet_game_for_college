using System;
using System.Windows.Forms;

namespace _232323
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mvTim = new System.Windows.Forms.Timer(this.components);
            this.mainPlayer = new System.Windows.Forms.PictureBox();
            this.leftmv = new System.Windows.Forms.Timer(this.components);
            this.rightmv = new System.Windows.Forms.Timer(this.components);
            this.upmv = new System.Windows.Forms.Timer(this.components);
            this.Downmv = new System.Windows.Forms.Timer(this.components);
            this.mvbullets = new System.Windows.Forms.Timer(this.components);
            this.mvEnemies = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // mvTim
            // 
            this.mvTim.Enabled = true;
            this.mvTim.Interval = 10;
            this.mvTim.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainPlayer
            // 
            this.mainPlayer.BackColor = System.Drawing.Color.DimGray;
            this.mainPlayer.Image = global::_232323.Properties.Resources.Снимок_экрана_2022_04_03_094324;
            this.mainPlayer.Location = new System.Drawing.Point(74, 554);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.Size = new System.Drawing.Size(98, 99);
            this.mainPlayer.TabIndex = 0;
            this.mainPlayer.TabStop = false;
            this.mainPlayer.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.mainplayer_PreviewKeyDown);
            // 
            // leftmv
            // 
            this.leftmv.Interval = 10;
            this.leftmv.Tick += new System.EventHandler(this.leftmv_Tick);
            // 
            // rightmv
            // 
            this.rightmv.Interval = 10;
            this.rightmv.Tick += new System.EventHandler(this.rightmv_Tick);
            // 
            // upmv
            // 
            this.upmv.Interval = 10;
            this.upmv.Tick += new System.EventHandler(this.upmv_Tick);
            // 
            // Downmv
            // 
            this.Downmv.Interval = 10;
            this.Downmv.Tick += new System.EventHandler(this.Downmv_Tick);
            // 
            // mvbullets
            // 
            this.mvbullets.Enabled = true;
            this.mvbullets.Interval = 10;
            this.mvbullets.Tick += new System.EventHandler(this.mvbullet);
            // 
            // mvEnemies
            // 
            this.mvEnemies.Enabled = true;
            this.mvEnemies.Interval = 10;
            this.mvEnemies.Tick += new System.EventHandler(this.mvEnemies_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("NSimSun", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(508, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("NSimSun", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(989, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("NSimSun", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(989, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Level;";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("NSimSun", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(1165, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(55, 37);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "00";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("NSimSun", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.Color.White;
            this.labelLevel.Location = new System.Drawing.Point(1165, 64);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(55, 37);
            this.labelLevel.TabIndex = 6;
            this.labelLevel.Text = "01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPlayer);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "game test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void mainplayer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Timer mvTim;
        private System.Windows.Forms.PictureBox mainPlayer;
        private System.Windows.Forms.Timer leftmv;
        private System.Windows.Forms.Timer rightmv;
        private System.Windows.Forms.Timer upmv;
        private System.Windows.Forms.Timer Downmv;
        private Timer mvbullets;
        private Timer mvEnemies;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label labelScore;
        private Label labelLevel;
    }
}

