﻿namespace UserInterface
{
    partial class OrderStatus
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
            this.kitchenlbl = new System.Windows.Forms.Label();
            this.Corderview = new System.Windows.Forms.ListView();
            this.namedish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requeststxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prepbtn = new System.Windows.Forms.Button();
            this.rdybtn = new System.Windows.Forms.Button();
            this.rdytablcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Ordersview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Barlbl = new System.Windows.Forms.Label();
            this.Crossmarkpic = new System.Windows.Forms.PictureBox();
            this.Checkmarkpic = new System.Windows.Forms.PictureBox();
            this.pbox_ChapeauLogo = new System.Windows.Forms.PictureBox();
            this.autorefresh = new System.Windows.Forms.Timer(this.components);
            this.exitbtn = new System.Windows.Forms.Button();
            this.pnl_LoginInfo = new System.Windows.Forms.Panel();
            this.lbl_UserType = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultdialogbox = new System.Windows.Forms.Label();
            this.rdytablcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Crossmarkpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checkmarkpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).BeginInit();
            this.pnl_LoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // kitchenlbl
            // 
            this.kitchenlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.kitchenlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kitchenlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchenlbl.Location = new System.Drawing.Point(313, 35);
            this.kitchenlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kitchenlbl.Name = "kitchenlbl";
            this.kitchenlbl.Size = new System.Drawing.Size(292, 46);
            this.kitchenlbl.TabIndex = 15;
            this.kitchenlbl.Text = "Orders Status: Kitchen";
            this.kitchenlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kitchenlbl.Click += new System.EventHandler(this.lbl_bill_Click);
            // 
            // Corderview
            // 
            this.Corderview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Corderview.BackgroundImageTiled = true;
            this.Corderview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namedish,
            this.Qty,
            this.OrderID,
            this.status,
            this.LastChange,
            this.OrderItemID,
            this.TableID});
            this.Corderview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Corderview.ForeColor = System.Drawing.Color.Black;
            this.Corderview.FullRowSelect = true;
            this.Corderview.HideSelection = false;
            this.Corderview.Location = new System.Drawing.Point(0, 0);
            this.Corderview.Name = "Corderview";
            this.Corderview.Size = new System.Drawing.Size(781, 154);
            this.Corderview.TabIndex = 12;
            this.Corderview.UseCompatibleStateImageBehavior = false;
            this.Corderview.View = System.Windows.Forms.View.Details;
            this.Corderview.SelectedIndexChanged += new System.EventHandler(this.Corderview_SelectedIndexChanged);
            // 
            // namedish
            // 
            this.namedish.Text = "Dish Name";
            this.namedish.Width = 173;
            // 
            // Qty
            // 
            this.Qty.Text = "Quantity";
            this.Qty.Width = 73;
            // 
            // OrderID
            // 
            this.OrderID.Text = "Order ID";
            this.OrderID.Width = 70;
            // 
            // status
            // 
            this.status.Text = "Order Status";
            this.status.Width = 98;
            // 
            // LastChange
            // 
            this.LastChange.Text = "Last State Change";
            this.LastChange.Width = 185;
            // 
            // OrderItemID
            // 
            this.OrderItemID.Text = "Order Item ID";
            this.OrderItemID.Width = 102;
            // 
            // TableID
            // 
            this.TableID.Text = "Table ID";
            this.TableID.Width = 72;
            // 
            // requeststxt
            // 
            this.requeststxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requeststxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requeststxt.Location = new System.Drawing.Point(35, 332);
            this.requeststxt.Name = "requeststxt";
            this.requeststxt.ReadOnly = true;
            this.requeststxt.Size = new System.Drawing.Size(215, 89);
            this.requeststxt.TabIndex = 14;
            this.requeststxt.Text = "";
            this.requeststxt.TextChanged += new System.EventHandler(this.requeststxt_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(34, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Selected order requests:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prepbtn
            // 
            this.prepbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.prepbtn.Location = new System.Drawing.Point(276, 332);
            this.prepbtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prepbtn.Name = "prepbtn";
            this.prepbtn.Size = new System.Drawing.Size(142, 92);
            this.prepbtn.TabIndex = 17;
            this.prepbtn.Text = "Change selected order to Preparing";
            this.prepbtn.UseVisualStyleBackColor = false;
            this.prepbtn.Click += new System.EventHandler(this.prepbtn_Click);
            // 
            // rdybtn
            // 
            this.rdybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.rdybtn.Location = new System.Drawing.Point(422, 332);
            this.rdybtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rdybtn.Name = "rdybtn";
            this.rdybtn.Size = new System.Drawing.Size(137, 92);
            this.rdybtn.TabIndex = 18;
            this.rdybtn.Text = "Change selected order to Ready";
            this.rdybtn.UseVisualStyleBackColor = false;
            this.rdybtn.Click += new System.EventHandler(this.rdybtn_Click);
            // 
            // rdytablcontrol
            // 
            this.rdytablcontrol.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.rdytablcontrol.Controls.Add(this.tabPage1);
            this.rdytablcontrol.Controls.Add(this.tabPage2);
            this.rdytablcontrol.Location = new System.Drawing.Point(12, 107);
            this.rdytablcontrol.Multiline = true;
            this.rdytablcontrol.Name = "rdytablcontrol";
            this.rdytablcontrol.SelectedIndex = 0;
            this.rdytablcontrol.Size = new System.Drawing.Size(804, 158);
            this.rdytablcontrol.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Ordersview);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 150);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Orders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Ordersview
            // 
            this.Ordersview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ordersview.BackgroundImageTiled = true;
            this.Ordersview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.Ordersview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ordersview.ForeColor = System.Drawing.Color.Black;
            this.Ordersview.FullRowSelect = true;
            this.Ordersview.HideSelection = false;
            this.Ordersview.Location = new System.Drawing.Point(0, 0);
            this.Ordersview.Name = "Ordersview";
            this.Ordersview.Size = new System.Drawing.Size(781, 150);
            this.Ordersview.TabIndex = 13;
            this.Ordersview.UseCompatibleStateImageBehavior = false;
            this.Ordersview.View = System.Windows.Forms.View.Details;
            this.Ordersview.SelectedIndexChanged += new System.EventHandler(this.Ordersview_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dish Name";
            this.columnHeader1.Width = 173;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Table";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Order Status";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Last State Change";
            this.columnHeader5.Width = 176;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Order Item ID";
            this.columnHeader6.Width = 102;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Order ID";
            this.columnHeader7.Width = 81;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Corderview);
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 150);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Completed Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Barlbl
            // 
            this.Barlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.Barlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Barlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barlbl.Location = new System.Drawing.Point(313, 35);
            this.Barlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Barlbl.Name = "Barlbl";
            this.Barlbl.Size = new System.Drawing.Size(292, 46);
            this.Barlbl.TabIndex = 20;
            this.Barlbl.Text = "Orders Status: Bar";
            this.Barlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Crossmarkpic
            // 
            this.Crossmarkpic.Image = global::UserInterface.Properties.Resources.CrossMark;
            this.Crossmarkpic.Location = new System.Drawing.Point(773, 303);
            this.Crossmarkpic.Margin = new System.Windows.Forms.Padding(2);
            this.Crossmarkpic.Name = "Crossmarkpic";
            this.Crossmarkpic.Size = new System.Drawing.Size(39, 41);
            this.Crossmarkpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Crossmarkpic.TabIndex = 23;
            this.Crossmarkpic.TabStop = false;
            // 
            // Checkmarkpic
            // 
            this.Checkmarkpic.Image = global::UserInterface.Properties.Resources.CheckMark;
            this.Checkmarkpic.Location = new System.Drawing.Point(773, 303);
            this.Checkmarkpic.Margin = new System.Windows.Forms.Padding(2);
            this.Checkmarkpic.Name = "Checkmarkpic";
            this.Checkmarkpic.Size = new System.Drawing.Size(39, 41);
            this.Checkmarkpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Checkmarkpic.TabIndex = 22;
            this.Checkmarkpic.TabStop = false;
            // 
            // pbox_ChapeauLogo
            // 
            this.pbox_ChapeauLogo.Image = global::UserInterface.Properties.Resources.ChapeauLogo;
            this.pbox_ChapeauLogo.Location = new System.Drawing.Point(34, 11);
            this.pbox_ChapeauLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbox_ChapeauLogo.Name = "pbox_ChapeauLogo";
            this.pbox_ChapeauLogo.Size = new System.Drawing.Size(216, 91);
            this.pbox_ChapeauLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_ChapeauLogo.TabIndex = 4;
            this.pbox_ChapeauLogo.TabStop = false;
            // 
            // autorefresh
            // 
            this.autorefresh.Enabled = true;
            this.autorefresh.Interval = 60000;
            this.autorefresh.Tick += new System.EventHandler(this.autorefresh_Tick);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(129)))), ((int)(((byte)(153)))));
            this.exitbtn.Location = new System.Drawing.Point(732, 383);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(84, 41);
            this.exitbtn.TabIndex = 25;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // pnl_LoginInfo
            // 
            this.pnl_LoginInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnl_LoginInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_LoginInfo.Controls.Add(this.lbl_UserType);
            this.pnl_LoginInfo.Controls.Add(this.lbl_Username);
            this.pnl_LoginInfo.Location = new System.Drawing.Point(683, 16);
            this.pnl_LoginInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_LoginInfo.Name = "pnl_LoginInfo";
            this.pnl_LoginInfo.Size = new System.Drawing.Size(133, 65);
            this.pnl_LoginInfo.TabIndex = 26;
            // 
            // lbl_UserType
            // 
            this.lbl_UserType.AutoSize = true;
            this.lbl_UserType.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserType.Location = new System.Drawing.Point(12, 40);
            this.lbl_UserType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserType.Name = "lbl_UserType";
            this.lbl_UserType.Size = new System.Drawing.Size(84, 14);
            this.lbl_UserType.TabIndex = 1;
            this.lbl_UserType.Text = "Change in Code";
            this.lbl_UserType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(12, 11);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(113, 18);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Change in Code";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(276, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 41);
            this.label2.TabIndex = 27;
            this.label2.Text = "Change Order Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultdialogbox
            // 
            this.resultdialogbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(130)))));
            this.resultdialogbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultdialogbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.resultdialogbox.Location = new System.Drawing.Point(584, 279);
            this.resultdialogbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultdialogbox.Name = "resultdialogbox";
            this.resultdialogbox.Size = new System.Drawing.Size(189, 86);
            this.resultdialogbox.TabIndex = 28;
            this.resultdialogbox.Text = "change in code";
            this.resultdialogbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(842, 433);
            this.Controls.Add(this.Checkmarkpic);
            this.Controls.Add(this.resultdialogbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl_LoginInfo);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.Crossmarkpic);
            this.Controls.Add(this.Barlbl);
            this.Controls.Add(this.rdybtn);
            this.Controls.Add(this.prepbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requeststxt);
            this.Controls.Add(this.kitchenlbl);
            this.Controls.Add(this.pbox_ChapeauLogo);
            this.Controls.Add(this.rdytablcontrol);
            this.Name = "OrderStatus";
            this.Text = "OrderStatus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderStatus_FormClosed);
            this.Load += new System.EventHandler(this.OrderStatus_Load);
            this.rdytablcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Crossmarkpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checkmarkpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ChapeauLogo)).EndInit();
            this.pnl_LoginInfo.ResumeLayout(false);
            this.pnl_LoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_ChapeauLogo;
        private System.Windows.Forms.Label kitchenlbl;
        private System.Windows.Forms.ListView Corderview;
        private System.Windows.Forms.ColumnHeader namedish;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader OrderItemID;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader LastChange;
        private System.Windows.Forms.RichTextBox requeststxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prepbtn;
        private System.Windows.Forms.Button rdybtn;
        private System.Windows.Forms.ColumnHeader TableID;
        private System.Windows.Forms.TabControl rdytablcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView Ordersview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Barlbl;
        private System.Windows.Forms.PictureBox Checkmarkpic;
        private System.Windows.Forms.PictureBox Crossmarkpic;
        private System.Windows.Forms.Timer autorefresh;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Panel pnl_LoginInfo;
        private System.Windows.Forms.Label lbl_UserType;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultdialogbox;
    }
}