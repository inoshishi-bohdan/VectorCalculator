namespace p2022_Koba_B_O_Ind_2._4
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
            this.first_vector_textBox = new System.Windows.Forms.TextBox();
            this.second_vector_textBox = new System.Windows.Forms.TextBox();
            this.vec1_label = new System.Windows.Forms.Label();
            this.vec2_label = new System.Windows.Forms.Label();
            this.add_radioButton = new System.Windows.Forms.RadioButton();
            this.diff_radioButton = new System.Windows.Forms.RadioButton();
            this.scalar_radioButton = new System.Windows.Forms.RadioButton();
            this.cons_mult_vec1_radioButton = new System.Windows.Forms.RadioButton();
            this.vectors_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.first_vecbutton = new System.Windows.Forms.Button();
            this.sec_vecbutton = new System.Windows.Forms.Button();
            this.const_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.const_mult_sec_vec_radioButton = new System.Windows.Forms.RadioButton();
            this.show_vec1_radioButton = new System.Windows.Forms.RadioButton();
            this.show_vec2_radioButton = new System.Windows.Forms.RadioButton();
            this.set_by_index_vec1_radioButton = new System.Windows.Forms.RadioButton();
            this.set_by_index_vec2_radioButton = new System.Windows.Forms.RadioButton();
            this.get_by_index_vec1_radioButton = new System.Windows.Forms.RadioButton();
            this.get_by_index_vec2_radioButton = new System.Windows.Forms.RadioButton();
            this.index_textBox = new System.Windows.Forms.TextBox();
            this.index_label = new System.Windows.Forms.Label();
            this.value_textBox = new System.Windows.Forms.TextBox();
            this.value_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // first_vector_textBox
            // 
            this.first_vector_textBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.first_vector_textBox.Location = new System.Drawing.Point(303, 73);
            this.first_vector_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.first_vector_textBox.MinimumSize = new System.Drawing.Size(228, 40);
            this.first_vector_textBox.Name = "first_vector_textBox";
            this.first_vector_textBox.Size = new System.Drawing.Size(228, 39);
            this.first_vector_textBox.TabIndex = 0;
            // 
            // second_vector_textBox
            // 
            this.second_vector_textBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.second_vector_textBox.Location = new System.Drawing.Point(303, 148);
            this.second_vector_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.second_vector_textBox.MinimumSize = new System.Drawing.Size(228, 40);
            this.second_vector_textBox.Name = "second_vector_textBox";
            this.second_vector_textBox.Size = new System.Drawing.Size(228, 39);
            this.second_vector_textBox.TabIndex = 1;
            // 
            // vec1_label
            // 
            this.vec1_label.AutoSize = true;
            this.vec1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vec1_label.Location = new System.Drawing.Point(105, 82);
            this.vec1_label.Name = "vec1_label";
            this.vec1_label.Size = new System.Drawing.Size(154, 31);
            this.vec1_label.TabIndex = 2;
            this.vec1_label.Text = "First Vector";
            // 
            // vec2_label
            // 
            this.vec2_label.AutoSize = true;
            this.vec2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vec2_label.Location = new System.Drawing.Point(105, 157);
            this.vec2_label.Name = "vec2_label";
            this.vec2_label.Size = new System.Drawing.Size(192, 31);
            this.vec2_label.TabIndex = 3;
            this.vec2_label.Text = "Second Vector";
            // 
            // add_radioButton
            // 
            this.add_radioButton.AutoSize = true;
            this.add_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_radioButton.Location = new System.Drawing.Point(234, 245);
            this.add_radioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_radioButton.Name = "add_radioButton";
            this.add_radioButton.Size = new System.Drawing.Size(77, 33);
            this.add_radioButton.TabIndex = 4;
            this.add_radioButton.TabStop = true;
            this.add_radioButton.Text = "Add";
            this.add_radioButton.UseVisualStyleBackColor = true;
            this.add_radioButton.CheckedChanged += new System.EventHandler(this.add_radioButton_CheckedChanged);
            // 
            // diff_radioButton
            // 
            this.diff_radioButton.AutoSize = true;
            this.diff_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diff_radioButton.Location = new System.Drawing.Point(234, 286);
            this.diff_radioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diff_radioButton.Name = "diff_radioButton";
            this.diff_radioButton.Size = new System.Drawing.Size(69, 33);
            this.diff_radioButton.TabIndex = 5;
            this.diff_radioButton.TabStop = true;
            this.diff_radioButton.Text = "Diff";
            this.diff_radioButton.UseVisualStyleBackColor = true;
            this.diff_radioButton.CheckedChanged += new System.EventHandler(this.diff_radioButton_CheckedChanged);
            // 
            // scalar_radioButton
            // 
            this.scalar_radioButton.AutoSize = true;
            this.scalar_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scalar_radioButton.Location = new System.Drawing.Point(234, 327);
            this.scalar_radioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scalar_radioButton.Name = "scalar_radioButton";
            this.scalar_radioButton.Size = new System.Drawing.Size(102, 33);
            this.scalar_radioButton.TabIndex = 6;
            this.scalar_radioButton.TabStop = true;
            this.scalar_radioButton.Text = "Scalar";
            this.scalar_radioButton.UseVisualStyleBackColor = true;
            this.scalar_radioButton.CheckedChanged += new System.EventHandler(this.scalar_radioButton_CheckedChanged);
            // 
            // cons_mult_vec1_radioButton
            // 
            this.cons_mult_vec1_radioButton.AutoSize = true;
            this.cons_mult_vec1_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cons_mult_vec1_radioButton.Location = new System.Drawing.Point(342, 246);
            this.cons_mult_vec1_radioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cons_mult_vec1_radioButton.Name = "cons_mult_vec1_radioButton";
            this.cons_mult_vec1_radioButton.Size = new System.Drawing.Size(284, 33);
            this.cons_mult_vec1_radioButton.TabIndex = 7;
            this.cons_mult_vec1_radioButton.TabStop = true;
            this.cons_mult_vec1_radioButton.Text = "Const Multiply First Vec";
            this.cons_mult_vec1_radioButton.UseVisualStyleBackColor = true;
            this.cons_mult_vec1_radioButton.CheckedChanged += new System.EventHandler(this.cons_mult_vec1_radioButton_CheckedChanged);
            // 
            // vectors_label
            // 
            this.vectors_label.AutoSize = true;
            this.vectors_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vectors_label.Location = new System.Drawing.Point(302, 12);
            this.vectors_label.Name = "vectors_label";
            this.vectors_label.Size = new System.Drawing.Size(132, 39);
            this.vectors_label.TabIndex = 8;
            this.vectors_label.Text = "Vectors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(302, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Actions";
            // 
            // result_textBox
            // 
            this.result_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_textBox.Location = new System.Drawing.Point(241, 404);
            this.result_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.result_textBox.MinimumSize = new System.Drawing.Size(342, 50);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.Size = new System.Drawing.Size(342, 49);
            this.result_textBox.TabIndex = 10;
            this.result_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // first_vecbutton
            // 
            this.first_vecbutton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.first_vecbutton.Location = new System.Drawing.Point(563, 73);
            this.first_vecbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.first_vecbutton.Name = "first_vecbutton";
            this.first_vecbutton.Size = new System.Drawing.Size(99, 40);
            this.first_vecbutton.TabIndex = 11;
            this.first_vecbutton.Text = "submit";
            this.first_vecbutton.UseVisualStyleBackColor = true;
            this.first_vecbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.first_vecbutton_MouseClick);
            // 
            // sec_vecbutton
            // 
            this.sec_vecbutton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sec_vecbutton.Location = new System.Drawing.Point(563, 148);
            this.sec_vecbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sec_vecbutton.Name = "sec_vecbutton";
            this.sec_vecbutton.Size = new System.Drawing.Size(99, 40);
            this.sec_vecbutton.TabIndex = 12;
            this.sec_vecbutton.Text = "submit";
            this.sec_vecbutton.UseVisualStyleBackColor = true;
            this.sec_vecbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sec_vecbutton_MouseClick);
            // 
            // const_textBox
            // 
            this.const_textBox.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.const_textBox.Location = new System.Drawing.Point(613, 404);
            this.const_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.const_textBox.MinimumSize = new System.Drawing.Size(49, 50);
            this.const_textBox.Name = "const_textBox";
            this.const_textBox.Size = new System.Drawing.Size(49, 45);
            this.const_textBox.TabIndex = 13;
            this.const_textBox.TextChanged += new System.EventHandler(this.const_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(585, 465);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "CONST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(368, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "RESULT";
            // 
            // const_mult_sec_vec_radioButton
            // 
            this.const_mult_sec_vec_radioButton.AutoSize = true;
            this.const_mult_sec_vec_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.const_mult_sec_vec_radioButton.Location = new System.Drawing.Point(342, 286);
            this.const_mult_sec_vec_radioButton.Name = "const_mult_sec_vec_radioButton";
            this.const_mult_sec_vec_radioButton.Size = new System.Drawing.Size(320, 33);
            this.const_mult_sec_vec_radioButton.TabIndex = 16;
            this.const_mult_sec_vec_radioButton.TabStop = true;
            this.const_mult_sec_vec_radioButton.Text = "Const Multiply Second Vec";
            this.const_mult_sec_vec_radioButton.UseVisualStyleBackColor = true;
            this.const_mult_sec_vec_radioButton.CheckedChanged += new System.EventHandler(this.const_mult_sec_vec_radioButton_CheckedChanged);
            // 
            // show_vec1_radioButton
            // 
            this.show_vec1_radioButton.AutoSize = true;
            this.show_vec1_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.show_vec1_radioButton.Location = new System.Drawing.Point(12, 246);
            this.show_vec1_radioButton.Name = "show_vec1_radioButton";
            this.show_vec1_radioButton.Size = new System.Drawing.Size(151, 33);
            this.show_vec1_radioButton.TabIndex = 17;
            this.show_vec1_radioButton.TabStop = true;
            this.show_vec1_radioButton.Text = "Show vec1";
            this.show_vec1_radioButton.UseVisualStyleBackColor = true;
            this.show_vec1_radioButton.CheckedChanged += new System.EventHandler(this.show_vec1_radioButton_CheckedChanged);
            // 
            // show_vec2_radioButton
            // 
            this.show_vec2_radioButton.AutoSize = true;
            this.show_vec2_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.show_vec2_radioButton.Location = new System.Drawing.Point(12, 286);
            this.show_vec2_radioButton.Name = "show_vec2_radioButton";
            this.show_vec2_radioButton.Size = new System.Drawing.Size(151, 33);
            this.show_vec2_radioButton.TabIndex = 18;
            this.show_vec2_radioButton.TabStop = true;
            this.show_vec2_radioButton.Text = "Show vec2";
            this.show_vec2_radioButton.UseVisualStyleBackColor = true;
            this.show_vec2_radioButton.CheckedChanged += new System.EventHandler(this.show_vec2_radioButton_CheckedChanged);
            // 
            // set_by_index_vec1_radioButton
            // 
            this.set_by_index_vec1_radioButton.AutoSize = true;
            this.set_by_index_vec1_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.set_by_index_vec1_radioButton.Location = new System.Drawing.Point(12, 330);
            this.set_by_index_vec1_radioButton.Name = "set_by_index_vec1_radioButton";
            this.set_by_index_vec1_radioButton.Size = new System.Drawing.Size(221, 33);
            this.set_by_index_vec1_radioButton.TabIndex = 19;
            this.set_by_index_vec1_radioButton.TabStop = true;
            this.set_by_index_vec1_radioButton.Text = "Set by index vec1";
            this.set_by_index_vec1_radioButton.UseVisualStyleBackColor = true;
            this.set_by_index_vec1_radioButton.CheckedChanged += new System.EventHandler(this.set_by_index_vec1_radioButton_CheckedChanged);
            // 
            // set_by_index_vec2_radioButton
            // 
            this.set_by_index_vec2_radioButton.AutoSize = true;
            this.set_by_index_vec2_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.set_by_index_vec2_radioButton.Location = new System.Drawing.Point(12, 373);
            this.set_by_index_vec2_radioButton.Name = "set_by_index_vec2_radioButton";
            this.set_by_index_vec2_radioButton.Size = new System.Drawing.Size(221, 33);
            this.set_by_index_vec2_radioButton.TabIndex = 20;
            this.set_by_index_vec2_radioButton.TabStop = true;
            this.set_by_index_vec2_radioButton.Text = "Set by index vec2";
            this.set_by_index_vec2_radioButton.UseVisualStyleBackColor = true;
            this.set_by_index_vec2_radioButton.CheckedChanged += new System.EventHandler(this.set_by_index_vec2_radioButton_CheckedChanged);
            // 
            // get_by_index_vec1_radioButton
            // 
            this.get_by_index_vec1_radioButton.AutoSize = true;
            this.get_by_index_vec1_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.get_by_index_vec1_radioButton.Location = new System.Drawing.Point(12, 415);
            this.get_by_index_vec1_radioButton.Name = "get_by_index_vec1_radioButton";
            this.get_by_index_vec1_radioButton.Size = new System.Drawing.Size(223, 33);
            this.get_by_index_vec1_radioButton.TabIndex = 21;
            this.get_by_index_vec1_radioButton.TabStop = true;
            this.get_by_index_vec1_radioButton.Text = "Get by index vec1";
            this.get_by_index_vec1_radioButton.UseVisualStyleBackColor = true;
            this.get_by_index_vec1_radioButton.CheckedChanged += new System.EventHandler(this.get_by_index_vec1_radioButton_CheckedChanged);
            // 
            // get_by_index_vec2_radioButton
            // 
            this.get_by_index_vec2_radioButton.AutoSize = true;
            this.get_by_index_vec2_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.get_by_index_vec2_radioButton.Location = new System.Drawing.Point(12, 456);
            this.get_by_index_vec2_radioButton.Name = "get_by_index_vec2_radioButton";
            this.get_by_index_vec2_radioButton.Size = new System.Drawing.Size(223, 33);
            this.get_by_index_vec2_radioButton.TabIndex = 22;
            this.get_by_index_vec2_radioButton.TabStop = true;
            this.get_by_index_vec2_radioButton.Text = "Get by index vec2";
            this.get_by_index_vec2_radioButton.UseVisualStyleBackColor = true;
            this.get_by_index_vec2_radioButton.CheckedChanged += new System.EventHandler(this.get_by_index_vec2_radioButton_CheckedChanged);
            // 
            // index_textBox
            // 
            this.index_textBox.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.index_textBox.Location = new System.Drawing.Point(613, 342);
            this.index_textBox.Name = "index_textBox";
            this.index_textBox.Size = new System.Drawing.Size(49, 45);
            this.index_textBox.TabIndex = 23;
            this.index_textBox.TextChanged += new System.EventHandler(this.index_textBox_TextChanged);
            // 
            // index_label
            // 
            this.index_label.AutoSize = true;
            this.index_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.index_label.Location = new System.Drawing.Point(511, 358);
            this.index_label.Name = "index_label";
            this.index_label.Size = new System.Drawing.Size(87, 29);
            this.index_label.TabIndex = 24;
            this.index_label.Text = "INDEX";
            // 
            // value_textBox
            // 
            this.value_textBox.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_textBox.Location = new System.Drawing.Point(427, 342);
            this.value_textBox.MinimumSize = new System.Drawing.Size(4, 50);
            this.value_textBox.Name = "value_textBox";
            this.value_textBox.Size = new System.Drawing.Size(49, 45);
            this.value_textBox.TabIndex = 25;
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_label.Location = new System.Drawing.Point(316, 358);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(89, 29);
            this.value_label.TabIndex = 26;
            this.value_label.Text = "VALUE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 503);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.value_textBox);
            this.Controls.Add(this.index_label);
            this.Controls.Add(this.index_textBox);
            this.Controls.Add(this.get_by_index_vec2_radioButton);
            this.Controls.Add(this.get_by_index_vec1_radioButton);
            this.Controls.Add(this.set_by_index_vec2_radioButton);
            this.Controls.Add(this.set_by_index_vec1_radioButton);
            this.Controls.Add(this.show_vec2_radioButton);
            this.Controls.Add(this.show_vec1_radioButton);
            this.Controls.Add(this.const_mult_sec_vec_radioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.const_textBox);
            this.Controls.Add(this.sec_vecbutton);
            this.Controls.Add(this.first_vecbutton);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vectors_label);
            this.Controls.Add(this.cons_mult_vec1_radioButton);
            this.Controls.Add(this.scalar_radioButton);
            this.Controls.Add(this.diff_radioButton);
            this.Controls.Add(this.add_radioButton);
            this.Controls.Add(this.vec2_label);
            this.Controls.Add(this.vec1_label);
            this.Controls.Add(this.second_vector_textBox);
            this.Controls.Add(this.first_vector_textBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_vector_textBox;
        private System.Windows.Forms.TextBox second_vector_textBox;
        private System.Windows.Forms.Label vec1_label;
        private System.Windows.Forms.Label vec2_label;
        private System.Windows.Forms.RadioButton add_radioButton;
        private System.Windows.Forms.RadioButton diff_radioButton;
        private System.Windows.Forms.RadioButton scalar_radioButton;
        private System.Windows.Forms.RadioButton cons_mult_vec1_radioButton;
        private System.Windows.Forms.Label vectors_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Button first_vecbutton;
        private System.Windows.Forms.Button sec_vecbutton;
        private System.Windows.Forms.TextBox const_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton const_mult_sec_vec_radioButton;
        private System.Windows.Forms.RadioButton show_vec1_radioButton;
        private System.Windows.Forms.RadioButton show_vec2_radioButton;
        private System.Windows.Forms.RadioButton set_by_index_vec1_radioButton;
        private System.Windows.Forms.RadioButton set_by_index_vec2_radioButton;
        private System.Windows.Forms.RadioButton get_by_index_vec1_radioButton;
        private System.Windows.Forms.RadioButton get_by_index_vec2_radioButton;
        private System.Windows.Forms.TextBox index_textBox;
        private System.Windows.Forms.Label index_label;
        private System.Windows.Forms.TextBox value_textBox;
        private System.Windows.Forms.Label value_label;
    }
}
