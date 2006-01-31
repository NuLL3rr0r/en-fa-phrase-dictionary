using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Engine
{
    public partial class frmMain : Form
    {
        private String path = String.Concat(Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar.ToString());
        private String msgTitle = "";
        private String msgErrTitle = "ÎØÇí ÒãÇä ÇÌÑÇ";
        private String errDb = "ÇãßÇä ÏÓÊÑÓí Èå ÇíÇå ÏÇÏå åÇ æÌæÏ äÏÇÑÏ";
	    private String dBpw = "OhUGy0fWzqF05W401jqF";
        private String sqlStr = "SELECT * FROM kywrds";
        private String fileDb;
        private String cnnStr;

        private OleDbConnection cnn;
        private OleDbDataAdapter oda;
		private OleDbCommand cmd;
		private OleDbDataReader drr;
        private OleDbCommandBuilder ocb;

        private DataSet ds = new DataSet();

        private bool done = false;


        public frmMain()
        {
            InitializeComponent();

            fileDb = String.Concat(path, "sntncmags.sql");
            cnnStr = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1};", fileDb, dBpw);

			if (!ChkFiles(fileDb, errDb))
			{
				Environment.Exit(Environment.ExitCode);
			}

            cnn = new OleDbConnection(cnnStr);
            oda = new OleDbDataAdapter(sqlStr, cnn);
            cmd = new OleDbCommand(sqlStr, cnn);
            ocb = new OleDbCommandBuilder(oda);
            ocb.QuotePrefix = "[";
            ocb.QuoteSuffix = "]";

            cnn.Open();
            oda.Fill(ds, "kywrds");
        }

        private bool ChkFiles(String file, String errMsg)
            {
                bool found = File.Exists(file);
                if (!found)
                {
                    MessageBox.Show(String.Concat(errMsg, "\n\nDetails:\n", file, "\t...Not Found"), msgErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return found;
            }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtFa.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnErase.Enabled = false;
            btnEdit.Enabled = false;
            btnSrchFa.Enabled = false;
            btnSrchEn.Enabled = false;
            btnNew.Enabled = false;
            btnCancel.Enabled = true;

            txtEn.Clear();
            txtFa.Clear();
            txtFa.Focus();

            done = false;
            dgw.DataSource = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnSrchFa.Enabled = true;
            btnSrchEn.Enabled = true;
            btnNew.Enabled = true;

            txtEn.Clear();
            txtFa.Clear();
            txtFa.Focus();
        }

        private void txtFa_TextChanged(object sender, EventArgs e)
        {
            if (btnCancel.Enabled)
            {
                if (txtEn.Text.Trim() != String.Empty && txtFa.Text.Trim() != String.Empty)
                    btnSave.Enabled = true;
                else
                    btnSave.Enabled = false;
             }
        }

        private void txtEn_TextChanged(object sender, EventArgs e)
        {
            if (btnCancel.Enabled)
            {
                if (txtEn.Text.Trim() != String.Empty && txtFa.Text.Trim() != String.Empty)
                    btnSave.Enabled = true;
                else
                    btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataRow dr;

            drr = cmd.ExecuteReader();

            bool found = false;
            while (drr.Read())
            {
                if (drr["Sentence"].ToString().Trim() == txtFa.Text.Trim())
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                dt = ds.Tables["kywrds"];
				dr = dt.NewRow();
                dr["Sentence"] = txtFa.Text.Trim();
                dr["equalsWith"] = txtEn.Text.Trim();
                dt.Rows.Add(dr);

                oda.InsertCommand = ocb.GetInsertCommand();

                if (oda.Update(ds, "kywrds") == 1)
                    ds.AcceptChanges();
                else
                    ds.RejectChanges();
            }
            else
            {
                MessageBox.Show("ÞÈáÇ ËÈÊ ÔÏå ÇÓÊ", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnSrchFa.Enabled = true;
            btnSrchEn.Enabled = true;
            btnNew.Enabled = true;
            
            txtEn.Clear();
            txtFa.Clear();
            txtFa.Focus();

            drr.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            cnn.Close();
        }

        private void btnSrchFa_Click(object sender, EventArgs e)
        {
            done = false;

            DataTable dt = new DataTable();
            DataRow dr;

            dgw.DataSource = null;

            btnErase.Enabled = false;
            btnEdit.Enabled = false;

            txtEn.Clear();

            drr = cmd.ExecuteReader();

            dt.Columns.Add("ÚÈÇÑÊ ÝÇÑÓí", Type.GetType("System.String"));
			dt.Columns.Add("ãÚÇÏá ÇäáíÓí", Type.GetType("System.String"));

            bool found = false;
            while (drr.Read())
            {
                if (drr["Sentence"].ToString().Trim().Contains(txtFa.Text.Trim()))
                {
                    dr = dt.NewRow();
                    dr[0] = drr["Sentence"].ToString();
                    dr[1] = drr["equalsWith"].ToString();						 
                    dt.Rows.Add(dr);
                    found = true;
                }
            }

            if (found)
            {
                dgw.DataSource = dt;
                dgw.Columns[0].Width = 232;
                dgw.Columns[1].Width = 232;
                dgw.Sort(dgw.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show("åí ãæÑÏí íÇÝÊ äÔÏ", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtFa.Focus();
            txtFa.SelectAll();

            drr.Close();

            done = true;
        }

        private void btnSrchEn_Click(object sender, EventArgs e)
        {
            done = false;

            DataTable dt = new DataTable();
            DataRow dr;

            dgw.DataSource = null;

            btnErase.Enabled = false;
            btnEdit.Enabled = false;

            txtFa.Clear();

            drr = cmd.ExecuteReader();

            dt.Columns.Add("ÚÈÇÑÊ ÝÇÑÓí", Type.GetType("System.String"));
            dt.Columns.Add("ãÚÇÏá ÇäáíÓí", Type.GetType("System.String"));

            bool found = false;
            while (drr.Read())
            {
                if (drr["equalsWith"].ToString().Trim().Contains(txtEn.Text.Trim()))
                {
                    dr = dt.NewRow();
                    dr[0] = drr["Sentence"].ToString();
                    dr[1] = drr["equalsWith"].ToString();
                    dt.Rows.Add(dr);
                    found = true;
                }
            }

            if (found)
            {
                dgw.DataSource = dt;
                dgw.Columns[0].Width = 232;
                dgw.Columns[1].Width = 232;
                dgw.Sort(dgw.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show("åí ãæÑÏí íÇÝÊ äÔÏ", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtFa.Focus();
            txtFa.SelectAll();

            drr.Close();

            done = true;
        }

        private void dgw_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (done)
                {
                    txtFa.Text = dgw.Rows[dgw.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                    txtEn.Text = dgw.Rows[dgw.CurrentRow.Index].Cells[1].Value.ToString().Trim();
                    btnErase.Enabled = true;
                    btnEdit.Enabled = true;
                }
            }
            catch (Exception err)
            {
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ÂíÇ ãÇíá Èå ÐÎíÑå ÊÛííÑÇÊ ãæÑÏ äÙÑ ãí ÈÇÔíÏ", msgTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch(result)
            {
                case DialogResult.Yes:
                    drr = cmd.ExecuteReader();
                    int id = -1;
                    bool identified = false;
                    bool found = false;
                    while (drr.Read())
                    {
                        if (identified == false)
                            id++;
                        if (drr["Sentence"].ToString().Trim() == dgw.Rows[dgw.CurrentRow.Index].Cells[0].Value.ToString().Trim() && identified == false)
                        {
                            found = true;
                            identified = true;
                        }
                        else if (drr["Sentence"].ToString().Trim() == txtFa.Text.Trim())
                        {
                            found = false;
                            MessageBox.Show("ãæÑÏ ÊßÑÇÑí ÏÑ ËÈÊ ÚÈÇÑÊ æíÑÇíÔ ÔÏå", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtFa.SelectAll();
                            txtFa.Focus();
                            break;
                        }
                    }

                    if (found == true)
                    {
                        DataTable dt = ds.Tables["kywrds"];
                        DataRow dr = dt.Rows[id];
                        dr.BeginEdit();
                        dr["Sentence"] = txtFa.Text.Trim();
                        dr["equalsWith"] = txtEn.Text.Trim();
                        dr.EndEdit();
                        
                        oda.UpdateCommand = ocb.GetUpdateCommand();

                        if (oda.Update(ds, "kywrds") == 1)
                        {
                            ds.AcceptChanges();
                            dgw.Rows[dgw.CurrentRow.Index].Cells[0].Value = txtFa.Text.Trim();
                            dgw.Rows[dgw.CurrentRow.Index].Cells[1].Value = txtEn.Text.Trim();
                            dgw.Sort(dgw.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                        }
                        else
                            ds.RejectChanges();

                        btnErase.Enabled = false;
                        btnEdit.Enabled = false;
                        txtFa.Clear();
                        txtEn.Clear();
                        txtFa.Focus();
                    }
                    break;
                case DialogResult.No:
                    btnErase.Enabled = false;
                    btnEdit.Enabled = false;
                    txtFa.Clear();
                    txtEn.Clear();
                    txtFa.Focus();
                    break;
                case DialogResult.Cancel:
                    txtFa.SelectAll();
                    txtFa.Focus();
                    break;
                default:
                    break;
            }
            drr.Close();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ÂíÇ ãÇíá Èå ÍÐÝ ÚÈÇÑÊ ãæÑÏ äÙÑ ãí ÈÇÔíÏ", msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.OK:
                    drr = cmd.ExecuteReader();
                    int id = -1;
                    while (drr.Read())
                    {
                        id++;
                        if (drr["Sentence"].ToString().Trim() == txtFa.Text.Trim())
                        {
                            DataTable dt = ds.Tables["kywrds"];
                            DataRow dr = dt.Rows[id];

                            dr.Delete();

                            oda.DeleteCommand = ocb.GetDeleteCommand();

                            if (oda.Update(ds, "kywrds") == 1)
                            {
                                ds.AcceptChanges();
                                done = false;
                                if (dgw.Rows.Count > 2)
                                    dgw.Rows.RemoveAt(dgw.CurrentRow.Index);
                                else
                                {
                                    dt.Reset();
                                    dgw.DataSource = dt;
                                }
                                done = true;
                            }
                            else
                                ds.RejectChanges();
                            break;
                        }
                    }

                    btnErase.Enabled = false;
                    btnEdit.Enabled = false;
                    txtFa.Clear();
                    txtEn.Clear();
                    txtFa.Focus();
                    break;
                case DialogResult.Cancel:
                    txtFa.SelectAll();
                    txtFa.Focus();
                    break;
                default:
                    break;
            }
            drr.Close();
        }
    }
}