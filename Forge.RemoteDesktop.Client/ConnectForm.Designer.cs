﻿using System;

namespace Forge.RemoteDesktop.Client
{
    partial class ConnectForm
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
            if (disposing)
            {
                connectControl.EventConnect -= new EventHandler<EventArgs>(ConnectEventHandler);
                connectControl.Dispose();
            }
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
            this.connectControl = new Forge.RemoteDesktop.Client.ConnectControl();
            this.SuspendLayout();
            // 
            // connectControl
            // 
            this.connectControl.Location = new System.Drawing.Point(12, 12);
            this.connectControl.Name = "connectControl";
            this.connectControl.ShowCancelButton = true;
            this.connectControl.Size = new System.Drawing.Size(414, 240);
            this.connectControl.TabIndex = 0;
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 264);
            this.Controls.Add(this.connectControl);
            this.MinimumSize = new System.Drawing.Size(393, 247);
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect to a remote service...";
            this.Shown += new System.EventHandler(this.ConnectForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The connect control
        /// </summary>
        protected ConnectControl connectControl;


    }
}