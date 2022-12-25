using CrystalDecisions.Shared;

namespace Learning_DB
{
    partial class triaal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        ///
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport1 CrystalReport11;
        private CrystalReport2 CrystalReport21;
        private CrystalReport3 CrystalReport31;
        private CrystalReport4 CrystalReport41;
     
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
            this.CrystalReport21 = new Learning_DB.CrystalReport2();
            this.CrystalReport11 = new Learning_DB.CrystalReport1();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport41 = new Learning_DB.CrystalReport4();
            this.CrystalReport31 = new Learning_DB.CrystalReport3();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport31;
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // triaal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "triaal";
            this.Text = "triaal";
            this.ResumeLayout(false);
            CrystalReport31.SetDatabaseLogon("adminS", "Salah123");
            //CrystalReport31.SetParameterValue("@Uname", "50002");
            ParameterFields p = new ParameterFields();
            ParameterField pid = new ParameterField();
            pid.Name = "Student_ID";
            ParameterDiscreteValue val=new ParameterDiscreteValue();
            val.Value = "50006";
            pid.CurrentValues.Add(val);
            p.Add(pid);
            crystalReportViewer1.ParameterFieldInfo= p;
            //CrystalReport31.DataDefinition.ParameterFields.Item("@ss");

        }

        #endregion

    
    }
}