using GymRoom_Business.Interfaces;
using GymRoom_Business.Services;
using GymRoom_Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymRoom
{
    public partial class frmRoutines : Form
    {
        private readonly IServiceRoutine _serviceRoutine;
        private int idRoutine = 0;

        public frmRoutines(IServiceRoutine serviceRoutine)
        {
            InitializeComponent();
            _serviceRoutine = serviceRoutine;
        }

        private void frmRoutines_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void RefreshDGV()
        {
            dgvRoutine.DataSource = null;
            var lstRoutines = _serviceRoutine.GetAllRoutines();
            dgvRoutine.DataSource = lstRoutines;
        }

        private void dgvRoutine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvRoutine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) // esto omite encabezados
            {
                var row = dgvRoutine.Rows[e.RowIndex];

                idRoutine = Convert.ToInt32(row.Cells["idRoutine"].Value);
                string routine = row.Cells["name"].Value.ToString();
                string description = row.Cells["description"].Value.ToString();

                txtName.Text = routine;
                txtDesc.Text = description;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string routine = txtName.Text;

                var lstRoutines = _serviceRoutine.SearchRoutines(routine);
                dgvRoutine.DataSource = lstRoutines;
                MessageBox.Show("Showing current results", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (idRoutine == 0)
            {
                return;
            }
            try
            {
                CatRoutine routine = new CatRoutine();

                routine.IdRoutine = idRoutine;
                routine.Name = txtName.Text;
                routine.Description = txtDesc.Text;

                _serviceRoutine.EditRoutine(routine);
                MessageBox.Show($"The routine {routine.Name} has been updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                ClearFields();
                RefreshDGV();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtDesc.Text = string.Empty;
            txtName.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idRoutine == 0)
            {
                return;
            }
            try
            {
                CatRoutine routine = new CatRoutine();

                routine.IdRoutine = idRoutine;

                _serviceRoutine.DeleteRoutine(routine);
                MessageBox.Show($"The routine {routine.Name} has been deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                ClearFields();
                RefreshDGV();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CatRoutine routine = new CatRoutine();

                routine.Name = txtName.Text;
                routine.Description = txtDesc.Text;

                _serviceRoutine.AddRoutine(routine);
                MessageBox.Show($"The routine {routine.Name} has been added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                ClearFields();
                RefreshDGV();
            }
        }
    }
}
