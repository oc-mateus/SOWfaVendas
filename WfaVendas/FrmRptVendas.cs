﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaVendas
{
    public partial class FrmRptVendas : Form
    {
        public FrmRptVendas()
        {
            InitializeComponent();
        }

        private void FrmRptVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'LP2DataSet.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            this.DataTable1TableAdapter.Fill(this.LP2DataSet.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
