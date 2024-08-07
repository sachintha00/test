﻿namespace HotelCalipso
{
    partial class frmAdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnTravel = new Guna.UI2.WinForms.Guna2Button();
            this.btnFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnRooms = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.pnlChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnReport);
            this.guna2Panel1.Controls.Add(this.btnTravel);
            this.guna2Panel1.Controls.Add(this.btnFood);
            this.guna2Panel1.Controls.Add(this.btnRooms);
            this.guna2Panel1.Controls.Add(this.btnRegister);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(351, 797);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.CheckedState.Parent = this.btnReport;
            this.btnReport.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.CustomImages.Image")));
            this.btnReport.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReport.CustomImages.Parent = this.btnReport;
            this.btnReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(36)))), ((int)(((byte)(83)))));
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(20)))));
            this.btnReport.HoverState.Parent = this.btnReport;
            this.btnReport.Location = new System.Drawing.Point(63, 586);
            this.btnReport.Name = "btnReport";
            this.btnReport.ShadowDecoration.Parent = this.btnReport;
            this.btnReport.Size = new System.Drawing.Size(234, 57);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "REPORTS";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnTravel
            // 
            this.btnTravel.CheckedState.Parent = this.btnTravel;
            this.btnTravel.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("btnTravel.CustomImages.Image")));
            this.btnTravel.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTravel.CustomImages.Parent = this.btnTravel;
            this.btnTravel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(36)))), ((int)(((byte)(83)))));
            this.btnTravel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTravel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(20)))));
            this.btnTravel.HoverState.Parent = this.btnTravel;
            this.btnTravel.Location = new System.Drawing.Point(63, 507);
            this.btnTravel.Name = "btnTravel";
            this.btnTravel.ShadowDecoration.Parent = this.btnTravel;
            this.btnTravel.Size = new System.Drawing.Size(234, 57);
            this.btnTravel.TabIndex = 0;
            this.btnTravel.Text = "TRAVEL PACKAGE";
            this.btnTravel.Click += new System.EventHandler(this.btnTravel_Click);
            // 
            // btnFood
            // 
            this.btnFood.CheckedState.Parent = this.btnFood;
            this.btnFood.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("btnFood.CustomImages.Image")));
            this.btnFood.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFood.CustomImages.Parent = this.btnFood;
            this.btnFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(36)))), ((int)(((byte)(83)))));
            this.btnFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(20)))));
            this.btnFood.HoverState.Parent = this.btnFood;
            this.btnFood.Location = new System.Drawing.Point(63, 428);
            this.btnFood.Name = "btnFood";
            this.btnFood.ShadowDecoration.Parent = this.btnFood;
            this.btnFood.Size = new System.Drawing.Size(234, 57);
            this.btnFood.TabIndex = 0;
            this.btnFood.Text = "FOODS";
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.CheckedState.Parent = this.btnRooms;
            this.btnRooms.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("btnRooms.CustomImages.Image")));
            this.btnRooms.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRooms.CustomImages.Parent = this.btnRooms;
            this.btnRooms.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(36)))), ((int)(((byte)(83)))));
            this.btnRooms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(20)))));
            this.btnRooms.HoverState.Parent = this.btnRooms;
            this.btnRooms.Location = new System.Drawing.Point(63, 349);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.ShadowDecoration.Parent = this.btnRooms;
            this.btnRooms.Size = new System.Drawing.Size(234, 57);
            this.btnRooms.TabIndex = 0;
            this.btnRooms.Text = "ROOMS";
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.CheckedState.Parent = this.btnRegister;
            this.btnRegister.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.CustomImages.Image")));
            this.btnRegister.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRegister.CustomImages.Parent = this.btnRegister;
            this.btnRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(36)))), ((int)(((byte)(83)))));
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(20)))));
            this.btnRegister.HoverState.Parent = this.btnRegister;
            this.btnRegister.Location = new System.Drawing.Point(63, 270);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.ShadowDecoration.Parent = this.btnRegister;
            this.btnRegister.Size = new System.Drawing.Size(234, 57);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "REGISTRATION";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChildForm.Location = new System.Drawing.Point(357, 50);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.ShadowDecoration.Parent = this.pnlChildForm;
            this.pnlChildForm.Size = new System.Drawing.Size(949, 735);
            this.pnlChildForm.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(36)))), ((int)(((byte)(83)))));
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1230, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(55)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(87, 44);
            this.gunaControlBox1.TabIndex = 3;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // frmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 797);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminMain";
            this.Load += new System.EventHandler(this.frmAdminMain_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlChildForm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnReport;
        private Guna.UI2.WinForms.Guna2Button btnTravel;
        private Guna.UI2.WinForms.Guna2Button btnFood;
        private Guna.UI2.WinForms.Guna2Button btnRooms;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}