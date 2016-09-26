using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Seraph
{
    public partial class FormSeraph : Form
    {
        List<Handler> m_handlers = new List<Handler>();
        ListSortDirection m_direction = ListSortDirection.Ascending;
        DatagridViewCheckBoxHeaderCell m_cbHeader;

        public FormSeraph()
        {
            InitializeComponent();
            m_tbName.Text = ""; // Trigger Text Changed
            m_dgvHandler.DataSource = m_handlers; // Initialize the grid
            // Fill the last column to match the resize of the form
            m_dgvHandler.Columns[m_dgvHandler.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // The grid is readonly except for the 1st column
            foreach (DataGridViewColumn col in m_dgvHandler.Columns)
                col.ReadOnly = true;
            DataGridViewColumn selectedCol = m_dgvHandler.Columns[0];
            selectedCol.ReadOnly = false;
            selectedCol.Width = 50;
            // Add an event on the header cell to sort the grid
            m_dgvHandler.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(m_dgvHandler_ColumnHeaderMouseClick);
            // CheckBox event handler walkaround https://stackoverflow.com/questions/11843488/datagridview-checkbox-event
            m_dgvHandler.CellContentClick += new DataGridViewCellEventHandler(m_dgvHandler_CellContentClick);
            m_dgvHandler.CellValueChanged += new DataGridViewCellEventHandler(m_dgvHandler_CellValueChanged);
        }

        private void FormSeraph_Load(object sender, EventArgs e)
        {
            m_dgvHandler.DataSource = m_handlers;
        }

        private void m_bHandle_Click(object sender, EventArgs e)
        {
            // Find handle for the entered name
            m_handlers = Command.Handle(m_tbName.Text.Trim()).ToList();
            m_dgvHandler.DataSource = m_handlers; // Update the DataSource
        }

        private void m_tbName_TextChanged(object sender, EventArgs e)
        {
            // Disable handle button is there is no name
            m_bHandle.Enabled = !string.IsNullOrWhiteSpace(m_tbName.Text);
        }

        private void m_bClose_Click(object sender, EventArgs e)
        {
            // Close selected handle
            foreach(Handler handler in m_handlers)
            {
                if (handler.Selected)
                    Command.Close(handler);
            }
            m_bHandle_Click(sender, e); // Callback Handle command to see if there is still handle remaining
        }

        // Called whenever the DataSource is changed
        private void m_dgvHandler_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Remove the text header of the first column and replace it by a "(Un)Select All" checkbox
            m_cbHeader = new DatagridViewCheckBoxHeaderCell();
            m_cbHeader.Value = "";
            m_cbHeader.OnCheckBoxClicked += new CheckBoxClickedHandler(m_cbHeader_CheckBoxClicked);
            m_dgvHandler.Columns[0].HeaderCell = m_cbHeader;
            m_dgvHandler.ClearSelection();
        }

        public void m_cbHeader_CheckBoxClicked(bool bState)
        {
            // Propagate the state of the checbox header to all checkbox in the column
            m_dgvHandler.ClearSelection();
            foreach (Handler handler in m_handlers)
                handler.Selected = bState;
            m_dgvHandler.Update();
            m_dgvHandler.Refresh();
            m_bClose.Select(); // Set the focus on Close button
        }

        private void m_dgvHandler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) // Only for selected column
                m_dgvHandler.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }


        private void m_dgvHandler_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            m_cbHeader.IsDirty = true; // Mix between selected and unselected
            m_dgvHandler.Invalidate(); // Trigger the Paint() event
        }

        private void m_dgvHandler_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Sort by column, depending which column was clicked
            if (e.ColumnIndex == 1)
            {
                if (m_direction == ListSortDirection.Ascending)
                    m_handlers = m_handlers.OrderBy(h => h.Process).ToList();
                else
                    m_handlers = m_handlers.OrderByDescending(h => h.Process).ToList();
            }
            else if (e.ColumnIndex == 2)
            {
                if (m_direction == ListSortDirection.Ascending)
                    m_handlers = m_handlers.OrderBy(h => h.Pid).ToList();
                else
                    m_handlers = m_handlers.OrderByDescending(h => h.Pid).ToList();
            }
            else if (e.ColumnIndex == 3)
            {
                if (m_direction == ListSortDirection.Ascending)
                    m_handlers = m_handlers.OrderBy(h => h.Type).ToList();
                else
                    m_handlers = m_handlers.OrderByDescending(h => h.Pid).ToList();
            }
            else if (e.ColumnIndex == 4)
            {
                if (m_direction == ListSortDirection.Ascending)
                    m_handlers = m_handlers.OrderBy(h => h.Handle).ToList();
                else
                    m_handlers = m_handlers.OrderByDescending(h => h.Handle).ToList();
            }
            else if (e.ColumnIndex == 5)
            {
                if (m_direction == ListSortDirection.Ascending)
                    m_handlers = m_handlers.OrderBy(h => h.Path).ToList();
                else
                    m_handlers = m_handlers.OrderByDescending(h => h.Path).ToList();
            }
            else
                return;

            m_direction = m_direction == ListSortDirection.Ascending
                ? ListSortDirection.Descending : ListSortDirection.Ascending;

            m_dgvHandler.DataSource = m_handlers;
        }

    }
}
