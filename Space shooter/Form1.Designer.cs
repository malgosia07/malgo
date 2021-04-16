
namespace Space_shooter
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Move_timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxhero_player = new System.Windows.Forms.PictureBox();
            this.timer_prawo = new System.Windows.Forms.Timer(this.components);
            this.timer_lewo = new System.Windows.Forms.Timer(this.components);
            this.timer_wGore = new System.Windows.Forms.Timer(this.components);
            this.timer_wDol = new System.Windows.Forms.Timer(this.components);
            this.timerPocisk = new System.Windows.Forms.Timer(this.components);
            this.timerPrzeciwnik = new System.Windows.Forms.Timer(this.components);
            this.timerPrzeciwnik_Pocisk = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.btn_powtorz = new System.Windows.Forms.Button();
            this.btn_zakoncz = new System.Windows.Forms.Button();
            this.label_poziom = new System.Windows.Forms.Label();
            this.label_punkty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhero_player)).BeginInit();
            this.SuspendLayout();
            // 
            // Move_timer
            // 
            this.Move_timer.Enabled = true;
            this.Move_timer.Interval = 10;
            this.Move_timer.Tick += new System.EventHandler(this.Move_timer_Tick);
            // 
            // pictureBoxhero_player
            // 
            this.pictureBoxhero_player.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxhero_player.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxhero_player.Image")));
            this.pictureBoxhero_player.Location = new System.Drawing.Point(255, 490);
            this.pictureBoxhero_player.Name = "pictureBoxhero_player";
            this.pictureBoxhero_player.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxhero_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxhero_player.TabIndex = 0;
            this.pictureBoxhero_player.TabStop = false;
            this.pictureBoxhero_player.Click += new System.EventHandler(this.pictureBoxhero_player_Click);
            // 
            // timer_prawo
            // 
            this.timer_prawo.Interval = 5;
            this.timer_prawo.Tick += new System.EventHandler(this.timer_prawo_Tick);
            // 
            // timer_lewo
            // 
            this.timer_lewo.Interval = 5;
            this.timer_lewo.Tick += new System.EventHandler(this.timer_lewo_Tick);
            // 
            // timer_wGore
            // 
            this.timer_wGore.Interval = 5;
            this.timer_wGore.Tick += new System.EventHandler(this.timer_wGore_Tick);
            // 
            // timer_wDol
            // 
            this.timer_wDol.Interval = 5;
            this.timer_wDol.Tick += new System.EventHandler(this.timer_wDol_Tick);
            // 
            // timerPocisk
            // 
            this.timerPocisk.Enabled = true;
            this.timerPocisk.Interval = 25;
            this.timerPocisk.Tick += new System.EventHandler(this.timerPocisk_Tick);
            // 
            // timerPrzeciwnik
            // 
            this.timerPrzeciwnik.Enabled = true;
            this.timerPrzeciwnik.Tick += new System.EventHandler(this.timerPrzeciwnik_Tick);
            // 
            // timerPrzeciwnik_Pocisk
            // 
            this.timerPrzeciwnik_Pocisk.Enabled = true;
            this.timerPrzeciwnik_Pocisk.Interval = 20;
            this.timerPrzeciwnik_Pocisk.Tick += new System.EventHandler(this.timerPrzeciwnik_Pocisk_Tick);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(168, 212);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(264, 84);
            this.label.TabIndex = 1;
            this.label.Text = "Koniec gry";
            this.label.Visible = false;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // btn_powtorz
            // 
            this.btn_powtorz.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_powtorz.Font = new System.Drawing.Font("Arial Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_powtorz.Location = new System.Drawing.Point(59, 299);
            this.btn_powtorz.Name = "btn_powtorz";
            this.btn_powtorz.Size = new System.Drawing.Size(221, 42);
            this.btn_powtorz.TabIndex = 2;
            this.btn_powtorz.Text = "Powtórz";
            this.btn_powtorz.UseVisualStyleBackColor = false;
            this.btn_powtorz.Visible = false;
            this.btn_powtorz.Click += new System.EventHandler(this.btn_powtorz_Click);
            // 
            // btn_zakoncz
            // 
            this.btn_zakoncz.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_zakoncz.Font = new System.Drawing.Font("Arial Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_zakoncz.Location = new System.Drawing.Point(286, 300);
            this.btn_zakoncz.Name = "btn_zakoncz";
            this.btn_zakoncz.Size = new System.Drawing.Size(221, 41);
            this.btn_zakoncz.TabIndex = 3;
            this.btn_zakoncz.Text = "Zakończ";
            this.btn_zakoncz.UseVisualStyleBackColor = false;
            this.btn_zakoncz.Visible = false;
            this.btn_zakoncz.Click += new System.EventHandler(this.btn_zakoncz_Click);
            // 
            // label_poziom
            // 
            this.label_poziom.AutoSize = true;
            this.label_poziom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_poziom.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_poziom.Location = new System.Drawing.Point(540, 9);
            this.label_poziom.Name = "label_poziom";
            this.label_poziom.Size = new System.Drawing.Size(30, 24);
            this.label_poziom.TabIndex = 4;
            this.label_poziom.Text = "01";
            // 
            // label_punkty
            // 
            this.label_punkty.AutoSize = true;
            this.label_punkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_punkty.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_punkty.Location = new System.Drawing.Point(92, 9);
            this.label_punkty.Name = "label_punkty";
            this.label_punkty.Size = new System.Drawing.Size(30, 24);
            this.label_punkty.TabIndex = 5;
            this.label_punkty.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Punkty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(461, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pozim:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_punkty);
            this.Controls.Add(this.label_poziom);
            this.Controls.Add(this.btn_zakoncz);
            this.Controls.Add(this.btn_powtorz);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBoxhero_player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.Text = "Space shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhero_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Move_timer;
        private System.Windows.Forms.PictureBox pictureBoxhero_player;
        private System.Windows.Forms.Timer timer_prawo;
        private System.Windows.Forms.Timer timer_lewo;
        private System.Windows.Forms.Timer timer_wGore;
        private System.Windows.Forms.Timer timer_wDol;
        private System.Windows.Forms.Timer timerPocisk;
        private System.Windows.Forms.Timer timerPrzeciwnik;
        private System.Windows.Forms.Timer timerPrzeciwnik_Pocisk;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_powtorz;
        private System.Windows.Forms.Button btn_zakoncz;
        private System.Windows.Forms.Label label_poziom;
        private System.Windows.Forms.Label label_punkty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

