﻿namespace UserInterface
{
    partial class Order_Home
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
            this.pnl_OrderHome = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.txtb_Requests = new System.Windows.Forms.TextBox();
            this.lbl_OrderView = new System.Windows.Forms.Label();
            this.lbl_TableID = new System.Windows.Forms.Label();
            this.nud_ItemCount = new System.Windows.Forms.NumericUpDown();
            this.liv_CurrentOrder = new System.Windows.Forms.ListView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_AddComment = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Menus = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.pbox_ChapeauLogo = new System.Windows.Forms.PictureBox();
            this.lbl_TableNumber = new System.Windows.Forms.Label();
            this.pnl_OrderHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ItemCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_OrderHome
            // 
            this.pnl_OrderHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_OrderHome.Controls.Add(this.lbl_TableNumber);
            this.pnl_OrderHome.Controls.Add(this.btn_Refresh);
            this.pnl_OrderHome.Controls.Add(this.txtb_Requests);
            this.pnl_OrderHome.Controls.Add(this.lbl_OrderView);
            this.pnl_OrderHome.Controls.Add(this.lbl_TableID);
            this.pnl_OrderHome.Controls.Add(this.nud_ItemCount);
            this.pnl_OrderHome.Controls.Add(this.liv_CurrentOrder);
            this.pnl_OrderHome.Controls.Add(this.btn_Delete);
            this.pnl_OrderHome.Controls.Add(this.btn_AddComment);
            this.pnl_OrderHome.Controls.Add(this.btn_Submit);
            this.pnl_OrderHome.Controls.Add(this.btn_Menus);
            this.pnl_OrderHome.Location = new System.Drawing.Point(62, 90);
            this.pnl_OrderHome.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_OrderHome.Name = "pnl_OrderHome";
            this.pnl_OrderHome.Size = new System.Drawing.Size(900, 650);
            this.pnl_OrderHome.TabIndex = 1;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Lavender;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(720, 56);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(130, 48);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // txtb_Requests
            // 
            this.txtb_Requests.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Requests.Location = new System.Drawing.Point(60, 260);
            this.txtb_Requests.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_Requests.Multiline = true;
            this.txtb_Requests.Name = "txtb_Requests";
            this.txtb_Requests.Size = new System.Drawing.Size(360, 160);
            this.txtb_Requests.TabIndex = 3;
            // 
            // lbl_OrderView
            // 
            this.lbl_OrderView.AutoSize = true;
            this.lbl_OrderView.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderView.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_OrderView.Location = new System.Drawing.Point(292, 1);
            this.lbl_OrderView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrderView.Name = "lbl_OrderView";
            this.lbl_OrderView.Size = new System.Drawing.Size(313, 71);
            this.lbl_OrderView.TabIndex = 10;
            this.lbl_OrderView.Text = "Order View";
            // 
            // lbl_TableID
            // 
            this.lbl_TableID.AutoSize = true;
            this.lbl_TableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TableID.Location = new System.Drawing.Point(56, 117);
            this.lbl_TableID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TableID.Name = "lbl_TableID";
            this.lbl_TableID.Size = new System.Drawing.Size(177, 25);
            this.lbl_TableID.TabIndex = 9;
            this.lbl_TableID.Text = "Selected Table:";
            // 
            // nud_ItemCount
            // 
            this.nud_ItemCount.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_ItemCount.Location = new System.Drawing.Point(320, 466);
            this.nud_ItemCount.Margin = new System.Windows.Forms.Padding(4);
            this.nud_ItemCount.Name = "nud_ItemCount";
            this.nud_ItemCount.Size = new System.Drawing.Size(100, 34);
            this.nud_ItemCount.TabIndex = 5;
            this.nud_ItemCount.ValueChanged += new System.EventHandler(this.nud_ItemCount_ValueChanged);
            // 
            // liv_CurrentOrder
            // 
            this.liv_CurrentOrder.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liv_CurrentOrder.FullRowSelect = true;
            this.liv_CurrentOrder.GridLines = true;
            this.liv_CurrentOrder.HideSelection = false;
            this.liv_CurrentOrder.Location = new System.Drawing.Point(450, 110);
            this.liv_CurrentOrder.Margin = new System.Windows.Forms.Padding(4);
            this.liv_CurrentOrder.Name = "liv_CurrentOrder";
            this.liv_CurrentOrder.Size = new System.Drawing.Size(400, 500);
            this.liv_CurrentOrder.TabIndex = 6;
            this.liv_CurrentOrder.UseCompatibleStateImageBehavior = false;
            this.liv_CurrentOrder.View = System.Windows.Forms.View.Details;
            this.liv_CurrentOrder.SelectedIndexChanged += new System.EventHandler(this.liv_CurrentOrder_SelectedIndexChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Lavender;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_Delete.Location = new System.Drawing.Point(60, 569);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(160, 40);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_AddComment
            // 
            this.btn_AddComment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_AddComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(129)))), ((int)(((byte)(153)))));
            this.btn_AddComment.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddComment.ForeColor = System.Drawing.Color.White;
            this.btn_AddComment.Location = new System.Drawing.Point(60, 456);
            this.btn_AddComment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddComment.Name = "btn_AddComment";
            this.btn_AddComment.Size = new System.Drawing.Size(200, 50);
            this.btn_AddComment.TabIndex = 4;
            this.btn_AddComment.Text = "Save Request";
            this.btn_AddComment.UseVisualStyleBackColor = false;
            this.btn_AddComment.Click += new System.EventHandler(this.btn_AddComment_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(226)))), ((int)(((byte)(133)))));
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_Submit.Location = new System.Drawing.Point(260, 569);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(160, 40);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Menus
            // 
            this.btn_Menus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_Menus.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Menus.Location = new System.Drawing.Point(148, 177);
            this.btn_Menus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Menus.Name = "btn_Menus";
            this.btn_Menus.Size = new System.Drawing.Size(180, 60);
            this.btn_Menus.TabIndex = 2;
            this.btn_Menus.Text = "Menus";
            this.btn_Menus.UseVisualStyleBackColor = false;
            this.btn_Menus.Click += new System.EventHandler(this.btn_Menus_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(226)))), ((int)(((byte)(133)))));
            this.btn_Home.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_Home.Location = new System.Drawing.Point(432, 19);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(160, 40);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Table View";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // pbox_ChapeauLogo
            // 
            this.pbox_ChapeauLogo.Image = global::UserInterface.Properties.Resources.ChapeauLogo;
            this.pbox_ChapeauLogo.Location = new System.Drawing.Point(62, 10);
            this.pbox_ChapeauLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbox_ChapeauLogo.Name = "pbox_ChapeauLogo";
            this.pbox_ChapeauLogo.Size = new System.Drawing.Size(140, 75);
            this.pbox_ChapeauLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_ChapeauLogo.TabIndex = 3;
            this.pbox_ChapeauLogo.TabStop = false;
            // 
            // lbl_TableNumber
            // 
            this.lbl_TableNumber.AutoSize = true;
            this.lbl_TableNumber.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TableNumber.Location = new System.Drawing.Point(332, 117);
            this.lbl_TableNumber.Name = "lbl_TableNumber";
            this.lbl_TableNumber.Size = new System.Drawing.Size(26, 34);
            this.lbl_TableNumber.TabIndex = 12;
            this.lbl_TableNumber.Text = "-";
            // 
            // Order_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1024, 769);
            this.Controls.Add(this.pbox_ChapeauLogo);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.pnl_OrderHome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Order_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Home_Load);
            this.pnl_OrderHome.ResumeLayout(false);
            this.pnl_OrderHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ItemCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_OrderHome;
        private System.Windows.Forms.NumericUpDown nud_ItemCount;
        private System.Windows.Forms.ListView liv_CurrentOrder;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_AddComment;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Menus;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label lbl_OrderView;
        private System.Windows.Forms.Label lbl_TableID;
        private System.Windows.Forms.TextBox txtb_Requests;
        private System.Windows.Forms.PictureBox pbox_ChapeauLogo;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_TableNumber;
    }
}