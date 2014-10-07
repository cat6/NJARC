using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace N_JARC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            // Get the paces and reduce them to seconds per unit.  Don't let the calculation proceed unless all the text boxes are filled.
            double pace_running = 0;
            double pace_walking = 0;
            try
            {
                pace_running = ((System.Convert.ToDouble(textBox_mins_running.Text)) * 60) + (System.Convert.ToDouble(textBox_secs_running.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Data are needed for the running pace time");
                return;
            }
            try
            {
                pace_walking = ((System.Convert.ToDouble(textBox_mins_walking.Text)) * 60) + (System.Convert.ToDouble(textBox_secs_walking.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Data are needed for the walking pace time");
                return;
            }

            double total_distance = 0;
            // Get the total distance from the user's input
            try
            {
                total_distance = (System.Convert.ToDouble(textBox_total_distance.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("You need to enter a total distance");
                return;
            }
            
            // Get the distance units from the user (kms or miles).  units = 0 means km's, units = 1 means miles
            // Default to km
            int distance_units = 0;
            if (radioButton_units_metric.Checked)
            {
                distance_units = 0;
            }
            if (radioButton_units_imperial.Checked)
            {
                distance_units = 1;
            }

            // Get the pace units from the user (kms or miles).  units = 0 means km's, units = 1 means miles
            // Default to km's
            int pace_units = 0;
            if (radioButton_pace_metric.Checked)
            {
                pace_units = 0;
            }
            else
            {
                pace_units = 1;
            }

            bool need_to_convert = false;
            // We only need to convert paces if distance and pace units are different.  Check: are they?
            if (distance_units != pace_units)
            {
                need_to_convert = true;
            }
            if (need_to_convert == true)
            {
                // Do unit conversions here
                if (distance_units == 0) // If distance is km's and pace is miles
                {
                    // convert pace from minutes per mile to seconds per km
                    // 0.6213 * number of seconds reported = pace per km, because it takes less to run a km versus a mile
                    pace_running = (pace_running * 0.621371192);
                    pace_walking = (pace_walking * 0.621371192);
                }
                if (distance_units == 1) // If distance is miles and pace is km's
                {
                    // distance is miles and pace is reported in km's
                    // convert seconds per km to seconds per mile so they'll be commensurate
                    pace_running = pace_running * 1.609344;
                    pace_walking = pace_walking * 1.609344;
                }
            }


            // Get the ratio of running to walking.  Assumes integers only.
            int ratio_running = 0;
            int ratio_walking = 0;
            try
            {
                ratio_running = System.Convert.ToInt32(textbox_ratio_running.Text);
                ratio_walking = System.Convert.ToInt32(textbox_ratio_walking.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("You need to define a ratio for both running and walking");
                return;
            }

            // Now we build a run/walk phase
            double phase_distance_running = (ratio_running * 60) / pace_running;
            double phase_distance_walking = (ratio_walking * 60) / pace_walking;
            double phase_distance_total = phase_distance_running + phase_distance_walking;
            double phase_total_time = (ratio_running + ratio_walking) * 60; // THIS IS IN SECONDS, NOT MINUTES


            // NOW WE LOOP THROUGH THE DISTANCE, ONE PHASE AT A TIME
            int i = 0;  // i captures the number of phases in this particular run
            double remaining_distance = total_distance;
            while (remaining_distance > phase_distance_total)
            {
                remaining_distance = remaining_distance - phase_distance_total;
                i++;
            }
            // Now remaining_distance is either exactly zero or (more likely) some fraction of phase_distance_total
            // Here we determie that exactly and 
            double total_time = 0;
            if (remaining_distance < phase_distance_running)
            {
                // Then the remaining distance will be done entirely at a run and will be simple:  
                // (distance left)/(running pace in secs) = secs to completion
                double last_phase_time = remaining_distance * pace_running;
                total_time = (i * phase_total_time) + last_phase_time;
            }
            else
            {
                // Then we have to do a last phase with both running and walking components
                double distance_left_to_walk = remaining_distance - ((ratio_running * 60) / pace_running);
                double time_in_final_walk = pace_walking * distance_left_to_walk;

                double last_phase_time = (ratio_running * 60) + time_in_final_walk;

                total_time = (i * phase_total_time) + last_phase_time;
            }


            // Parse the Results to be printed
            var total_time_hours = total_time / 60 / 60;

            if (total_time_hours < 1)
            {
                total_time_hours = 0;
            }
            else
            {
                total_time_hours = Math.Floor(total_time_hours);
            }
           
            var total_time_minutes = Math.Floor(    (total_time - (total_time_hours * 60 * 60)) /60    );
            var total_time_seconds = (total_time - (total_time_hours * 60 * 60)  - (total_time_minutes * 60));
            var total_time_minutes_output = total_time_minutes.ToString();
            var total_time_seconds_output = Math.Round(total_time_seconds, 2).ToString();

            // Add an extra zero in front of minutes if it's a single digit number so it doesn't look weird
            if ((total_time_minutes.ToString().Length) < 2)
            {
                total_time_minutes_output = "0" + total_time_minutes.ToString();
            }         
            // Add an extra zero in front of seconds if it's a single digit number so it doesn't look weird.  
            // Also, rounded it off to 2 decimal places (above)
            if ((Math.Round(total_time_seconds)).ToString().Length < 2)
            {
                total_time_seconds_output = "0" + total_time_seconds_output;
            }
            
            // Output the time to label_total_time
            label_total_time.Text = total_time_hours.ToString() + " : " + total_time_minutes_output + " : " + total_time_seconds_output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Now we need ToolTips in case people don't know that they should do stuff like enter their total distance in the box marked "total distance".
            // (Why do we even let people like that use computers, anyway?)
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.textBox_total_distance, "Total Distance in Your Race");
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.textbox_ratio_running, "This is the number of minutes (whole numbers only) that you will spend running at a time");
            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip3.SetToolTip(this.textbox_ratio_walking, "This is the number of minutes (whole numbers only) that you will spend walking at a time");
            System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
            ToolTip4.SetToolTip(this.textBox_mins_running, "Minutes Running");
            System.Windows.Forms.ToolTip ToolTip5 = new System.Windows.Forms.ToolTip();
            ToolTip5.SetToolTip(this.textBox_secs_running, "Seconds Running");
            System.Windows.Forms.ToolTip ToolTip6 = new System.Windows.Forms.ToolTip();
            ToolTip6.SetToolTip(this.textBox_mins_walking, "Minutes Walking");
            System.Windows.Forms.ToolTip ToolTip7 = new System.Windows.Forms.ToolTip();
            ToolTip7.SetToolTip(this.textBox_secs_walking, "Seconds Walking");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Hyperlink to help page here
            System.Diagnostics.Process.Start("http://www.brianneary.net/njarc.html");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label_total_time_Click(object sender, EventArgs e)
        {

        }


    }
}
