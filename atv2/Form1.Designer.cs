
namespace atv2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.award = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 449);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.AccessibleName = "a ";
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(198, 500);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(12, 468);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(475, 29);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score:  0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 102);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pressione a direita para mover o carro.\r\n\r\nNão bata em nenhum carro no jogo e sob" +
    "reviva enquanto puder.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // award
            // 
            this.award.Image = global::atv2.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(140, 175);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(252, 101);
            this.award.TabIndex = 1;
            this.award.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.Image = global::atv2.Properties.Resources.carGrey;
            this.AI2.Location = new System.Drawing.Point(342, 54);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 103);
            this.AI2.TabIndex = 1;
            this.AI2.TabStop = false;
            this.AI2.Tag = "carRight";
            // 
            // explosion
            // 
            this.explosion.Image = global::atv2.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(77, 293);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(69, 68);
            this.explosion.TabIndex = 1;
            this.explosion.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.Image = global::atv2.Properties.Resources.carGreen;
            this.AI1.Location = new System.Drawing.Point(77, 54);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(54, 103);
            this.AI1.TabIndex = 1;
            this.AI1.TabStop = false;
            this.AI1.Tag = "carLeft";
            // 
            // player
            // 
            this.player.Image = global::atv2.Properties.Resources.carOrange;
            this.player.Location = new System.Drawing.Point(219, 347);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(54, 102);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::atv2.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, 519);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(475, 449);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 0;
            this.roadTrack2.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::atv2.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(0, -449);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(475, 449);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 781);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Game de carro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
    }
}

