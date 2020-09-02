namespace Databasegrid
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_mgr = new System.Windows.Forms.ComboBox();
            this.cmb_deptno = new System.Windows.Forms.ComboBox();
            this.txt_jdate = new System.Windows.Forms.TextBox();
            this.txt_sal = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_Empno = new System.Windows.Forms.TextBox();
            this.lbl_mgr = new System.Windows.Forms.Label();
            this.lbl_jdate = new System.Windows.Forms.Label();
            this.lbl_deptno = new System.Windows.Forms.Label();
            this.lbl_sal = new System.Windows.Forms.Label();
            this.lbl_Ename = new System.Windows.Forms.Label();
            this.lbl_Empno = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_mgr);
            this.panel1.Controls.Add(this.cmb_deptno);
            this.panel1.Controls.Add(this.txt_jdate);
            this.panel1.Controls.Add(this.txt_sal);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.txt_Empno);
            this.panel1.Controls.Add(this.lbl_mgr);
            this.panel1.Controls.Add(this.lbl_jdate);
            this.panel1.Controls.Add(this.lbl_deptno);
            this.panel1.Controls.Add(this.lbl_sal);
            this.panel1.Controls.Add(this.lbl_Ename);
            this.panel1.Controls.Add(this.lbl_Empno);
            this.panel1.Location = new System.Drawing.Point(60, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 258);
            this.panel1.TabIndex = 0;
            // 
            // cmb_mgr
            // 
            this.cmb_mgr.FormattingEnabled = true;
            this.cmb_mgr.Location = new System.Drawing.Point(135, 217);
            this.cmb_mgr.Name = "cmb_mgr";
            this.cmb_mgr.Size = new System.Drawing.Size(155, 21);
            this.cmb_mgr.TabIndex = 11;
            // 
            // cmb_deptno
            // 
            this.cmb_deptno.FormattingEnabled = true;
            this.cmb_deptno.Location = new System.Drawing.Point(135, 134);
            this.cmb_deptno.Name = "cmb_deptno";
            this.cmb_deptno.Size = new System.Drawing.Size(155, 21);
            this.cmb_deptno.TabIndex = 10;
            // 
            // txt_jdate
            // 
            this.txt_jdate.Location = new System.Drawing.Point(135, 176);
            this.txt_jdate.Name = "txt_jdate";
            this.txt_jdate.Size = new System.Drawing.Size(155, 20);
            this.txt_jdate.TabIndex = 9;
            // 
            // txt_sal
            // 
            this.txt_sal.Location = new System.Drawing.Point(135, 100);
            this.txt_sal.Name = "txt_sal";
            this.txt_sal.Size = new System.Drawing.Size(155, 20);
            this.txt_sal.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(135, 62);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(155, 20);
            this.txt_name.TabIndex = 7;
            // 
            // txt_Empno
            // 
            this.txt_Empno.Location = new System.Drawing.Point(135, 28);
            this.txt_Empno.Name = "txt_Empno";
            this.txt_Empno.Size = new System.Drawing.Size(155, 20);
            this.txt_Empno.TabIndex = 6;
            // 
            // lbl_mgr
            // 
            this.lbl_mgr.AutoSize = true;
            this.lbl_mgr.Location = new System.Drawing.Point(24, 226);
            this.lbl_mgr.Name = "lbl_mgr";
            this.lbl_mgr.Size = new System.Drawing.Size(49, 13);
            this.lbl_mgr.TabIndex = 5;
            this.lbl_mgr.Text = "Manager";
            // 
            // lbl_jdate
            // 
            this.lbl_jdate.AutoSize = true;
            this.lbl_jdate.Location = new System.Drawing.Point(24, 184);
            this.lbl_jdate.Name = "lbl_jdate";
            this.lbl_jdate.Size = new System.Drawing.Size(52, 13);
            this.lbl_jdate.TabIndex = 4;
            this.lbl_jdate.Text = "Join Date";
            // 
            // lbl_deptno
            // 
            this.lbl_deptno.AutoSize = true;
            this.lbl_deptno.Location = new System.Drawing.Point(24, 143);
            this.lbl_deptno.Name = "lbl_deptno";
            this.lbl_deptno.Size = new System.Drawing.Size(50, 13);
            this.lbl_deptno.TabIndex = 3;
            this.lbl_deptno.Text = "Dept No:";
            // 
            // lbl_sal
            // 
            this.lbl_sal.AutoSize = true;
            this.lbl_sal.Location = new System.Drawing.Point(24, 107);
            this.lbl_sal.Name = "lbl_sal";
            this.lbl_sal.Size = new System.Drawing.Size(36, 13);
            this.lbl_sal.TabIndex = 2;
            this.lbl_sal.Text = "Salary";
            // 
            // lbl_Ename
            // 
            this.lbl_Ename.AutoSize = true;
            this.lbl_Ename.Location = new System.Drawing.Point(24, 65);
            this.lbl_Ename.Name = "lbl_Ename";
            this.lbl_Ename.Size = new System.Drawing.Size(35, 13);
            this.lbl_Ename.TabIndex = 1;
            this.lbl_Ename.Text = "Name";
            // 
            // lbl_Empno
            // 
            this.lbl_Empno.AutoSize = true;
            this.lbl_Empno.Location = new System.Drawing.Point(24, 28);
            this.lbl_Empno.Name = "lbl_Empno";
            this.lbl_Empno.Size = new System.Drawing.Size(48, 13);
            this.lbl_Empno.TabIndex = 0;
            this.lbl_Empno.Text = "Emp No:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_next);
            this.panel2.Controls.Add(this.btn_prev);
            this.panel2.Controls.Add(this.btn_last);
            this.panel2.Controls.Add(this.btn_first);
            this.panel2.Location = new System.Drawing.Point(460, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 258);
            this.panel2.TabIndex = 1;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_next.Location = new System.Drawing.Point(61, 197);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "NEXT";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_prev.Location = new System.Drawing.Point(61, 138);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_prev.TabIndex = 2;
            this.btn_prev.Text = "PREV";
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_last
            // 
            this.btn_last.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_last.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_last.Location = new System.Drawing.Point(61, 84);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(75, 23);
            this.btn_last.TabIndex = 1;
            this.btn_last.Text = "LAST";
            this.btn_last.UseVisualStyleBackColor = false;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_first.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_first.Location = new System.Drawing.Point(61, 28);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(75, 23);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "FIRST";
            this.btn_first.UseVisualStyleBackColor = false;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(87, 287);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD NEW";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(237, 287);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Location = new System.Drawing.Point(397, 287);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(543, 287);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 183);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(750, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_mgr;
        private System.Windows.Forms.ComboBox cmb_deptno;
        private System.Windows.Forms.TextBox txt_jdate;
        private System.Windows.Forms.TextBox txt_sal;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_Empno;
        private System.Windows.Forms.Label lbl_mgr;
        private System.Windows.Forms.Label lbl_jdate;
        private System.Windows.Forms.Label lbl_deptno;
        private System.Windows.Forms.Label lbl_sal;
        private System.Windows.Forms.Label lbl_Ename;
        private System.Windows.Forms.Label lbl_Empno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

