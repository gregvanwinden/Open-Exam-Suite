﻿using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Shared.Controls
{
    public partial class OptionControl : UserControl
    {
        #region Public Properties

        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public char Letter
        {
            get => Convert.ToChar(rdb_letter.Text);
            set => rdb_letter.Text = value.ToString();
        }

        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public override string Text
        {
            get => txt_text.Text;
            set => txt_text.Text = value;
        }

        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public bool Checked
        {
            get => rdb_letter.Checked;
            set => rdb_letter.Checked = value;
        }

        #endregion

        public OptionControl()
        {
            InitializeComponent();
        }

        private void rdb_letter_Click(object sender, EventArgs e)
        {
            rdb_letter.Checked = !rdb_letter.Checked;
        }
    }
}