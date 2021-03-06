﻿using System.Windows.Forms;

namespace SpiderForm
{
    partial class CrawlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrawlForm));
            this.labelBrandUpdate = new System.Windows.Forms.Label();
            this.labelBrandInsert = new System.Windows.Forms.Label();
            this.labelBrandName = new System.Windows.Forms.Label();
            this.carBrandButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelModelUpdate = new System.Windows.Forms.Label();
            this.labelModelInsert = new System.Windows.Forms.Label();
            this.labelModelName = new System.Windows.Forms.Label();
            this.labelSeriesUpdate = new System.Windows.Forms.Label();
            this.labelSeriesInsert = new System.Windows.Forms.Label();
            this.labelSeriesName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBrandUpdate
            // 
            this.labelBrandUpdate.AutoSize = true;
            this.labelBrandUpdate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrandUpdate.ForeColor = System.Drawing.Color.Red;
            this.labelBrandUpdate.Location = new System.Drawing.Point(184, 26);
            this.labelBrandUpdate.Name = "labelBrandUpdate";
            this.labelBrandUpdate.Size = new System.Drawing.Size(48, 20);
            this.labelBrandUpdate.TabIndex = 2;
            this.labelBrandUpdate.Text = "更新:0";
            // 
            // labelBrandInsert
            // 
            this.labelBrandInsert.AutoSize = true;
            this.labelBrandInsert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrandInsert.ForeColor = System.Drawing.Color.Red;
            this.labelBrandInsert.Location = new System.Drawing.Point(184, 76);
            this.labelBrandInsert.Name = "labelBrandInsert";
            this.labelBrandInsert.Size = new System.Drawing.Size(48, 20);
            this.labelBrandInsert.TabIndex = 3;
            this.labelBrandInsert.Text = "插入:0";
            // 
            // labelBrandName
            // 
            this.labelBrandName.AutoSize = true;
            this.labelBrandName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrandName.ForeColor = System.Drawing.Color.Red;
            this.labelBrandName.Location = new System.Drawing.Point(295, 51);
            this.labelBrandName.Name = "labelBrandName";
            this.labelBrandName.Size = new System.Drawing.Size(0, 20);
            this.labelBrandName.TabIndex = 4;
            // 
            // carBrandButton
            // 
            this.carBrandButton.Location = new System.Drawing.Point(59, 38);
            this.carBrandButton.Name = "carBrandButton";
            this.carBrandButton.Size = new System.Drawing.Size(80, 40);
            this.carBrandButton.TabIndex = 5;
            this.carBrandButton.Text = "采集品牌";
            this.carBrandButton.Click += new System.EventHandler(this.carBrandButton_Click);
            // 
            // labelModelUpdate
            // 
            this.labelModelUpdate.AutoSize = true;
            this.labelModelUpdate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelUpdate.Location = new System.Drawing.Point(78, 139);
            this.labelModelUpdate.Name = "labelModelUpdate";
            this.labelModelUpdate.Size = new System.Drawing.Size(48, 20);
            this.labelModelUpdate.TabIndex = 7;
            this.labelModelUpdate.Text = "更新:0";
            // 
            // labelModelInsert
            // 
            this.labelModelInsert.AutoSize = true;
            this.labelModelInsert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelInsert.Location = new System.Drawing.Point(78, 195);
            this.labelModelInsert.Name = "labelModelInsert";
            this.labelModelInsert.Size = new System.Drawing.Size(48, 20);
            this.labelModelInsert.TabIndex = 8;
            this.labelModelInsert.Text = "插入:0";
            // 
            // labelModelName
            // 
            this.labelModelName.AutoSize = true;
            this.labelModelName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelName.Location = new System.Drawing.Point(190, 165);
            this.labelModelName.Name = "labelModelName";
            this.labelModelName.Size = new System.Drawing.Size(0, 20);
            this.labelModelName.TabIndex = 9;
            // 
            // labelSeriesUpdate
            // 
            this.labelSeriesUpdate.AutoSize = true;
            this.labelSeriesUpdate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSeriesUpdate.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelSeriesUpdate.Location = new System.Drawing.Point(79, 276);
            this.labelSeriesUpdate.Name = "labelSeriesUpdate";
            this.labelSeriesUpdate.Size = new System.Drawing.Size(48, 20);
            this.labelSeriesUpdate.TabIndex = 10;
            this.labelSeriesUpdate.Text = "更新:0";
            // 
            // labelSeriesInsert
            // 
            this.labelSeriesInsert.AutoSize = true;
            this.labelSeriesInsert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSeriesInsert.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelSeriesInsert.Location = new System.Drawing.Point(79, 323);
            this.labelSeriesInsert.Name = "labelSeriesInsert";
            this.labelSeriesInsert.Size = new System.Drawing.Size(48, 20);
            this.labelSeriesInsert.TabIndex = 11;
            this.labelSeriesInsert.Text = "插入:0";
            // 
            // labelSeriesName
            // 
            this.labelSeriesName.AutoSize = true;
            this.labelSeriesName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeriesName.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelSeriesName.Location = new System.Drawing.Point(194, 296);
            this.labelSeriesName.Name = "labelSeriesName";
            this.labelSeriesName.Size = new System.Drawing.Size(0, 20);
            this.labelSeriesName.TabIndex = 12;
            // 
            // CrawlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 382);
            this.Controls.Add(this.labelSeriesName);
            this.Controls.Add(this.labelSeriesInsert);
            this.Controls.Add(this.labelSeriesUpdate);
            this.Controls.Add(this.labelModelName);
            this.Controls.Add(this.labelModelInsert);
            this.Controls.Add(this.labelModelUpdate);
            this.Controls.Add(this.carBrandButton);
            this.Controls.Add(this.labelBrandName);
            this.Controls.Add(this.labelBrandInsert);
            this.Controls.Add(this.labelBrandUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrawlForm";
            this.Text = "CrawlForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelBrandUpdate;
        private Label labelBrandInsert;
        private Label labelBrandName;
        private DevExpress.XtraEditors.SimpleButton carBrandButton;
        private Label labelModelUpdate;
        private Label labelModelInsert;
        private Label labelModelName;
        private Label labelSeriesUpdate;
        private Label labelSeriesInsert;
        private Label labelSeriesName;
    }
}