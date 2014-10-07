namespace N_JARC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_calculate = new System.Windows.Forms.Button();
            this.textBox_total_distance = new System.Windows.Forms.TextBox();
            this.label_distance = new System.Windows.Forms.Label();
            this.radioButton_units_metric = new System.Windows.Forms.RadioButton();
            this.radioButton_units_imperial = new System.Windows.Forms.RadioButton();
            this.groupBox_distance_units = new System.Windows.Forms.GroupBox();
            this.textBox_mins_running = new System.Windows.Forms.TextBox();
            this.textBox_mins_walking = new System.Windows.Forms.TextBox();
            this.label_pace_running = new System.Windows.Forms.Label();
            this.label_pace_walking = new System.Windows.Forms.Label();
            this.textBox_secs_running = new System.Windows.Forms.TextBox();
            this.textBox_secs_walking = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_total_time = new System.Windows.Forms.Label();
            this.textbox_ratio_running = new System.Windows.Forms.TextBox();
            this.textbox_ratio_walking = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_pace_units = new System.Windows.Forms.GroupBox();
            this.radioButton_pace_imperial = new System.Windows.Forms.RadioButton();
            this.radioButton_pace_metric = new System.Windows.Forms.RadioButton();
            this.groupBox_time = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_distance_units.SuspendLayout();
            this.groupBox_pace_units.SuspendLayout();
            this.groupBox_time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_calculate
            // 
            this.button_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calculate.Location = new System.Drawing.Point(30, 192);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(114, 43);
            this.button_calculate.TabIndex = 12;
            this.button_calculate.Text = "R U N";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // textBox_total_distance
            // 
            this.textBox_total_distance.Location = new System.Drawing.Point(30, 69);
            this.textBox_total_distance.Name = "textBox_total_distance";
            this.textBox_total_distance.Size = new System.Drawing.Size(59, 20);
            this.textBox_total_distance.TabIndex = 1;
            // 
            // label_distance
            // 
            this.label_distance.AutoSize = true;
            this.label_distance.Location = new System.Drawing.Point(95, 72);
            this.label_distance.Name = "label_distance";
            this.label_distance.Size = new System.Drawing.Size(49, 13);
            this.label_distance.TabIndex = 2;
            this.label_distance.Text = "Distance";
            // 
            // radioButton_units_metric
            // 
            this.radioButton_units_metric.AutoSize = true;
            this.radioButton_units_metric.Checked = true;
            this.radioButton_units_metric.Location = new System.Drawing.Point(6, 19);
            this.radioButton_units_metric.Name = "radioButton_units_metric";
            this.radioButton_units_metric.Size = new System.Drawing.Size(84, 17);
            this.radioButton_units_metric.TabIndex = 8;
            this.radioButton_units_metric.TabStop = true;
            this.radioButton_units_metric.Text = "Metric (KMs)";
            this.radioButton_units_metric.UseVisualStyleBackColor = true;
            // 
            // radioButton_units_imperial
            // 
            this.radioButton_units_imperial.AutoSize = true;
            this.radioButton_units_imperial.Location = new System.Drawing.Point(6, 42);
            this.radioButton_units_imperial.Name = "radioButton_units_imperial";
            this.radioButton_units_imperial.Size = new System.Drawing.Size(81, 17);
            this.radioButton_units_imperial.TabIndex = 9;
            this.radioButton_units_imperial.Text = "Imperial (Mi)";
            this.radioButton_units_imperial.UseVisualStyleBackColor = true;
            // 
            // groupBox_distance_units
            // 
            this.groupBox_distance_units.Controls.Add(this.radioButton_units_imperial);
            this.groupBox_distance_units.Controls.Add(this.radioButton_units_metric);
            this.groupBox_distance_units.Location = new System.Drawing.Point(221, 30);
            this.groupBox_distance_units.Name = "groupBox_distance_units";
            this.groupBox_distance_units.Size = new System.Drawing.Size(95, 68);
            this.groupBox_distance_units.TabIndex = 5;
            this.groupBox_distance_units.TabStop = false;
            this.groupBox_distance_units.Text = "Distance Units";
            // 
            // textBox_mins_running
            // 
            this.textBox_mins_running.Location = new System.Drawing.Point(30, 108);
            this.textBox_mins_running.Name = "textBox_mins_running";
            this.textBox_mins_running.Size = new System.Drawing.Size(31, 20);
            this.textBox_mins_running.TabIndex = 2;
            // 
            // textBox_mins_walking
            // 
            this.textBox_mins_walking.Location = new System.Drawing.Point(30, 146);
            this.textBox_mins_walking.Name = "textBox_mins_walking";
            this.textBox_mins_walking.Size = new System.Drawing.Size(31, 20);
            this.textBox_mins_walking.TabIndex = 4;
            // 
            // label_pace_running
            // 
            this.label_pace_running.AutoSize = true;
            this.label_pace_running.Location = new System.Drawing.Point(136, 111);
            this.label_pace_running.Name = "label_pace_running";
            this.label_pace_running.Size = new System.Drawing.Size(75, 13);
            this.label_pace_running.TabIndex = 8;
            this.label_pace_running.Text = "Pace Running";
            // 
            // label_pace_walking
            // 
            this.label_pace_walking.AutoSize = true;
            this.label_pace_walking.Location = new System.Drawing.Point(136, 146);
            this.label_pace_walking.Name = "label_pace_walking";
            this.label_pace_walking.Size = new System.Drawing.Size(74, 13);
            this.label_pace_walking.TabIndex = 9;
            this.label_pace_walking.Text = "Pace Walking";
            // 
            // textBox_secs_running
            // 
            this.textBox_secs_running.Location = new System.Drawing.Point(78, 108);
            this.textBox_secs_running.Name = "textBox_secs_running";
            this.textBox_secs_running.Size = new System.Drawing.Size(52, 20);
            this.textBox_secs_running.TabIndex = 3;
            // 
            // textBox_secs_walking
            // 
            this.textBox_secs_walking.Location = new System.Drawing.Point(78, 146);
            this.textBox_secs_walking.Name = "textBox_secs_walking";
            this.textBox_secs_walking.Size = new System.Drawing.Size(52, 20);
            this.textBox_secs_walking.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = ":";
            // 
            // label_total_time
            // 
            this.label_total_time.AutoSize = true;
            this.label_total_time.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_time.Location = new System.Drawing.Point(18, 16);
            this.label_total_time.Name = "label_total_time";
            this.label_total_time.Size = new System.Drawing.Size(118, 32);
            this.label_total_time.TabIndex = 16;
            this.label_total_time.Text = "0 : 00 : 00";
            this.label_total_time.Click += new System.EventHandler(this.label_total_time_Click);
            // 
            // textbox_ratio_running
            // 
            this.textbox_ratio_running.Location = new System.Drawing.Point(349, 74);
            this.textbox_ratio_running.Name = "textbox_ratio_running";
            this.textbox_ratio_running.ShortcutsEnabled = false;
            this.textbox_ratio_running.Size = new System.Drawing.Size(49, 20);
            this.textbox_ratio_running.TabIndex = 6;
            this.textbox_ratio_running.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textbox_ratio_walking
            // 
            this.textbox_ratio_walking.Location = new System.Drawing.Point(446, 74);
            this.textbox_ratio_walking.Name = "textbox_ratio_walking";
            this.textbox_ratio_walking.Size = new System.Drawing.Size(49, 20);
            this.textbox_ratio_walking.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ratio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mins Running";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mins Walking";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = ":";
            // 
            // groupBox_pace_units
            // 
            this.groupBox_pace_units.Controls.Add(this.radioButton_pace_imperial);
            this.groupBox_pace_units.Controls.Add(this.radioButton_pace_metric);
            this.groupBox_pace_units.Location = new System.Drawing.Point(221, 104);
            this.groupBox_pace_units.Name = "groupBox_pace_units";
            this.groupBox_pace_units.Size = new System.Drawing.Size(90, 77);
            this.groupBox_pace_units.TabIndex = 23;
            this.groupBox_pace_units.TabStop = false;
            this.groupBox_pace_units.Text = "Pace Units";
            // 
            // radioButton_pace_imperial
            // 
            this.radioButton_pace_imperial.AutoSize = true;
            this.radioButton_pace_imperial.Location = new System.Drawing.Point(7, 46);
            this.radioButton_pace_imperial.Name = "radioButton_pace_imperial";
            this.radioButton_pace_imperial.Size = new System.Drawing.Size(77, 17);
            this.radioButton_pace_imperial.TabIndex = 11;
            this.radioButton_pace_imperial.TabStop = true;
            this.radioButton_pace_imperial.Text = "Mins / Mile";
            this.radioButton_pace_imperial.UseVisualStyleBackColor = true;
            // 
            // radioButton_pace_metric
            // 
            this.radioButton_pace_metric.AutoSize = true;
            this.radioButton_pace_metric.Checked = true;
            this.radioButton_pace_metric.Location = new System.Drawing.Point(6, 23);
            this.radioButton_pace_metric.Name = "radioButton_pace_metric";
            this.radioButton_pace_metric.Size = new System.Drawing.Size(74, 17);
            this.radioButton_pace_metric.TabIndex = 10;
            this.radioButton_pace_metric.TabStop = true;
            this.radioButton_pace_metric.Text = "Mins / KM";
            this.radioButton_pace_metric.UseVisualStyleBackColor = true;
            // 
            // groupBox_time
            // 
            this.groupBox_time.Controls.Add(this.label_total_time);
            this.groupBox_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_time.Location = new System.Drawing.Point(172, 187);
            this.groupBox_time.Name = "groupBox_time";
            this.groupBox_time.Size = new System.Drawing.Size(177, 53);
            this.groupBox_time.TabIndex = 24;
            this.groupBox_time.TabStop = false;
            this.groupBox_time.Text = "Finish Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::N_JARC.Properties.Resources.NJARC_small;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 50);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::N_JARC.Properties.Resources.help_metro;
            this.button1.Location = new System.Drawing.Point(455, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::N_JARC.Properties.Resources.checkered_flag;
            this.pictureBox3.Location = new System.Drawing.Point(306, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::N_JARC.Properties.Resources.ratio2_metro;
            this.pictureBox2.Location = new System.Drawing.Point(465, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "N-JARC 1.01";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "GPLv3 Licensed";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Brian M. Neary";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(178, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 12);
            this.label10.TabIndex = 32;
            this.label10.Text = "Hours      :   Minutes  :    Seconds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 252);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox_pace_units);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_ratio_walking);
            this.Controls.Add(this.textbox_ratio_running);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_secs_walking);
            this.Controls.Add(this.textBox_secs_running);
            this.Controls.Add(this.label_pace_walking);
            this.Controls.Add(this.label_pace_running);
            this.Controls.Add(this.textBox_mins_walking);
            this.Controls.Add(this.textBox_mins_running);
            this.Controls.Add(this.groupBox_distance_units);
            this.Controls.Add(this.label_distance);
            this.Controls.Add(this.textBox_total_distance);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.groupBox_time);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "N-JARC (Not Just Another Running Calculator)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_distance_units.ResumeLayout(false);
            this.groupBox_distance_units.PerformLayout();
            this.groupBox_pace_units.ResumeLayout(false);
            this.groupBox_pace_units.PerformLayout();
            this.groupBox_time.ResumeLayout(false);
            this.groupBox_time.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.TextBox textBox_total_distance;
        private System.Windows.Forms.Label label_distance;
        private System.Windows.Forms.RadioButton radioButton_units_metric;
        private System.Windows.Forms.RadioButton radioButton_units_imperial;
        private System.Windows.Forms.GroupBox groupBox_distance_units;
        private System.Windows.Forms.TextBox textBox_mins_running;
        private System.Windows.Forms.TextBox textBox_mins_walking;
        private System.Windows.Forms.Label label_pace_running;
        private System.Windows.Forms.Label label_pace_walking;
        private System.Windows.Forms.TextBox textBox_secs_running;
        private System.Windows.Forms.TextBox textBox_secs_walking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_total_time;
        private System.Windows.Forms.TextBox textbox_ratio_running;
        private System.Windows.Forms.TextBox textbox_ratio_walking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_pace_units;
        private System.Windows.Forms.RadioButton radioButton_pace_imperial;
        private System.Windows.Forms.RadioButton radioButton_pace_metric;
        private System.Windows.Forms.GroupBox groupBox_time;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

